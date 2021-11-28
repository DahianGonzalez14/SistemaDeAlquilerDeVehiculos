using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using SistemaDeAlquilerDeVehiculos.BackEnd.Controllers;
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoTipoCombustible
{
    public partial class CrearTipoCombustible : Form
    {
        TipoCombustibleController combustible = new TipoCombustibleController();
        public CrearTipoCombustible()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                TipoCombustible nuevoCombustible = new TipoCombustible()
                {
                    Nombre = textBox1.Text,
                    Estatus = textBox2.Text,
                    FechaRegistro = DateTime.Now,
                    FechaModificacion = null,
                    Borrado = false,
                };

                var crear = combustible.Create(nuevoCombustible);
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

        private void CrearTipoCombustible_Load(object sender, EventArgs e)
        {
            dgvCrearTipoCombustible.DataSource = combustible.getAll();
        }

        private void LlenarDataTable()
        {
            dgvCrearTipoCombustible.DataSource = combustible.getAll();
        }
    }
}
