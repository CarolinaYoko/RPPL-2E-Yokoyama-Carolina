
namespace PetShop
{
    partial class FrmColaDeVentas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColaDeVentas));
            this.btnCerrarColaVentas = new System.Windows.Forms.Button();
            this.lvVentasEnviadas = new System.Windows.Forms.ListView();
            this.txtVentaEnProceso = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lvVentasEspera = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCerrarColaVentas
            // 
            this.btnCerrarColaVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarColaVentas.BackgroundImage")));
            this.btnCerrarColaVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarColaVentas.FlatAppearance.BorderSize = 0;
            this.btnCerrarColaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarColaVentas.Location = new System.Drawing.Point(560, 12);
            this.btnCerrarColaVentas.Name = "btnCerrarColaVentas";
            this.btnCerrarColaVentas.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarColaVentas.TabIndex = 20;
            this.btnCerrarColaVentas.UseVisualStyleBackColor = true;
            this.btnCerrarColaVentas.Click += new System.EventHandler(this.btnCerrarColaVentas_Click);
            // 
            // lvVentasEnviadas
            // 
            this.lvVentasEnviadas.HideSelection = false;
            this.lvVentasEnviadas.Location = new System.Drawing.Point(42, 357);
            this.lvVentasEnviadas.Name = "lvVentasEnviadas";
            this.lvVentasEnviadas.Size = new System.Drawing.Size(516, 170);
            this.lvVentasEnviadas.TabIndex = 22;
            this.lvVentasEnviadas.UseCompatibleStateImageBehavior = false;
            // 
            // txtVentaEnProceso
            // 
            this.txtVentaEnProceso.Location = new System.Drawing.Point(201, 53);
            this.txtVentaEnProceso.Name = "txtVentaEnProceso";
            this.txtVentaEnProceso.Size = new System.Drawing.Size(191, 23);
            this.txtVentaEnProceso.TabIndex = 23;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(425, 50);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 27);
            this.btnEnviar.TabIndex = 24;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "PRÓXIMO ENVÍO: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(229, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "ENVÍOS EN ESPERA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(257, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "ENVIADOS";
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "load.png");
            this.imgList.Images.SetKeyName(1, "check.png");
            // 
            // lvVentasEspera
            // 
            this.lvVentasEspera.HideSelection = false;
            this.lvVentasEspera.Location = new System.Drawing.Point(42, 135);
            this.lvVentasEspera.Name = "lvVentasEspera";
            this.lvVentasEspera.Size = new System.Drawing.Size(516, 170);
            this.lvVentasEspera.TabIndex = 28;
            this.lvVentasEspera.UseCompatibleStateImageBehavior = false;
            // 
            // FrmColaDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.lvVentasEspera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtVentaEnProceso);
            this.Controls.Add(this.lvVentasEnviadas);
            this.Controls.Add(this.btnCerrarColaVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FrmColaDeVentas";
            this.Text = "FrmColaDeVentas";
            this.Load += new System.EventHandler(this.FrmColaDeVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarColaVentas;
        private System.Windows.Forms.ListView lvVentasEnviadas;
        private System.Windows.Forms.TextBox txtVentaEnProceso;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ListView lvVentasEspera;
    }
}