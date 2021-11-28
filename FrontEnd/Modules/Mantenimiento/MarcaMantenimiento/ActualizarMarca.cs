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
    public partial class ActualizarMarca : Form
    {
        MarcaController marca = new MarcaController();
        public ActualizarMarca()
        {
            InitializeComponent();
        }
        private void LlenarDataTable()
        {
            dgvCrearMarca.DataSource = marca.getAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                Marca actualizarMarca = new Marca()
                {
                    Id = Int32.Parse(textBox5.Text),
                    Nombre = textBox4.Text,
                    Estatus = textBox3.Text,
                    FechaModificacion = DateTime.Now,
                    Borrado = false,
                };

                var actualizar = marca.Edit(actualizarMarca);
                LlenarDataTable();
                if (actualizar.Success)
                {
                    MessageBox.Show(actualizar.Message);
                }
                else
                {
                    MessageBox.Show(actualizar.Message);
                }

            }
        }

        private void ActualizarMarca_Load(object sender, EventArgs e)
        {
            dgvCrearMarca.DataSource = marca.getAll();
        }
    }
}
