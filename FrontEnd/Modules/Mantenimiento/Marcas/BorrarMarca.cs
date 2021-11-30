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
    public partial class DeleteMarca : Form
    {
        MarcaController marca = new MarcaController();
        public DeleteMarca()
        {
            InitializeComponent();
        }
        private void LlenarDataTable()
        {
            dgvCrearMarca.DataSource = marca.getAll();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                Marca eliminarMarca = new Marca()
                {
                    Id = Int32.Parse(textBox6.Text),

                };

                var elminar = marca.Delete(eliminarMarca);
                LlenarDataTable();
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

        private void DeleteMarca_Load(object sender, EventArgs e)
        {
            dgvCrearMarca.DataSource = marca.getAll();
        }
    }
}
