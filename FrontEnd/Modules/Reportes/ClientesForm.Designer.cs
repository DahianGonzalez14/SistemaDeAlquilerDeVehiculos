namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Reportes
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.panelReporteClientes = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvReporteClientes = new System.Windows.Forms.DataGridView();
            this.lReporteClientes = new System.Windows.Forms.Label();
            this.panelReporteClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReporteClientes
            // 
            this.panelReporteClientes.Controls.Add(this.txtNombre);
            this.panelReporteClientes.Controls.Add(this.lNombre);
            this.panelReporteClientes.Location = new System.Drawing.Point(76, 92);
            this.panelReporteClientes.Name = "panelReporteClientes";
            this.panelReporteClientes.Size = new System.Drawing.Size(1005, 100);
            this.panelReporteClientes.TabIndex = 53;
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
            // dgvReporteClientes
            // 
            this.dgvReporteClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteClientes.Location = new System.Drawing.Point(76, 209);
            this.dgvReporteClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporteClientes.Name = "dgvReporteClientes";
            this.dgvReporteClientes.RowHeadersWidth = 51;
            this.dgvReporteClientes.Size = new System.Drawing.Size(1005, 378);
            this.dgvReporteClientes.TabIndex = 52;
            // 
            // lReporteClientes
            // 
            this.lReporteClientes.AutoSize = true;
            this.lReporteClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReporteClientes.Location = new System.Drawing.Point(73, 53);
            this.lReporteClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lReporteClientes.Name = "lReporteClientes";
            this.lReporteClientes.Size = new System.Drawing.Size(157, 18);
            this.lReporteClientes.TabIndex = 51;
            this.lReporteClientes.Text = "Reporte de Clientes";
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 609);
            this.Controls.Add(this.panelReporteClientes);
            this.Controls.Add(this.dgvReporteClientes);
            this.Controls.Add(this.lReporteClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientesForm";
            this.Text = "Reporte Clientes";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.panelReporteClientes.ResumeLayout(false);
            this.panelReporteClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReporteClientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvReporteClientes;
        private System.Windows.Forms.Label lReporteClientes;
    }
}