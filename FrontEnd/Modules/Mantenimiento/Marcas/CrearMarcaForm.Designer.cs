
namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.Mantenimiento.MarcaMantenimiento
{
    partial class CrearMarcaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearMarcaForm));
            this.panelCrearMarca = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvCrearMarca = new System.Windows.Forms.DataGridView();
            this.labelCrearClienteMantenimiento = new System.Windows.Forms.Label();
            this.panelCrearMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearMarca
            // 
            this.panelCrearMarca.Controls.Add(this.txtNombre);
            this.panelCrearMarca.Controls.Add(this.lNombre);
            this.panelCrearMarca.Controls.Add(this.btnLimpiar);
            this.panelCrearMarca.Controls.Add(this.btnGuardar);
            this.panelCrearMarca.Location = new System.Drawing.Point(75, 63);
            this.panelCrearMarca.Name = "panelCrearMarca";
            this.panelCrearMarca.Size = new System.Drawing.Size(1005, 153);
            this.panelCrearMarca.TabIndex = 47;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 18);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 22);
            this.txtNombre.TabIndex = 43;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(6, 24);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(56, 16);
            this.lNombre.TabIndex = 42;
            this.lNombre.Text = "Nombre";
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
            // dgvCrearMarca
            // 
            this.dgvCrearMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCrearMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrearMarca.Location = new System.Drawing.Point(75, 238);
            this.dgvCrearMarca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCrearMarca.Name = "dgvCrearMarca";
            this.dgvCrearMarca.RowHeadersWidth = 51;
            this.dgvCrearMarca.Size = new System.Drawing.Size(1005, 347);
            this.dgvCrearMarca.TabIndex = 46;
            // 
            // labelCrearClienteMantenimiento
            // 
            this.labelCrearClienteMantenimiento.AutoSize = true;
            this.labelCrearClienteMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrearClienteMantenimiento.Location = new System.Drawing.Point(72, 25);
            this.labelCrearClienteMantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrearClienteMantenimiento.Name = "labelCrearClienteMantenimiento";
            this.labelCrearClienteMantenimiento.Size = new System.Drawing.Size(154, 18);
            this.labelCrearClienteMantenimiento.TabIndex = 45;
            this.labelCrearClienteMantenimiento.Text = "Crear Nueva Marca";
            // 
            // CrearMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelCrearMarca);
            this.Controls.Add(this.dgvCrearMarca);
            this.Controls.Add(this.labelCrearClienteMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrearMarca";
            this.Text = "Crear Marca";
            this.Load += new System.EventHandler(this.CrearMarca_Load);
            this.panelCrearMarca.ResumeLayout(false);
            this.panelCrearMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCrearMarca;
        private System.Windows.Forms.Label labelCrearClienteMantenimiento;
    }
}