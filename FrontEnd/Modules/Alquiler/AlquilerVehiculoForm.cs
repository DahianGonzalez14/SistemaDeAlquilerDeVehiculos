using SistemaDeAlquilerDeVehiculos.BackEnd.Controllers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Helpers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.AlquilerVehiculo
{
    public partial class AlquilerVehiculoForm : Form
    {
        AlquilerController alquilerController;
        ClienteController clienteController;
        VehiculoController vehiculoController;
        ModeloController modeloController;
        MarcaController marcaController;
        List<PairValue> metodoPagoList;
        public AlquilerVehiculoForm()
        {
            alquilerController = new AlquilerController();
            clienteController = new ClienteController();
            vehiculoController = new VehiculoController();
            modeloController = new ModeloController();
            marcaController = new MarcaController();
            metodoPagoList = new List<PairValue>
            {
                new PairValue { Key = "Transferencia", Value = "Transferencia" },
                new PairValue { Key = "Tarjeta Credito/Debito", Value = "Tarjeta Credito/Debito"},
                new PairValue { Key = "Efectivo", Value ="Efectivo"},
                new PairValue { Key = "Paypal", Value = "Paypal"}
            };
            InitializeComponent();
        }

        private void AlquilerVehiculoForm_Load(object sender, EventArgs e)
        {
            panelAlquilerVehiculo.BorderStyle = BorderStyle.FixedSingle;
            dateTimePickerFechaDesde.MinDate = DateTime.Now;
            LlenarDataTable();
            LlenarComboBoxCliente();
            LlenarComboBoxVehiculo();
            LlenarComboBoxMetodoPago();
        }

        private void LlenarDataTable()
        {
            var showListAlquilerVehiculo = alquilerController.getAll().Select(x => new { Cliente =  getClienteById(x.ClienteId), Vehiculo = getVehiculoById(x.VehiculoId), x.MetodoPago, x.Costo, x.FechaDesde, x.FechaHasta , x.Estatus }).Where(x => x.Estatus.Equals("A")).ToList();
            dgvAlquilerVehiculo.DataSource = showListAlquilerVehiculo;
            if(showListAlquilerVehiculo.Count() != 0)
            {
                dgvAlquilerVehiculo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void LlenarComboBoxCliente()
        {
            var clienteList = clienteController.getAll().Where(x => x.Estatus.Equals("A")).ToList();
            comboBoxCliente.DataSource = clienteList;
            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.ValueMember = "Id";
        }

        private void LlenarComboBoxVehiculo()
        {
            var vehiculoList = vehiculoController.getAll().Where(x => x.Estatus.Equals("A")).ToList();
            comboBoxVehiculo.DataSource = vehiculoList;
            comboBoxVehiculo.DisplayMember = "Chasis";
            comboBoxVehiculo.ValueMember = "Id";
        }

        private void LlenarComboBoxMetodoPago()
        {
            comboBoxMetodoPago.DataSource = metodoPagoList;
            comboBoxMetodoPago.DisplayMember = "Value";
            comboBoxMetodoPago.ValueMember = "Key";
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
            comboBoxCliente.Text = string.Empty;
            comboBoxVehiculo.Text = string.Empty;
            comboBoxMetodoPago.Text = string.Empty;
            txtCosto.Text = string.Empty;
            dateTimePickerFechaDesde.Value = DateTime.Now;
            dateTimePickerFechaHasta.Value = DateTime.Now;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
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
            if (string.IsNullOrWhiteSpace(comboBoxCliente.Text) || string.IsNullOrWhiteSpace(comboBoxVehiculo.Text)
                || string.IsNullOrWhiteSpace(comboBoxMetodoPago.Text) || string.IsNullOrWhiteSpace(txtCosto.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                Alquiler nuevoAlquiler = new Alquiler()
                {
                    ClienteId = Convert.ToInt32(comboBoxCliente.SelectedValue),
                    VehiculoId = Convert.ToInt32(comboBoxVehiculo.SelectedValue),
                    MetodoPago = comboBoxMetodoPago.SelectedValue.ToString(),
                    Costo = Convert.ToDecimal(txtCosto.Text),
                    FechaDesde = dateTimePickerFechaDesde.Value,
                    FechaHasta = dateTimePickerFechaHasta.Value,
                    Borrado = false,
                    Estatus = "A",
                    FechaRegistro = DateTime.Now
                };
                var createdAlquiler = alquilerController.Create(nuevoAlquiler);
                if (createdAlquiler.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(createdAlquiler.Message);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(createdAlquiler.Message);
                }

            }
        }

        private void dateTimePickerFechaDesde_CloseUp(object sender, EventArgs e)
        {
            dateTimePickerFechaHasta.MinDate = dateTimePickerFechaDesde.Value;
        }
    }
}
