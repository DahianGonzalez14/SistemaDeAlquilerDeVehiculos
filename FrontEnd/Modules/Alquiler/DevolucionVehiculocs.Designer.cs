
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.AlquilerModulo
{
    partial class DevolucionVehiculocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolucionVehiculocs));
            this.panelCrearCliente = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvDevolverAlquiler = new System.Windows.Forms.DataGridView();
            this.labelCrearClienteMantenimiento = new System.Windows.Forms.Label();
            this.comboBoxAlquiler = new System.Windows.Forms.ComboBox();
            this.panelCrearCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolverAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearCliente
            // 
            this.panelCrearCliente.Controls.Add(this.comboBoxAlquiler);
            this.panelCrearCliente.Controls.Add(this.label7);
            this.panelCrearCliente.Controls.Add(this.textBox3);
            this.panelCrearCliente.Controls.Add(this.label5);
            this.panelCrearCliente.Controls.Add(this.btnLimpiar);
            this.panelCrearCliente.Controls.Add(this.btnGuardar);
            this.panelCrearCliente.Location = new System.Drawing.Point(108, 82);
            this.panelCrearCliente.Name = "panelCrearCliente";
            this.panelCrearCliente.Size = new System.Drawing.Size(985, 238);
            this.panelCrearCliente.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Alquiler";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(559, 81);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(295, 22);
            this.textBox3.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Penalidad";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(59)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(519, 176);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(282, 43);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGuardar.Location = new System.Drawing.Point(78, 176);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(282, 43);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Devolver";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvDevolverAlquiler
            // 
            this.dgvDevolverAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolverAlquiler.Location = new System.Drawing.Point(108, 336);
            this.dgvDevolverAlquiler.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDevolverAlquiler.Name = "dgvDevolverAlquiler";
            this.dgvDevolverAlquiler.RowHeadersWidth = 51;
            this.dgvDevolverAlquiler.Size = new System.Drawing.Size(985, 268);
            this.dgvDevolverAlquiler.TabIndex = 49;
            // 
            // labelCrearClienteMantenimiento
            // 
            this.labelCrearClienteMantenimiento.AutoSize = true;
            this.labelCrearClienteMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrearClienteMantenimiento.Location = new System.Drawing.Point(114, 40);
            this.labelCrearClienteMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrearClienteMantenimiento.Name = "labelCrearClienteMantenimiento";
            this.labelCrearClienteMantenimiento.Size = new System.Drawing.Size(134, 18);
            this.labelCrearClienteMantenimiento.TabIndex = 48;
            this.labelCrearClienteMantenimiento.Text = "Devolver Alquiler";
            // 
            // comboBoxAlquiler
            // 
            this.comboBoxAlquiler.FormattingEnabled = true;
            this.comboBoxAlquiler.Location = new System.Drawing.Point(152, 72);
            this.comboBoxAlquiler.Name = "comboBoxAlquiler";
            this.comboBoxAlquiler.Size = new System.Drawing.Size(282, 24);
            this.comboBoxAlquiler.TabIndex = 47;
            // 
            // DevolucionVehiculocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 668);
            this.Controls.Add(this.panelCrearCliente);
            this.Controls.Add(this.dgvDevolverAlquiler);
            this.Controls.Add(this.labelCrearClienteMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevolucionVehiculocs";
            this.Text = "DevolucionVehiculocs";
            this.Load += new System.EventHandler(this.DevolucionVehiculocs_Load);
            this.panelCrearCliente.ResumeLayout(false);
            this.panelCrearCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolverAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvDevolverAlquiler;
        private System.Windows.Forms.Label labelCrearClienteMantenimiento;
        private System.Windows.Forms.ComboBox comboBoxAlquiler;
    }
}