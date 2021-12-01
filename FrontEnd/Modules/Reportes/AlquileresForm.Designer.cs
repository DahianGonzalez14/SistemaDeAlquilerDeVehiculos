namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    partial class AlquileresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlquileresForm));
            this.panelReporteAlquileres = new System.Windows.Forms.Panel();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lVehiculo = new System.Windows.Forms.Label();
            this.dgvReporteAlquileres = new System.Windows.Forms.DataGridView();
            this.lReporteAlquileres = new System.Windows.Forms.Label();
            this.panelReporteAlquileres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReporteAlquileres
            // 
            this.panelReporteAlquileres.Controls.Add(this.txtVehiculo);
            this.panelReporteAlquileres.Controls.Add(this.lVehiculo);
            this.panelReporteAlquileres.Location = new System.Drawing.Point(76, 76);
            this.panelReporteAlquileres.Name = "panelReporteAlquileres";
            this.panelReporteAlquileres.Size = new System.Drawing.Size(1005, 100);
            this.panelReporteAlquileres.TabIndex = 59;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVehiculo.Location = new System.Drawing.Point(97, 36);
            this.txtVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(273, 22);
            this.txtVehiculo.TabIndex = 32;
            this.txtVehiculo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtChasis_KeyUp);
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
            // dgvReporteAlquileres
            // 
            this.dgvReporteAlquileres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteAlquileres.Location = new System.Drawing.Point(76, 193);
            this.dgvReporteAlquileres.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteAlquileres.Name = "dgvReporteAlquileres";
            this.dgvReporteAlquileres.RowHeadersWidth = 51;
            this.dgvReporteAlquileres.Size = new System.Drawing.Size(1005, 378);
            this.dgvReporteAlquileres.TabIndex = 58;
            // 
            // lReporteAlquileres
            // 
            this.lReporteAlquileres.AutoSize = true;
            this.lReporteAlquileres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReporteAlquileres.Location = new System.Drawing.Point(73, 37);
            this.lReporteAlquileres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lReporteAlquileres.Name = "lReporteAlquileres";
            this.lReporteAlquileres.Size = new System.Drawing.Size(169, 18);
            this.lReporteAlquileres.TabIndex = 57;
            this.lReporteAlquileres.Text = "Reporte de Alquileres";
            // 
            // AlquileresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 609);
            this.Controls.Add(this.panelReporteAlquileres);
            this.Controls.Add(this.dgvReporteAlquileres);
            this.Controls.Add(this.lReporteAlquileres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlquileresForm";
            this.Text = "Reporte Alquileres";
            this.Load += new System.EventHandler(this.AlquileresForm_Load);
            this.panelReporteAlquileres.ResumeLayout(false);
            this.panelReporteAlquileres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAlquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReporteAlquileres;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label lVehiculo;
        private System.Windows.Forms.DataGridView dgvReporteAlquileres;
        private System.Windows.Forms.Label lReporteAlquileres;
    }
}