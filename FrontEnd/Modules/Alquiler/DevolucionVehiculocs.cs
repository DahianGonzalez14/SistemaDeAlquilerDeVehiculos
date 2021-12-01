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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.AlquilerModulo
{
    public partial class DevolucionVehiculocs : Form
    {
        AlquilerController alquilerController = new AlquilerController();
        ClienteController clienteController = new ClienteController();
        VehiculoController vehiculoController = new VehiculoController();
        private string getCliente(int cli)
        {
            return clienteController.findById(cli).Nombre;
        }

        private string getVeh(int veh)
        {
            return vehiculoController.findById(veh).Placa;
        }


        public DevolucionVehiculocs()
        {
            InitializeComponent();
        }
        private void LlenarDataTable()
        {
            dgvDevolverAlquiler.DataSource = alquilerController.getAll().Where(x => x.Estatus.Equals("A")).Select(x => new { x.Id, Cliente = getCliente(x.ClienteId),Vehiculo=getVeh(x.VehiculoId),x.MetodoPago,x.Costo,x.FechaDesde,x.FechaHasta,x.FechaDevolucion,x.Penalidad }).ToList();
        }
        private void LimpiarCampos()
        {
            textBox3.Text = string.Empty;
            comboBoxAlquiler.Text = string.Empty;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if ( string.IsNullOrWhiteSpace(comboBoxAlquiler.Text))
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                Alquiler actualizarAlquiler = new Alquiler()
                {
                    Id = Convert.ToInt32(comboBoxAlquiler.SelectedValue),
                 Penalidad=Int32.Parse(textBox3.Text),
                    Estatus ="I",
                    FechaDevolucion=DateTime.Now,

                    Borrado = false,
                };

                var actualizar = alquilerController.EndAlquiler(actualizarAlquiler);
               
                if (actualizar.Success)
                {
                    LimpiarCampos();
                    LlenarDataTable();
                    MessageBox.Show(actualizar.Message);
                }
                else
                {
                    MessageBox.Show(actualizar.Message);
                }

            }









        }

        private void DevolucionVehiculocs_Load(object sender, EventArgs e)
        {
            var alqui = alquilerController.getAll().Where(x => x.Estatus.Equals("A")).Select(x=> new {x.Id,Cliente=getCliente(x.ClienteId) }).ToList();
            comboBoxAlquiler.DataSource = alqui;
            comboBoxAlquiler.DisplayMember = "Cliente";
            comboBoxAlquiler.ValueMember = "Id";

            LlenarDataTable();
        }
    }
}
