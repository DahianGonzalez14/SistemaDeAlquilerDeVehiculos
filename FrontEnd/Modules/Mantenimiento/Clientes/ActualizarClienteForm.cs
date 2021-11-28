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
    public partial class ActualizarClienteForm : Form
    {
        ClienteController clienteController;
        int clienteId;
        public ActualizarClienteForm()
        {
            clienteController = new ClienteController();
            InitializeComponent();
        }

        private void ActualizarClienteForm_Load(object sender, EventArgs e)
        {
            panelActualizarCliente.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
            dgvActualizarCliente.Columns["Id"].Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCedula.Text = string.Empty;
            comboBoxEstatus.Text = string.Empty;
        }

        private void LlenarDataTable()
        {
            var showListCliente = clienteController.getAll().Select(x => new { x.Id, x.Nombre, x.Apellido, x.Direccion, x.Telefono, x.Correo, x.Cedula, x.Estatus }).ToList();
            dgvActualizarCliente.DataSource = showListCliente;
        }

        private void dgvActualizarCliente_SelectionChanged(object sender, EventArgs e)
        {
            clienteId = Convert.ToInt32(dgvActualizarCliente.CurrentRow.Cells["Id"].Value.ToString());
            txtNombre.Text = dgvActualizarCliente.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvActualizarCliente.CurrentRow.Cells["Apellido"].Value.ToString();
            txtDireccion.Text = dgvActualizarCliente.CurrentRow.Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgvActualizarCliente.CurrentRow.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = dgvActualizarCliente.CurrentRow.Cells["Correo"].Value.ToString();
            txtCedula.Text = dgvActualizarCliente.CurrentRow.Cells["Cedula"].Value.ToString();
            comboBoxEstatus.SelectedIndex = getIndexByEstatus();
        }

        private int getIndexByEstatus()
        {
            var estatus = dgvActualizarCliente.CurrentRow.Cells["Estatus"].Value.ToString();
            if (estatus.Equals("A"))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private string getValueByEstatus(string estatus)
        {
            if (estatus.Equals("Activo"))
            {
                return "A";
            }
            else
            {
                return "I";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text)
                || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (clienteController.isValidTelefono(txtTelefono.Text) == false)
                {
                    MessageBox.Show("Error teléfono incorrecto");

                }
                else if (clienteController.isValidCorreo(txtCorreo.Text) == false)
                {
                    MessageBox.Show("Error correo incorrecto");
                }
                else if (clienteController.isValidCedula(txtCedula.Text) == false)
                {
                    MessageBox.Show("Error cédula incorrecta");
                }
                else
                {
                    
                    Cliente cliente = new Cliente();
                    cliente.Id = clienteId;
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.Correo = txtCorreo.Text;
                    cliente.Cedula = txtCedula.Text;
                    cliente.Estatus = getValueByEstatus(comboBoxEstatus.Text);

                    var updatedCliente = clienteController.Edit(cliente);
                    if (updatedCliente.Success == true)
                    {
                        LlenarDataTable();
                        MessageBox.Show(updatedCliente.Message);
                    }
                    else
                    {
                        MessageBox.Show(updatedCliente.Message);
                    }
                }
            }    
        }
    }
}
