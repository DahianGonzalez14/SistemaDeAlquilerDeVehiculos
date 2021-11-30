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
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoVehiculo
{
    public partial class ActualizarVehiculo : Form
    {
        VehiculoController vehiculo = new VehiculoController();
        public ActualizarVehiculo()
        {
            InitializeComponent();
        }
        private void LlenarDataTable()
        {
            dgvCrearVehiculo.DataSource = vehiculo.getAll();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt2.Text) || string.IsNullOrWhiteSpace(txt3.Text) || string.IsNullOrWhiteSpace(txt4.Text) || string.IsNullOrWhiteSpace(txt5.Text) || string.IsNullOrWhiteSpace(txt6.Text) || string.IsNullOrWhiteSpace(txt7.Text) || string.IsNullOrWhiteSpace(txt8.Text) || string.IsNullOrWhiteSpace(txt9.Text) || string.IsNullOrWhiteSpace(txt10.Text) || string.IsNullOrWhiteSpace(txt11.Text) || string.IsNullOrWhiteSpace(txt12.Text))
            {

                MessageBox.Show("completa los campos faltan");


            }
            else
            {

                Vehiculo actualizarVehiculo = new Vehiculo()
                {
                    TipoTransmisionId = Int32.Parse(txt1.Text),
                    TipoCombustibleId = Int32.Parse(txt2.Text),
                    ModeloId = Int32.Parse(txt3.Text),
                    CantidadPuerta = Int32.Parse(txt4.Text),
                    Chasis = txt5.Text,
                    Placa = txt6.Text,
                    Anio = txt7.Text,
                    Precio = Int32.Parse(txt8.Text),
                    Color = txt9.Text,
                    Cilindraje = txt10.Text,
                    KilometrosTablero = txt11.Text,
                    Estatus = txt12.Text,
                    FechaRegistro = DateTime.Now,
                    FechaModificacion = null,
                    Borrado = false,
                };
                var actualizar = vehiculo.Edit(actualizarVehiculo);
                LlenarDataTable();
                if (actualizar.Success)
                {
                    MessageBox.Show(actualizar.Message);
                }
                else
                {
                    MessageBox.Show(actualizar.Message);
                }
            }








        }

        private void ActualizarVehiculo_Load(object sender, EventArgs e)
        {
            dgvCrearVehiculo.DataSource = vehiculo.getAll();
        }
    }
}
