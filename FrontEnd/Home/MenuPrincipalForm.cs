using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Clientes;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Home
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoTipoTransmisionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoTipoCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoTipoCombustible mante = new MantenimientoTipoCombustible();
            mante.Show();
        }

        private void mantenimientoMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoMarca Marca = new MantenimientoMarca();
            Marca.Show();
        }

        private void reporteMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reporteTipoCobustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteTipoCombustible ReporCombus = new ReporteTipoCombustible();
            ReporCombus.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void reporteTipoTransmisionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearClienteForm crearClienteForm = new CrearClienteForm();
            crearClienteForm.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarClienteForm actualizarClienteForm = new ActualizarClienteForm();
            actualizarClienteForm.ShowDialog();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarClienteForm borrarClienteForm = new BorrarClienteForm();
            borrarClienteForm.ShowDialog();
        }
    }
}
