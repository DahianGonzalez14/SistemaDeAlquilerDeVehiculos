namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Modelos
{
    partial class CrearModeloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearModeloForm));
            this.panelCrearModelo = new System.Windows.Forms.Panel();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lMarca = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvCrearModelo = new System.Windows.Forms.DataGridView();
            this.labelCrearModeloMantenimiento = new System.Windows.Forms.Label();
            this.panelCrearModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearModelo
            // 
            this.panelCrearModelo.Controls.Add(this.comboBoxMarca);
            this.panelCrearModelo.Controls.Add(this.btnLimpiar);
            this.panelCrearModelo.Controls.Add(this.btnGuardar);
            this.panelCrearModelo.Controls.Add(this.lMarca);
            this.panelCrearModelo.Controls.Add(this.txtNombre);
            this.panelCrearModelo.Controls.Add(this.lNombre);
            this.panelCrearModelo.Location = new System.Drawing.Point(75, 63);
            this.panelCrearModelo.Name = "panelCrearModelo";
            this.panelCrearModelo.Size = new System.Drawing.Size(1005, 153);
            this.panelCrearModelo.TabIndex = 44;
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
            this.btnLimpiar.Location = new System.Drawing.Point(519, 72);
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
            this.btnGuardar.Location = new System.Drawing.Point(78, 72);
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
            // dgvCrearModelo
            // 
            this.dgvCrearModelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCrearModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrearModelo.Location = new System.Drawing.Point(75, 237);
            this.dgvCrearModelo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCrearModelo.Name = "dgvCrearModelo";
            this.dgvCrearModelo.RowHeadersWidth = 51;
            this.dgvCrearModelo.Size = new System.Drawing.Size(1005, 347);
            this.dgvCrearModelo.TabIndex = 43;
            // 
            // labelCrearModeloMantenimiento
            // 
            this.labelCrearModeloMantenimiento.AutoSize = true;
            this.labelCrearModeloMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrearModeloMantenimiento.Location = new System.Drawing.Point(95, 21);
            this.labelCrearModeloMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrearModeloMantenimiento.Name = "labelCrearModeloMantenimiento";
            this.labelCrearModeloMantenimiento.Size = new System.Drawing.Size(164, 18);
            this.labelCrearModeloMantenimiento.TabIndex = 42;
            this.labelCrearModeloMantenimiento.Text = "Crear Nuevo Modelo";
            // 
            // CrearModeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelCrearModelo);
            this.Controls.Add(this.dgvCrearModelo);
            this.Controls.Add(this.labelCrearModeloMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrearModeloForm";
            this.Text = "Crear Modelo";
            this.Load += new System.EventHandler(this.CrearModeloForm_Load);
            this.panelCrearModelo.ResumeLayout(false);
            this.panelCrearModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearModelo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvCrearModelo;
        private System.Windows.Forms.Label labelCrearModeloMantenimiento;
    }
}