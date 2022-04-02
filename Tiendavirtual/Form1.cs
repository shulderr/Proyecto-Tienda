namespace Tiendavirtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            string usuario = "Administrador";
            string Contrasena = "Admin";
            if (text_usuario.Text == "" | text_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos.");
            }
            else if (text_usuario.Text == usuario & text_contrasena.Text == Contrasena)
            {
                this.Hide();
                Form2 vista2 = new Form2();
                vista2.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos.");
            }
            text_usuario.Text = "";
            text_contrasena.Text = "";
        }
        private void bt_tienda_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form3 vista3 = new Form3();
            vista3.Show();*/
        }
    }
}