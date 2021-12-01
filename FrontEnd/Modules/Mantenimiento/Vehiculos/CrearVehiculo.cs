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

namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoVehiculo
{
    public partial class CrearVehiculo : Form
    {
        VehiculoController vehiculo = new VehiculoController();
        TipoTransmisionController transmisionController = new TipoTransmisionController();
        TipoCombustibleController combustibleController = new TipoCombustibleController();
        ModeloController modeloController = new ModeloController();
        public CrearVehiculo()
        {
            InitializeComponent();
        }
        private string getTipoTrans(int transId)
        {
            return transmisionController.findById(transId).Nombre;
        }

        private string getcombustible(int combus)
        {
            return combustibleController.findById(combus).Nombre;
        }


        private string getModelo(int modelo)
        {
            return modeloController.findById(modelo).Nombre;
        }

        private void LlenarDataTable()
        {
            dgvCrearVehiculo.DataSource = vehiculo.getAll().Select(x=> new { Modelo= getModelo(x.ModeloId),Transmision=getTipoTrans(x.TipoTransmisionId),Combustible=getcombustible(x.TipoCombustibleId),x.CantidadPuerta,x.Chasis,x.Placa,x.Anio,x.Precio,x.Color,x.Cilindraje,x.KilometrosTablero}).ToList();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            txt4.Text = string.Empty;
            txt5.Text = string.Empty;
            txt6.Text = string.Empty;
            txt7.Text = string.Empty;
            txt8.Text = string.Empty;
            txt9.Text = string.Empty;
            txt10.Text = string.Empty;
            txt11.Text = string.Empty;
            txt12.Text = string.Empty;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt4.Text)|| string.IsNullOrWhiteSpace(txt5.Text)|| string.IsNullOrWhiteSpace(txt6.Text)|| string.IsNullOrWhiteSpace(txt7.Text)|| string.IsNullOrWhiteSpace(txt8.Text)|| string.IsNullOrWhiteSpace(txt9.Text)|| string.IsNullOrWhiteSpace(txt10.Text)|| string.IsNullOrWhiteSpace(txt11.Text)|| string.IsNullOrWhiteSpace(txt12.Text))
            {

                MessageBox.Show("completa los campos faltan");


            } else {

                Vehiculo nuevoVehiculo = new Vehiculo() {
                    TipoTransmisionId = Convert.ToInt32(comboBox1.SelectedValue),
                    TipoCombustibleId = Convert.ToInt32(comboBox2.SelectedValue),
                    ModeloId = Convert.ToInt32(comboBox3.SelectedValue),
                    CantidadPuerta= Int32.Parse(txt4.Text),
                    Chasis=txt5.Text,
                    Placa=txt6.Text,
                    Anio=txt7.Text,
                    Precio= Int32.Parse(txt8.Text),
                    Color=txt9.Text,
                    Cilindraje=txt10.Text,
                    KilometrosTablero=txt11.Text,
                    Estatus=txt12.Text,
                    FechaRegistro = DateTime.Now,
                    FechaModificacion = null,
                    Borrado= false,
                };
                var crear = vehiculo.Create(nuevoVehiculo);
                
                if (crear.Success)
                {
                    MessageBox.Show(crear.Message);
                    LlenarDataTable();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(crear.Message);
                }
            }






        }

        private void CrearVehiculo_Load(object sender, EventArgs e)
        {
            var trans = transmisionController.getAll().Where(x => x.Estatus.Equals("A")).ToList();
            comboBox1.DataSource = trans;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";

            var combus = combustibleController.getAll().Where(x => x.Estatus.Equals("A")).ToList();
            comboBox2.DataSource = combus;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Id";

            var modelo = modeloController.getAll().Where(x => x.Estatus.Equals("A")).ToList();
            comboBox3.DataSource = modelo;
            comboBox3.DisplayMember = "Nombre";
            comboBox3.ValueMember = "Id";


            LlenarDataTable();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
