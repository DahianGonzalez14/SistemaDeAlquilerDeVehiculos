
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.AlquilerModulo;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Clientes;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoTipoCombustible;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoVehiculo;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MarcaMantenimiento;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Modelos;
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

        private void reporteTipoCobustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoCombustible reporteTipoCombustible = new TipoCombustible();
            reporteTipoCombustible.ShowDialog();
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
            CrearMarcaForm crearMarcaForm = new CrearMarcaForm();
            crearMarcaForm.ShowDialog();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActualizarMarcaForm actualizarMarcaForm = new ActualizarMarcaForm();
            actualizarMarcaForm.ShowDialog();
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BorrarMarcaForm borrarMarcaForm = new BorrarMarcaForm();
            borrarMarcaForm.ShowDialog();
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

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CrearModeloForm crearModeloForm = new CrearModeloForm();
            crearModeloForm.ShowDialog();
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ActualizarModeloForm actualizarModeloForm= new ActualizarModeloForm();
            actualizarModeloForm.ShowDialog();
        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BorrarModeloForm borrarModeloForm= new BorrarModeloForm();
            borrarModeloForm.ShowDialog();
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

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
