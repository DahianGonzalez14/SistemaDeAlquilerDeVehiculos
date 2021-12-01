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
    public partial class CrearTipoCombustibleForm : Form
    {
        TipoCombustibleController tipoCombustibleController;
        public CrearTipoCombustibleForm()
        {
            tipoCombustibleController = new TipoCombustibleController();
            InitializeComponent();
        }

        private void CrearTipoCombustible_Load(object sender, EventArgs e)
        {
            panelCrearTipoCombustible.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            var showListTipoCombustible = tipoCombustibleController.getAll().Select(x => new { x.Nombre, x.Estatus }).ToList();
            dgvCrearCombustible.DataSource = showListTipoCombustible;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                TipoCombustible tipoCombustible = new TipoCombustible()
                {
                    Nombre = txtNombre.Text,
                    Borrado = false,
                    Estatus = "A",
                    FechaRegistro = DateTime.Now
                };
                var createdTipoCombustible = tipoCombustibleController.Create(tipoCombustible);
                if (createdTipoCombustible.Success == true)
                {
                    LlenarDataTable();
                    MessageBox.Show(createdTipoCombustible.Message);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(createdTipoCombustible.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
        }

    }
}
