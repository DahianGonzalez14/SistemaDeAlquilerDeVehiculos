using ClosedXML.Excel;
using SistemaDeAlquilerDeVehiculos.BackEnd.Controllers;
using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    public partial class ClientesForm : Form
    {
        ClienteController clienteController;
        List<Cliente> clientes;
        List<Cliente> clientesTemp;
        public ClientesForm()
        {
            clienteController = new ClienteController();
            InitializeComponent();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            panelReporteClientes.BorderStyle = BorderStyle.FixedSingle;
            clientes = clienteController.getAll().ToList();
            clientesTemp = clientes;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            dgvReporteClientes.DataSource = clientes.Select(x => new { x.Nombre, x.Estatus }).ToList();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            var termino = txtNombre.Text;
            List<Cliente> arrayToReturn = new List<Cliente>();
            termino.ToLower();
            for (int i = 0; i < clientesTemp.Count(); i++)
            {
                var cliente = clientesTemp[i];
                var nombre = cliente.Nombre.ToLower();
                if (nombre.ToLower().IndexOf(termino.ToLower()) >= 0)
                {
                    arrayToReturn.Add(cliente);
                }
            }
            clientes = arrayToReturn;
            dgvReporteClientes.DataSource = clientes.Select(x => new { x.Nombre, x.Estatus }).ToList();
        }

    }
}
