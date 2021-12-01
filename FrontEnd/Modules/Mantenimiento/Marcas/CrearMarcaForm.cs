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
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MarcaMantenimiento
{
    public partial class CrearMarcaForm : Form
    {
        MarcaController marcaController;
        public CrearMarcaForm()
        {
            marcaController = new MarcaController();
            InitializeComponent();
        }
        private void CrearMarca_Load(object sender, EventArgs e)
        {
            panelCrearMarca.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            dgvCrearMarca.DataSource = marcaController.getAll().Select(x => new { x.Nombre, x.Estatus }).ToList();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
                    Nombre = txtNombre.Text,
                    Borrado = false,
                    Estatus = "A",
                    FechaRegistro = DateTime.Now
                };

                var createdMarca = marcaController.Create(marca);
                if (createdMarca.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(createdMarca.Message);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(createdMarca.Message);
                }
            }
        }

    }
}
