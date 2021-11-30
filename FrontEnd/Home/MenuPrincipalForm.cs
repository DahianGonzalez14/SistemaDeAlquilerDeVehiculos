
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.AlquilerModulo;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Clientes;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoTipoCombustible;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoVehiculo;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MarcaMantenimiento;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.TipoTransmisiones;
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
            
        }

        private void mantenimientoMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reporteTipoCobustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoCombustible ReporCombus = new TipoCombustible();
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

        private void crearToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CrearTipoCombustible crearTipoCombustible = new CrearTipoCombustible();
            crearTipoCombustible.ShowDialog();
        }

        private void actualizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ActualizarTipoCombustible actualizarTipoCombustible = new ActualizarTipoCombustible();
            actualizarTipoCombustible.ShowDialog();
        }

        private void borrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DeleteTipoCombustible deleteTipoCombustible = new DeleteTipoCombustible();
            deleteTipoCombustible.ShowDialog();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearMarca crearMarca = new CrearMarca();
            crearMarca.ShowDialog();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActualizarMarca actualizarMarca = new ActualizarMarca();
            actualizarMarca.ShowDialog();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteMarca deleteMarca = new DeleteMarca();
            deleteMarca.ShowDialog();
        }

        private void crearToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CrearVehiculo crearVehiculo = new CrearVehiculo();
            crearVehiculo.ShowDialog();
        }

        private void actualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ActualizarVehiculo actualizarVehiculo = new ActualizarVehiculo();
            actualizarVehiculo.ShowDialog();
        }

        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteVehiculo deleteVehiculo = new DeleteVehiculo();
            deleteVehiculo.ShowDialog();
        }

        private void reporteVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculo reporteVehiculo = new Vehiculo();
            reporteVehiculo.ShowDialog();
        }

        private void crearToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CrearTipoTransmisionForm crearTipoTransmisionForm = new CrearTipoTransmisionForm();
            crearTipoTransmisionForm.ShowDialog();
        }

        private void actualizarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ActualizarTipoTransmisionForm actualizarTipoTransmisionForm = new ActualizarTipoTransmisionForm();
            actualizarTipoTransmisionForm.ShowDialog();
        }

        private void borrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            BorrarTipoTransmisionForm borrarTipoTransmisionForm = new BorrarTipoTransmisionForm();
            borrarTipoTransmisionForm.ShowDialog();
        }

        private void devoluciónDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolucionVehiculocs devolucionVehiculocs = new DevolucionVehiculocs();
            devolucionVehiculocs.ShowDialog();
        }

        private void reporteHistorialDeAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialAlquiler historialAlquiler = new HistorialAlquiler();
            historialAlquiler.ShowDialog();
        }
    }
}
