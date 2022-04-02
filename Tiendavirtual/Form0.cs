using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //Libreria para colores
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tiendavirtual
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }
        private void bt_ingresar2_Click(object sender, EventArgs e)
        {
            ConexionDB conexion = new ConexionDB();
            conexion.Abrir();
            try
            {
                SqlCommand Query = new SqlCommand("SELECT Usuario,Contraseña FROM Administradores WHERE Usuario='" + text_usuario2.Text + "' AND Contraseña = '" + text_contrasena2.Text + "'", conexion.conx);
                SqlDataReader Reader = Query.ExecuteReader();
                if (Reader.Read())
                {
                    CambioLb.Adminitradores = text_usuario2.Text;
                    this.Hide();
                    Form2 vista2 = new Form2();
                    vista2.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta");
                    text_usuario2.Text = "";
                    text_contrasena2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }   
            conexion.Cerrar();
        }
    }
}