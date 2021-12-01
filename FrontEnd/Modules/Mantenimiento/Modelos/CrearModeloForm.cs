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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Modelos
{
    public partial class CrearModeloForm : Form
    {
        ModeloController modeloController;
        MarcaController marcaController;
        public CrearModeloForm()
        {
            modeloController = new ModeloController();
            marcaController = new MarcaController();
            InitializeComponent();
        }

        private void CrearModeloForm_Load(object sender, EventArgs e)
        {
            var marcaList = marcaController.getAll().Where(x => x.Estatus.Equals("A")).ToList();
            comboBoxMarca.DataSource = marcaList;
            comboBoxMarca.DisplayMember = "Nombre";
            comboBoxMarca.ValueMember = "Id";
            panelCrearModelo.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();

        }

        private void LlenarDataTable()
        {
            var showListModelo = modeloController.getAll().Select(x => new { x.Nombre, Marca = getMarcaById(x.MarcaId), x.Estatus }).ToList();
            dgvCrearModelo.DataSource = showListModelo;
        }

        private string getMarcaById(int marcaId)
        {
            return marcaController.findById(marcaId).Nombre;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            comboBoxMarca.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(comboBoxMarca.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                var value = comboBoxMarca.SelectedValue;
                Console.WriteLine(value);
                Modelo nuevoModelo = new Modelo()
                {
                    Nombre = txtNombre.Text,
                    MarcaId = Convert.ToInt32(comboBoxMarca.SelectedValue),
                    Borrado = false,
                    Estatus = "A",
                    FechaRegistro = DateTime.Now
                };
                var createdModelo = modeloController.Create(nuevoModelo);
                if (createdModelo.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(createdModelo.Message);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(createdModelo.Message);
                }

            }
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
