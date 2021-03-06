
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.AlquilerVehiculo;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.AlquilerModulo;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Clientes;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoTipoCombustible;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoVehiculo;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MarcaMantenimiento;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Modelos;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.TipoTransmisiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes;

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
            TipoCombustiblesForm tipoCombustiblesForm = new TipoCombustiblesForm();
            tipoCombustiblesForm.ShowDialog();
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
            CrearTipoCombustibleForm crearTipoCombustibleForm = new CrearTipoCombustibleForm();
            crearTipoCombustibleForm.ShowDialog();
        }

        private void actualizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ActualizarTipoCombustibleForm actualizarTipoCombustibleForm = new ActualizarTipoCombustibleForm();
            actualizarTipoCombustibleForm.ShowDialog();
        }

        private void borrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BorrarTipoCombustibleForm borrarTipoCombustibleForm = new BorrarTipoCombustibleForm();
            borrarTipoCombustibleForm.ShowDialog();
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
            CrearVehiculoForm crearVehiculoForm = new CrearVehiculoForm();
            crearVehiculoForm.ShowDialog();
        }

        private void actualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ActualizarVehiculoForm actualizarVehiculoForm = new ActualizarVehiculoForm();
            actualizarVehiculoForm.ShowDialog();
        }

        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BorrarVehiculoForm borrarVehiculoForm = new BorrarVehiculoForm();
            borrarVehiculoForm.ShowDialog();
        }

        private void reporteVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehiculosForm vehiculosForm = new VehiculosForm();
            vehiculosForm.ShowDialog();
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
            DevolucionVehiculoForm devolucionVehiculoForm = new DevolucionVehiculoForm();
            devolucionVehiculoForm.ShowDialog();
        }

        private void reporteHistorialDeAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialAlquileresForm historialAlquileresForm = new HistorialAlquileresForm();
            historialAlquileresForm.ShowDialog();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void alquilerDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlquilerVehiculoForm alquilerVehiculoForm = new AlquilerVehiculoForm();
            alquilerVehiculoForm.ShowDialog();
        }

        private void reporteClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.ShowDialog();
        }

        private void reporteMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarcasForm marcasForm = new MarcasForm();
            marcasForm.ShowDialog();
        }

        private void reporteModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelosForm modelosForm = new ModelosForm();
            modelosForm.ShowDialog();
        }

        private void reporteTipoTransmisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoTransmisionesForm tipoTransmisionesForm = new TipoTransmisionesForm();
            tipoTransmisionesForm.ShowDialog();
        }

        private void reporteVerTodosLosAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlquileresForm alquileresForm = new AlquileresForm();
            alquileresForm.ShowDialog();
        }
    }
}
