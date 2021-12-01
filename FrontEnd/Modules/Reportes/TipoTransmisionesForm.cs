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
    public partial class TipoTransmisionesForm : Form
    {
        TipoTransmisionController tipoTransmisionController;
        List<TipoTransmision> tiposTransmisiones;
        List<TipoTransmision> tiposTransmisionesTemp;
        public TipoTransmisionesForm()
        {
            tipoTransmisionController = new TipoTransmisionController();
            InitializeComponent();
        }

        private void TipoTransmisionesForm_Load(object sender, EventArgs e)
        {
            panelReporteTipoTransmisiones.BorderStyle = BorderStyle.FixedSingle;
            tiposTransmisiones = tipoTransmisionController.getAll().ToList();
            tiposTransmisionesTemp = tiposTransmisiones;
            LlenarDataTable();
        }

        private void LlenarDataTable()
        {
            dgvReporteTipoTransmisiones.DataSource = tiposTransmisiones.Select(x => new { x.Nombre, x.Estatus }).ToList();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            var termino = txtNombre.Text;
            List<TipoTransmision> arrayToReturn = new List<TipoTransmision>();
            termino.ToLower();
            for (int i = 0; i < tiposTransmisionesTemp.Count(); i++)
            {
                var tipoTransmision = tiposTransmisionesTemp[i];
                var nombre = tipoTransmision.Nombre.ToLower();
                if (nombre.ToLower().IndexOf(termino.ToLower()) >= 0)
                {
                    arrayToReturn.Add(tipoTransmision);
                }
            }
            tiposTransmisiones = arrayToReturn;
            dgvReporteTipoTransmisiones.DataSource = tiposTransmisiones.Select(x => new { x.Nombre, x.Estatus }).ToList();
        }
    }
}
