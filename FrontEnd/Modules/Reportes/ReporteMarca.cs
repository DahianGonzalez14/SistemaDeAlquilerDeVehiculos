using SistemaDeAlquilerDeVehiculos.BackEnd.Controllers;
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
    public partial class ReporteMarca : Form
    {
        MarcaController marca= new  MarcaController();
        public ReporteMarca()
        {
            InitializeComponent();
        }

        private void ReporteMarca_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = marca.getAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = marca.findById(Int32.Parse(textBox1.Text));
        }
    }
}
