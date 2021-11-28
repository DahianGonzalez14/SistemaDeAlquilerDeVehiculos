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
    public partial class ActualizarTipoTransmisionForm : Form
    {
        TipoTransmisionController tipoTransmisionController;
        int tipoTransmisionId;
        public ActualizarTipoTransmisionForm()
        {
            tipoTransmisionController = new TipoTransmisionController();
            InitializeComponent();
        }

        private void ActualizarTipoTransmisionForm_Load(object sender, EventArgs e)
        {
            panelActualizarTipoTransmision.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
            dgvActualizarTipoTransmision.Columns["Id"].Visible = false;
        }

        private void LlenarDataTable()
        {
            var showListTipoTransmision = tipoTransmisionController.getAll().Select(x => new { x.Id, x.Nombre, x.Estatus }).ToList();
            dgvActualizarTipoTransmision.DataSource = showListTipoTransmision;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            comboBoxEstatus.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvActualizarTipoTransmision_SelectionChanged(object sender, EventArgs e)
        {
            tipoTransmisionId = Convert.ToInt32(dgvActualizarTipoTransmision.CurrentRow.Cells["Id"].Value.ToString());
            txtNombre.Text = dgvActualizarTipoTransmision.CurrentRow.Cells["Nombre"].Value.ToString();
            comboBoxEstatus.SelectedIndex = getIndexByEstatus();
        }

        private int getIndexByEstatus()
        {
            var estatus = dgvActualizarTipoTransmision.CurrentRow.Cells["Estatus"].Value.ToString();
            if (estatus.Equals("A"))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private string getValueByEstatus(string estatus)
        {
            if (estatus.Equals("Activo"))
            {
                return "A";
            }
            else
            {
                return "I";
            }
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
                    Id = tipoTransmisionId,
                    Nombre = txtNombre.Text,
                    Estatus = getValueByEstatus(comboBoxEstatus.Text)
                };

                var updatedTipoTransmision = tipoTransmisionController.Edit(tipoTransmision);
                if (updatedTipoTransmision.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(updatedTipoTransmision.Message);
                }
                else
                {
                    MessageBox.Show(updatedTipoTransmision.Message);
                }
            }
        }
    }
}
