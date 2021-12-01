namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    partial class ModelosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelosForm));
            this.panelReporteModelos = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvReporteModelos = new System.Windows.Forms.DataGridView();
            this.lReporteModelos = new System.Windows.Forms.Label();
            this.panelReporteModelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReporteModelos
            // 
            this.panelReporteModelos.Controls.Add(this.txtNombre);
            this.panelReporteModelos.Controls.Add(this.lNombre);
            this.panelReporteModelos.Location = new System.Drawing.Point(76, 76);
            this.panelReporteModelos.Name = "panelReporteModelos";
            this.panelReporteModelos.Size = new System.Drawing.Size(1005, 100);
            this.panelReporteModelos.TabIndex = 59;
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
            // dgvReporteModelos
            // 
            this.dgvReporteModelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteModelos.Location = new System.Drawing.Point(76, 193);
            this.dgvReporteModelos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteModelos.Name = "dgvReporteModelos";
            this.dgvReporteModelos.RowHeadersWidth = 51;
            this.dgvReporteModelos.Size = new System.Drawing.Size(1005, 378);
            this.dgvReporteModelos.TabIndex = 58;
            // 
            // lReporteModelos
            // 
            this.lReporteModelos.AutoSize = true;
            this.lReporteModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReporteModelos.Location = new System.Drawing.Point(73, 37);
            this.lReporteModelos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lReporteModelos.Name = "lReporteModelos";
            this.lReporteModelos.Size = new System.Drawing.Size(161, 18);
            this.lReporteModelos.TabIndex = 57;
            this.lReporteModelos.Text = "Reporte de Modelos";
            // 
            // ModelosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 609);
            this.Controls.Add(this.panelReporteModelos);
            this.Controls.Add(this.dgvReporteModelos);
            this.Controls.Add(this.lReporteModelos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModelosForm";
            this.Text = "Reporte Modelos";
            this.Load += new System.EventHandler(this.ModelosForm_Load);
            this.panelReporteModelos.ResumeLayout(false);
            this.panelReporteModelos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReporteModelos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvReporteModelos;
        private System.Windows.Forms.Label lReporteModelos;
    }
}