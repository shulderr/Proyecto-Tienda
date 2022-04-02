namespace Tiendavirtual
{
    partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_usuario1 = new System.Windows.Forms.Label();
            this.lb_contrasena2 = new System.Windows.Forms.Label();
            this.text_usuario2 = new System.Windows.Forms.TextBox();
            this.text_contrasena2 = new System.Windows.Forms.TextBox();
            this.bt_ingresar2 = new System.Windows.Forms.Button();
            this.mensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lb_usuario1
            // 
            this.lb_usuario1.AutoSize = true;
            this.lb_usuario1.Location = new System.Drawing.Point(288, 234);
            this.lb_usuario1.Name = "lb_usuario1";
            this.lb_usuario1.Size = new System.Drawing.Size(72, 25);
            this.lb_usuario1.TabIndex = 4;
            this.lb_usuario1.Text = "Usuario";
            // 
            // lb_contrasena2
            // 
            this.lb_contrasena2.AutoSize = true;
            this.lb_contrasena2.Location = new System.Drawing.Point(288, 304);
            this.lb_contrasena2.Name = "lb_contrasena2";
            this.lb_contrasena2.Size = new System.Drawing.Size(101, 25);
            this.lb_contrasena2.TabIndex = 5;
            this.lb_contrasena2.Text = "Contraseña";
            // 
            // text_usuario2
            // 
            this.text_usuario2.Location = new System.Drawing.Point(288, 262);
            this.text_usuario2.Name = "text_usuario2";
            this.text_usuario2.Size = new System.Drawing.Size(180, 31);
            this.text_usuario2.TabIndex = 6;
            // 
            // text_contrasena2
            // 
            this.text_contrasena2.Location = new System.Drawing.Point(288, 332);
            this.text_contrasena2.Name = "text_contrasena2";
            this.text_contrasena2.Size = new System.Drawing.Size(180, 31);
            this.text_contrasena2.TabIndex = 7;
            // 
            // bt_ingresar2
            // 
            this.bt_ingresar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_ingresar2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_ingresar2.Location = new System.Drawing.Point(319, 378);
            this.bt_ingresar2.Name = "bt_ingresar2";
            this.bt_ingresar2.Size = new System.Drawing.Size(112, 34);
            this.bt_ingresar2.TabIndex = 8;
            this.bt_ingresar2.Text = "Ingresar";
            this.bt_ingresar2.UseVisualStyleBackColor = false;
            this.bt_ingresar2.Click += new System.EventHandler(this.bt_ingresar2_Click);
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.mensaje.Location = new System.Drawing.Point(147, 199);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(472, 27);
            this.mensaje.TabIndex = 9;
            this.mensaje.Text = "Bienvenidos a la tienda Tecnological Apliances S.A";
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.bt_ingresar2);
            this.Controls.Add(this.text_contrasena2);
            this.Controls.Add(this.text_usuario2);
            this.Controls.Add(this.lb_contrasena2);
            this.Controls.Add(this.lb_usuario1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_usuario1;
        private Label lb_contrasena2;
        private TextBox text_usuario2;
        private TextBox text_contrasena2;
        private Button bt_ingresar2;
        private Label mensaje;
    }
}