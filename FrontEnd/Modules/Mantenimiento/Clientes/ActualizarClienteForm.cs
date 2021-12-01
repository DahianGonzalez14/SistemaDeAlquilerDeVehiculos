using SistemaDeAlquilerDeVehiculos.BackEnd.Controllers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Helpers;
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
        List<PairValue> pairValueList;
        public ActualizarClienteForm()
        {
            clienteController = new ClienteController();
            pairValueList = new List<PairValue>
            {
                new PairValue { Key = "A", Value = "Activo" },
                new PairValue { Key = "I", Value = "Inactivo"}
            };
            InitializeComponent();
        }

        private void ActualizarClienteForm_Load(object sender, EventArgs e)
        {
            panelActualizarCliente.BorderStyle = BorderStyle.FixedSingle;
            LlenarComboBoxEstatus();          
            LlenarDataTable();                  
        }

        private void LlenarComboBoxEstatus()
        {
            comboBoxEstatus.DataSource = pairValueList;
            comboBoxEstatus.DisplayMember = "Value";
            comboBoxEstatus.ValueMember = "Key";
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
            dgvActualizarCliente.Columns["Id"].Visible = false;
            if (showListCliente.Count() == 0)
            {
                LimpiarCampos();
            }
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
            comboBoxEstatus.SelectedValue = dgvActualizarCliente.CurrentRow.Cells["Estatus"].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text)
                || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(comboBoxEstatus.Text))
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

                    Cliente cliente = new Cliente()
                    {
                        Id = clienteId,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Correo = txtCorreo.Text,
                        Cedula = txtCedula.Text,
                        Estatus = comboBoxEstatus.SelectedValue.ToString()
                    };

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
