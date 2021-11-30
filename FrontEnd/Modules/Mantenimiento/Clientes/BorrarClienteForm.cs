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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Clientes
{
    public partial class BorrarClienteForm : Form
    {
        ClienteController clienteController;
        int clienteId;
        public BorrarClienteForm()
        {
            clienteController = new ClienteController();
            InitializeComponent();
        }

        private void BorrarClienteForm_Load(object sender, EventArgs e)
        {
            panelBorrarCliente.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();       
        }

        private void LlenarDataTable()
        {
            var showListCliente = clienteController.getAll().Select(x => new { x.Id, x.Nombre, x.Apellido, x.Direccion, x.Telefono, x.Correo, x.Cedula, x.Estatus }).ToList();
            dgvBorrarCliente.DataSource = showListCliente;
            dgvBorrarCliente.Columns["Id"].Visible = false;
        }

        private void LimpiarCampos()
        {
            txtCedula.Text = string.Empty;
        }

        private void dgvBorrarCliente_SelectionChanged(object sender, EventArgs e)
        {
            clienteId = Convert.ToInt32(dgvBorrarCliente.CurrentRow.Cells["Id"].Value.ToString());
            txtCedula.Text = dgvBorrarCliente.CurrentRow.Cells["Cedula"].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Favor de seleccionar el cliente que desea borrar");
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.Id = clienteId;
                var deletedCliente = clienteController.Delete(cliente);
                if (deletedCliente.Success == true)
                {
                    LlenarDataTable();
                    LimpiarCampos();
                    MessageBox.Show(deletedCliente.Message);
                }
                else
                {
                    MessageBox.Show(deletedCliente.Message);
                }
            }
        }
    }
}
