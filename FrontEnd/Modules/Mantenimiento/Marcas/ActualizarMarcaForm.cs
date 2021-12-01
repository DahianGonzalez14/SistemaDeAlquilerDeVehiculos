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
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MarcaMantenimiento
{
    public partial class ActualizarMarcaForm : Form
    {
        MarcaController marcaController;
        List<PairValue> pairValueList;
        int marcaId;
        public ActualizarMarcaForm()
        {
            marcaController = new MarcaController();
            pairValueList = new List<PairValue>()
            {
                new PairValue { Key = "A", Value = "Activo" },
                new PairValue { Key = "I", Value = "Inactivo"}
            };
            InitializeComponent();
        }

        private void ActualizarMarca_Load(object sender, EventArgs e)
        {
            panelActualizarMarca.BorderStyle = BorderStyle.FixedSingle;
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
            var showListMarca = marcaController.getAll().Select(x => new { x.Id, x.Nombre, x.Estatus }).ToList();
            dgvActualizarMarca.DataSource = showListMarca;
            dgvActualizarMarca.Columns["Id"].Visible = false;
            if (showListMarca.Count() == 0)
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

        private void dgvActualizarMarca_SelectionChanged(object sender, EventArgs e)
        {
            marcaId = Convert.ToInt32(dgvActualizarMarca.CurrentRow.Cells["Id"].Value.ToString());
            txtNombre.Text = dgvActualizarMarca.CurrentRow.Cells["Nombre"].Value.ToString();
            comboBoxEstatus.SelectedValue = dgvActualizarMarca.CurrentRow.Cells["Estatus"].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                Marca marca = new Marca()
                {
                    Id = marcaId,
                    Nombre = txtNombre.Text,
                    Estatus = comboBoxEstatus.SelectedValue.ToString()
                };

                var updatedMarca = marcaController.Edit(marca);
                if (updatedMarca.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(updatedMarca.Message);
                }
                else
                {
                    MessageBox.Show(updatedMarca.Message);
                }
            }
        }
    }
}
