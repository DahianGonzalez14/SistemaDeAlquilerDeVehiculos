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
using SistemaDeAlquilerDeVehiculos.BackEnd.Helpers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoVehiculo
{
    public partial class ActualizarVehiculoForm : Form
    {
        VehiculoController vehiculoController;
        TipoTransmisionController tipoTransmisionController;
        TipoCombustibleController tipoCombustibleController;
        ModeloController modeloController;
        List<PairValue> pairValueList;
        List<PairValue> puertaList;
        List<PairValue> anioList;
        int vehiculoId;
        public ActualizarVehiculoForm()
        {
            vehiculoController = new VehiculoController();
            tipoTransmisionController = new TipoTransmisionController();
            tipoCombustibleController = new TipoCombustibleController();
            modeloController = new ModeloController();
            pairValueList = new List<PairValue>
            {
                new PairValue { Key = "A", Value = "Activo" },
                new PairValue { Key = "I", Value = "Inactivo"}
            };
            puertaList = new List<PairValue>
            {
                new PairValue { Key = 4, Value = 4 },
                new PairValue { Key = 2, Value = 2}
            };
            anioList = new List<PairValue>();
            InitializeComponent();
        }

        private void ActualizarVehiculo_Load(object sender, EventArgs e)
        {
            panelActualizarVehiculo.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
            LlenarComboBoxTransmision();
            LlenarComboBoxCombustible();
            LlenarComboBoxModelo();
            LlenarComboBoxAnio();
            LlenarComboBoxPuertas();
            LlenarComboBoxEstatus();
        }

        private void LlenarComboBoxEstatus()
        {
            comboBoxEstatus.DataSource = pairValueList;
            comboBoxEstatus.DisplayMember = "Value";
            comboBoxEstatus.ValueMember = "Key";
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
            var showListVehiculo = vehiculoController.getAll().Select(x => new {
                x.Id,
                x.TipoTransmisionId,
                x.TipoCombustibleId,
                x.ModeloId,
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
            dgvActualizarVehiculo.DataSource = showListVehiculo;
            dgvActualizarVehiculo.Columns["Id"].Visible = false;
            dgvActualizarVehiculo.Columns["TipoTransmisionId"].Visible = false;
            dgvActualizarVehiculo.Columns["TipoCombustibleId"].Visible = false;
            dgvActualizarVehiculo.Columns["ModeloId"].Visible = false;
            if (showListVehiculo.Count() == 0)
            {
                LimpiarCampos();
            }
            LlenarComboBoxAnio();
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
            var aniosList = Enumerable.Range(1950, DateTime.UtcNow.Year - 1949).Reverse().ToList();
            foreach(int anio in aniosList){
                PairValue value = new PairValue();
                value.Value = anio.ToString();
                value.Key = anio.ToString();
                anioList.Add(value);
            }
            comboBoxAnio.DataSource = anioList;
            comboBoxAnio.DisplayMember = "Value";
            comboBoxAnio.ValueMember = "Key";
        }

        private void LlenarComboBoxPuertas()
        {
            comboBoxPuertas.DataSource = puertaList;
            comboBoxPuertas.DisplayMember = "Value";
            comboBoxPuertas.ValueMember = "Key";
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
            comboBoxEstatus.Text = string.Empty;

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

        private void dgvActualizarVehiculo_SelectionChanged(object sender, EventArgs e)
        {
            vehiculoId = Convert.ToInt32(dgvActualizarVehiculo.CurrentRow.Cells["Id"].Value.ToString());
            comboBoxTransmision.SelectedValue = Convert.ToInt32(dgvActualizarVehiculo.CurrentRow.Cells["TipoTransmisionId"].Value.ToString());
            comboBoxCombustible.SelectedValue = Convert.ToInt32(dgvActualizarVehiculo.CurrentRow.Cells["TipoCombustibleId"].Value.ToString());
            comboBoxModelo.SelectedValue = Convert.ToInt32(dgvActualizarVehiculo.CurrentRow.Cells["ModeloId"].Value.ToString());
            txtChasis.Text = dgvActualizarVehiculo.CurrentRow.Cells["Chasis"].Value.ToString();
            txtPlaca.Text = dgvActualizarVehiculo.CurrentRow.Cells["Placa"].Value.ToString();
            comboBoxAnio.SelectedValue = dgvActualizarVehiculo.CurrentRow.Cells["Año"].Value.ToString();
            txtColor.Text = dgvActualizarVehiculo.CurrentRow.Cells["Color"].Value.ToString();
            txtCilindraje.Text = dgvActualizarVehiculo.CurrentRow.Cells["Cilindraje"].Value.ToString();
            txtKilometros.Text = dgvActualizarVehiculo.CurrentRow.Cells["Kilometros"].Value.ToString();
            comboBoxPuertas.SelectedValue = Convert.ToInt32(dgvActualizarVehiculo.CurrentRow.Cells["Puertas"].Value.ToString());
            txtPrecio.Text = dgvActualizarVehiculo.CurrentRow.Cells["Precio"].Value.ToString();
            comboBoxEstatus.SelectedValue = dgvActualizarVehiculo.CurrentRow.Cells["Estatus"].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxTransmision.Text) || string.IsNullOrWhiteSpace(comboBoxCombustible.Text)
                            || string.IsNullOrWhiteSpace(comboBoxModelo.Text) || string.IsNullOrWhiteSpace(txtChasis.Text)
                            || string.IsNullOrWhiteSpace(comboBoxAnio.Text) || string.IsNullOrWhiteSpace(txtColor.Text)
                            || string.IsNullOrWhiteSpace(txtCilindraje.Text) || string.IsNullOrWhiteSpace(txtKilometros.Text)
                            || string.IsNullOrWhiteSpace(comboBoxPuertas.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text)
                            || string.IsNullOrWhiteSpace(comboBoxEstatus.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else if (txtChasis.Text.Count() != 17)
            {
                MessageBox.Show("Chasis incorrecto");
            }
            else if (txtPlaca.Text.Count() != 7)
            {
                MessageBox.Show("Placa incorrecta");
            }
            else
            {
                Vehiculo vehiculo = new Vehiculo()
                {
                    Id = vehiculoId,
                    TipoTransmisionId = Convert.ToInt32(comboBoxTransmision.SelectedValue),
                    TipoCombustibleId = Convert.ToInt32(comboBoxCombustible.SelectedValue),
                    ModeloId = Convert.ToInt32(comboBoxModelo.SelectedValue),
                    Chasis = txtChasis.Text,
                    Placa = txtPlaca.Text,
                    Anio = comboBoxAnio.SelectedValue.ToString(),
                    Color = txtColor.Text,
                    Cilindraje = txtCilindraje.Text,
                    KilometrosTablero = txtKilometros.Text,
                    CantidadPuerta = Convert.ToInt32(comboBoxPuertas.SelectedValue),
                    Precio = Convert.ToDecimal(txtPrecio.Text),
                    Borrado = false,
                    Estatus = comboBoxEstatus.SelectedValue.ToString(),
                    FechaRegistro = DateTime.Now
                };

                var updatedVehiculo = vehiculoController.Edit(vehiculo);
                if (updatedVehiculo.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(updatedVehiculo.Message);
                }
                else
                {
                    MessageBox.Show(updatedVehiculo.Message);
                }
            }
        }
    }
}
