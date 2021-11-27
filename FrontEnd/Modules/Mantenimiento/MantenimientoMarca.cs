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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento
{
    public partial class MantenimientoMarca : Form
    {
        MarcaController marca = new MarcaController();
        public MantenimientoMarca()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                Marca eliminarMarca= new Marca()
                {
                    Id = Int32.Parse(textBox6.Text),

                };

                var elminar = marca.Delete(eliminarMarca);
                if (elminar.Success)
                {
                    MessageBox.Show(elminar.Message);
                }
                else
                {
                    MessageBox.Show(elminar.Message);
                }

            }
        }
    }
}
