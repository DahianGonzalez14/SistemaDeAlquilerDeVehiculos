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
    public partial class ModelosForm : Form
    {
        ModeloController modeloController;
        MarcaController marcaController;
        List<Modelo> modelos;
        List<Modelo> modelosTemp;
        public ModelosForm()
        {
            modeloController = new ModeloController();
            marcaController = new MarcaController();
            InitializeComponent();
        }

        private void ModelosForm_Load(object sender, EventArgs e)
        {
            panelReporteModelos.BorderStyle = BorderStyle.FixedSingle;
            modelos = modeloController.getAll().ToList();
            modelosTemp = modelos;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            dgvReporteModelos.DataSource = modelos.Select(x => new { x.Nombre, Marca = getMarcaById(x.MarcaId), x.Estatus }).ToList();
        }

        private string getMarcaById(int marcaId)
        {
            return marcaController.findById(marcaId).Nombre;
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            var termino = txtNombre.Text;
            List<Modelo> arrayToReturn = new List<Modelo>();
            termino.ToLower();
            for (int i = 0; i < modelosTemp.Count(); i++)
            {
                var modelo = modelosTemp[i];
                var nombre = modelo.Nombre.ToLower();
                if (nombre.ToLower().IndexOf(termino.ToLower()) >= 0)
                {
                    arrayToReturn.Add(modelo);
                }
            }
            modelos = arrayToReturn;
            dgvReporteModelos.DataSource = modelos.Select(x => new { x.Nombre, Marca = getMarcaById(x.MarcaId), x.Estatus }).ToList();
        }
    }
}
