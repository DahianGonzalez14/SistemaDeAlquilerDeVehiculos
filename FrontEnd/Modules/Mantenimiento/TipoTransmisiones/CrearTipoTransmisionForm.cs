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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.TipoTransmisiones
{
    public partial class CrearTipoTransmisionForm : Form
    {
        TipoTransmisionController tipoTransmisionController;
        public CrearTipoTransmisionForm()
        {
            tipoTransmisionController = new TipoTransmisionController();
            InitializeComponent();
        }

        private void labelCrearClienteMantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void dgvCrearCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelCrearCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CrearTipoTransmisionForm_Load(object sender, EventArgs e)
        {
            panelCrearTipoTransmision.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            var showListTipoTransmision = tipoTransmisionController.getAll().Select(x => new { x.Nombre, x.Estatus }).ToList();
            dgvCrearTransmision.DataSource = showListTipoTransmision;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                TipoTransmision tipoTransmision = new TipoTransmision()
                {
                    Nombre = txtNombre.Text,
                    Borrado = false,
                    Estatus = "A",
                    FechaRegistro = DateTime.Now
                };
                var createdTipoTransmision = tipoTransmisionController.Create(tipoTransmision);
                if (createdTipoTransmision.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(createdTipoTransmision.Message);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(createdTipoTransmision.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
        }
    }
}
