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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.TipoTransmisiones
{
    public partial class ActualizarTipoTransmisionForm : Form
    {
        TipoTransmisionController tipoTransmisionController;
        int tipoTransmisionId;
        List<PairValue> pairValueList;
        public ActualizarTipoTransmisionForm()
        {
            tipoTransmisionController = new TipoTransmisionController();
            pairValueList = new List<PairValue>()
            {
                new PairValue { Key = "A", Value = "Activo" },
                new PairValue { Key = "I", Value = "Inactivo"}
            };
            InitializeComponent();
        }

        private void ActualizarTipoTransmisionForm_Load(object sender, EventArgs e)
        {
            panelActualizarTipoTransmision.BorderStyle = BorderStyle.FixedSingle;
            LlenarComboBoxEstatus();          
            LlenarDataTable();               
        }

        private void LlenarComboBoxEstatus()
        {
            comboBoxEstatus.DataSource = pairValueList;
            comboBoxEstatus.DisplayMember = "Value";
            comboBoxEstatus.ValueMember = "Key";
        }

        private void LlenarDataTable()
        {
            var showListTipoTransmision = tipoTransmisionController.getAll().Select(x => new { x.Id, x.Nombre, x.Estatus }).ToList();
            dgvActualizarTipoTransmision.DataSource = showListTipoTransmision;
            dgvActualizarTipoTransmision.Columns["Id"].Visible = false;
            if (showListTipoTransmision.Count() == 0)
            {
                LimpiarCampos();
            }
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
            comboBoxEstatus.SelectedValue = dgvActualizarTipoTransmision.CurrentRow.Cells["Estatus"].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(comboBoxEstatus.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                TipoTransmision tipoTransmision = new TipoTransmision()
                {
                    Id = tipoTransmisionId,
                    Nombre = txtNombre.Text,
                    Estatus = comboBoxEstatus.SelectedValue.ToString()
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
