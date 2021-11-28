namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.TipoTransmisiones
{
    partial class CrearTipoTransmisionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearTipoTransmisionForm));
            this.panelCrearTipoTransmision = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvCrearTransmision = new System.Windows.Forms.DataGridView();
            this.labelCrearTipoTransmisionMantenimiento = new System.Windows.Forms.Label();
            this.panelCrearTipoTransmision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearTransmision)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearTipoTransmision
            // 
            this.panelCrearTipoTransmision.Controls.Add(this.btnLimpiar);
            this.panelCrearTipoTransmision.Controls.Add(this.btnGuardar);
            this.panelCrearTipoTransmision.Controls.Add(this.txtNombre);
            this.panelCrearTipoTransmision.Controls.Add(this.lNombre);
            this.panelCrearTipoTransmision.Location = new System.Drawing.Point(75, 63);
            this.panelCrearTipoTransmision.Name = "panelCrearTipoTransmision";
            this.panelCrearTipoTransmision.Size = new System.Drawing.Size(1005, 153);
            this.panelCrearTipoTransmision.TabIndex = 44;
            this.panelCrearTipoTransmision.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCrearCliente_Paint);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(59)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(519, 77);
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
            this.btnGuardar.Location = new System.Drawing.Point(78, 77);
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
            // dgvCrearTransmision
            // 
            this.dgvCrearTransmision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCrearTransmision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrearTransmision.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.dgvCrearTransmision.Location = new System.Drawing.Point(75, 238);
            this.dgvCrearTransmision.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCrearTransmision.Name = "dgvCrearTransmision";
            this.dgvCrearTransmision.RowHeadersWidth = 51;
            this.dgvCrearTransmision.Size = new System.Drawing.Size(1005, 347);
            this.dgvCrearTransmision.TabIndex = 43;
            this.dgvCrearTransmision.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCrearCliente_CellContentClick);
            // 
            // labelCrearTipoTransmisionMantenimiento
            // 
            this.labelCrearTipoTransmisionMantenimiento.AutoSize = true;
            this.labelCrearTipoTransmisionMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrearTipoTransmisionMantenimiento.Location = new System.Drawing.Point(95, 21);
            this.labelCrearTipoTransmisionMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrearTipoTransmisionMantenimiento.Name = "labelCrearTipoTransmisionMantenimiento";
            this.labelCrearTipoTransmisionMantenimiento.Size = new System.Drawing.Size(262, 18);
            this.labelCrearTipoTransmisionMantenimiento.TabIndex = 42;
            this.labelCrearTipoTransmisionMantenimiento.Text = "Crear Nuevo Tipo de Transmisión";
            this.labelCrearTipoTransmisionMantenimiento.Click += new System.EventHandler(this.labelCrearClienteMantenimiento_Click);
            // 
            // CrearTipoTransmisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelCrearTipoTransmision);
            this.Controls.Add(this.dgvCrearTransmision);
            this.Controls.Add(this.labelCrearTipoTransmisionMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrearTipoTransmisionForm";
            this.Text = "Crear Tipo de Transmisión";
            this.Load += new System.EventHandler(this.CrearTipoTransmisionForm_Load);
            this.panelCrearTipoTransmision.ResumeLayout(false);
            this.panelCrearTipoTransmision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearTransmision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearTipoTransmision;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvCrearTransmision;
        private System.Windows.Forms.Label labelCrearTipoTransmisionMantenimiento;
    }
}