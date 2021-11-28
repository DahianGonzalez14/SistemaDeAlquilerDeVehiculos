
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MarcaMantenimiento
{
    partial class DeleteMarca
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
            this.panelCrearCliente = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvCrearMarca = new System.Windows.Forms.DataGridView();
            this.labelCrearClienteMantenimiento = new System.Windows.Forms.Label();
            this.panelCrearCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearCliente
            // 
            this.panelCrearCliente.Controls.Add(this.textBox6);
            this.panelCrearCliente.Controls.Add(this.label7);
            this.panelCrearCliente.Controls.Add(this.btnLimpiar);
            this.panelCrearCliente.Controls.Add(this.btnGuardar);
            this.panelCrearCliente.Location = new System.Drawing.Point(127, 112);
            this.panelCrearCliente.Name = "panelCrearCliente";
            this.panelCrearCliente.Size = new System.Drawing.Size(985, 238);
            this.panelCrearCliente.TabIndex = 50;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(144, 45);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(284, 22);
            this.textBox6.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Id";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(59)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(481, 137);
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
            this.btnGuardar.Location = new System.Drawing.Point(65, 128);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(282, 43);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Eliminar ";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvCrearMarca
            // 
            this.dgvCrearMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrearMarca.Location = new System.Drawing.Point(127, 366);
            this.dgvCrearMarca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCrearMarca.Name = "dgvCrearMarca";
            this.dgvCrearMarca.RowHeadersWidth = 51;
            this.dgvCrearMarca.Size = new System.Drawing.Size(985, 268);
            this.dgvCrearMarca.TabIndex = 49;
            // 
            // labelCrearClienteMantenimiento
            // 
            this.labelCrearClienteMantenimiento.AutoSize = true;
            this.labelCrearClienteMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrearClienteMantenimiento.Location = new System.Drawing.Point(124, 70);
            this.labelCrearClienteMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrearClienteMantenimiento.Name = "labelCrearClienteMantenimiento";
            this.labelCrearClienteMantenimiento.Size = new System.Drawing.Size(121, 18);
            this.labelCrearClienteMantenimiento.TabIndex = 48;
            this.labelCrearClienteMantenimiento.Text = "Eliminar Marca";
            // 
            // DeleteMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 704);
            this.Controls.Add(this.panelCrearCliente);
            this.Controls.Add(this.dgvCrearMarca);
            this.Controls.Add(this.labelCrearClienteMantenimiento);
            this.Name = "DeleteMarca";
            this.Text = "DeleteMarca";
            this.Load += new System.EventHandler(this.DeleteMarca_Load);
            this.panelCrearCliente.ResumeLayout(false);
            this.panelCrearCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearCliente;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCrearMarca;
        private System.Windows.Forms.Label labelCrearClienteMantenimiento;
    }
}