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
    public partial class ActualizarVehiculo : Form
    {
        VehiculoController vehiculo = new VehiculoController();
        TipoTransmisionController transmisionController = new TipoTransmisionController();
        TipoCombustibleController combustibleController = new TipoCombustibleController();
        ModeloController modeloController = new ModeloController();
        string chasiss;
        public ActualizarVehiculo()
        {
            InitializeComponent();
        }
        private string getTipoTrans(int transId)
        {
            return transmisionController.findById(transId).Nombre;
        }

        private string getcombustible(int combus)
        {
            return combustibleController.findById(combus).Nombre;
        }


        private string getModelo(int modelo)
        {
            return modeloController.findById(modelo).Nombre;
        }

        private void LlenarDataTable()
        {
            dgvCrearVehiculo.DataSource = vehiculo.getAll().Select(x => new { Modelo = getModelo(x.ModeloId), Transmision = getTipoTrans(x.TipoTransmisionId), Combustible = getcombustible(x.TipoCombustibleId), x.CantidadPuerta, x.Chasis, x.Placa, x.Anio, x.Precio, x.Color, x.Cilindraje, x.KilometrosTablero }).ToList(); ;
            dgvCrearVehiculo.Columns["Chasis"].Visible = false;
        }

        private void dgvCrearVehiculo_SelectionChanged(object sender, EventArgs e)
        {
            chasiss = dgvCrearVehiculo.CurrentRow.Cells["Chasis"].Value.ToString();
            txt1.Text = dgvCrearVehiculo.CurrentRow.Cells["TipoCombustibleId"].Value.ToString();
            txt2.Text = dgvCrearVehiculo.CurrentRow.Cells["TipoTransmisionId"].Value.ToString();
            txt3.Text = dgvCrearVehiculo.CurrentRow.Cells["ModeloId"].Value.ToString();
            txt4.Text = dgvCrearVehiculo.CurrentRow.Cells["CantidadPuerta"].Value.ToString();
            txt6.Text = dgvCrearVehiculo.CurrentRow.Cells["Placa"].Value.ToString();
            txt7.Text = dgvCrearVehiculo.CurrentRow.Cells["Anio"].Value.ToString();
            txt8.Text = dgvCrearVehiculo.CurrentRow.Cells["Precio"].Value.ToString();
            txt9.Text = dgvCrearVehiculo.CurrentRow.Cells["Color"].Value.ToString();
            txt10.Text = dgvCrearVehiculo.CurrentRow.Cells["Cilindraje"].Value.ToString();
            txt11.Text = dgvCrearVehiculo.CurrentRow.Cells["KilometrosTablero"].Value.ToString();
            txt12.Text = dgvCrearVehiculo.CurrentRow.Cells["Estatus"].Value.ToString();

        }
        private void LimpiarCampos()
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt4.Text = string.Empty;
            txt3.Text = string.Empty;
            txt6.Text = string.Empty;
            txt7.Text = string.Empty;
            txt8.Text = string.Empty;
            txt9.Text = string.Empty;
            txt10.Text = string.Empty;
            txt11.Text = string.Empty;
            txt12.Text = string.Empty;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt2.Text) || string.IsNullOrWhiteSpace(txt3.Text) || string.IsNullOrWhiteSpace(txt4.Text) || string.IsNullOrWhiteSpace(txt6.Text) || string.IsNullOrWhiteSpace(txt7.Text) || string.IsNullOrWhiteSpace(txt8.Text) || string.IsNullOrWhiteSpace(txt9.Text) || string.IsNullOrWhiteSpace(txt10.Text) || string.IsNullOrWhiteSpace(txt11.Text) || string.IsNullOrWhiteSpace(txt12.Text))
            {

                MessageBox.Show("completa los campos faltan");


            }
            else
            {

                Vehiculo actualizarVehiculo = new Vehiculo()
                {
                    TipoTransmisionId = Int32.Parse(txt1.Text),
                    TipoCombustibleId = Int32.Parse(txt2.Text),
                    ModeloId = Int32.Parse(txt3.Text),
                    CantidadPuerta = Int32.Parse(txt4.Text),
                    Chasis = chasiss,
                    Placa = txt6.Text,
                    Anio = txt7.Text,
                    Precio = Int32.Parse(txt8.Text),
                    Color = txt9.Text,
                    Cilindraje = txt10.Text,
                    KilometrosTablero = txt11.Text,
                    Estatus = txt12.Text,
                    FechaRegistro = DateTime.Now,
                    FechaModificacion = null,
                    Borrado = false,
                };
                var actualizar = vehiculo.Edit(actualizarVehiculo);
               
                if (actualizar.Success)
                {
                    LlenarDataTable();
                    LimpiarCampos();
                    MessageBox.Show(actualizar.Message);
                }
                else
                {
                    MessageBox.Show(actualizar.Message);
                }
            }








        }

        private void ActualizarVehiculo_Load(object sender, EventArgs e)
        {
            LlenarDataTable();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
