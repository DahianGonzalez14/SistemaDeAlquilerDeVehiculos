namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Clientes
{
    partial class ActualizarClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarClienteForm));
            this.panelActualizarCliente = new System.Windows.Forms.Panel();
            this.comboBoxEstatus = new System.Windows.Forms.ComboBox();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lCedula = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lCorreo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvActualizarCliente = new System.Windows.Forms.DataGridView();
            this.labelActualizarClienteMantenimiento = new System.Windows.Forms.Label();
            this.panelActualizarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActualizarCliente
            // 
            this.panelActualizarCliente.Controls.Add(this.comboBoxEstatus);
            this.panelActualizarCliente.Controls.Add(this.labelEstatus);
            this.panelActualizarCliente.Controls.Add(this.btnLimpiar);
            this.panelActualizarCliente.Controls.Add(this.btnGuardar);
            this.panelActualizarCliente.Controls.Add(this.txtCedula);
            this.panelActualizarCliente.Controls.Add(this.lTelefono);
            this.panelActualizarCliente.Controls.Add(this.txtTelefono);
            this.panelActualizarCliente.Controls.Add(this.lCedula);
            this.panelActualizarCliente.Controls.Add(this.txtCorreo);
            this.panelActualizarCliente.Controls.Add(this.lCorreo);
            this.panelActualizarCliente.Controls.Add(this.txtDireccion);
            this.panelActualizarCliente.Controls.Add(this.lDireccion);
            this.panelActualizarCliente.Controls.Add(this.txtApellido);
            this.panelActualizarCliente.Controls.Add(this.lApellido);
            this.panelActualizarCliente.Controls.Add(this.txtNombre);
            this.panelActualizarCliente.Controls.Add(this.lNombre);
            this.panelActualizarCliente.Location = new System.Drawing.Point(85, 63);
            this.panelActualizarCliente.Name = "panelActualizarCliente";
            this.panelActualizarCliente.Size = new System.Drawing.Size(1005, 284);
            this.panelActualizarCliente.TabIndex = 44;
            // 
            // comboBoxEstatus
            // 
            this.comboBoxEstatus.FormattingEnabled = true;
            this.comboBoxEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstatus.Location = new System.Drawing.Point(78, 179);
            this.comboBoxEstatus.Name = "comboBoxEstatus";
            this.comboBoxEstatus.Size = new System.Drawing.Size(282, 24);
            this.comboBoxEstatus.TabIndex = 43;
            // 
            // labelEstatus
            // 
            this.labelEstatus.AutoSize = true;
            this.labelEstatus.Location = new System.Drawing.Point(6, 183);
            this.labelEstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstatus.Name = "labelEstatus";
            this.labelEstatus.Size = new System.Drawing.Size(51, 16);
            this.labelEstatus.TabIndex = 42;
            this.labelEstatus.Text = "Estatus";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(59)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(519, 224);
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
            this.btnGuardar.Location = new System.Drawing.Point(78, 224);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(282, 43);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(444, 24);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(61, 16);
            this.lTelefono.TabIndex = 27;
            this.lTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTelefono.Location = new System.Drawing.Point(519, 18);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(282, 22);
            this.txtTelefono.TabIndex = 28;
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
            // txtDireccion
            // 
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDireccion.Location = new System.Drawing.Point(78, 127);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(282, 22);
            this.txtDireccion.TabIndex = 26;
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
            // dgvActualizarCliente
            // 
            this.dgvActualizarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizarCliente.Location = new System.Drawing.Point(85, 369);
            this.dgvActualizarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActualizarCliente.Name = "dgvActualizarCliente";
            this.dgvActualizarCliente.RowHeadersWidth = 51;
            this.dgvActualizarCliente.Size = new System.Drawing.Size(1005, 216);
            this.dgvActualizarCliente.TabIndex = 43;
            this.dgvActualizarCliente.SelectionChanged += new System.EventHandler(this.dgvActualizarCliente_SelectionChanged);
            // 
            // labelActualizarClienteMantenimiento
            // 
            this.labelActualizarClienteMantenimiento.AutoSize = true;
            this.labelActualizarClienteMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualizarClienteMantenimiento.Location = new System.Drawing.Point(91, 21);
            this.labelActualizarClienteMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActualizarClienteMantenimiento.Name = "labelActualizarClienteMantenimiento";
            this.labelActualizarClienteMantenimiento.Size = new System.Drawing.Size(139, 18);
            this.labelActualizarClienteMantenimiento.TabIndex = 42;
            this.labelActualizarClienteMantenimiento.Text = "Actualizar Cliente";
            // 
            // ActualizarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelActualizarCliente);
            this.Controls.Add(this.dgvActualizarCliente);
            this.Controls.Add(this.labelActualizarClienteMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActualizarClienteForm";
            this.Text = "Actualizar Cliente";
            this.Load += new System.EventHandler(this.ActualizarClienteForm_Load);
            this.panelActualizarCliente.ResumeLayout(false);
            this.panelActualizarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelActualizarCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lCedula;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvActualizarCliente;
        private System.Windows.Forms.Label labelActualizarClienteMantenimiento;
        private System.Windows.Forms.ComboBox comboBoxEstatus;
        private System.Windows.Forms.Label labelEstatus;
    }
}