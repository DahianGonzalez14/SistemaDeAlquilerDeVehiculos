namespace SistemaDeAlquilerDeVehiculos.FrontEnd.Modules.AlquilerVehiculo
{
    partial class AlquilerVehiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlquilerVehiculoForm));
            this.panelAlquilerVehiculo = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lFechaHasta = new System.Windows.Forms.Label();
            this.lFechaDesde = new System.Windows.Forms.Label();
            this.lMetodoPago = new System.Windows.Forms.Label();
            this.lVehiculo = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.dgvAlquilerVehiculo = new System.Windows.Forms.DataGridView();
            this.labelCrearAlquiler = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxVehiculo = new System.Windows.Forms.ComboBox();
            this.comboBoxMetodoPago = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.panelAlquilerVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquilerVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlquilerVehiculo
            // 
            this.panelAlquilerVehiculo.Controls.Add(this.dateTimePickerFechaHasta);
            this.panelAlquilerVehiculo.Controls.Add(this.dateTimePickerFechaDesde);
            this.panelAlquilerVehiculo.Controls.Add(this.comboBoxMetodoPago);
            this.panelAlquilerVehiculo.Controls.Add(this.comboBoxVehiculo);
            this.panelAlquilerVehiculo.Controls.Add(this.comboBoxCliente);
            this.panelAlquilerVehiculo.Controls.Add(this.btnLimpiar);
            this.panelAlquilerVehiculo.Controls.Add(this.btnGuardar);
            this.panelAlquilerVehiculo.Controls.Add(this.lCosto);
            this.panelAlquilerVehiculo.Controls.Add(this.txtCosto);
            this.panelAlquilerVehiculo.Controls.Add(this.lFechaHasta);
            this.panelAlquilerVehiculo.Controls.Add(this.lFechaDesde);
            this.panelAlquilerVehiculo.Controls.Add(this.lMetodoPago);
            this.panelAlquilerVehiculo.Controls.Add(this.lVehiculo);
            this.panelAlquilerVehiculo.Controls.Add(this.lCliente);
            this.panelAlquilerVehiculo.Location = new System.Drawing.Point(76, 63);
            this.panelAlquilerVehiculo.Name = "panelAlquilerVehiculo";
            this.panelAlquilerVehiculo.Size = new System.Drawing.Size(1005, 238);
            this.panelAlquilerVehiculo.TabIndex = 44;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(59)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(538, 176);
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
            this.btnGuardar.Location = new System.Drawing.Point(122, 176);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(278, 43);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lCosto
            // 
            this.lCosto.AutoSize = true;
            this.lCosto.Location = new System.Drawing.Point(444, 24);
            this.lCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCosto.Name = "lCosto";
            this.lCosto.Size = new System.Drawing.Size(42, 16);
            this.lCosto.TabIndex = 27;
            this.lCosto.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCosto.Location = new System.Drawing.Point(538, 18);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(282, 22);
            this.txtCosto.TabIndex = 28;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // lFechaHasta
            // 
            this.lFechaHasta.AutoSize = true;
            this.lFechaHasta.Location = new System.Drawing.Point(442, 130);
            this.lFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFechaHasta.Name = "lFechaHasta";
            this.lFechaHasta.Size = new System.Drawing.Size(84, 16);
            this.lFechaHasta.TabIndex = 31;
            this.lFechaHasta.Text = "Fecha Hasta";
            // 
            // lFechaDesde
            // 
            this.lFechaDesde.AutoSize = true;
            this.lFechaDesde.Location = new System.Drawing.Point(442, 76);
            this.lFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFechaDesde.Name = "lFechaDesde";
            this.lFechaDesde.Size = new System.Drawing.Size(89, 16);
            this.lFechaDesde.TabIndex = 29;
            this.lFechaDesde.Text = "Fecha Desde";
            // 
            // lMetodoPago
            // 
            this.lMetodoPago.AutoSize = true;
            this.lMetodoPago.Location = new System.Drawing.Point(6, 133);
            this.lMetodoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMetodoPago.Name = "lMetodoPago";
            this.lMetodoPago.Size = new System.Drawing.Size(108, 16);
            this.lMetodoPago.TabIndex = 25;
            this.lMetodoPago.Text = "Método de Pago";
            // 
            // lVehiculo
            // 
            this.lVehiculo.AutoSize = true;
            this.lVehiculo.Location = new System.Drawing.Point(6, 76);
            this.lVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVehiculo.Name = "lVehiculo";
            this.lVehiculo.Size = new System.Drawing.Size(59, 16);
            this.lVehiculo.TabIndex = 23;
            this.lVehiculo.Text = "Vehículo";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Location = new System.Drawing.Point(6, 24);
            this.lCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(48, 16);
            this.lCliente.TabIndex = 21;
            this.lCliente.Text = "Cliente";
            this.lCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvAlquilerVehiculo
            // 
            this.dgvAlquilerVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquilerVehiculo.Location = new System.Drawing.Point(76, 317);
            this.dgvAlquilerVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlquilerVehiculo.Name = "dgvAlquilerVehiculo";
            this.dgvAlquilerVehiculo.RowHeadersWidth = 51;
            this.dgvAlquilerVehiculo.Size = new System.Drawing.Size(1005, 268);
            this.dgvAlquilerVehiculo.TabIndex = 43;
            // 
            // labelCrearAlquiler
            // 
            this.labelCrearAlquiler.AutoSize = true;
            this.labelCrearAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrearAlquiler.Location = new System.Drawing.Point(73, 22);
            this.labelCrearAlquiler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrearAlquiler.Name = "labelCrearAlquiler";
            this.labelCrearAlquiler.Size = new System.Drawing.Size(132, 18);
            this.labelCrearAlquiler.TabIndex = 42;
            this.labelCrearAlquiler.Text = "Alquiler Vehículo";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(122, 18);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(278, 24);
            this.comboBoxCliente.TabIndex = 42;
            // 
            // comboBoxVehiculo
            // 
            this.comboBoxVehiculo.FormattingEnabled = true;
            this.comboBoxVehiculo.Location = new System.Drawing.Point(122, 73);
            this.comboBoxVehiculo.Name = "comboBoxVehiculo";
            this.comboBoxVehiculo.Size = new System.Drawing.Size(278, 24);
            this.comboBoxVehiculo.TabIndex = 43;
            // 
            // comboBoxMetodoPago
            // 
            this.comboBoxMetodoPago.FormattingEnabled = true;
            this.comboBoxMetodoPago.Location = new System.Drawing.Point(122, 130);
            this.comboBoxMetodoPago.Name = "comboBoxMetodoPago";
            this.comboBoxMetodoPago.Size = new System.Drawing.Size(278, 24);
            this.comboBoxMetodoPago.TabIndex = 44;
            // 
            // dateTimePickerFechaDesde
            // 
            this.dateTimePickerFechaDesde.Location = new System.Drawing.Point(538, 71);
            this.dateTimePickerFechaDesde.Name = "dateTimePickerFechaDesde";
            this.dateTimePickerFechaDesde.Size = new System.Drawing.Size(282, 22);
            this.dateTimePickerFechaDesde.TabIndex = 45;
            this.dateTimePickerFechaDesde.CloseUp += new System.EventHandler(this.dateTimePickerFechaDesde_CloseUp);
            // 
            // dateTimePickerFechaHasta
            // 
            this.dateTimePickerFechaHasta.Location = new System.Drawing.Point(538, 124);
            this.dateTimePickerFechaHasta.Name = "dateTimePickerFechaHasta";
            this.dateTimePickerFechaHasta.Size = new System.Drawing.Size(282, 22);
            this.dateTimePickerFechaHasta.TabIndex = 46;
            // 
            // AlquilerVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 607);
            this.Controls.Add(this.panelAlquilerVehiculo);
            this.Controls.Add(this.dgvAlquilerVehiculo);
            this.Controls.Add(this.labelCrearAlquiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlquilerVehiculoForm";
            this.Text = "Alquiler Vehículo";
            this.Load += new System.EventHandler(this.AlquilerVehiculoForm_Load);
            this.panelAlquilerVehiculo.ResumeLayout(false);
            this.panelAlquilerVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquilerVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAlquilerVehiculo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDesde;
        private System.Windows.Forms.ComboBox comboBoxMetodoPago;
        private System.Windows.Forms.ComboBox comboBoxVehiculo;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lFechaHasta;
        private System.Windows.Forms.Label lFechaDesde;
        private System.Windows.Forms.Label lMetodoPago;
        private System.Windows.Forms.Label lVehiculo;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.DataGridView dgvAlquilerVehiculo;
        private System.Windows.Forms.Label labelCrearAlquiler;
    }
}