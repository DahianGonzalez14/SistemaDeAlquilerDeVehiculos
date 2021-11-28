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
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoTipoCombustible
{
    public partial class DeleteTipoCombustible : Form
    {
        TipoCombustibleController combustible = new TipoCombustibleController();
        public DeleteTipoCombustible()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                TipoCombustible eliminarCombustible = new TipoCombustible()
                {
                    Id = Int32.Parse(textBox5.Text),

                };

                var elminar = combustible.Delete(eliminarCombustible);
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
        private void LlenarDataTable()
        {
            dgvCrearTipoCombustible.DataSource = combustible.getAll();
        }

        private void DeleteTipoCombustible_Load(object sender, EventArgs e)
        {
            dgvCrearTipoCombustible.DataSource = combustible.getAll();
        }
    }
}
