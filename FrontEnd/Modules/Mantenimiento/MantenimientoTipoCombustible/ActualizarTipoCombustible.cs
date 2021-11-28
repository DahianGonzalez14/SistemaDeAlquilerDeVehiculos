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
    public partial class ActualizarTipoCombustible : Form
    {
        TipoCombustibleController combustible = new TipoCombustibleController();
        public ActualizarTipoCombustible()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void ActualizarTipoCombustible_Load(object sender, EventArgs e)
        {
            dgvCrearTipoCombustible.DataSource = combustible.getAll();
        }

        private void LlenarDataTable()
        {
            dgvCrearTipoCombustible.DataSource = combustible.getAll();
        }
    }
}
