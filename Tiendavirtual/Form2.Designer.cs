namespace Tiendavirtual
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_producto = new System.Windows.Forms.Label();
            this.text_producto = new System.Windows.Forms.TextBox();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.lb_precio = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.text_stock = new System.Windows.Forms.TextBox();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.text_codigo = new System.Windows.Forms.TextBox();
            this.bt_agregar2 = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_eliminar2 = new System.Windows.Forms.Button();
            this.bt_tienda2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.lb_info = new System.Windows.Forms.Label();
            this.lb_Admin = new System.Windows.Forms.Label();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.cmb_Selec = new System.Windows.Forms.ComboBox();
            this.text_selec = new System.Windows.Forms.TextBox();
            this.lb_nom = new System.Windows.Forms.Label();
            this.lb_selec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(250, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            // 
            // lb_producto
            // 
            this.lb_producto.AutoSize = true;
            this.lb_producto.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_producto.Location = new System.Drawing.Point(31, 14);
            this.lb_producto.Name = "lb_producto";
            this.lb_producto.Size = new System.Drawing.Size(104, 29);
            this.lb_producto.TabIndex = 1;
            this.lb_producto.Text = "Producto";
            // 
            // text_producto
            // 
            this.text_producto.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.text_producto.Location = new System.Drawing.Point(138, 14);
            this.text_producto.Name = "text_producto";
            this.text_producto.Size = new System.Drawing.Size(238, 37);
            this.text_producto.TabIndex = 2;
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_codigo.Location = new System.Drawing.Point(31, 62);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(83, 29);
            this.lb_codigo.TabIndex = 3;
            this.lb_codigo.Text = "Codigo";
            // 
            // lb_precio
            // 
            this.lb_precio.AutoSize = true;
            this.lb_precio.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_precio.Location = new System.Drawing.Point(31, 114);
            this.lb_precio.Name = "lb_precio";
            this.lb_precio.Size = new System.Drawing.Size(75, 29);
            this.lb_precio.TabIndex = 4;
            this.lb_precio.Text = "Precio";
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_stock.Location = new System.Drawing.Point(31, 166);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(67, 29);
            this.lb_stock.TabIndex = 5;
            this.lb_stock.Text = "Stock";
            // 
            // text_stock
            // 
            this.text_stock.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.text_stock.Location = new System.Drawing.Point(138, 170);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(238, 37);
            this.text_stock.TabIndex = 6;
            // 
            // text_precio
            // 
            this.text_precio.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.text_precio.Location = new System.Drawing.Point(138, 118);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(238, 37);
            this.text_precio.TabIndex = 7;
            // 
            // text_codigo
            // 
            this.text_codigo.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.text_codigo.Location = new System.Drawing.Point(138, 66);
            this.text_codigo.Name = "text_codigo";
            this.text_codigo.Size = new System.Drawing.Size(238, 37);
            this.text_codigo.TabIndex = 8;
            // 
            // bt_agregar2
            // 
            this.bt_agregar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_agregar2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bt_agregar2.Location = new System.Drawing.Point(382, 14);
            this.bt_agregar2.Name = "bt_agregar2";
            this.bt_agregar2.Size = new System.Drawing.Size(112, 37);
            this.bt_agregar2.TabIndex = 9;
            this.bt_agregar2.Text = "Agregar";
            this.bt_agregar2.UseVisualStyleBackColor = false;
            this.bt_agregar2.Click += new System.EventHandler(this.bt_agregar2_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_editar.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bt_editar.Location = new System.Drawing.Point(382, 66);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(112, 37);
            this.bt_editar.TabIndex = 10;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            // 
            // bt_eliminar2
            // 
            this.bt_eliminar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_eliminar2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bt_eliminar2.Location = new System.Drawing.Point(382, 118);
            this.bt_eliminar2.Name = "bt_eliminar2";
            this.bt_eliminar2.Size = new System.Drawing.Size(112, 37);
            this.bt_eliminar2.TabIndex = 11;
            this.bt_eliminar2.Text = "Eliminar";
            this.bt_eliminar2.UseVisualStyleBackColor = false;
            // 
            // bt_tienda2
            // 
            this.bt_tienda2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_tienda2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_tienda2.Location = new System.Drawing.Point(705, 464);
            this.bt_tienda2.Name = "bt_tienda2";
            this.bt_tienda2.Size = new System.Drawing.Size(132, 44);
            this.bt_tienda2.TabIndex = 13;
            this.bt_tienda2.Text = "Ir a tienda";
            this.bt_tienda2.UseVisualStyleBackColor = false;
            this.bt_tienda2.Click += new System.EventHandler(this.bt_tienda2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Precio,
            this.Stock});
            this.dataGridView1.Location = new System.Drawing.Point(31, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(668, 255);
            this.dataGridView1.TabIndex = 14;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 8;
            this.Producto.Name = "Producto";
            this.Producto.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.Width = 150;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 8;
            this.Stock.Name = "Stock";
            this.Stock.Width = 150;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(708, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_cerrar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_cerrar.Location = new System.Drawing.Point(708, 406);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(129, 42);
            this.bt_cerrar.TabIndex = 16;
            this.bt_cerrar.Text = "Cerrar Sesion\r\n";
            this.bt_cerrar.UseVisualStyleBackColor = false;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_info.Location = new System.Drawing.Point(620, 42);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(217, 70);
            this.lb_info.TabIndex = 17;
            this.lb_info.Text = "Ingresaste Como \r\n  Administrador.";
            // 
            // lb_Admin
            // 
            this.lb_Admin.AutoSize = true;
            this.lb_Admin.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_Admin.Location = new System.Drawing.Point(620, 7);
            this.lb_Admin.Name = "lb_Admin";
            this.lb_Admin.Size = new System.Drawing.Size(135, 35);
            this.lb_Admin.TabIndex = 18;
            this.lb_Admin.Text = "XXXXXXXX";
            // 
            // bt_consultar
            // 
            this.bt_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_consultar.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bt_consultar.Location = new System.Drawing.Point(382, 170);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(121, 37);
            this.bt_consultar.TabIndex = 19;
            this.bt_consultar.Text = "Consultar";
            this.bt_consultar.UseVisualStyleBackColor = false;
            // 
            // cmb_Selec
            // 
            this.cmb_Selec.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cmb_Selec.FormattingEnabled = true;
            this.cmb_Selec.Items.AddRange(new object[] {
            "Codigo",
            "Producto",
            "Precio",
            "Stock"});
            this.cmb_Selec.Location = new System.Drawing.Point(509, 171);
            this.cmb_Selec.Name = "cmb_Selec";
            this.cmb_Selec.Size = new System.Drawing.Size(165, 37);
            this.cmb_Selec.TabIndex = 20;
            this.cmb_Selec.SelectedIndexChanged += new System.EventHandler(this.cmb_Selec_SelectedIndexChanged);
            // 
            // text_selec
            // 
            this.text_selec.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.text_selec.Location = new System.Drawing.Point(680, 171);
            this.text_selec.Name = "text_selec";
            this.text_selec.Size = new System.Drawing.Size(157, 37);
            this.text_selec.TabIndex = 21;
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_nom.Location = new System.Drawing.Point(579, 139);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(109, 29);
            this.lb_nom.TabIndex = 22;
            this.lb_nom.Text = "Ingrese el";
            // 
            // lb_selec
            // 
            this.lb_selec.AutoSize = true;
            this.lb_selec.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_selec.Location = new System.Drawing.Point(680, 139);
            this.lb_selec.Name = "lb_selec";
            this.lb_selec.Size = new System.Drawing.Size(78, 29);
            this.lb_selec.TabIndex = 23;
            this.lb_selec.Text = "XXXXX";
            this.lb_selec.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(858, 533);
            this.Controls.Add(this.lb_selec);
            this.Controls.Add(this.lb_nom);
            this.Controls.Add(this.text_selec);
            this.Controls.Add(this.cmb_Selec);
            this.Controls.Add(this.bt_consultar);
            this.Controls.Add(this.lb_Admin);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.bt_cerrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_tienda2);
            this.Controls.Add(this.bt_eliminar2);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_agregar2);
            this.Controls.Add(this.text_codigo);
            this.Controls.Add(this.text_precio);
            this.Controls.Add(this.text_stock);
            this.Controls.Add(this.lb_stock);
            this.Controls.Add(this.lb_precio);
            this.Controls.Add(this.lb_codigo);
            this.Controls.Add(this.text_producto);
            this.Controls.Add(this.lb_producto);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lb_producto;
        private TextBox text_producto;
        private Label lb_codigo;
        private Label lb_precio;
        private Label lb_stock;
        private TextBox text_stock;
        private TextBox text_precio;
        private TextBox text_codigo;
        private Button bt_agregar2;
        private Button bt_editar;
        private Button bt_eliminar2;
        private Button bt_tienda2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Button bt_cerrar;
        private Label lb_info;
        private Label lb_Admin;
        private Button bt_consultar;
        private ComboBox cmb_Selec;
        private TextBox text_selec;
        private Label lb_nom;
        private Label lb_selec;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
    }
}