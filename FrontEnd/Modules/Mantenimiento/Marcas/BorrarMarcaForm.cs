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
    public partial class BorrarMarcaForm : Form
    {
        MarcaController marcaController;
        int marcaId;
        public BorrarMarcaForm()
        {
            marcaController = new MarcaController();
            InitializeComponent();
        }
        private void DeleteMarca_Load(object sender, EventArgs e)
        {
            panelBorrarMarca.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            var showListMarca = marcaController.getAll().Select(x => new { x.Id, x.Nombre, x.Estatus }).ToList();
            dgvBorrarMarca.DataSource = showListMarca;
            dgvBorrarMarca.Columns["Id"].Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
        }

        private void dgvBorrarMarca_SelectionChanged(object sender, EventArgs e)
        {
            marcaId = Convert.ToInt32(dgvBorrarMarca.CurrentRow.Cells["Id"].Value.ToString());
            txtNombre.Text = dgvBorrarMarca.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Favor de seleccionar la marca que desea borrar");
            }
            else
            {
                Marca marca = new Marca()
                {
                    Id = marcaId
                };

                var deletedMarca = marcaController.Delete(marca);
                if (deletedMarca.Success == true)
                {
                    LlenarDataTable();
                    LimpiarCampos();
                    MessageBox.Show(deletedMarca.Message);
                }
                else
                {
                    MessageBox.Show(deletedMarca.Message);
                }
            }
        }
    }
}
