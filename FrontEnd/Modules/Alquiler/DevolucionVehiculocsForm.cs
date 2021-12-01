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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.AlquilerModulo
{
    public partial class DevolucionVehiculoForm : Form
    {
        AlquilerController alquilerController;
        ClienteController clienteController;
        VehiculoController vehiculoController;
        ModeloController modeloController;
        MarcaController marcaController;
        int alquilerId;
        int toogleIsPenalty = 0;
        public DevolucionVehiculoForm()
        {
            alquilerController = new AlquilerController();
            clienteController = new ClienteController();
            vehiculoController = new VehiculoController();
            modeloController = new ModeloController();
            marcaController = new MarcaController();
            InitializeComponent();
        }

        private void DevolucionVehiculoForm_Load(object sender, EventArgs e)
        {
            panelDevolucionVehiculo.BorderStyle = BorderStyle.FixedSingle;
            labelPenalidad.Visible = false;
            txtPenalidad.Visible=false;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            var showListAlquilerVehiculo = alquilerController.getAll().Select(x => new { x.Id, Cliente = getClienteById(x.ClienteId), Vehiculo = getVehiculoById(x.VehiculoId), x.MetodoPago, x.Costo, x.FechaDesde, x.FechaHasta, x.Estatus }).Where(x => x.Estatus.Equals("A")).ToList();
            dgvDevolucionVehiculo.DataSource = showListAlquilerVehiculo;
            dgvDevolucionVehiculo.Columns["Id"].Visible = false;
            if (showListAlquilerVehiculo.Count() != 0)
            {
                dgvDevolucionVehiculo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private string getClienteById(int clienteId)
        {
            return clienteController.findById(clienteId).Nombre;
        }

        private string getVehiculoById(int vehiculoId)
        {
            var vehiculo = vehiculoController.findById(vehiculoId);
            string chasis = vehiculo.Chasis;
            var modelo = modeloController.findById(vehiculo.ModeloId);
            string nombreModelo = modelo.Nombre;
            var marca = marcaController.findById(modelo.MarcaId);
            string nombreMarca = marca.Nombre;
            string result = $"{chasis} - {nombreMarca} - {nombreModelo}";
            return result;
        }

        private void LimpiarCampos()
        {
            txtVehiculo.Text = string.Empty;
            txtPenalidad.Text = string.Empty;
        }

        private void dgvDevolucionVehiculo_SelectionChanged(object sender, EventArgs e)
        {
            alquilerId = Convert.ToInt32(dgvDevolucionVehiculo.CurrentRow.Cells["Id"].Value.ToString());
            txtVehiculo.Text = dgvDevolucionVehiculo.CurrentRow.Cells["Vehiculo"].Value.ToString();
            var fechaHasta = Convert.ToDateTime(dgvDevolucionVehiculo.CurrentRow.Cells["FechaHasta"].Value.ToString());
            if(DateTime.Now > fechaHasta)
            {
                labelPenalidad.Visible = true;
                txtPenalidad.Visible = true;
                toogleIsPenalty = 1;
            }
            else
            {
                labelPenalidad.Visible = false;
                txtPenalidad.Visible = false;
                toogleIsPenalty = 0;
            }
        }

        private void txtPenalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehiculo.Text) ||  (toogleIsPenalty == 1 && string.IsNullOrWhiteSpace(txtPenalidad.Text)))
            {
                MessageBox.Show("Favor de seleccionar el alquiler para realizar la devolución del vehículo");
            }
            else
            {
                decimal txtPenalidadValue;
                if(toogleIsPenalty == 1)
                {
                    txtPenalidadValue = Convert.ToDecimal(txtPenalidad.Text);
                }
                else
                {
                    txtPenalidadValue = 0;
                }
                Alquiler alquiler = new Alquiler()
                {
                    Id = alquilerId,
                    FechaDevolucion = DateTime.Now,
                    Penalidad = txtPenalidadValue,
                    Estatus = "I",
                    FechaModificacion = DateTime.Now
                };

                var devolvedVehiculo = alquilerController.Edit(alquiler);
                if (devolvedVehiculo.Success == true)
                {
                    LlenarDataTable();
                    LimpiarCampos();
                    MessageBox.Show(devolvedVehiculo.Message);
                }
                else
                {
                    MessageBox.Show(devolvedVehiculo.Message);
                }
            }
        }

    }
}
