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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Modelos
{
    public partial class BorrarModeloForm : Form
    {
        ModeloController modeloController;
        MarcaController marcaController;
        int modeloId;
        public BorrarModeloForm()
        {
            modeloController = new ModeloController();
            marcaController = new MarcaController();
            InitializeComponent();
        }

        private void BorrarModeloForm_Load(object sender, EventArgs e)
        {
            panelBorrarModelo.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();        
        }

        private void LlenarDataTable()
        {
            var showListModelo = modeloController.getAll().Select(x => new { x.Id, x.Nombre, Marca = getMarcaById(x.MarcaId), x.Estatus }).ToList();
            dgvBorrarModelo.DataSource = showListModelo;
            dgvBorrarModelo.Columns["Id"].Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
        }

        private string getMarcaById(int marcaId)
        {
            return marcaController.findById(marcaId).Nombre;
        }

        private void dgvBorrarModelo_SelectionChanged(object sender, EventArgs e)
        {
            modeloId = Convert.ToInt32(dgvBorrarModelo.CurrentRow.Cells["Id"].Value.ToString());
            txtNombre.Text = dgvBorrarModelo.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Favor de seleccionar el modelo que desea borrar");
            }
            else
            {
                Modelo modelo = new Modelo()
                {
                    Id = modeloId
                };

                var deletedModelo = modeloController.Delete(modelo);
                if (deletedModelo.Success == true)
                {
                    LlenarDataTable();
                    LimpiarCampos();
                    MessageBox.Show(deletedModelo.Message);
                }
                else
                {
                    MessageBox.Show(deletedModelo.Message);
                }
            }
        }
    }
}
