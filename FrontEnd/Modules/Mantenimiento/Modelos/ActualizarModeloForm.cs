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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Modelos
{
    public partial class ActualizarModeloForm : Form
    {
        ModeloController modeloController;
        MarcaController marcaController;
        int modeloId;
        List<PairValue> pairValueList;
        public ActualizarModeloForm()
        {
            modeloController = new ModeloController();
            marcaController = new MarcaController();
            pairValueList = new List<PairValue>
            {
                new PairValue { Key = "A", Value = "Activo" },
                new PairValue { Key = "I", Value = "Inactivo"}
            };
            InitializeComponent();
        }

        private void ActualizarModeloForm_Load(object sender, EventArgs e)
        {
            panelActualizarModelo.BorderStyle = BorderStyle.FixedSingle;
            LlenarComboBoxMarca();
            LlenarComboBoxEstatus();            
            LlenarDataTable();
        }

        private void LlenarComboBoxEstatus()
        {
            comboBoxEstatus.DataSource = pairValueList;
            comboBoxEstatus.DisplayMember = "Value";
            comboBoxEstatus.ValueMember = "Key";
        }

        private void LlenarComboBoxMarca()
        {
            var marcaList = marcaController.getAll().Where(x => x.Estatus.Equals("A")).ToList();
            comboBoxMarca.DataSource = marcaList;
            comboBoxMarca.DisplayMember = "Nombre";
            comboBoxMarca.ValueMember = "Id";
        }

        private void LlenarDataTable()
        {
            var showListModelo = modeloController.getAll().Select(x => new { x.Id ,x.Nombre, x.MarcaId ,Marca = getMarcaById(x.MarcaId), x.Estatus }).ToList();
            dgvActualizarModelo.DataSource = showListModelo;
            dgvActualizarModelo.Columns["Id"].Visible = false;
            dgvActualizarModelo.Columns["MarcaId"].Visible = false;
            if (showListModelo.Count() == 0)
            {
                LimpiarCampos();
            }
        }

        private string getMarcaById(int marcaId)
        {
            return marcaController.findById(marcaId).Nombre;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            comboBoxMarca.Text = string.Empty;
            comboBoxEstatus.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvActualizarModelo_SelectionChanged(object sender, EventArgs e)
        {
            modeloId = Convert.ToInt32(dgvActualizarModelo.CurrentRow.Cells["Id"].Value.ToString());
            txtNombre.Text = dgvActualizarModelo.CurrentRow.Cells["Nombre"].Value.ToString();
            comboBoxMarca.SelectedValue = Convert.ToInt32(dgvActualizarModelo.CurrentRow.Cells["MarcaId"].Value.ToString());
            comboBoxEstatus.SelectedValue = dgvActualizarModelo.CurrentRow.Cells["Estatus"].Value.ToString();           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text ) || string.IsNullOrWhiteSpace(comboBoxEstatus.Text)
                || string.IsNullOrWhiteSpace(comboBoxMarca.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                Modelo modelo = new Modelo()
                {
                    Id = modeloId,
                    Nombre = txtNombre.Text,
                    MarcaId = Convert.ToInt32(comboBoxMarca.SelectedValue),
                    Estatus = comboBoxEstatus.SelectedValue.ToString()
                };

                var updatedModelo = modeloController.Edit(modelo);
                if (updatedModelo.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(updatedModelo.Message);
                }
                else
                {
                    MessageBox.Show(updatedModelo.Message);
                }
            }
        }
    }
}
