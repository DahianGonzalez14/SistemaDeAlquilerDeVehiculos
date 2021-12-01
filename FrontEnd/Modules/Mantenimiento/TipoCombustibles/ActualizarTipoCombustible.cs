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
        int combusId;
        public ActualizarTipoCombustible()
        {
            InitializeComponent();
        }
        private void LimpiarCampos()
        {
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
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
                    Id = combusId,
                    Nombre = textBox4.Text,
                    Estatus = textBox3.Text,
                    FechaModificacion = DateTime.Now,
                    Borrado = false,
                };

                var actualizar = combustible.Edit(actualizarCombustible);
               
                if (actualizar.Success)
                {
                    MessageBox.Show(actualizar.Message);
                    LlenarDataTable();
                }
                else
                {
                    MessageBox.Show(actualizar.Message);
                }

            }
        }

        private void ActualizarTipoCombustible_Load(object sender, EventArgs e)
        {
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            dgvCrearTipoCombustible.DataSource = combustible.getAll().Select(x => new {x.Id,x.Nombre,x.Estatus }).ToList();
            dgvCrearTipoCombustible.Columns["Id"].Visible = false;
        }

        private void dgvCrearTipoCombustible_SelectionChanged(object sender, EventArgs e)
        {
            combusId = Convert.ToInt32(dgvCrearTipoCombustible.CurrentRow.Cells["Id"].Value.ToString());
            textBox4.Text = dgvCrearTipoCombustible.CurrentRow.Cells["Nombre"].Value.ToString();
            textBox3.Text = dgvCrearTipoCombustible.CurrentRow.Cells["Estatus"].Value.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
