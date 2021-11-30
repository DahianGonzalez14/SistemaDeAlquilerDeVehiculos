
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MarcaMantenimiento
{
    partial class BorrarMarcaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarMarcaForm));
            this.panelBorrarMarca = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvBorrarMarca = new System.Windows.Forms.DataGridView();
            this.labelBorrarMarcaMantenimiento = new System.Windows.Forms.Label();
            this.panelBorrarMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorrarMarca
            // 
            this.panelBorrarMarca.Controls.Add(this.btnBorrar);
            this.panelBorrarMarca.Controls.Add(this.txtNombre);
            this.panelBorrarMarca.Controls.Add(this.lNombre);
            this.panelBorrarMarca.Location = new System.Drawing.Point(76, 91);
            this.panelBorrarMarca.Name = "panelBorrarMarca";
            this.panelBorrarMarca.Size = new System.Drawing.Size(1005, 168);
            this.panelBorrarMarca.TabIndex = 50;
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
            // dgvBorrarMarca
            // 
            this.dgvBorrarMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrarMarca.Location = new System.Drawing.Point(76, 286);
            this.dgvBorrarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBorrarMarca.Name = "dgvBorrarMarca";
            this.dgvBorrarMarca.RowHeadersWidth = 51;
            this.dgvBorrarMarca.Size = new System.Drawing.Size(1005, 268);
            this.dgvBorrarMarca.TabIndex = 49;
            this.dgvBorrarMarca.SelectionChanged += new System.EventHandler(this.dgvBorrarMarca_SelectionChanged);
            // 
            // labelBorrarMarcaMantenimiento
            // 
            this.labelBorrarMarcaMantenimiento.AutoSize = true;
            this.labelBorrarMarcaMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrarMarcaMantenimiento.Location = new System.Drawing.Point(73, 52);
            this.labelBorrarMarcaMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBorrarMarcaMantenimiento.Name = "labelBorrarMarcaMantenimiento";
            this.labelBorrarMarcaMantenimiento.Size = new System.Drawing.Size(108, 18);
            this.labelBorrarMarcaMantenimiento.TabIndex = 48;
            this.labelBorrarMarcaMantenimiento.Text = "Borrar Marca";
            // 
            // BorrarMarcaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelBorrarMarca);
            this.Controls.Add(this.dgvBorrarMarca);
            this.Controls.Add(this.labelBorrarMarcaMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BorrarMarcaForm";
            this.Text = "Borrar Marca";
            this.Load += new System.EventHandler(this.DeleteMarca_Load);
            this.panelBorrarMarca.ResumeLayout(false);
            this.panelBorrarMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorrarMarca;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvBorrarMarca;
        private System.Windows.Forms.Label labelBorrarMarcaMantenimiento;
    }
}