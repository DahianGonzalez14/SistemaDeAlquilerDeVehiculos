
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.AlquilerModulo
{
    partial class DevolucionVehiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolucionVehiculoForm));
            this.panelDevolucionVehiculo = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPenalidad = new System.Windows.Forms.TextBox();
            this.labelPenalidad = new System.Windows.Forms.Label();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lVehiculo = new System.Windows.Forms.Label();
            this.dgvDevolucionVehiculo = new System.Windows.Forms.DataGridView();
            this.labelDevolucionVehiculo = new System.Windows.Forms.Label();
            this.panelDevolucionVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucionVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDevolucionVehiculo
            // 
            this.panelDevolucionVehiculo.Controls.Add(this.btnGuardar);
            this.panelDevolucionVehiculo.Controls.Add(this.txtPenalidad);
            this.panelDevolucionVehiculo.Controls.Add(this.labelPenalidad);
            this.panelDevolucionVehiculo.Controls.Add(this.txtVehiculo);
            this.panelDevolucionVehiculo.Controls.Add(this.lVehiculo);
            this.panelDevolucionVehiculo.Location = new System.Drawing.Point(76, 91);
            this.panelDevolucionVehiculo.Name = "panelDevolucionVehiculo";
            this.panelDevolucionVehiculo.Size = new System.Drawing.Size(1005, 168);
            this.panelDevolucionVehiculo.TabIndex = 53;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGuardar.Location = new System.Drawing.Point(150, 93);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(282, 43);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPenalidad
            // 
            this.txtPenalidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPenalidad.Location = new System.Drawing.Point(560, 40);
            this.txtPenalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtPenalidad.Name = "txtPenalidad";
            this.txtPenalidad.Size = new System.Drawing.Size(148, 22);
            this.txtPenalidad.TabIndex = 43;
            this.txtPenalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenalidad_KeyPress);
            // 
            // labelPenalidad
            // 
            this.labelPenalidad.AutoSize = true;
            this.labelPenalidad.Location = new System.Drawing.Point(485, 43);
            this.labelPenalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPenalidad.Name = "labelPenalidad";
            this.labelPenalidad.Size = new System.Drawing.Size(69, 16);
            this.labelPenalidad.TabIndex = 42;
            this.labelPenalidad.Text = "Penalidad";
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Enabled = false;
            this.txtVehiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVehiculo.Location = new System.Drawing.Point(150, 40);
            this.txtVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(282, 22);
            this.txtVehiculo.TabIndex = 32;
            // 
            // lVehiculo
            // 
            this.lVehiculo.AutoSize = true;
            this.lVehiculo.Location = new System.Drawing.Point(75, 43);
            this.lVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVehiculo.Name = "lVehiculo";
            this.lVehiculo.Size = new System.Drawing.Size(59, 16);
            this.lVehiculo.TabIndex = 31;
            this.lVehiculo.Text = "Vehículo";
            // 
            // dgvDevolucionVehiculo
            // 
            this.dgvDevolucionVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucionVehiculo.Location = new System.Drawing.Point(76, 286);
            this.dgvDevolucionVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDevolucionVehiculo.Name = "dgvDevolucionVehiculo";
            this.dgvDevolucionVehiculo.RowHeadersWidth = 51;
            this.dgvDevolucionVehiculo.Size = new System.Drawing.Size(1005, 268);
            this.dgvDevolucionVehiculo.TabIndex = 52;
            this.dgvDevolucionVehiculo.SelectionChanged += new System.EventHandler(this.dgvDevolucionVehiculo_SelectionChanged);
            // 
            // labelDevolucionVehiculo
            // 
            this.labelDevolucionVehiculo.AutoSize = true;
            this.labelDevolucionVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevolucionVehiculo.Location = new System.Drawing.Point(73, 52);
            this.labelDevolucionVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDevolucionVehiculo.Name = "labelDevolucionVehiculo";
            this.labelDevolucionVehiculo.Size = new System.Drawing.Size(161, 18);
            this.labelDevolucionVehiculo.TabIndex = 51;
            this.labelDevolucionVehiculo.Text = "Devolución Vehículo";
            // 
            // DevolucionVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelDevolucionVehiculo);
            this.Controls.Add(this.dgvDevolucionVehiculo);
            this.Controls.Add(this.labelDevolucionVehiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DevolucionVehiculoForm";
            this.Text = "Devolución Vehículo";
            this.Load += new System.EventHandler(this.DevolucionVehiculoForm_Load);
            this.panelDevolucionVehiculo.ResumeLayout(false);
            this.panelDevolucionVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucionVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDevolucionVehiculo;
        private System.Windows.Forms.TextBox txtPenalidad;
        private System.Windows.Forms.Label labelPenalidad;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label lVehiculo;
        private System.Windows.Forms.DataGridView dgvDevolucionVehiculo;
        private System.Windows.Forms.Label labelDevolucionVehiculo;
        private System.Windows.Forms.Button btnGuardar;
    }
}