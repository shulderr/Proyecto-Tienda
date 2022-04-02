namespace Proyecto_Tienda
{
    partial class Registrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrarse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Regresar = new System.Windows.Forms.Button();
            this.bt_Tienda = new System.Windows.Forms.Button();
            this.bt_CerrarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NuevoUsuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_ConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rdb_Empleado = new System.Windows.Forms.RadioButton();
            this.Rdb_Administrador = new System.Windows.Forms.RadioButton();
            this.bt_Registrarse = new System.Windows.Forms.Button();
            this.bt_Borrar = new System.Windows.Forms.Button();
            this.bt_Editar = new System.Windows.Forms.Button();
            this.dataG_Usuarios = new System.Windows.Forms.DataGridView();
            this.lb_Limpiar = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bt_Regresar);
            this.panel1.Controls.Add(this.bt_Tienda);
            this.panel1.Controls.Add(this.bt_CerrarSesion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 66);
            this.panel1.TabIndex = 0;
            // 
            // bt_Regresar
            // 
            this.bt_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bt_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Regresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bt_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Regresar.Image = global::Proyecto_Tienda.Properties.Resources.atras;
            this.bt_Regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Regresar.Location = new System.Drawing.Point(363, 20);
            this.bt_Regresar.Name = "bt_Regresar";
            this.bt_Regresar.Size = new System.Drawing.Size(87, 33);
            this.bt_Regresar.TabIndex = 19;
            this.bt_Regresar.Text = "Regresar";
            this.bt_Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Regresar.UseVisualStyleBackColor = false;
            this.bt_Regresar.Click += new System.EventHandler(this.bt_Regresar_Click);
            // 
            // bt_Tienda
            // 
            this.bt_Tienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bt_Tienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Tienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Tienda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bt_Tienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Tienda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Tienda.Image = global::Proyecto_Tienda.Properties.Resources.tienda;
            this.bt_Tienda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Tienda.Location = new System.Drawing.Point(586, 17);
            this.bt_Tienda.Name = "bt_Tienda";
            this.bt_Tienda.Size = new System.Drawing.Size(75, 37);
            this.bt_Tienda.TabIndex = 18;
            this.bt_Tienda.Text = "Tienda";
            this.bt_Tienda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Tienda.UseVisualStyleBackColor = false;
            this.bt_Tienda.Click += new System.EventHandler(this.bt_Tienda_Click);
            // 
            // bt_CerrarSesion
            // 
            this.bt_CerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bt_CerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_CerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bt_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_CerrarSesion.Image = global::Proyecto_Tienda.Properties.Resources.cerrar_sesion;
            this.bt_CerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_CerrarSesion.Location = new System.Drawing.Point(463, 19);
            this.bt_CerrarSesion.Name = "bt_CerrarSesion";
            this.bt_CerrarSesion.Size = new System.Drawing.Size(109, 33);
            this.bt_CerrarSesion.TabIndex = 9;
            this.bt_CerrarSesion.Text = "Cerrar Sesion";
            this.bt_CerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_CerrarSesion.UseVisualStyleBackColor = false;
            this.bt_CerrarSesion.Click += new System.EventHandler(this.bt_CerrarSesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(87, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tecnological Apliances SA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(417, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(417, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(417, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // txt_NuevoUsuario
            // 
            this.txt_NuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_NuevoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_NuevoUsuario.Location = new System.Drawing.Point(417, 118);
            this.txt_NuevoUsuario.Name = "txt_NuevoUsuario";
            this.txt_NuevoUsuario.Size = new System.Drawing.Size(206, 23);
            this.txt_NuevoUsuario.TabIndex = 4;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Contraseña.Location = new System.Drawing.Point(417, 171);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(206, 23);
            this.txt_Contraseña.TabIndex = 5;
            // 
            // txt_ConfirmarContraseña
            // 
            this.txt_ConfirmarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_ConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ConfirmarContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_ConfirmarContraseña.Location = new System.Drawing.Point(417, 226);
            this.txt_ConfirmarContraseña.Name = "txt_ConfirmarContraseña";
            this.txt_ConfirmarContraseña.Size = new System.Drawing.Size(206, 23);
            this.txt_ConfirmarContraseña.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rdb_Empleado);
            this.groupBox1.Controls.Add(this.Rdb_Administrador);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(421, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "        Rol Del Nuevo Usuario";
            // 
            // Rdb_Empleado
            // 
            this.Rdb_Empleado.AutoSize = true;
            this.Rdb_Empleado.Location = new System.Drawing.Point(35, 64);
            this.Rdb_Empleado.Name = "Rdb_Empleado";
            this.Rdb_Empleado.Size = new System.Drawing.Size(78, 19);
            this.Rdb_Empleado.TabIndex = 1;
            this.Rdb_Empleado.TabStop = true;
            this.Rdb_Empleado.Text = "Empleado";
            this.Rdb_Empleado.UseVisualStyleBackColor = true;
            // 
            // Rdb_Administrador
            // 
            this.Rdb_Administrador.AutoSize = true;
            this.Rdb_Administrador.Location = new System.Drawing.Point(35, 31);
            this.Rdb_Administrador.Name = "Rdb_Administrador";
            this.Rdb_Administrador.Size = new System.Drawing.Size(101, 19);
            this.Rdb_Administrador.TabIndex = 0;
            this.Rdb_Administrador.TabStop = true;
            this.Rdb_Administrador.Text = "Administrador";
            this.Rdb_Administrador.UseVisualStyleBackColor = true;
            // 
            // bt_Registrarse
            // 
            this.bt_Registrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bt_Registrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Registrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Registrarse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bt_Registrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bt_Registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Registrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Registrarse.Image = global::Proyecto_Tienda.Properties.Resources.Registrarse;
            this.bt_Registrarse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Registrarse.Location = new System.Drawing.Point(51, 371);
            this.bt_Registrarse.Name = "bt_Registrarse";
            this.bt_Registrarse.Size = new System.Drawing.Size(87, 33);
            this.bt_Registrarse.TabIndex = 8;
            this.bt_Registrarse.Text = "Registrar";
            this.bt_Registrarse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Registrarse.UseVisualStyleBackColor = false;
            this.bt_Registrarse.Click += new System.EventHandler(this.bt_Registrarse_Click);
            // 
            // bt_Borrar
            // 
            this.bt_Borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bt_Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Borrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bt_Borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bt_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Borrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Borrar.Image = global::Proyecto_Tienda.Properties.Resources.borrar;
            this.bt_Borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Borrar.Location = new System.Drawing.Point(287, 369);
            this.bt_Borrar.Name = "bt_Borrar";
            this.bt_Borrar.Size = new System.Drawing.Size(71, 37);
            this.bt_Borrar.TabIndex = 18;
            this.bt_Borrar.Text = "Borrar";
            this.bt_Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Borrar.UseVisualStyleBackColor = false;
            this.bt_Borrar.Click += new System.EventHandler(this.bt_Borrar_Click);
            // 
            // bt_Editar
            // 
            this.bt_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bt_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bt_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bt_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_Editar.Image = global::Proyecto_Tienda.Properties.Resources.editar;
            this.bt_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Editar.Location = new System.Drawing.Point(171, 367);
            this.bt_Editar.Name = "bt_Editar";
            this.bt_Editar.Size = new System.Drawing.Size(75, 37);
            this.bt_Editar.TabIndex = 17;
            this.bt_Editar.Text = "Editar";
            this.bt_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Editar.UseVisualStyleBackColor = false;
            this.bt_Editar.Click += new System.EventHandler(this.bt_Editar_Click);
            // 
            // dataG_Usuarios
            // 
            this.dataG_Usuarios.AllowUserToAddRows = false;
            this.dataG_Usuarios.AllowUserToDeleteRows = false;
            this.dataG_Usuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dataG_Usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataG_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataG_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataG_Usuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataG_Usuarios.EnableHeadersVisualStyles = false;
            this.dataG_Usuarios.Location = new System.Drawing.Point(51, 113);
            this.dataG_Usuarios.Name = "dataG_Usuarios";
            this.dataG_Usuarios.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataG_Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataG_Usuarios.RowHeadersVisible = false;
            this.dataG_Usuarios.RowTemplate.Height = 25;
            this.dataG_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataG_Usuarios.Size = new System.Drawing.Size(307, 230);
            this.dataG_Usuarios.TabIndex = 15;
            this.dataG_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataG_Usuarios_CellClick);
            // 
            // lb_Limpiar
            // 
            this.lb_Limpiar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lb_Limpiar.AutoSize = true;
            this.lb_Limpiar.ForeColor = System.Drawing.Color.White;
            this.lb_Limpiar.LinkColor = System.Drawing.Color.White;
            this.lb_Limpiar.Location = new System.Drawing.Point(497, 378);
            this.lb_Limpiar.Name = "lb_Limpiar";
            this.lb_Limpiar.Size = new System.Drawing.Size(47, 15);
            this.lb_Limpiar.TabIndex = 19;
            this.lb_Limpiar.TabStop = true;
            this.lb_Limpiar.Text = "Limpiar";
            this.lb_Limpiar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lb_Limpiar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_Limpiar_LinkClicked);
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.lb_Limpiar);
            this.Controls.Add(this.bt_Borrar);
            this.Controls.Add(this.bt_Editar);
            this.Controls.Add(this.dataG_Usuarios);
            this.Controls.Add(this.bt_Registrarse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_ConfirmarContraseña);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_NuevoUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Registrarse";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txt_NuevoUsuario;
        private TextBox txt_Contraseña;
        private TextBox txt_ConfirmarContraseña;
        private GroupBox groupBox1;
        private RadioButton Rdb_Empleado;
        private RadioButton Rdb_Administrador;
        private Button bt_Registrarse;
        private Button bt_CerrarSesion;
        private Button bt_Borrar;
        private Button bt_Editar;
        private DataGridView dataG_Usuarios;
        private Button bt_Tienda;
        private Button bt_Regresar;
        private LinkLabel lb_Limpiar;
    }
}