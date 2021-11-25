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
    public partial class MantenimientoTipoCombustible : Form
    {

        TipoCombustibleController combustible = new TipoCombustibleController();
        public MantenimientoTipoCombustible()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text)) {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                TipoCombustible nuevoCombustible = new TipoCombustible()
                {
                    Nombre=textBox1.Text,
                    Estatus=textBox2.Text,
                    FechaRegistro=DateTime.Now,
                    FechaModificacion= DateTime.Now,
                    Borrado=false,
                };

                var crear = combustible.Create(nuevoCombustible);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                TipoCombustible actualizarCombustible = new TipoCombustible()
                {
                   Id = Int32.Parse(textBox5.Text),
                    Nombre = textBox4.Text,
                    Estatus = textBox3.Text,
                 
                    FechaModificacion = DateTime.Now,
                    Borrado = false,
                };

                var actualizar = combustible.Edit(actualizarCombustible);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text) )
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                TipoCombustible eliminarCombustible = new TipoCombustible()
                {
                    Id = Int32.Parse(textBox6.Text),
                    
                };

                var elminar = combustible.Delete(eliminarCombustible);
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
