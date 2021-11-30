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
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    public partial class HistorialAlquiler : Form
    {
        AlquilerController alquilerController = new AlquilerController();
        public HistorialAlquiler()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = alquilerController.findById(Int32.Parse(txt1.Text));
        }

        private void HistorialAlquiler_Load(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = alquilerController.getAllHistory();
        }
    }
}
