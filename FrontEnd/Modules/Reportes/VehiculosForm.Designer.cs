namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    partial class VehiculosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculosForm));
            this.panelReporteVehiculos = new System.Windows.Forms.Panel();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.lChasis = new System.Windows.Forms.Label();
            this.dgvReporteVehiculos = new System.Windows.Forms.DataGridView();
            this.lReporteVehiculos = new System.Windows.Forms.Label();
            this.panelReporteVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReporteVehiculos
            // 
            this.panelReporteVehiculos.Controls.Add(this.txtChasis);
            this.panelReporteVehiculos.Controls.Add(this.lChasis);
            this.panelReporteVehiculos.Location = new System.Drawing.Point(76, 76);
            this.panelReporteVehiculos.Name = "panelReporteVehiculos";
            this.panelReporteVehiculos.Size = new System.Drawing.Size(1005, 100);
            this.panelReporteVehiculos.TabIndex = 62;
            // 
            // txtChasis
            // 
            this.txtChasis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtChasis.Location = new System.Drawing.Point(97, 36);
            this.txtChasis.Margin = new System.Windows.Forms.Padding(4);
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(273, 22);
            this.txtChasis.TabIndex = 32;
            this.txtChasis.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // lChasis
            // 
            this.lChasis.AutoSize = true;
            this.lChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChasis.Location = new System.Drawing.Point(19, 37);
            this.lChasis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lChasis.Name = "lChasis";
            this.lChasis.Size = new System.Drawing.Size(62, 18);
            this.lChasis.TabIndex = 31;
            this.lChasis.Text = "Chasís: ";
            // 
            // dgvReporteVehiculos
            // 
            this.dgvReporteVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteVehiculos.Location = new System.Drawing.Point(76, 193);
            this.dgvReporteVehiculos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteVehiculos.Name = "dgvReporteVehiculos";
            this.dgvReporteVehiculos.RowHeadersWidth = 51;
            this.dgvReporteVehiculos.Size = new System.Drawing.Size(1005, 378);
            this.dgvReporteVehiculos.TabIndex = 61;
            // 
            // lReporteVehiculos
            // 
            this.lReporteVehiculos.AutoSize = true;
            this.lReporteVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReporteVehiculos.Location = new System.Drawing.Point(73, 37);
            this.lReporteVehiculos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lReporteVehiculos.Name = "lReporteVehiculos";
            this.lReporteVehiculos.Size = new System.Drawing.Size(169, 18);
            this.lReporteVehiculos.TabIndex = 60;
            this.lReporteVehiculos.Text = "Reporte de Vehiculos";
            // 
            // VehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 609);
            this.Controls.Add(this.panelReporteVehiculos);
            this.Controls.Add(this.dgvReporteVehiculos);
            this.Controls.Add(this.lReporteVehiculos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VehiculosForm";
            this.Text = "Reporte Vehiculos";
            this.Load += new System.EventHandler(this.VehiculosForm_Load);
            this.panelReporteVehiculos.ResumeLayout(false);
            this.panelReporteVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReporteVehiculos;
        private System.Windows.Forms.TextBox txtChasis;
        private System.Windows.Forms.Label lChasis;
        private System.Windows.Forms.DataGridView dgvReporteVehiculos;
        private System.Windows.Forms.Label lReporteVehiculos;
    }
}