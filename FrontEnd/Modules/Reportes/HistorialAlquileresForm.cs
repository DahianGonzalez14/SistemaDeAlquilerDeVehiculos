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
    public partial class HistorialAlquileresForm : Form
    {
        AlquilerController alquilerController;
        ClienteController clienteController;
        VehiculoController vehiculoController;
        ModeloController modeloController;
        MarcaController marcaController;
        List<Alquiler> alquileres;
        List<Alquiler> alquileresTemp;
        public HistorialAlquileresForm()
        {
            alquilerController = new AlquilerController();
            clienteController = new ClienteController();
            vehiculoController = new VehiculoController();
            modeloController = new ModeloController();
            marcaController = new MarcaController();
            InitializeComponent();
        }

        private void HistorialAlquileresForm_Load(object sender, EventArgs e)
        {
            panelReporteHistorialAlquileres.BorderStyle = BorderStyle.FixedSingle;
            alquileres = alquilerController.getAll().Where(x => x.Estatus.Equals("I")).ToList();
            alquileresTemp = alquileres;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            dgvReporteHistorialAlquileres.DataSource = alquileres.Select(x => new { Cliente = getClienteById(x.ClienteId), Vehiculo = getVehiculoById(x.VehiculoId), x.MetodoPago, x.Costo, x.FechaDesde, x.FechaHasta, x.Estatus }).Where(x => x.Estatus.Equals("I")).ToList();
        }

        private string getClienteById(int clienteId)
        {
            return clienteController.findById(clienteId).Nombre;
        }

        private string getVehiculoById(int vehiculoId)
        {
            var vehiculo = vehiculoController.findById(vehiculoId);
            string chasis = vehiculo.Chasis;
            var modelo = modeloController.findById(vehiculo.ModeloId);
            string nombreModelo = modelo.Nombre;
            var marca = marcaController.findById(modelo.MarcaId);
            string nombreMarca = marca.Nombre;
            string result = $"{chasis} - {nombreMarca} - {nombreModelo}";
            return result;
        }

        private void txtVehiculo_KeyUp(object sender, KeyEventArgs e)
        {
            var termino = txtVehiculo.Text;
            List<Alquiler> arrayToReturn = new List<Alquiler>();
            termino.ToLower();
            for (int i = 0; i < alquileresTemp.Count(); i++)
            {
                var alquiler = alquileresTemp[i];
                var chasis = getVehiculoById(alquiler.VehiculoId).ToLower();
                if (chasis.ToLower().IndexOf(termino.ToLower()) >= 0)
                {
                    arrayToReturn.Add(alquiler);
                }
            }
            alquileres = arrayToReturn;
            dgvReporteHistorialAlquileres.DataSource = alquileres.Select(x => new { Cliente = getClienteById(x.ClienteId), Vehiculo = getVehiculoById(x.VehiculoId), x.MetodoPago, x.Costo, x.FechaDesde, x.FechaHasta, x.Estatus }).Where(x => x.Estatus.Equals("I")).ToList();
        }
    }
}
