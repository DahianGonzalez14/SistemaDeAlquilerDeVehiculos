
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoTipoCombustible
{
    partial class ActualizarTipoCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarTipoCombustible));
            this.panelCrearCliente = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvCrearTipoCombustible = new System.Windows.Forms.DataGridView();
            this.labelCrearClienteMantenimiento = new System.Windows.Forms.Label();
            this.panelCrearCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearTipoCombustible)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearCliente
            // 
            this.panelCrearCliente.Controls.Add(this.textBox3);
            this.panelCrearCliente.Controls.Add(this.label5);
            this.panelCrearCliente.Controls.Add(this.textBox4);
            this.panelCrearCliente.Controls.Add(this.label6);
            this.panelCrearCliente.Controls.Add(this.btnLimpiar);
            this.panelCrearCliente.Controls.Add(this.btnGuardar);
            this.panelCrearCliente.Location = new System.Drawing.Point(87, 93);
            this.panelCrearCliente.Name = "panelCrearCliente";
            this.panelCrearCliente.Size = new System.Drawing.Size(985, 238);
            this.panelCrearCliente.TabIndex = 44;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(532, 84);
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
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Estatus";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(133, 84);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(295, 22);
            this.textBox4.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nombre";
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnGuardar.Text = "Actualizar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvCrearTipoCombustible
            // 
            this.dgvCrearTipoCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrearTipoCombustible.Location = new System.Drawing.Point(87, 347);
            this.dgvCrearTipoCombustible.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCrearTipoCombustible.Name = "dgvCrearTipoCombustible";
            this.dgvCrearTipoCombustible.RowHeadersWidth = 51;
            this.dgvCrearTipoCombustible.Size = new System.Drawing.Size(985, 268);
            this.dgvCrearTipoCombustible.TabIndex = 43;
            this.dgvCrearTipoCombustible.SelectionChanged += new System.EventHandler(this.dgvCrearTipoCombustible_SelectionChanged);
            // 
            // labelCrearClienteMantenimiento
            // 
            this.labelCrearClienteMantenimiento.AutoSize = true;
            this.labelCrearClienteMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrearClienteMantenimiento.Location = new System.Drawing.Point(93, 51);
            this.labelCrearClienteMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrearClienteMantenimiento.Name = "labelCrearClienteMantenimiento";
            this.labelCrearClienteMantenimiento.Size = new System.Drawing.Size(214, 18);
            this.labelCrearClienteMantenimiento.TabIndex = 42;
            this.labelCrearClienteMantenimiento.Text = "Actualizar TipoCombustible";
            // 
            // ActualizarTipoCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 666);
            this.Controls.Add(this.panelCrearCliente);
            this.Controls.Add(this.dgvCrearTipoCombustible);
            this.Controls.Add(this.labelCrearClienteMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActualizarTipoCombustible";
            this.Text = "ActualizarTipoCombustible";
            this.Load += new System.EventHandler(this.ActualizarTipoCombustible_Load);
            this.panelCrearCliente.ResumeLayout(false);
            this.panelCrearCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearTipoCombustible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCrearTipoCombustible;
        private System.Windows.Forms.Label labelCrearClienteMantenimiento;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
    }
}