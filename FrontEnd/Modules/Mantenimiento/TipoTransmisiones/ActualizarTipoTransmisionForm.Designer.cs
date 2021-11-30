namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.TipoTransmisiones
{
    partial class ActualizarTipoTransmisionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarTipoTransmisionForm));
            this.panelActualizarTipoTransmision = new System.Windows.Forms.Panel();
            this.comboBoxEstatus = new System.Windows.Forms.ComboBox();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvActualizarTipoTransmision = new System.Windows.Forms.DataGridView();
            this.labelActualizarTipoTransmisionMantenimiento = new System.Windows.Forms.Label();
            this.panelActualizarTipoTransmision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarTipoTransmision)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActualizarTipoTransmision
            // 
            this.panelActualizarTipoTransmision.Controls.Add(this.comboBoxEstatus);
            this.panelActualizarTipoTransmision.Controls.Add(this.labelEstatus);
            this.panelActualizarTipoTransmision.Controls.Add(this.btnLimpiar);
            this.panelActualizarTipoTransmision.Controls.Add(this.btnGuardar);
            this.panelActualizarTipoTransmision.Controls.Add(this.txtNombre);
            this.panelActualizarTipoTransmision.Controls.Add(this.lNombre);
            this.panelActualizarTipoTransmision.Location = new System.Drawing.Point(75, 63);
            this.panelActualizarTipoTransmision.Name = "panelActualizarTipoTransmision";
            this.panelActualizarTipoTransmision.Size = new System.Drawing.Size(1005, 153);
            this.panelActualizarTipoTransmision.TabIndex = 47;
            // 
            // comboBoxEstatus
            // 
            this.comboBoxEstatus.FormattingEnabled = true;
            this.comboBoxEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstatus.Location = new System.Drawing.Point(521, 20);
            this.comboBoxEstatus.Name = "comboBoxEstatus";
            this.comboBoxEstatus.Size = new System.Drawing.Size(282, 24);
            this.comboBoxEstatus.TabIndex = 43;
            // 
            // labelEstatus
            // 
            this.labelEstatus.AutoSize = true;
            this.labelEstatus.Location = new System.Drawing.Point(449, 24);
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
            this.btnLimpiar.Location = new System.Drawing.Point(519, 75);
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
            this.btnGuardar.Location = new System.Drawing.Point(78, 75);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(282, 43);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // dgvActualizarTipoTransmision
            // 
            this.dgvActualizarTipoTransmision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActualizarTipoTransmision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizarTipoTransmision.Location = new System.Drawing.Point(75, 249);
            this.dgvActualizarTipoTransmision.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActualizarTipoTransmision.Name = "dgvActualizarTipoTransmision";
            this.dgvActualizarTipoTransmision.RowHeadersWidth = 51;
            this.dgvActualizarTipoTransmision.Size = new System.Drawing.Size(1005, 347);
            this.dgvActualizarTipoTransmision.TabIndex = 46;
            this.dgvActualizarTipoTransmision.SelectionChanged += new System.EventHandler(this.dgvActualizarTipoTransmision_SelectionChanged);
            // 
            // labelActualizarTipoTransmisionMantenimiento
            // 
            this.labelActualizarTipoTransmisionMantenimiento.AutoSize = true;
            this.labelActualizarTipoTransmisionMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualizarTipoTransmisionMantenimiento.Location = new System.Drawing.Point(81, 21);
            this.labelActualizarTipoTransmisionMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActualizarTipoTransmisionMantenimiento.Name = "labelActualizarTipoTransmisionMantenimiento";
            this.labelActualizarTipoTransmisionMantenimiento.Size = new System.Drawing.Size(241, 18);
            this.labelActualizarTipoTransmisionMantenimiento.TabIndex = 45;
            this.labelActualizarTipoTransmisionMantenimiento.Text = "Actualizar Tipo de Transmisión";
            // 
            // ActualizarTipoTransmisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelActualizarTipoTransmision);
            this.Controls.Add(this.dgvActualizarTipoTransmision);
            this.Controls.Add(this.labelActualizarTipoTransmisionMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActualizarTipoTransmisionForm";
            this.Text = "Actualizar Tipo de Transmisión";
            this.Load += new System.EventHandler(this.ActualizarTipoTransmisionForm_Load);
            this.panelActualizarTipoTransmision.ResumeLayout(false);
            this.panelActualizarTipoTransmision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarTipoTransmision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelActualizarTipoTransmision;
        private System.Windows.Forms.ComboBox comboBoxEstatus;
        private System.Windows.Forms.Label labelEstatus;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvActualizarTipoTransmision;
        private System.Windows.Forms.Label labelActualizarTipoTransmisionMantenimiento;
    }
}