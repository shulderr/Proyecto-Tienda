namespace Tiendavirtual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.text_contrasena = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.lb_contrasena = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_tienda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lb_titulo);
            this.panel1.Controls.Add(this.bt_ingresar);
            this.panel1.Controls.Add(this.text_contrasena);
            this.panel1.Controls.Add(this.text_usuario);
            this.panel1.Controls.Add(this.lb_contrasena);
            this.panel1.Controls.Add(this.lb_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 478);
            this.panel1.TabIndex = 0;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.Location = new System.Drawing.Point(34, 69);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(212, 64);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Ingresar Como\r\nAdministrador.";
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_ingresar.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_ingresar.Location = new System.Drawing.Point(62, 379);
            this.bt_ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(143, 33);
            this.bt_ingresar.TabIndex = 5;
            this.bt_ingresar.Text = "INGRESAR";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // text_contrasena
            // 
            this.text_contrasena.Location = new System.Drawing.Point(34, 282);
            this.text_contrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_contrasena.Name = "text_contrasena";
            this.text_contrasena.Size = new System.Drawing.Size(213, 32);
            this.text_contrasena.TabIndex = 4;
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(34, 201);
            this.text_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(213, 32);
            this.text_usuario.TabIndex = 3;
            // 
            // lb_contrasena
            // 
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Location = new System.Drawing.Point(34, 249);
            this.lb_contrasena.Name = "lb_contrasena";
            this.lb_contrasena.Size = new System.Drawing.Size(106, 24);
            this.lb_contrasena.TabIndex = 2;
            this.lb_contrasena.Text = "Contraseña";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(34, 164);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(75, 24);
            this.lb_usuario.TabIndex = 1;
            this.lb_usuario.Text = "Usuario";
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.mensaje.Location = new System.Drawing.Point(354, 349);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(472, 27);
            this.mensaje.TabIndex = 1;
            this.mensaje.Text = "Bienvenidos a la tienda Tecnological Apliances S.A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(405, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bt_tienda
            // 
            this.bt_tienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_tienda.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_tienda.Location = new System.Drawing.Point(491, 379);
            this.bt_tienda.Name = "bt_tienda";
            this.bt_tienda.Size = new System.Drawing.Size(201, 34);
            this.bt_tienda.TabIndex = 3;
            this.bt_tienda.Text = "Ingresar a la tienda";
            this.bt_tienda.UseVisualStyleBackColor = false;
            this.bt_tienda.Click += new System.EventHandler(this.bt_tienda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(867, 478);
            this.Controls.Add(this.bt_tienda);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox text_usuario;
        private Label lb_contrasena;
        private Label lb_usuario;
        private Button bt_ingresar;
        private TextBox text_contrasena;
        private Label mensaje;
        private PictureBox pictureBox1;
        private Button bt_tienda;
        private Label lb_titulo;
    }
}