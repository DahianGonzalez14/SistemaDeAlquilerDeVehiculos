using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeAlquilerDeVehiculos.BackEnd.Controllers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoVehiculo
{
    public partial class BorrarVehiculoForm : Form
    {
        VehiculoController vehiculoController;
        TipoTransmisionController tipoTransmisionController;
        TipoCombustibleController tipoCombustibleController;
        ModeloController modeloController;
        int vehiculoId;
        public BorrarVehiculoForm()
        {
            vehiculoController = new VehiculoController();
            tipoTransmisionController = new TipoTransmisionController();
            tipoCombustibleController = new TipoCombustibleController();
            modeloController = new ModeloController();
            InitializeComponent();
        }

        private void BorrarVehiculoForm_Load(object sender, EventArgs e)
        {
            panelBorrarVehiculo.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            var showListVehiculo = vehiculoController.getAll().Select(x => new {
                Id = x.Id,
                Transmision = getTransmisionById(x.TipoTransmisionId),
                Combustible = getCombustibleById(x.TipoCombustibleId),
                Modelo = getModeloById(x.ModeloId),
                x.Chasis,
                x.Placa,
                Año = x.Anio,
                x.Color,
                x.Cilindraje,
                Kilometros = x.KilometrosTablero,
                Puertas = x.CantidadPuerta,
                x.Precio,
                x.Estatus
            }).ToList();
            dgvBorrarVehiculo.DataSource = showListVehiculo;
            dgvBorrarVehiculo.Columns["Id"].Visible = false;
        }

        private string getTransmisionById(int transmisionId)
        {
            return tipoTransmisionController.findById(transmisionId).Nombre;
        }

        private string getCombustibleById(int combustibleId)
        {
            return tipoCombustibleController.findById(combustibleId).Nombre;
        }

        private string getModeloById(int modeloId)
        {
            return modeloController.findById(modeloId).Nombre;
        }

        private void LimpiarCampos()
        {
            txtChasis.Text = string.Empty;
        }

        private void dgvBorrarVehiculo_SelectionChanged(object sender, EventArgs e)
        {
            vehiculoId = Convert.ToInt32(dgvBorrarVehiculo.CurrentRow.Cells["Id"].Value.ToString());
            txtChasis.Text = dgvBorrarVehiculo.CurrentRow.Cells["Chasis"].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChasis.Text))
            {
                MessageBox.Show("Favor de seleccionar el vehículo que desea borrar");
            }
            else
            {
                Vehiculo vehiculo = new Vehiculo()
                {
                    Id = vehiculoId
                };

                var deletedVehiculo = vehiculoController.Delete(vehiculo);
                if (deletedVehiculo.Success == true)
                {
                    LlenarDataTable();
                    LimpiarCampos();
                    MessageBox.Show(deletedVehiculo.Message);
                }
                else
                {
                    MessageBox.Show(deletedVehiculo.Message);
                }
            }
        }
    }
}
