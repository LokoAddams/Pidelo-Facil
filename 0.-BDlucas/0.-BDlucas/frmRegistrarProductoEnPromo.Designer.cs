namespace _0._BDlucas
{
    partial class frmRegistrarProductoEnPromo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarProductoEnPromo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProducto = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodNegocio = new System.Windows.Forms.Label();
            this.dgdProductos = new System.Windows.Forms.DataGridView();
            this.dgdProductosSelecionados = new System.Windows.Forms.DataGridView();
            this.lblCodPromo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdProductosSelecionados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista Productos Selecionados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo de Promocion Selecionada:";
            // 
            // btnAddProducto
            // 
            this.btnAddProducto.Location = new System.Drawing.Point(574, 198);
            this.btnAddProducto.Name = "btnAddProducto";
            this.btnAddProducto.Size = new System.Drawing.Size(193, 49);
            this.btnAddProducto.TabIndex = 6;
            this.btnAddProducto.Text = "Añadir Producto>>";
            this.btnAddProducto.UseVisualStyleBackColor = true;
            this.btnAddProducto.Click += new System.EventHandler(this.btnAddProducto_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(574, 253);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(193, 49);
            this.btnQuitarProducto.TabIndex = 7;
            this.btnQuitarProducto.Text = "<<Quitar Producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Negocio:";
            // 
            // lblCodNegocio
            // 
            this.lblCodNegocio.AutoSize = true;
            this.lblCodNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodNegocio.Location = new System.Drawing.Point(632, 1);
            this.lblCodNegocio.Name = "lblCodNegocio";
            this.lblCodNegocio.Size = new System.Drawing.Size(0, 37);
            this.lblCodNegocio.TabIndex = 9;
            // 
            // dgdProductos
            // 
            this.dgdProductos.AllowUserToAddRows = false;
            this.dgdProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdProductos.Location = new System.Drawing.Point(24, 66);
            this.dgdProductos.MultiSelect = false;
            this.dgdProductos.Name = "dgdProductos";
            this.dgdProductos.ReadOnly = true;
            this.dgdProductos.RowHeadersWidth = 62;
            this.dgdProductos.RowTemplate.Height = 28;
            this.dgdProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdProductos.Size = new System.Drawing.Size(509, 383);
            this.dgdProductos.TabIndex = 10;
            // 
            // dgdProductosSelecionados
            // 
            this.dgdProductosSelecionados.AllowUserToAddRows = false;
            this.dgdProductosSelecionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgdProductosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdProductosSelecionados.Location = new System.Drawing.Point(11, 66);
            this.dgdProductosSelecionados.MultiSelect = false;
            this.dgdProductosSelecionados.Name = "dgdProductosSelecionados";
            this.dgdProductosSelecionados.ReadOnly = true;
            this.dgdProductosSelecionados.RowHeadersWidth = 62;
            this.dgdProductosSelecionados.RowTemplate.Height = 28;
            this.dgdProductosSelecionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdProductosSelecionados.Size = new System.Drawing.Size(479, 383);
            this.dgdProductosSelecionados.TabIndex = 11;
            // 
            // lblCodPromo
            // 
            this.lblCodPromo.AutoSize = true;
            this.lblCodPromo.Location = new System.Drawing.Point(281, 18);
            this.lblCodPromo.Name = "lblCodPromo";
            this.lblCodPromo.Size = new System.Drawing.Size(0, 20);
            this.lblCodPromo.TabIndex = 12;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(574, 508);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(193, 49);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodPromo);
            this.groupBox1.Controls.Add(this.lblCodNegocio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 81);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgdProductos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(27, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 486);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(546, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 414);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgdProductosSelecionados);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(774, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 485);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // frmRegistrarProductoEnPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 708);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnAddProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarProductoEnPromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar productos en promo";
            this.Load += new System.EventHandler(this.frmRegistrarProductoEnPromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdProductosSelecionados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProducto;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCodNegocio;
        private System.Windows.Forms.DataGridView dgdProductos;
        private System.Windows.Forms.DataGridView dgdProductosSelecionados;
        private System.Windows.Forms.Label lblCodPromo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}