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
    public partial class CrearClienteForm : Form
    {
        ClienteController clienteController;
        public CrearClienteForm()
        {
            clienteController = new ClienteController();
            InitializeComponent();
        }

        private void CrearClienteForm_Load(object sender, EventArgs e)
        {
            panelCrearCliente.BorderStyle = BorderStyle.FixedSingle;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            var showListCliente = clienteController.getAll().Select(x => new { x.Nombre, x.Apellido, x.Direccion, x.Telefono, x.Correo, x.Cedula, x.Estatus }).ToList();
            dgvCrearCliente.DataSource = showListCliente;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCedula.Text = string.Empty;
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
                if(clienteController.isValidTelefono(txtTelefono.Text) == false)
                {
                    MessageBox.Show("Error teléfono incorrecto");
                   
                } else if(clienteController.isValidCorreo(txtCorreo.Text) == false)
                {
                    MessageBox.Show("Error correo incorrecto");
                } else if(clienteController.isValidCedula(txtCedula.Text) == false)
                {
                    MessageBox.Show("Error cédula incorrecta");
                }
                else
                {
                    Cliente nuevoCliente = new Cliente()
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Correo = txtCorreo.Text,
                        Cedula = txtCedula.Text,
                        Borrado = false,
                        Estatus = "A",
                        FechaRegistro = DateTime.Now
                    };
                    var createdCliente = clienteController.Create(nuevoCliente);
                    if (createdCliente.Success == true)
                    {
                        LlenarDataTable();
                        MessageBox.Show(createdCliente.Message);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(createdCliente.Message);
                    }
                }             
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
