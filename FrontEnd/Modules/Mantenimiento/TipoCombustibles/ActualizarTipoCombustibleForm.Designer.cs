
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoTipoCombustible
{
    partial class ActualizarTipoCombustibleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarTipoCombustibleForm));
            this.panelActualizarTipoCombustible = new System.Windows.Forms.Panel();
            this.comboBoxEstatus = new System.Windows.Forms.ComboBox();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvActualizarTipoCombustible = new System.Windows.Forms.DataGridView();
            this.labelActualizarTipoCombustibleMantenimiento = new System.Windows.Forms.Label();
            this.panelActualizarTipoCombustible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarTipoCombustible)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActualizarTipoCombustible
            // 
            this.panelActualizarTipoCombustible.Controls.Add(this.comboBoxEstatus);
            this.panelActualizarTipoCombustible.Controls.Add(this.labelEstatus);
            this.panelActualizarTipoCombustible.Controls.Add(this.btnLimpiar);
            this.panelActualizarTipoCombustible.Controls.Add(this.btnGuardar);
            this.panelActualizarTipoCombustible.Controls.Add(this.txtNombre);
            this.panelActualizarTipoCombustible.Controls.Add(this.lNombre);
            this.panelActualizarTipoCombustible.Location = new System.Drawing.Point(76, 57);
            this.panelActualizarTipoCombustible.Name = "panelActualizarTipoCombustible";
            this.panelActualizarTipoCombustible.Size = new System.Drawing.Size(1005, 153);
            this.panelActualizarTipoCombustible.TabIndex = 50;
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
            // dgvActualizarTipoCombustible
            // 
            this.dgvActualizarTipoCombustible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActualizarTipoCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizarTipoCombustible.Location = new System.Drawing.Point(76, 243);
            this.dgvActualizarTipoCombustible.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActualizarTipoCombustible.Name = "dgvActualizarTipoCombustible";
            this.dgvActualizarTipoCombustible.RowHeadersWidth = 51;
            this.dgvActualizarTipoCombustible.Size = new System.Drawing.Size(1005, 347);
            this.dgvActualizarTipoCombustible.TabIndex = 49;
            this.dgvActualizarTipoCombustible.SelectionChanged += new System.EventHandler(this.dgvActualizarTipoCombustible_SelectionChanged);
            // 
            // labelActualizarTipoCombustibleMantenimiento
            // 
            this.labelActualizarTipoCombustibleMantenimiento.AutoSize = true;
            this.labelActualizarTipoCombustibleMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualizarTipoCombustibleMantenimiento.Location = new System.Drawing.Point(73, 17);
            this.labelActualizarTipoCombustibleMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActualizarTipoCombustibleMantenimiento.Name = "labelActualizarTipoCombustibleMantenimiento";
            this.labelActualizarTipoCombustibleMantenimiento.Size = new System.Drawing.Size(242, 18);
            this.labelActualizarTipoCombustibleMantenimiento.TabIndex = 48;
            this.labelActualizarTipoCombustibleMantenimiento.Text = "Actualizar Tipo de Combustible";
            // 
            // ActualizarTipoCombustibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelActualizarTipoCombustible);
            this.Controls.Add(this.dgvActualizarTipoCombustible);
            this.Controls.Add(this.labelActualizarTipoCombustibleMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActualizarTipoCombustibleForm";
            this.Text = "Actualizar Tipo de Combustible";
            this.Load += new System.EventHandler(this.ActualizarTipoCombustible_Load);
            this.panelActualizarTipoCombustible.ResumeLayout(false);
            this.panelActualizarTipoCombustible.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizarTipoCombustible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelActualizarTipoCombustible;
        private System.Windows.Forms.ComboBox comboBoxEstatus;
        private System.Windows.Forms.Label labelEstatus;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvActualizarTipoCombustible;
        private System.Windows.Forms.Label labelActualizarTipoCombustibleMantenimiento;
    }
}