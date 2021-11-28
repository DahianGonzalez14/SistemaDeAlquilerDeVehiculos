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
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoVehiculo
{
    public partial class DeleteVehiculo : Form
    {
        VehiculoController vehiculo = new VehiculoController();
        public DeleteVehiculo()
        {
            InitializeComponent();
        }
        private void LlenarDataTable()
        {
            dgvCrearVehiculo.DataSource = vehiculo.getAll();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(txt1.Text) )
            {

                MessageBox.Show("completa los campos faltan");


            }
            else
            {

                Vehiculo DeleteVehiculo = new Vehiculo()
                {
                    Id = Int32.Parse(txt1.Text),
                 
                };
                var eliminar = vehiculo.Delete(DeleteVehiculo);
                LlenarDataTable();
                if (eliminar.Success)
                {
                    MessageBox.Show(eliminar.Message);
                }
                else
                {
                    MessageBox.Show(eliminar.Message);
                }
            }






















        }

        private void DeleteVehiculo_Load(object sender, EventArgs e)
        {
            dgvCrearVehiculo.DataSource = vehiculo.getAll();
        }
    }
}
