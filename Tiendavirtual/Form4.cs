using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tiendavirtual
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
<<<<<<< HEAD:Tiendavirtual/Form2.cs
        private void bt_tienda2_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form3 vista3 = new Form3();
            vista3.Show();*/
        }
        private void bt_agregar2_Click(object sender, EventArgs e)
        {
            if (text_producto.Text == "" | text_codigo.Text == "" | text_precio.Text == "" | text_stock.Text == "")
            {
                MessageBox.Show("ERROR !!!! Verifique Los Datos.");
            }
            else
            {
                int a = dataGridView1.Rows.Add();
                dataGridView1.Rows[a].Cells[0].Value = text_producto.Text;
                dataGridView1.Rows[a].Cells[1].Value = text_codigo.Text;
                dataGridView1.Rows[a].Cells[2].Value = text_precio.Text;
                dataGridView1.Rows[a].Cells[3].Value = text_stock.Text;

                text_producto.Text = ("");
                text_codigo.Text = ("");
                text_precio.Text = ("");
                text_stock.Text = ("");
            }
        }
        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 vista1 = new Form1();
            vista1.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lb_Admin.Text = CambioLb.Adminitradores;
        }

        private void cmb_Selec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cambio = cmb_Selec.SelectedIndex;
            lb_selec.Text = cmb_Selec.Items[cambio].ToString();
            lb_selec.Visible = true;
=======

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

>>>>>>> 84d55bfe8816ccea63b113565e1cf5e2416871fc:Tiendavirtual/Form4.cs
        }
    }
}