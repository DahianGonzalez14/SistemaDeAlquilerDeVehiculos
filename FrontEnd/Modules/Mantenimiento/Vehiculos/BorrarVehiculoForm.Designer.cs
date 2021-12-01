
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoVehiculo
{
    partial class BorrarVehiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarVehiculoForm));
            this.panelBorrarVehiculo = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.lChasis = new System.Windows.Forms.Label();
            this.dgvBorrarVehiculo = new System.Windows.Forms.DataGridView();
            this.labelBorrarVehiculoMantenimiento = new System.Windows.Forms.Label();
            this.panelBorrarVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorrarVehiculo
            // 
            this.panelBorrarVehiculo.Controls.Add(this.btnBorrar);
            this.panelBorrarVehiculo.Controls.Add(this.txtChasis);
            this.panelBorrarVehiculo.Controls.Add(this.lChasis);
            this.panelBorrarVehiculo.Location = new System.Drawing.Point(76, 91);
            this.panelBorrarVehiculo.Name = "panelBorrarVehiculo";
            this.panelBorrarVehiculo.Size = new System.Drawing.Size(1005, 168);
            this.panelBorrarVehiculo.TabIndex = 50;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(59)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrar.Location = new System.Drawing.Point(150, 88);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(282, 43);
            this.btnBorrar.TabIndex = 41;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtChasis
            // 
            this.txtChasis.Enabled = false;
            this.txtChasis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtChasis.Location = new System.Drawing.Point(150, 40);
            this.txtChasis.Margin = new System.Windows.Forms.Padding(4);
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(282, 22);
            this.txtChasis.TabIndex = 32;
            // 
            // lChasis
            // 
            this.lChasis.AutoSize = true;
            this.lChasis.Location = new System.Drawing.Point(75, 43);
            this.lChasis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lChasis.Name = "lChasis";
            this.lChasis.Size = new System.Drawing.Size(48, 16);
            this.lChasis.TabIndex = 31;
            this.lChasis.Text = "Chasís";
            // 
            // dgvBorrarVehiculo
            // 
            this.dgvBorrarVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrarVehiculo.Location = new System.Drawing.Point(76, 286);
            this.dgvBorrarVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBorrarVehiculo.Name = "dgvBorrarVehiculo";
            this.dgvBorrarVehiculo.RowHeadersWidth = 51;
            this.dgvBorrarVehiculo.Size = new System.Drawing.Size(1005, 268);
            this.dgvBorrarVehiculo.TabIndex = 49;
            this.dgvBorrarVehiculo.SelectionChanged += new System.EventHandler(this.dgvBorrarVehiculo_SelectionChanged);
            // 
            // labelBorrarVehiculoMantenimiento
            // 
            this.labelBorrarVehiculoMantenimiento.AutoSize = true;
            this.labelBorrarVehiculoMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrarVehiculoMantenimiento.Location = new System.Drawing.Point(73, 52);
            this.labelBorrarVehiculoMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBorrarVehiculoMantenimiento.Name = "labelBorrarVehiculoMantenimiento";
            this.labelBorrarVehiculoMantenimiento.Size = new System.Drawing.Size(125, 18);
            this.labelBorrarVehiculoMantenimiento.TabIndex = 48;
            this.labelBorrarVehiculoMantenimiento.Text = "Borrar Vehículo";
            // 
            // BorrarVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelBorrarVehiculo);
            this.Controls.Add(this.dgvBorrarVehiculo);
            this.Controls.Add(this.labelBorrarVehiculoMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BorrarVehiculoForm";
            this.Text = "Borrar Vehículo";
            this.Load += new System.EventHandler(this.BorrarVehiculoForm_Load);
            this.panelBorrarVehiculo.ResumeLayout(false);
            this.panelBorrarVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorrarVehiculo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtChasis;
        private System.Windows.Forms.Label lChasis;
        private System.Windows.Forms.DataGridView dgvBorrarVehiculo;
        private System.Windows.Forms.Label labelBorrarVehiculoMantenimiento;
    }
}