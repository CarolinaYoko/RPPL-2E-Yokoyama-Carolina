
namespace PetShop
{
    partial class FrmTotalCompra
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
            this.lblDetalle = new System.Windows.Forms.Label();
            this.dgDetalleDeCompra = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalCompraTxt = new System.Windows.Forms.Label();
            this.lblEnvioTxt = new System.Windows.Forms.Label();
            this.lblTotaltxt = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEnvioNumero = new System.Windows.Forms.Label();
            this.lblCompraNumero = new System.Windows.Forms.Label();
            this.lblTotalNumero = new System.Windows.Forms.Label();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblServicioDeTransporte = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.btnImprimirTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleDeCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetalle.Location = new System.Drawing.Point(178, 30);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(225, 23);
            this.lblDetalle.TabIndex = 0;
            this.lblDetalle.Text = "DETALLE DE LA COMPRA";
            // 
            // dgDetalleDeCompra
            // 
            this.dgDetalleDeCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetalleDeCompra.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgDetalleDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleDeCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Total});
            this.dgDetalleDeCompra.Location = new System.Drawing.Point(22, 87);
            this.dgDetalleDeCompra.Name = "dgDetalleDeCompra";
            this.dgDetalleDeCompra.RowTemplate.Height = 25;
            this.dgDetalleDeCompra.Size = new System.Drawing.Size(557, 292);
            this.dgDetalleDeCompra.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio unitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // lblTotalCompraTxt
            // 
            this.lblTotalCompraTxt.AutoSize = true;
            this.lblTotalCompraTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCompraTxt.Location = new System.Drawing.Point(320, 436);
            this.lblTotalCompraTxt.Name = "lblTotalCompraTxt";
            this.lblTotalCompraTxt.Size = new System.Drawing.Size(168, 20);
            this.lblTotalCompraTxt.TabIndex = 2;
            this.lblTotalCompraTxt.Text = "TOTAL DE LA COMPRA";
            // 
            // lblEnvioTxt
            // 
            this.lblEnvioTxt.AutoSize = true;
            this.lblEnvioTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnvioTxt.Location = new System.Drawing.Point(356, 396);
            this.lblEnvioTxt.Name = "lblEnvioTxt";
            this.lblEnvioTxt.Size = new System.Drawing.Size(132, 20);
            this.lblEnvioTxt.TabIndex = 3;
            this.lblEnvioTxt.Text = "TOTAL DEL ENVÍO";
            // 
            // lblTotaltxt
            // 
            this.lblTotaltxt.AutoSize = true;
            this.lblTotaltxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotaltxt.Location = new System.Drawing.Point(438, 476);
            this.lblTotaltxt.Name = "lblTotaltxt";
            this.lblTotaltxt.Size = new System.Drawing.Size(50, 20);
            this.lblTotaltxt.TabIndex = 4;
            this.lblTotaltxt.Text = "TOTAL";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(48, 535);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(213, 33);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEnvioNumero
            // 
            this.lblEnvioNumero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnvioNumero.Location = new System.Drawing.Point(523, 396);
            this.lblEnvioNumero.Name = "lblEnvioNumero";
            this.lblEnvioNumero.Size = new System.Drawing.Size(42, 20);
            this.lblEnvioNumero.TabIndex = 7;
            // 
            // lblCompraNumero
            // 
            this.lblCompraNumero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompraNumero.Location = new System.Drawing.Point(523, 436);
            this.lblCompraNumero.Name = "lblCompraNumero";
            this.lblCompraNumero.Size = new System.Drawing.Size(42, 20);
            this.lblCompraNumero.TabIndex = 8;
            // 
            // lblTotalNumero
            // 
            this.lblTotalNumero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalNumero.Location = new System.Drawing.Point(523, 476);
            this.lblTotalNumero.Name = "lblTotalNumero";
            this.lblTotalNumero.Size = new System.Drawing.Size(42, 20);
            this.lblTotalNumero.TabIndex = 9;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // lblServicioDeTransporte
            // 
            this.lblServicioDeTransporte.AutoSize = true;
            this.lblServicioDeTransporte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServicioDeTransporte.Location = new System.Drawing.Point(22, 395);
            this.lblServicioDeTransporte.Name = "lblServicioDeTransporte";
            this.lblServicioDeTransporte.Size = new System.Drawing.Size(193, 20);
            this.lblServicioDeTransporte.TabIndex = 10;
            this.lblServicioDeTransporte.Text = "SERVICIO DE TRANSPORTE";
            this.lblServicioDeTransporte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransporte
            // 
            this.lblTransporte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransporte.Location = new System.Drawing.Point(233, 396);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(71, 20);
            this.lblTransporte.TabIndex = 11;
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImprimirTicket.Location = new System.Drawing.Point(320, 535);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            this.btnImprimirTicket.Size = new System.Drawing.Size(213, 33);
            this.btnImprimirTicket.TabIndex = 12;
            this.btnImprimirTicket.Text = "IMPRIMIR TICKET";
            this.btnImprimirTicket.UseVisualStyleBackColor = true;
            this.btnImprimirTicket.Click += new System.EventHandler(this.btnImprimirTicket_Click);
            // 
            // FrmTotalCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.btnImprimirTicket);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.lblServicioDeTransporte);
            this.Controls.Add(this.lblTotalNumero);
            this.Controls.Add(this.lblCompraNumero);
            this.Controls.Add(this.lblEnvioNumero);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTotaltxt);
            this.Controls.Add(this.lblEnvioTxt);
            this.Controls.Add(this.lblTotalCompraTxt);
            this.Controls.Add(this.dgDetalleDeCompra);
            this.Controls.Add(this.lblDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTotalCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTotalCompra";
            this.Load += new System.EventHandler(this.FrmTotalCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleDeCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DataGridView dgDetalleDeCompra;
        private System.Windows.Forms.Label lblTotalCompraTxt;
        private System.Windows.Forms.Label lblEnvioTxt;
        private System.Windows.Forms.Label lblTotaltxt;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEnvioNumero;
        private System.Windows.Forms.Label lblCompraNumero;
        private System.Windows.Forms.Label lblTotalNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblServicioDeTransporte;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.Button btnImprimirTicket;
    }
}