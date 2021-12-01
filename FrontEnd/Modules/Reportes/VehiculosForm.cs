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
    public partial class VehiculosForm : Form
    {
        VehiculoController vehiculoController;
        TipoTransmisionController tipoTransmisionController;
        TipoCombustibleController tipoCombustibleController;
        ModeloController modeloController;
        List<Vehiculo> vehiculos;
        List<Vehiculo> vehiculosTemp;
        public VehiculosForm()
        {
            vehiculoController = new VehiculoController();
            tipoTransmisionController = new TipoTransmisionController();
            tipoCombustibleController = new TipoCombustibleController();
            modeloController = new ModeloController();
            InitializeComponent();
        }

        private void VehiculosForm_Load(object sender, EventArgs e)
        {
            panelReporteVehiculos.BorderStyle = BorderStyle.FixedSingle;
            vehiculos = vehiculoController.getAll().ToList();
            vehiculosTemp = vehiculos;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            var showListVehiculo = vehiculos.Select(x => new {
                Transmision = getTransmisionById(x.TipoTransmisionId),
                Combustible = getCombustibleById(x.TipoCombustibleId),
                Modelo = getModeloById(x.ModeloId),
                x.Chasis,
                x.Placa,
                Año = x.Anio,
                x.Color,
                x.Cilindraje,
                Kilometros = x.KilometrosTablero,
                Puertas = x.CantidadPuerta,
                x.Precio,
                x.Estatus
            }).ToList();
            dgvReporteVehiculos.DataSource = showListVehiculo;
        }

        private string getTransmisionById(int transmisionId)
        {
            return tipoTransmisionController.findById(transmisionId).Nombre;
        }

        private string getCombustibleById(int combustibleId)
        {
            return tipoCombustibleController.findById(combustibleId).Nombre;
        }

        private string getModeloById(int modeloId)
        {
            return modeloController.findById(modeloId).Nombre;
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            var termino = txtChasis.Text;
            List<Vehiculo> arrayToReturn = new List<Vehiculo>();
            termino.ToLower();
            for (int i = 0; i < vehiculosTemp.Count(); i++)
            {
                var vehiculo = vehiculosTemp[i];
                var chasis = vehiculo.Chasis.ToLower();
                if (chasis.ToLower().IndexOf(termino.ToLower()) >= 0 )
                {
                    arrayToReturn.Add(vehiculo);
                }
            }
            vehiculos = arrayToReturn;
            var showListVehiculo = vehiculos.Select(x => new {
                Transmision = getTransmisionById(x.TipoTransmisionId),
                Combustible = getCombustibleById(x.TipoCombustibleId),
                Modelo = getModeloById(x.ModeloId),
                x.Chasis,
                x.Placa,
                Año = x.Anio,
                x.Color,
                x.Cilindraje,
                Kilometros = x.KilometrosTablero,
                Puertas = x.CantidadPuerta,
                x.Precio,
                x.Estatus
            }).ToList();
            dgvReporteVehiculos.DataSource = showListVehiculo;
        }
    }
}
