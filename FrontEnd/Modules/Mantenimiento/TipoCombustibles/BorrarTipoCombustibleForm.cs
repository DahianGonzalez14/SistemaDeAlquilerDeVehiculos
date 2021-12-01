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
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoTipoCombustible
{
    public partial class BorrarTipoCombustibleForm : Form
    {
        TipoCombustibleController tipoCombustibleController;
        int tipoCombustibleId;
        public BorrarTipoCombustibleForm()
        {
            tipoCombustibleController = new TipoCombustibleController();
            InitializeComponent();
        }

        private void DeleteTipoCombustible_Load(object sender, EventArgs e)
        {
            panelBorrarTipoCombustible.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            var showListTipoCombustible = tipoCombustibleController.getAll().Select(x => new { x.Id, x.Nombre, x.Estatus }).ToList();
            dgvBorrarTipoCombustible.DataSource = showListTipoCombustible;
            dgvBorrarTipoCombustible.Columns["Id"].Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
        }

        private void dgvBorrarTipoCombustible_SelectionChanged(object sender, EventArgs e)
        {
            tipoCombustibleId = Convert.ToInt32(dgvBorrarTipoCombustible.CurrentRow.Cells["Id"].Value.ToString());
            txtNombre.Text = dgvBorrarTipoCombustible.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Favor de seleccionar el tipo de combustible que desea borrar");
            }
            else
            {
                TipoCombustible tipoCombustible = new TipoCombustible()
                {
                    Id = tipoCombustibleId
                };

                var deletedTipoCombustible = tipoCombustibleController.Delete(tipoCombustible);
                if (deletedTipoCombustible.Success == true)
                {
                    LlenarDataTable();
                    LimpiarCampos();
                    MessageBox.Show(deletedTipoCombustible.Message);
                }
                else
                {
                    MessageBox.Show(deletedTipoCombustible.Message);
                }
            }
        }
    }
}
