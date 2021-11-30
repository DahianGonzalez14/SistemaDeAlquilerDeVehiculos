
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MarcaMantenimiento
{
    partial class ActualizarMarcaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarMarcaForm));
            this.panelActualizarMarca = new System.Windows.Forms.Panel();
            this.comboBoxEstatus = new System.Windows.Forms.ComboBox();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvActualizarMarca = new System.Windows.Forms.DataGridView();
            this.labelActualizarMarcaMantenimiento = new System.Windows.Forms.Label();
            this.panelActualizarMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActualizarMarca
            // 
            this.panelActualizarMarca.Controls.Add(this.comboBoxEstatus);
            this.panelActualizarMarca.Controls.Add(this.labelEstatus);
            this.panelActualizarMarca.Controls.Add(this.btnLimpiar);
            this.panelActualizarMarca.Controls.Add(this.btnGuardar);
            this.panelActualizarMarca.Controls.Add(this.txtNombre);
            this.panelActualizarMarca.Controls.Add(this.lNombre);
            this.panelActualizarMarca.Location = new System.Drawing.Point(76, 57);
            this.panelActualizarMarca.Name = "panelActualizarMarca";
            this.panelActualizarMarca.Size = new System.Drawing.Size(1005, 153);
            this.panelActualizarMarca.TabIndex = 50;
            // 
            // comboBoxEstatus
            // 
            this.comboBoxEstatus.FormattingEnabled = true;
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
            // dgvActualizarMarca
            // 
            this.dgvActualizarMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActualizarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizarMarca.Location = new System.Drawing.Point(76, 243);
            this.dgvActualizarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActualizarMarca.Name = "dgvActualizarMarca";
            this.dgvActualizarMarca.RowHeadersWidth = 51;
            this.dgvActualizarMarca.Size = new System.Drawing.Size(1005, 347);
            this.dgvActualizarMarca.TabIndex = 49;
            this.dgvActualizarMarca.SelectionChanged += new System.EventHandler(this.dgvActualizarMarca_SelectionChanged);
            // 
            // labelActualizarMarcaMantenimiento
            // 
            this.labelActualizarMarcaMantenimiento.AutoSize = true;
            this.labelActualizarMarcaMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualizarMarcaMantenimiento.Location = new System.Drawing.Point(73, 17);
            this.labelActualizarMarcaMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActualizarMarcaMantenimiento.Name = "labelActualizarMarcaMantenimiento";
            this.labelActualizarMarcaMantenimiento.Size = new System.Drawing.Size(134, 18);
            this.labelActualizarMarcaMantenimiento.TabIndex = 48;
            this.labelActualizarMarcaMantenimiento.Text = "Actualizar Marca";
            // 
            // ActualizarMarcaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelActualizarMarca);
            this.Controls.Add(this.dgvActualizarMarca);
            this.Controls.Add(this.labelActualizarMarcaMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActualizarMarcaForm";
            this.Text = "Actualizar Marca";
            this.Load += new System.EventHandler(this.ActualizarMarca_Load);
            this.panelActualizarMarca.ResumeLayout(false);
            this.panelActualizarMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelActualizarMarca;
        private System.Windows.Forms.ComboBox comboBoxEstatus;
        private System.Windows.Forms.Label labelEstatus;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvActualizarMarca;
        private System.Windows.Forms.Label labelActualizarMarcaMantenimiento;
    }
}