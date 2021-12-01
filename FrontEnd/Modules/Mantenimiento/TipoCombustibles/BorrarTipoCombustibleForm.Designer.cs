
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MantenimientoTipoCombustible
{
    partial class BorrarTipoCombustibleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarTipoCombustibleForm));
            this.panelBorrarTipoCombustible = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvBorrarTipoCombustible = new System.Windows.Forms.DataGridView();
            this.labelBorrarTipoCombustibleMantenimiento = new System.Windows.Forms.Label();
            this.panelBorrarTipoCombustible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarTipoCombustible)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorrarTipoCombustible
            // 
            this.panelBorrarTipoCombustible.Controls.Add(this.btnBorrar);
            this.panelBorrarTipoCombustible.Controls.Add(this.txtNombre);
            this.panelBorrarTipoCombustible.Controls.Add(this.lNombre);
            this.panelBorrarTipoCombustible.Location = new System.Drawing.Point(76, 91);
            this.panelBorrarTipoCombustible.Name = "panelBorrarTipoCombustible";
            this.panelBorrarTipoCombustible.Size = new System.Drawing.Size(1005, 168);
            this.panelBorrarTipoCombustible.TabIndex = 50;
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
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombre.Location = new System.Drawing.Point(150, 40);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 22);
            this.txtNombre.TabIndex = 32;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(75, 43);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(56, 16);
            this.lNombre.TabIndex = 31;
            this.lNombre.Text = "Nombre";
            // 
            // dgvBorrarTipoCombustible
            // 
            this.dgvBorrarTipoCombustible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrarTipoCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrarTipoCombustible.Location = new System.Drawing.Point(76, 286);
            this.dgvBorrarTipoCombustible.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBorrarTipoCombustible.Name = "dgvBorrarTipoCombustible";
            this.dgvBorrarTipoCombustible.RowHeadersWidth = 51;
            this.dgvBorrarTipoCombustible.Size = new System.Drawing.Size(1005, 268);
            this.dgvBorrarTipoCombustible.TabIndex = 49;
            this.dgvBorrarTipoCombustible.SelectionChanged += new System.EventHandler(this.dgvBorrarTipoCombustible_SelectionChanged);
            // 
            // labelBorrarTipoCombustibleMantenimiento
            // 
            this.labelBorrarTipoCombustibleMantenimiento.AutoSize = true;
            this.labelBorrarTipoCombustibleMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrarTipoCombustibleMantenimiento.Location = new System.Drawing.Point(73, 52);
            this.labelBorrarTipoCombustibleMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBorrarTipoCombustibleMantenimiento.Name = "labelBorrarTipoCombustibleMantenimiento";
            this.labelBorrarTipoCombustibleMantenimiento.Size = new System.Drawing.Size(216, 18);
            this.labelBorrarTipoCombustibleMantenimiento.TabIndex = 48;
            this.labelBorrarTipoCombustibleMantenimiento.Text = "Borrar Tipo de Combustible";
            // 
            // BorrarTipoCombustibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelBorrarTipoCombustible);
            this.Controls.Add(this.dgvBorrarTipoCombustible);
            this.Controls.Add(this.labelBorrarTipoCombustibleMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BorrarTipoCombustibleForm";
            this.Text = "Borrar Tipo de Combustible";
            this.Load += new System.EventHandler(this.DeleteTipoCombustible_Load);
            this.panelBorrarTipoCombustible.ResumeLayout(false);
            this.panelBorrarTipoCombustible.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarTipoCombustible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorrarTipoCombustible;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvBorrarTipoCombustible;
        private System.Windows.Forms.Label labelBorrarTipoCombustibleMantenimiento;
    }
}