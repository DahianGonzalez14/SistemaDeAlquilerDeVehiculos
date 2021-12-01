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
        private void LlenarDataTable()
        {
            dgvCrearTipoCombustible.DataSource = combustible.getAll().Select(x => new { x.Nombre, x.Estatus }).ToList();
        }
        private void LimpiarCampos()
        {
            textBox1.Text = string.Empty;
         
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                TipoCombustible nuevoCombustible = new TipoCombustible()
                {
                    Nombre = textBox1.Text,
                    Estatus = "A",
                    FechaRegistro = DateTime.Now,
                    FechaModificacion = null,
                    Borrado = false,
                };

                var crear = combustible.Create(nuevoCombustible);
              
                if (crear.Success)
                {
                    LimpiarCampos();
                    LlenarDataTable();
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
            LlenarDataTable();
        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
