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
        public DevolucionVehiculocs()
        {
            InitializeComponent();
        }
        private void LlenarDataTable()
        {
            dgvDevolverAlquiler.DataSource = alquilerController.getAll();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {

                MessageBox.Show("completa los campos faltan");
            }
            else
            {
                Alquiler actualizarAlquiler = new Alquiler()
                {
                    Id = Int32.Parse(textBox5.Text),
                 Penalidad=Int32.Parse(textBox3.Text),
                    Estatus = textBox4.Text,
                   
                    Borrado = false,
                };

                var actualizar = alquilerController.EndAlquiler(actualizarAlquiler);
                LlenarDataTable();
                if (actualizar.Success)
                {
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
            dgvDevolverAlquiler.DataSource = alquilerController.getAll();
        }
    }
}
