namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Clientes
{
    partial class BorrarClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarClienteForm));
            this.panelBorrarCliente = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lCedula = new System.Windows.Forms.Label();
            this.dgvBorrarCliente = new System.Windows.Forms.DataGridView();
            this.labelBorrarClienteMantenimiento = new System.Windows.Forms.Label();
            this.panelBorrarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorrarCliente
            // 
            this.panelBorrarCliente.Controls.Add(this.btnBorrar);
            this.panelBorrarCliente.Controls.Add(this.txtCedula);
            this.panelBorrarCliente.Controls.Add(this.lCedula);
            this.panelBorrarCliente.Location = new System.Drawing.Point(85, 63);
            this.panelBorrarCliente.Name = "panelBorrarCliente";
            this.panelBorrarCliente.Size = new System.Drawing.Size(1005, 168);
            this.panelBorrarCliente.TabIndex = 44;
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
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCedula.Location = new System.Drawing.Point(150, 40);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(282, 22);
            this.txtCedula.TabIndex = 32;
            // 
            // lCedula
            // 
            this.lCedula.AutoSize = true;
            this.lCedula.Location = new System.Drawing.Point(75, 43);
            this.lCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCedula.Name = "lCedula";
            this.lCedula.Size = new System.Drawing.Size(50, 16);
            this.lCedula.TabIndex = 31;
            this.lCedula.Text = "Cédula";
            // 
            // dgvBorrarCliente
            // 
            this.dgvBorrarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrarCliente.Location = new System.Drawing.Point(85, 258);
            this.dgvBorrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBorrarCliente.Name = "dgvBorrarCliente";
            this.dgvBorrarCliente.RowHeadersWidth = 51;
            this.dgvBorrarCliente.Size = new System.Drawing.Size(1005, 268);
            this.dgvBorrarCliente.TabIndex = 43;
            this.dgvBorrarCliente.SelectionChanged += new System.EventHandler(this.dgvBorrarCliente_SelectionChanged);
            // 
            // labelBorrarClienteMantenimiento
            // 
            this.labelBorrarClienteMantenimiento.AutoSize = true;
            this.labelBorrarClienteMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrarClienteMantenimiento.Location = new System.Drawing.Point(82, 24);
            this.labelBorrarClienteMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBorrarClienteMantenimiento.Name = "labelBorrarClienteMantenimiento";
            this.labelBorrarClienteMantenimiento.Size = new System.Drawing.Size(113, 18);
            this.labelBorrarClienteMantenimiento.TabIndex = 42;
            this.labelBorrarClienteMantenimiento.Text = "Borrar Cliente";
            // 
            // BorrarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelBorrarCliente);
            this.Controls.Add(this.dgvBorrarCliente);
            this.Controls.Add(this.labelBorrarClienteMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BorrarClienteForm";
            this.Text = "Borrar Cliente";
            this.Load += new System.EventHandler(this.BorrarClienteForm_Load);
            this.panelBorrarCliente.ResumeLayout(false);
            this.panelBorrarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorrarCliente;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lCedula;
        private System.Windows.Forms.DataGridView dgvBorrarCliente;
        private System.Windows.Forms.Label labelBorrarClienteMantenimiento;
    }
}