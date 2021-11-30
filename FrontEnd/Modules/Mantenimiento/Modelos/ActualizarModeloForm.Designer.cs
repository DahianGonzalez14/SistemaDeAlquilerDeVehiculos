namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Modelos
{
    partial class ActualizarModeloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarModeloForm));
            this.panelActualizarModelo = new System.Windows.Forms.Panel();
            this.comboBoxEstatus = new System.Windows.Forms.ComboBox();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lMarca = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvActualizarModelo = new System.Windows.Forms.DataGridView();
            this.labelActualizarModeloMantenimiento = new System.Windows.Forms.Label();
            this.panelActualizarModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActualizarModelo
            // 
            this.panelActualizarModelo.Controls.Add(this.comboBoxEstatus);
            this.panelActualizarModelo.Controls.Add(this.labelEstatus);
            this.panelActualizarModelo.Controls.Add(this.comboBoxMarca);
            this.panelActualizarModelo.Controls.Add(this.btnLimpiar);
            this.panelActualizarModelo.Controls.Add(this.btnGuardar);
            this.panelActualizarModelo.Controls.Add(this.lMarca);
            this.panelActualizarModelo.Controls.Add(this.txtNombre);
            this.panelActualizarModelo.Controls.Add(this.lNombre);
            this.panelActualizarModelo.Location = new System.Drawing.Point(75, 64);
            this.panelActualizarModelo.Name = "panelActualizarModelo";
            this.panelActualizarModelo.Size = new System.Drawing.Size(1005, 176);
            this.panelActualizarModelo.TabIndex = 47;
            // 
            // comboBoxEstatus
            // 
            this.comboBoxEstatus.FormattingEnabled = true;
            this.comboBoxEstatus.Location = new System.Drawing.Point(78, 65);
            this.comboBoxEstatus.Name = "comboBoxEstatus";
            this.comboBoxEstatus.Size = new System.Drawing.Size(282, 24);
            this.comboBoxEstatus.TabIndex = 45;
            // 
            // labelEstatus
            // 
            this.labelEstatus.AutoSize = true;
            this.labelEstatus.Location = new System.Drawing.Point(6, 69);
            this.labelEstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstatus.Name = "labelEstatus";
            this.labelEstatus.Size = new System.Drawing.Size(51, 16);
            this.labelEstatus.TabIndex = 44;
            this.labelEstatus.Text = "Estatus";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(519, 21);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(282, 24);
            this.comboBoxMarca.TabIndex = 42;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(59)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(519, 114);
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
            this.btnGuardar.Location = new System.Drawing.Point(78, 114);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(282, 43);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(444, 24);
            this.lMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(45, 16);
            this.lMarca.TabIndex = 27;
            this.lMarca.Text = "Marca";
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
            // dgvActualizarModelo
            // 
            this.dgvActualizarModelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActualizarModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizarModelo.Location = new System.Drawing.Point(75, 262);
            this.dgvActualizarModelo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActualizarModelo.Name = "dgvActualizarModelo";
            this.dgvActualizarModelo.RowHeadersWidth = 51;
            this.dgvActualizarModelo.Size = new System.Drawing.Size(1005, 323);
            this.dgvActualizarModelo.TabIndex = 46;
            this.dgvActualizarModelo.SelectionChanged += new System.EventHandler(this.dgvActualizarModelo_SelectionChanged);
            // 
            // labelActualizarModeloMantenimiento
            // 
            this.labelActualizarModeloMantenimiento.AutoSize = true;
            this.labelActualizarModeloMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualizarModeloMantenimiento.Location = new System.Drawing.Point(72, 25);
            this.labelActualizarModeloMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActualizarModeloMantenimiento.Name = "labelActualizarModeloMantenimiento";
            this.labelActualizarModeloMantenimiento.Size = new System.Drawing.Size(143, 18);
            this.labelActualizarModeloMantenimiento.TabIndex = 45;
            this.labelActualizarModeloMantenimiento.Text = "Actualizar Modelo";
            // 
            // ActualizarModeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelActualizarModelo);
            this.Controls.Add(this.dgvActualizarModelo);
            this.Controls.Add(this.labelActualizarModeloMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActualizarModeloForm";
            this.Text = "Actualizar Modelo";
            this.Load += new System.EventHandler(this.ActualizarModeloForm_Load);
            this.panelActualizarModelo.ResumeLayout(false);
            this.panelActualizarModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelActualizarModelo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvActualizarModelo;
        private System.Windows.Forms.Label labelActualizarModeloMantenimiento;
        private System.Windows.Forms.ComboBox comboBoxEstatus;
        private System.Windows.Forms.Label labelEstatus;
    }
}