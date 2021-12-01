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
    public partial class TipoCombustiblesForm : Form
    {
        TipoCombustibleController tipoCombustibleController;
        List<TipoCombustible> tiposCombustibles;
        List<TipoCombustible> tiposCombustiblesTemp;
        public TipoCombustiblesForm()
        {
            tipoCombustibleController = new TipoCombustibleController();
            InitializeComponent();
        }

        private void TipoCombustiblesForm_Load(object sender, EventArgs e)
        {
            panelReporteTipoCombustibles.BorderStyle = BorderStyle.FixedSingle;
            tiposCombustibles = tipoCombustibleController.getAll().ToList();
            tiposCombustiblesTemp = tiposCombustibles;
            LlenarDataTable();
        }
        private void LlenarDataTable()
        {
            dgvReporteTipoCombustibles.DataSource = tiposCombustibles.Select(x => new { x.Nombre, x.Estatus }).ToList();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            var termino = txtNombre.Text;
            List<TipoCombustible> arrayToReturn = new List<TipoCombustible>();
            termino.ToLower();
            for (int i = 0; i < tiposCombustiblesTemp.Count(); i++)
            {
                var tipoCombustible = tiposCombustiblesTemp[i];
                var nombre = tipoCombustible.Nombre.ToLower();
                if (nombre.ToLower().IndexOf(termino.ToLower()) >= 0)
                {
                    arrayToReturn.Add(tipoCombustible);
                }
            }
            tiposCombustibles = arrayToReturn;
            dgvReporteTipoCombustibles.DataSource = tiposCombustibles.Select(x => new { x.Nombre, x.Estatus }).ToList();
        }
    }
}
