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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoTipoCombustible
{
    public partial class ActualizarTipoCombustibleForm : Form
    {
        TipoCombustibleController tipoCombustibleController;
        int tipoCombustibleId;
        List<PairValue> pairValueList;
        public ActualizarTipoCombustibleForm()
        {
            tipoCombustibleController = new TipoCombustibleController();
            pairValueList = new List<PairValue>()
            {
                new PairValue { Key = "A", Value = "Activo" },
                new PairValue { Key = "I", Value = "Inactivo"}
            };
            InitializeComponent();
        }

        private void ActualizarTipoCombustible_Load(object sender, EventArgs e)
        {
            panelActualizarTipoCombustible.BorderStyle = BorderStyle.FixedSingle;
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
            var showListTipoCombustible = tipoCombustibleController.getAll().Select(x => new { x.Id, x.Nombre, x.Estatus }).ToList();
            dgvActualizarTipoCombustible.DataSource = showListTipoCombustible;
            dgvActualizarTipoCombustible.Columns["Id"].Visible = false;
            if (showListTipoCombustible.Count() == 0)
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

        private void dgvActualizarTipoCombustible_SelectionChanged(object sender, EventArgs e)
        {
            tipoCombustibleId = Convert.ToInt32(dgvActualizarTipoCombustible.CurrentRow.Cells["Id"].Value.ToString());
            txtNombre.Text = dgvActualizarTipoCombustible.CurrentRow.Cells["Nombre"].Value.ToString();
            comboBoxEstatus.SelectedValue = dgvActualizarTipoCombustible.CurrentRow.Cells["Estatus"].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(comboBoxEstatus.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                TipoCombustible tipoCombustible = new TipoCombustible()
                {
                    Id = tipoCombustibleId,
                    Nombre = txtNombre.Text,
                    Estatus = comboBoxEstatus.SelectedValue.ToString()
                };

                var updatedTipoCombustible = tipoCombustibleController.Edit(tipoCombustible);
                if (updatedTipoCombustible.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(updatedTipoCombustible.Message);
                }
                else
                {
                    MessageBox.Show(updatedTipoCombustible.Message);
                }
            }
        }
    }
}
