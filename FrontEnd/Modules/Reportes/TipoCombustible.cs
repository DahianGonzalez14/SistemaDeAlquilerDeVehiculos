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
    public partial class TipoCombustible : Form
    {
        TipoCombustibleController tipoCombus = new TipoCombustibleController();
        public TipoCombustible()
        {
            InitializeComponent();
        }

        private void ReporteTipoCombustible_Load(object sender, EventArgs e)
        {
            Buscar.DataSource = tipoCombus.getAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Buscar.DataSource = tipoCombus.findById(Int32.Parse(txt1.Text));
        }
    }
}
