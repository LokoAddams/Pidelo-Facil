namespace _0._BDlucas
{
    partial class frmRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarProducto));
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.tbxCantStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(368, 363);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(220, 26);
            this.tbxDescripcion.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Descripcion:";
            // 
            // tbxCategoria
            // 
            this.tbxCategoria.Location = new System.Drawing.Point(368, 324);
            this.tbxCategoria.Name = "tbxCategoria";
            this.tbxCategoria.Size = new System.Drawing.Size(220, 26);
            this.tbxCategoria.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Categoria:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(625, 324);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 70);
            this.btnRegistrar.TabIndex = 32;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(368, 283);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(220, 26);
            this.txbNombre.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre:";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(368, 410);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(220, 26);
            this.tbxPrecio.TabIndex = 38;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(274, 410);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 20);
            this.label.TabIndex = 37;
            this.label.Text = "Precio:";
            // 
            // tbxCantStock
            // 
            this.tbxCantStock.Location = new System.Drawing.Point(368, 456);
            this.tbxCantStock.Name = "tbxCantStock";
            this.tbxCantStock.Size = new System.Drawing.Size(220, 26);
            this.tbxCantStock.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Cant Stock:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::_0._BDlucas.Properties.Resources.pedidosYafondo;
            this.pictureBox2.Location = new System.Drawing.Point(253, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 236);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // frmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 551);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbxCantStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar nuevo Producto";
            this.Load += new System.EventHandler(this.frmRegistrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbxCantStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}