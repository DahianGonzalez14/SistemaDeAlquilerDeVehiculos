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
    public partial class MarcasForm : Form
    {
        MarcaController marcaController;
        List<Marca> marcas;
        List<Marca> marcasTemp;
        public MarcasForm()
        {
            marcaController = new MarcaController();
            InitializeComponent();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            var termino = txtNombre.Text;
            List<Marca> arrayToReturn = new List<Marca>();
            termino.ToLower();
            for (int i = 0; i < marcasTemp.Count(); i++)
            {
                var marca = marcasTemp[i];
                var nombre = marca.Nombre.ToLower();
                if (nombre.ToLower().IndexOf(termino.ToLower()) >= 0)
                {
                    arrayToReturn.Add(marca);
                }
            }
            marcas = arrayToReturn;
            dgvReporteMarcas.DataSource = marcas.Select(x => new { x.Nombre, x.Estatus }).ToList();
        }

        private void MarcasForm_Load(object sender, EventArgs e)
        {
            panelReporteMarcas.BorderStyle = BorderStyle.FixedSingle;
            marcas = marcaController.getAll().ToList();
            marcasTemp = marcas;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            dgvReporteMarcas.DataSource = marcas.Select(x => new { x.Nombre, x.Estatus }).ToList();
        }
    }
}
