using SistemaDeAlquilerDeVehiculos.BackEnd.Controllers;
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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoVehiculo
{
    public partial class CrearVehiculoForm : Form
    {
        VehiculoController vehiculoController;
        TipoTransmisionController tipoTransmisionController;
        TipoCombustibleController tipoCombustibleController;
        ModeloController modeloController;
        public CrearVehiculoForm()
        {
            vehiculoController = new VehiculoController();
            tipoTransmisionController = new TipoTransmisionController();
            tipoCombustibleController = new TipoCombustibleController();
            modeloController = new ModeloController();
            InitializeComponent();
        }

        private void CrearVehiculo_Load(object sender, EventArgs e)
        {
            panelCrearVehiculo.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
            LlenarComboBoxTransmision();
            LlenarComboBoxCombustible();
            LlenarComboBoxModelo();
            LlenarComboBoxAnio();
            LlenarComboBoxPuertas();
        }

        private void LlenarComboBoxTransmision()
        {
            var transmisionList = tipoTransmisionController.getAll().Where(x => x.Estatus.Equals("A")).ToList();
            comboBoxTransmision.DataSource = transmisionList;
            comboBoxTransmision.DisplayMember = "Nombre";
            comboBoxTransmision.ValueMember = "Id";
        }

        private void LlenarComboBoxCombustible()
        {
            var combustibleList = tipoCombustibleController.getAll().Where(x => x.Estatus.Equals("A")).ToList();
            comboBoxCombustible.DataSource = combustibleList;
            comboBoxCombustible.DisplayMember = "Nombre";
            comboBoxCombustible.ValueMember = "Id";
        }

        private void LlenarComboBoxModelo()
        {
            var modeloList = modeloController.getAll().Where(x => x.Estatus.Equals("A")).ToList();
            comboBoxModelo.DataSource = modeloList;
            comboBoxModelo.DisplayMember = "Nombre";
            comboBoxModelo.ValueMember = "Id";
        }

        private void LlenarDataTable()
        {
            var showListVehiculo = vehiculoController.getAll().Select(x => new { Transmision = getTransmisionById(x.TipoTransmisionId), Combustible = getCombustibleById(x.TipoCombustibleId),
                                                                                Modelo = getModeloById(x.ModeloId), x.Chasis, x.Placa, Año = x.Anio, x.Color, x.Cilindraje, Kilometros = x.KilometrosTablero,
                                                                                Puertas = x.CantidadPuerta, x.Precio, x.Estatus }).ToList();
            dgvCrearVehiculo.DataSource = showListVehiculo;
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

        private void LlenarComboBoxAnio()
        {
            comboBoxAnio.DataSource = Enumerable.Range(1950, DateTime.UtcNow.Year - 1949).Reverse().ToList();
        }

        private void LlenarComboBoxPuertas()
        {
            List<int> puertaList = new List<int>()
            {
                4,2
            };
            comboBoxPuertas.DataSource = puertaList;
        }

        private void LimpiarCampos()
        {
            comboBoxTransmision.Text = string.Empty;
            comboBoxCombustible.Text = string.Empty;
            comboBoxModelo.Text = string.Empty;
            txtChasis.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            comboBoxAnio.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtCilindraje.Text = string.Empty;
            txtKilometros.Text = string.Empty;
            comboBoxPuertas.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxTransmision.Text) || string.IsNullOrWhiteSpace(comboBoxCombustible.Text)
                || string.IsNullOrWhiteSpace(comboBoxModelo.Text) || string.IsNullOrWhiteSpace(txtChasis.Text)
                || string.IsNullOrWhiteSpace(comboBoxAnio.Text) || string.IsNullOrWhiteSpace(txtColor.Text)
                || string.IsNullOrWhiteSpace(txtCilindraje.Text) || string.IsNullOrWhiteSpace(txtKilometros.Text)
                || string.IsNullOrWhiteSpace(comboBoxPuertas.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            } else if (txtChasis.Text.Count() != 17)
            {
                MessageBox.Show("Chasis incorrecto");
            } else if (txtPlaca.Text.Count() !=7)
            {
                MessageBox.Show("Placa incorrecta");
            }
            else
            {
                Vehiculo nuevoVehiculo = new Vehiculo()
                {
                    TipoTransmisionId = Convert.ToInt32(comboBoxTransmision.SelectedValue),
                    TipoCombustibleId = Convert.ToInt32(comboBoxCombustible.SelectedValue),
                    ModeloId = Convert.ToInt32(comboBoxModelo.SelectedValue),
                    Chasis = txtChasis.Text,
                    Placa = txtPlaca.Text,
                    Anio  = comboBoxAnio.SelectedValue.ToString(),
                    Color = txtColor.Text,
                    Cilindraje = txtCilindraje.Text,
                    KilometrosTablero = txtKilometros.Text,
                    CantidadPuerta = Convert.ToInt32(comboBoxPuertas.SelectedValue),
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Borrado = false,
                    Estatus = "A",
                    FechaRegistro = DateTime.Now
                };
                var createdVehiculo = vehiculoController.Create(nuevoVehiculo);
                if (createdVehiculo.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(createdVehiculo.Message);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(createdVehiculo.Message);
                }

            }
        }
    }
}
