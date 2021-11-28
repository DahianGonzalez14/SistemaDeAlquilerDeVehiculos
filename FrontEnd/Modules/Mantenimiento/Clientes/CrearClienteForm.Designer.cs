namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Clientes
{
    partial class CrearClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearClienteForm));
            this.labelCrearClienteMantenimiento = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvCrearCliente = new System.Windows.Forms.DataGridView();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lCedula = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.panelCrearCliente = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearCliente)).BeginInit();
            this.panelCrearCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCrearClienteMantenimiento
            // 
            this.labelCrearClienteMantenimiento.AutoSize = true;
            this.labelCrearClienteMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrearClienteMantenimiento.Location = new System.Drawing.Point(111, 20);
            this.labelCrearClienteMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrearClienteMantenimiento.Name = "labelCrearClienteMantenimiento";
            this.labelCrearClienteMantenimiento.Size = new System.Drawing.Size(160, 18);
            this.labelCrearClienteMantenimiento.TabIndex = 1;
            this.labelCrearClienteMantenimiento.Text = "Crear Nuevo Cliente";
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
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvCrearCliente
            // 
            this.dgvCrearCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrearCliente.Location = new System.Drawing.Point(91, 316);
            this.dgvCrearCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCrearCliente.Name = "dgvCrearCliente";
            this.dgvCrearCliente.RowHeadersWidth = 51;
            this.dgvCrearCliente.Size = new System.Drawing.Size(1005, 268);
            this.dgvCrearCliente.TabIndex = 39;
            // 
            // txtCedula
            // 
            this.txtCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCedula.Location = new System.Drawing.Point(517, 127);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(282, 22);
            this.txtCedula.TabIndex = 32;
            // 
            // lCedula
            // 
            this.lCedula.AutoSize = true;
            this.lCedula.Location = new System.Drawing.Point(442, 130);
            this.lCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCedula.Name = "lCedula";
            this.lCedula.Size = new System.Drawing.Size(50, 16);
            this.lCedula.TabIndex = 31;
            this.lCedula.Text = "Cédula";
            this.lCedula.Click += new System.EventHandler(this.lCedula_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCorreo.Location = new System.Drawing.Point(517, 70);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(282, 22);
            this.txtCorreo.TabIndex = 30;
            // 
            // lCorreo
            // 
            this.lCorreo.AutoSize = true;
            this.lCorreo.Location = new System.Drawing.Point(442, 76);
            this.lCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCorreo.Name = "lCorreo";
            this.lCorreo.Size = new System.Drawing.Size(48, 16);
            this.lCorreo.TabIndex = 29;
            this.lCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTelefono.Location = new System.Drawing.Point(519, 18);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(282, 22);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(444, 24);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(61, 16);
            this.lTelefono.TabIndex = 27;
            this.lTelefono.Text = "Teléfono";
            this.lTelefono.Click += new System.EventHandler(this.lTelefono_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDireccion.Location = new System.Drawing.Point(78, 127);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(282, 22);
            this.txtDireccion.TabIndex = 26;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtAno_TextChanged);
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(6, 133);
            this.lDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(64, 16);
            this.lDireccion.TabIndex = 25;
            this.lDireccion.Text = "Dirección";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(78, 73);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(282, 22);
            this.txtApellido.TabIndex = 24;
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(6, 76);
            this.lApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(57, 16);
            this.lApellido.TabIndex = 23;
            this.lApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 18);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 22);
            this.txtNombre.TabIndex = 22;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(6, 24);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(56, 16);
            this.lNombre.TabIndex = 21;
            this.lNombre.Text = "Nombre";
            this.lNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelCrearCliente
            // 
            this.panelCrearCliente.Controls.Add(this.btnLimpiar);
            this.panelCrearCliente.Controls.Add(this.btnGuardar);
            this.panelCrearCliente.Controls.Add(this.txtCedula);
            this.panelCrearCliente.Controls.Add(this.lTelefono);
            this.panelCrearCliente.Controls.Add(this.txtTelefono);
            this.panelCrearCliente.Controls.Add(this.lCedula);
            this.panelCrearCliente.Controls.Add(this.txtCorreo);
            this.panelCrearCliente.Controls.Add(this.lCorreo);
            this.panelCrearCliente.Controls.Add(this.txtDireccion);
            this.panelCrearCliente.Controls.Add(this.lDireccion);
            this.panelCrearCliente.Controls.Add(this.txtApellido);
            this.panelCrearCliente.Controls.Add(this.lApellido);
            this.panelCrearCliente.Controls.Add(this.txtNombre);
            this.panelCrearCliente.Controls.Add(this.lNombre);
            this.panelCrearCliente.Location = new System.Drawing.Point(91, 62);
            this.panelCrearCliente.Name = "panelCrearCliente";
            this.panelCrearCliente.Size = new System.Drawing.Size(1005, 238);
            this.panelCrearCliente.TabIndex = 41;
            this.panelCrearCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCrearCliente_Paint);
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
            // CrearClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelCrearCliente);
            this.Controls.Add(this.dgvCrearCliente);
            this.Controls.Add(this.labelCrearClienteMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrearClienteForm";
            this.Text = "Crear Cliente";
            this.Load += new System.EventHandler(this.CrearClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearCliente)).EndInit();
            this.panelCrearCliente.ResumeLayout(false);
            this.panelCrearCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCrearClienteMantenimiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCrearCliente;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lCedula;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Panel panelCrearCliente;
        private System.Windows.Forms.Button btnLimpiar;
    }
}