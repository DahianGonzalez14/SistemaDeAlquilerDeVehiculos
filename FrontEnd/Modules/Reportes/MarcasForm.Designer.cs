namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    partial class MarcasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcasForm));
            this.panelReporteMarcas = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvReporteMarcas = new System.Windows.Forms.DataGridView();
            this.lReporteMarcas = new System.Windows.Forms.Label();
            this.panelReporteMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReporteMarcas
            // 
            this.panelReporteMarcas.Controls.Add(this.txtNombre);
            this.panelReporteMarcas.Controls.Add(this.lNombre);
            this.panelReporteMarcas.Location = new System.Drawing.Point(76, 76);
            this.panelReporteMarcas.Name = "panelReporteMarcas";
            this.panelReporteMarcas.Size = new System.Drawing.Size(1005, 100);
            this.panelReporteMarcas.TabIndex = 56;
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
            // dgvReporteMarcas
            // 
            this.dgvReporteMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteMarcas.Location = new System.Drawing.Point(76, 193);
            this.dgvReporteMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteMarcas.Name = "dgvReporteMarcas";
            this.dgvReporteMarcas.RowHeadersWidth = 51;
            this.dgvReporteMarcas.Size = new System.Drawing.Size(1005, 378);
            this.dgvReporteMarcas.TabIndex = 55;
            // 
            // lReporteMarcas
            // 
            this.lReporteMarcas.AutoSize = true;
            this.lReporteMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReporteMarcas.Location = new System.Drawing.Point(73, 37);
            this.lReporteMarcas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lReporteMarcas.Name = "lReporteMarcas";
            this.lReporteMarcas.Size = new System.Drawing.Size(152, 18);
            this.lReporteMarcas.TabIndex = 54;
            this.lReporteMarcas.Text = "Reporte de Marcas";
            // 
            // MarcasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 609);
            this.Controls.Add(this.panelReporteMarcas);
            this.Controls.Add(this.dgvReporteMarcas);
            this.Controls.Add(this.lReporteMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MarcasForm";
            this.Text = "Reporte Marcas";
            this.Load += new System.EventHandler(this.MarcasForm_Load);
            this.panelReporteMarcas.ResumeLayout(false);
            this.panelReporteMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReporteMarcas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvReporteMarcas;
        private System.Windows.Forms.Label lReporteMarcas;
    }
}