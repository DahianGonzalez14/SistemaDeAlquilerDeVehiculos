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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.TipoTransmisiones
{
    public partial class BorrarTipoTransmisionForm : Form
    {
        TipoTransmisionController tipoTransmisionController;
        int tipoTransmisionId;
        public BorrarTipoTransmisionForm()
        {
            tipoTransmisionController = new TipoTransmisionController();
            InitializeComponent();
        }

        private void BorrarTipoTransmisionForm_Load(object sender, EventArgs e)
        {
            panelBorrarTipoTransmision.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
            dgvBorrarTipoTransmision.Columns["Id"].Visible = false;
        }

        private void LlenarDataTable()
        {
            var showListTipoTransmision = tipoTransmisionController.getAll().Select(x => new { x.Id, x.Nombre, x.Estatus }).ToList();
            dgvBorrarTipoTransmision.DataSource = showListTipoTransmision;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
        }

        private void dgvBorrarTipoTransmision_SelectionChanged(object sender, EventArgs e)
        {
            tipoTransmisionId = Convert.ToInt32(dgvBorrarTipoTransmision.CurrentRow.Cells["Id"].Value.ToString());
            txtNombre.Text = dgvBorrarTipoTransmision.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Favor de seleccionar el tipo de transmisión que desea borrar");
            }
            else
            {
                TipoTransmision tipoTransmision = new TipoTransmision()
                {
                    Id = tipoTransmisionId
                };

                var deletedTipoTransmision = tipoTransmisionController.Delete(tipoTransmision);
                if (deletedTipoTransmision.Success == true)
                {
                    LlenarDataTable();
                    LimpiarCampos();
                    MessageBox.Show(deletedTipoTransmision.Message);
                }
                else
                {
                    MessageBox.Show(deletedTipoTransmision.Message);
                }
            }
        }
    }
}
