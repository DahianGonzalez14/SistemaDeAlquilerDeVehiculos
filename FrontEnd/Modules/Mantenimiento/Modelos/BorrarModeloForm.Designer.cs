namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.Modelos
{
    partial class BorrarModeloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarModeloForm));
            this.panelBorrarModelo = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.dgvBorrarModelo = new System.Windows.Forms.DataGridView();
            this.labelBorrarModeloMantenimiento = new System.Windows.Forms.Label();
            this.panelBorrarModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorrarModelo
            // 
            this.panelBorrarModelo.Controls.Add(this.btnBorrar);
            this.panelBorrarModelo.Controls.Add(this.txtNombre);
            this.panelBorrarModelo.Controls.Add(this.lNombre);
            this.panelBorrarModelo.Location = new System.Drawing.Point(75, 93);
            this.panelBorrarModelo.Name = "panelBorrarModelo";
            this.panelBorrarModelo.Size = new System.Drawing.Size(1005, 168);
            this.panelBorrarModelo.TabIndex = 47;
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
            // dgvBorrarModelo
            // 
            this.dgvBorrarModelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrarModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrarModelo.Location = new System.Drawing.Point(75, 288);
            this.dgvBorrarModelo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBorrarModelo.Name = "dgvBorrarModelo";
            this.dgvBorrarModelo.RowHeadersWidth = 51;
            this.dgvBorrarModelo.Size = new System.Drawing.Size(1005, 268);
            this.dgvBorrarModelo.TabIndex = 46;
            this.dgvBorrarModelo.SelectionChanged += new System.EventHandler(this.dgvBorrarModelo_SelectionChanged);
            // 
            // labelBorrarModeloMantenimiento
            // 
            this.labelBorrarModeloMantenimiento.AutoSize = true;
            this.labelBorrarModeloMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrarModeloMantenimiento.Location = new System.Drawing.Point(81, 51);
            this.labelBorrarModeloMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBorrarModeloMantenimiento.Name = "labelBorrarModeloMantenimiento";
            this.labelBorrarModeloMantenimiento.Size = new System.Drawing.Size(117, 18);
            this.labelBorrarModeloMantenimiento.TabIndex = 45;
            this.labelBorrarModeloMantenimiento.Text = "Borrar Modelo";
            // 
            // BorrarModeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelBorrarModelo);
            this.Controls.Add(this.dgvBorrarModelo);
            this.Controls.Add(this.labelBorrarModeloMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BorrarModeloForm";
            this.Text = "Borrar Modelo";
            this.Load += new System.EventHandler(this.BorrarModeloForm_Load);
            this.panelBorrarModelo.ResumeLayout(false);
            this.panelBorrarModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorrarModelo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.DataGridView dgvBorrarModelo;
        private System.Windows.Forms.Label labelBorrarModeloMantenimiento;
    }
}