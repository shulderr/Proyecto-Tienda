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
            if (text_usuario.Text == "" | text_contrasena.Text == "")
            {
                MessageBox.Show("Ingrese los campos requeridos.");
            }
            text_contrasena.Text = "";
            text_contrasena.Text = "";
        }

        private void bt_tienda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 vista2 = new Form2();
            Form2.Show();
            
            Form1.Close();
            Form2.Hide();
        }
    }
}

