namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    partial class HistorialAlquileresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialAlquileresForm));
            this.panelReporteHistorialAlquileres = new System.Windows.Forms.Panel();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lVehiculo = new System.Windows.Forms.Label();
            this.dgvReporteHistorialAlquileres = new System.Windows.Forms.DataGridView();
            this.lReporteHistorialAlquileres = new System.Windows.Forms.Label();
            this.panelReporteHistorialAlquileres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteHistorialAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReporteHistorialAlquileres
            // 
            this.panelReporteHistorialAlquileres.Controls.Add(this.txtVehiculo);
            this.panelReporteHistorialAlquileres.Controls.Add(this.lVehiculo);
            this.panelReporteHistorialAlquileres.Location = new System.Drawing.Point(76, 76);
            this.panelReporteHistorialAlquileres.Name = "panelReporteHistorialAlquileres";
            this.panelReporteHistorialAlquileres.Size = new System.Drawing.Size(1005, 100);
            this.panelReporteHistorialAlquileres.TabIndex = 62;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVehiculo.Location = new System.Drawing.Point(97, 36);
            this.txtVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(273, 22);
            this.txtVehiculo.TabIndex = 32;
            this.txtVehiculo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVehiculo_KeyUp);
            // 
            // lVehiculo
            // 
            this.lVehiculo.AutoSize = true;
            this.lVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVehiculo.Location = new System.Drawing.Point(19, 37);
            this.lVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVehiculo.Name = "lVehiculo";
            this.lVehiculo.Size = new System.Drawing.Size(72, 18);
            this.lVehiculo.TabIndex = 31;
            this.lVehiculo.Text = "Vehículo: ";
            // 
            // dgvReporteHistorialAlquileres
            // 
            this.dgvReporteHistorialAlquileres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteHistorialAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteHistorialAlquileres.Location = new System.Drawing.Point(76, 193);
            this.dgvReporteHistorialAlquileres.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteHistorialAlquileres.Name = "dgvReporteHistorialAlquileres";
            this.dgvReporteHistorialAlquileres.RowHeadersWidth = 51;
            this.dgvReporteHistorialAlquileres.Size = new System.Drawing.Size(1005, 378);
            this.dgvReporteHistorialAlquileres.TabIndex = 61;
            // 
            // lReporteHistorialAlquileres
            // 
            this.lReporteHistorialAlquileres.AutoSize = true;
            this.lReporteHistorialAlquileres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReporteHistorialAlquileres.Location = new System.Drawing.Point(73, 37);
            this.lReporteHistorialAlquileres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lReporteHistorialAlquileres.Name = "lReporteHistorialAlquileres";
            this.lReporteHistorialAlquileres.Size = new System.Drawing.Size(237, 18);
            this.lReporteHistorialAlquileres.TabIndex = 60;
            this.lReporteHistorialAlquileres.Text = "Reporte Historial de Alquileres";
            // 
            // HistorialAlquileresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 609);
            this.Controls.Add(this.panelReporteHistorialAlquileres);
            this.Controls.Add(this.dgvReporteHistorialAlquileres);
            this.Controls.Add(this.lReporteHistorialAlquileres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistorialAlquileresForm";
            this.Text = "Reporte Historial de Alquileres";
            this.Load += new System.EventHandler(this.HistorialAlquileresForm_Load);
            this.panelReporteHistorialAlquileres.ResumeLayout(false);
            this.panelReporteHistorialAlquileres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteHistorialAlquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReporteHistorialAlquileres;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label lVehiculo;
        private System.Windows.Forms.DataGridView dgvReporteHistorialAlquileres;
        private System.Windows.Forms.Label lReporteHistorialAlquileres;
    }
}