namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    partial class TipoTransmisionesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoTransmisionesForm));
            this.panelReporteTipoTransmisiones = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvReporteTipoTransmisiones = new System.Windows.Forms.DataGridView();
            this.lReporteTipoTransmisiones = new System.Windows.Forms.Label();
            this.panelReporteTipoTransmisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteTipoTransmisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReporteTipoTransmisiones
            // 
            this.panelReporteTipoTransmisiones.Controls.Add(this.txtNombre);
            this.panelReporteTipoTransmisiones.Controls.Add(this.lNombre);
            this.panelReporteTipoTransmisiones.Location = new System.Drawing.Point(76, 76);
            this.panelReporteTipoTransmisiones.Name = "panelReporteTipoTransmisiones";
            this.panelReporteTipoTransmisiones.Size = new System.Drawing.Size(1005, 100);
            this.panelReporteTipoTransmisiones.TabIndex = 62;
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombre.Location = new System.Drawing.Point(97, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 22);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(19, 37);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(70, 18);
            this.lNombre.TabIndex = 31;
            this.lNombre.Text = "Nombre: ";
            // 
            // dgvReporteTipoTransmisiones
            // 
            this.dgvReporteTipoTransmisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteTipoTransmisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteTipoTransmisiones.Location = new System.Drawing.Point(76, 193);
            this.dgvReporteTipoTransmisiones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteTipoTransmisiones.Name = "dgvReporteTipoTransmisiones";
            this.dgvReporteTipoTransmisiones.RowHeadersWidth = 51;
            this.dgvReporteTipoTransmisiones.Size = new System.Drawing.Size(1005, 378);
            this.dgvReporteTipoTransmisiones.TabIndex = 61;
            // 
            // lReporteTipoTransmisiones
            // 
            this.lReporteTipoTransmisiones.AutoSize = true;
            this.lReporteTipoTransmisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReporteTipoTransmisiones.Location = new System.Drawing.Point(73, 37);
            this.lReporteTipoTransmisiones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lReporteTipoTransmisiones.Name = "lReporteTipoTransmisiones";
            this.lReporteTipoTransmisiones.Size = new System.Drawing.Size(245, 18);
            this.lReporteTipoTransmisiones.TabIndex = 60;
            this.lReporteTipoTransmisiones.Text = "Reporte Tipo de Transmisiones";
            // 
            // TipoTransmisionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 609);
            this.Controls.Add(this.panelReporteTipoTransmisiones);
            this.Controls.Add(this.dgvReporteTipoTransmisiones);
            this.Controls.Add(this.lReporteTipoTransmisiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TipoTransmisionesForm";
            this.Text = "Reporte Tipo de Transmisiones";
            this.Load += new System.EventHandler(this.TipoTransmisionesForm_Load);
            this.panelReporteTipoTransmisiones.ResumeLayout(false);
            this.panelReporteTipoTransmisiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteTipoTransmisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReporteTipoTransmisiones;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvReporteTipoTransmisiones;
        private System.Windows.Forms.Label lReporteTipoTransmisiones;
    }
}