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
    public partial class CrearMarca : Form
    {
        MarcaController marca = new MarcaController();
        public CrearMarca()
        {
            InitializeComponent();
        }
        private void LlenarDataTable()
        {
            dgvCrearMarca.DataSource = marca.getAll();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                Marca nuevoMarca = new Marca()
                {
                    Nombre = textBox1.Text,
                    Estatus = textBox2.Text,
                    FechaRegistro = DateTime.Now,
                    FechaModificacion = null,
                    Borrado = false,
                };

                var crear = marca.Create(nuevoMarca);
                LlenarDataTable();
                if (crear.Success)
                {
                    MessageBox.Show(crear.Message);
                }
                else
                {
                    MessageBox.Show(crear.Message);
                }

            }
        }

        private void CrearMarca_Load(object sender, EventArgs e)
        {
            dgvCrearMarca.DataSource = marca.getAll();
        }
    }
}
