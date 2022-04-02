using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiendavirtual
{
    public partial class Form3 : Form
    {
        public int n = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ConexionDB connect = new ConexionDB();
            connect.Abrir();
            try
            {
                SqlCommand Query = new SqlCommand("SELECT Nombre FROM dbo.Producto", connect.conx);
                SqlDataReader rd = Query.ExecuteReader();

                while (rd.Read())
                {
                    Combox_productos.Items.Add(rd["Nombre"].ToString());
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox" + ex.ToString());
            }
            connect.Cerrar();           
        }

        private void Combox_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionDB connect = new ConexionDB();
            connect.Abrir();

            try
            {
                SqlCommand Query = new SqlCommand("SELECT * FROM dbo.Producto WHERE Nombre= '" + Combox_productos.Text + "'", connect.conx);
                SqlDataReader rd = Query.ExecuteReader();

                if (rd.Read() == true)
                {
                    txt_precio.Text = rd["Precio"].ToString();
                    txt_codigoprod.Text = rd["Codigo"].ToString();
                    txt_stock.Text = rd["Stock"].ToString();
                }

                txt_precio.Enabled = false;
                txt_codigoprod.Enabled = false;
                txt_stock.Enabled = false;

                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar los textbox" + ex.ToString());
            }
            connect.Cerrar();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if ((txt_cliente.Text == "") | (txt_cedula.Text == "") | (txt_cantidad.Text == "") | (txt_precio.Text == "") | (txt_codigoprod.Text == "") | (txt_stock.Text == "") | ((radioButton1.Checked == false) & (radioButton2.Checked == false)))
            {
                MessageBox.Show("ERROR!!, Verifique los datos.");
            }
            else
            {
                int n = dataGrid_compra.Rows.Add();

                dataGrid_compra.Rows[n].Cells[2].Value = txt_cantidad.Text;

                dataGrid_compra.Rows[n].Cells[0].Value = Combox_productos.Text;
                dataGrid_compra.Rows[n].Cells[1].Value = txt_codigoprod.Text;
                dataGrid_compra.Rows[n].Cells[3].Value = Convert.ToDouble(txt_precio.Text) * Convert.ToDouble(txt_cantidad.Text);

                txt_cantidad.Text = "";
                txt_codigoprod.Text = "";
                txt_precio.Text = "";
                txt_stock.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                Combox_productos.Text = "";
            }
        }

        private void dataGrid_compra_CellClick(object sender, DataGridViewCellEventArgs e) => n = e.RowIndex;

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
               dataGrid_compra.Rows.RemoveAt(n);
            }
        }

        private void bt_finalizarpedido_Click(object sender, EventArgs e)
        {

        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            Form2 vista2 = new Form2();
            this.Hide();
            vista2.Show();
        }
    }
}
