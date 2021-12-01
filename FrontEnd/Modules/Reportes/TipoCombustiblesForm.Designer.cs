namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    partial class TipoCombustiblesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoCombustiblesForm));
            this.panelReporteTipoCombustibles = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvReporteTipoCombustibles = new System.Windows.Forms.DataGridView();
            this.lReporteTipoCombustibles = new System.Windows.Forms.Label();
            this.panelReporteTipoCombustibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteTipoCombustibles)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReporteTipoCombustibles
            // 
            this.panelReporteTipoCombustibles.Controls.Add(this.txtNombre);
            this.panelReporteTipoCombustibles.Controls.Add(this.lNombre);
            this.panelReporteTipoCombustibles.Location = new System.Drawing.Point(76, 76);
            this.panelReporteTipoCombustibles.Name = "panelReporteTipoCombustibles";
            this.panelReporteTipoCombustibles.Size = new System.Drawing.Size(1005, 100);
            this.panelReporteTipoCombustibles.TabIndex = 59;
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
            // dgvReporteTipoCombustibles
            // 
            this.dgvReporteTipoCombustibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteTipoCombustibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteTipoCombustibles.Location = new System.Drawing.Point(76, 193);
            this.dgvReporteTipoCombustibles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteTipoCombustibles.Name = "dgvReporteTipoCombustibles";
            this.dgvReporteTipoCombustibles.RowHeadersWidth = 51;
            this.dgvReporteTipoCombustibles.Size = new System.Drawing.Size(1005, 378);
            this.dgvReporteTipoCombustibles.TabIndex = 58;
            // 
            // lReporteTipoCombustibles
            // 
            this.lReporteTipoCombustibles.AutoSize = true;
            this.lReporteTipoCombustibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReporteTipoCombustibles.Location = new System.Drawing.Point(73, 37);
            this.lReporteTipoCombustibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lReporteTipoCombustibles.Name = "lReporteTipoCombustibles";
            this.lReporteTipoCombustibles.Size = new System.Drawing.Size(237, 18);
            this.lReporteTipoCombustibles.TabIndex = 57;
            this.lReporteTipoCombustibles.Text = "Reporte Tipo de Combustibles";
            // 
            // TipoCombustiblesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 609);
            this.Controls.Add(this.panelReporteTipoCombustibles);
            this.Controls.Add(this.dgvReporteTipoCombustibles);
            this.Controls.Add(this.lReporteTipoCombustibles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TipoCombustiblesForm";
            this.Text = "Reporte Tipo de Combustibles";
            this.Load += new System.EventHandler(this.TipoCombustiblesForm_Load);
            this.panelReporteTipoCombustibles.ResumeLayout(false);
            this.panelReporteTipoCombustibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteTipoCombustibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReporteTipoCombustibles;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvReporteTipoCombustibles;
        private System.Windows.Forms.Label lReporteTipoCombustibles;
    }
}