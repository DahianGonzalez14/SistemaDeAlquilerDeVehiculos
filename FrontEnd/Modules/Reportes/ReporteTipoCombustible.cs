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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    public partial class ReporteTipoCombustible : Form
    {
        TipoCombustibleController tipoCombus = new TipoCombustibleController();
        public ReporteTipoCombustible()
        {
            InitializeComponent();
        }

        private void ReporteTipoCombustible_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tipoCombus.getAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tipoCombus.findById(Int32.Parse(textBox1.Text));
        }
    }
}
