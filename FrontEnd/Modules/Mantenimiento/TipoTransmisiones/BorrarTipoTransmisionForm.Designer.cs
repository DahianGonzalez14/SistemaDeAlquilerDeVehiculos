namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.TipoTransmisiones
{
    partial class BorrarTipoTransmisionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarTipoTransmisionForm));
            this.panelBorrarTipoTransmision = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvBorrarTipoTransmision = new System.Windows.Forms.DataGridView();
            this.labelBorrarClienteMantenimiento = new System.Windows.Forms.Label();
            this.panelBorrarTipoTransmision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarTipoTransmision)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorrarTipoTransmision
            // 
            this.panelBorrarTipoTransmision.Controls.Add(this.btnBorrar);
            this.panelBorrarTipoTransmision.Controls.Add(this.txtNombre);
            this.panelBorrarTipoTransmision.Controls.Add(this.lNombre);
            this.panelBorrarTipoTransmision.Location = new System.Drawing.Point(75, 93);
            this.panelBorrarTipoTransmision.Name = "panelBorrarTipoTransmision";
            this.panelBorrarTipoTransmision.Size = new System.Drawing.Size(1005, 168);
            this.panelBorrarTipoTransmision.TabIndex = 47;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(59)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrar.Location = new System.Drawing.Point(150, 88);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(282, 43);
            this.btnBorrar.TabIndex = 41;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombre.Location = new System.Drawing.Point(150, 40);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 22);
            this.txtNombre.TabIndex = 32;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(75, 43);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(56, 16);
            this.lNombre.TabIndex = 31;
            this.lNombre.Text = "Nombre";
            // 
            // dgvBorrarTipoTransmision
            // 
            this.dgvBorrarTipoTransmision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrarTipoTransmision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrarTipoTransmision.Location = new System.Drawing.Point(75, 288);
            this.dgvBorrarTipoTransmision.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBorrarTipoTransmision.Name = "dgvBorrarTipoTransmision";
            this.dgvBorrarTipoTransmision.RowHeadersWidth = 51;
            this.dgvBorrarTipoTransmision.Size = new System.Drawing.Size(1005, 268);
            this.dgvBorrarTipoTransmision.TabIndex = 46;
            this.dgvBorrarTipoTransmision.SelectionChanged += new System.EventHandler(this.dgvBorrarTipoTransmision_SelectionChanged);
            // 
            // labelBorrarClienteMantenimiento
            // 
            this.labelBorrarClienteMantenimiento.AutoSize = true;
            this.labelBorrarClienteMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrarClienteMantenimiento.Location = new System.Drawing.Point(81, 51);
            this.labelBorrarClienteMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBorrarClienteMantenimiento.Name = "labelBorrarClienteMantenimiento";
            this.labelBorrarClienteMantenimiento.Size = new System.Drawing.Size(215, 18);
            this.labelBorrarClienteMantenimiento.TabIndex = 45;
            this.labelBorrarClienteMantenimiento.Text = "Borrar Tipo de Transmisión";
            // 
            // BorrarTipoTransmisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelBorrarTipoTransmision);
            this.Controls.Add(this.dgvBorrarTipoTransmision);
            this.Controls.Add(this.labelBorrarClienteMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BorrarTipoTransmisionForm";
            this.Text = "Borrar Tipo de Transmisión";
            this.Load += new System.EventHandler(this.BorrarTipoTransmisionForm_Load);
            this.panelBorrarTipoTransmision.ResumeLayout(false);
            this.panelBorrarTipoTransmision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarTipoTransmision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorrarTipoTransmision;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvBorrarTipoTransmision;
        private System.Windows.Forms.Label labelBorrarClienteMantenimiento;
    }
}