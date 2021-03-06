using System.Data.SqlClient;

namespace Proyecto_Tienda
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion_db conexion = new Conexion_db();
            conexion.Abrir();
            try
            {
                SqlCommand Query = new SqlCommand("SELECT Usuario,Contraseņa,Rol FROM dbo.Usuarios WHERE Usuario='" + txt_Usuario.Text + "' AND Contraseņa = '" + txt_Contraseņa.Text + "'", conexion.conx);
                SqlDataReader Reader = Query.ExecuteReader();
                if (Reader.Read())
                {
                    if (Reader["Rol"].ToString() == "1")
                    {
                        Crud crud = new Crud();
                        crud.Show();
                        this.Hide();
                        Reader.Close();
                    }
                    else if (Reader["Rol"].ToString() == "0")
                    {
                        Tienda tienda = new Tienda();
                        tienda.Show();
                        this.Hide();
                        Reader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseņa Incorrecto");
                    txt_Contraseņa.Text = "";
                    txt_Usuario.Text = "";
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