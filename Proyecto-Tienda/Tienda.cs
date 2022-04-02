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

namespace Proyecto_Tienda
{
    public partial class Tienda : Form
    {
        public int n = 0;
        public int conteo = 0;
        public int historial = 0;
        public double stock = 0;
        public string var = "";
        public Tienda()
        {
            InitializeComponent();
        }

        private void Tienda_Load(object sender, EventArgs e)
        {
            txt_Precio.Enabled = false;
            txt_Codigo.Enabled = false;
            txt_Stock.Enabled = false;
            Conexion_db connect = new Conexion_db();
            connect.Abrir();
            try
            {
                SqlCommand Query = new SqlCommand("SELECT Nombre FROM dbo.Producto", connect.conx);
                SqlDataReader rd = Query.ExecuteReader();

                while (rd.Read())
                {
                    Cbb_Productos.Items.Add(rd["Nombre"].ToString());
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox" + ex.ToString());
            }
            connect.Cerrar();
        }

        private void Cbb_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion_db connect = new Conexion_db();
            connect.Abrir();
            try
            {
                SqlCommand Query = new SqlCommand("SELECT * FROM dbo.Producto WHERE Nombre= '" + Cbb_Productos.Text + "'", connect.conx);
                SqlDataReader rd = Query.ExecuteReader();

                if (rd.Read() == true)
                {
                    txt_Precio.Text = rd["Precio"].ToString();
                    txt_Codigo.Text = rd["Codigo"].ToString();
                    txt_Stock.Text = rd["Stock"].ToString();
                }
                rd.Close();
                stock = Convert.ToInt32(txt_Stock.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar los textbox" + ex.ToString());
            }
            connect.Cerrar();
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            if ((txt_Cliente.Text == "") | (txt_Cedula.Text == "") | (txt_Cantidad.Text == "") | (txt_Precio.Text == "") | (txt_Codigo.Text == "") | (txt_Stock.Text == ""))
            {
                MessageBox.Show("ERROR!!, Verifique los datos.");
            }
            else
            {
                if (Convert.ToInt32(txt_Stock.Text) < 1)
                {
                    MessageBox.Show("No Se Encuentran Existencias De Ese Producto");
                }
                else if (Convert.ToInt16(txt_Cantidad.Text) > Convert.ToInt32(txt_Stock.Text))
                {
                    MessageBox.Show("No Hay unidades suficientes");
                }
                else
                {
                    int n = dataG_Tienda.Rows.Add();
                    dataG_Tienda.Rows[n].Cells[2].Value = txt_Cantidad.Text;
                    dataG_Tienda.Rows[n].Cells[1].Value = Cbb_Productos.Text;
                    dataG_Tienda.Rows[n].Cells[0].Value = txt_Codigo.Text;
                    dataG_Tienda.Rows[n].Cells[3].Value = Convert.ToDouble(txt_Precio.Text) * Convert.ToDouble(txt_Cantidad.Text);
                    stock = Convert.ToInt32(txt_Stock.Text) - Convert.ToInt32(txt_Cantidad.Text);
                    string var = txt_Codigo.Text;
                    txt_Cantidad.Text = "";
                    txt_Codigo.Text = "";
                    txt_Precio.Text = "";
                    txt_Stock.Text = "";
                    Cbb_Productos.Text = "";
                    conteo++;
                    try
                    {
                        Conexion_db conexion = new Conexion_db();
                        conexion.Abrir();
                        string query = "UPDATE Producto SET Stock ='" + stock + "' WHERE Codigo ='" + var + "'";
                        SqlCommand comando = new SqlCommand(query, conexion.conx);
                        comando.ExecuteNonQuery();
                        conexion.Cerrar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error al adaptar el stock" + ex);
                    }
                }
                stock = 0;
            }
        }

        private void dataG_Tienda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                try
                {
#pragma warning disable CS8601 // Posible asignación de referencia nula
                    var = Convert.ToString(dataG_Tienda.Rows[n].Cells[0].Value);
#pragma warning restore CS8601 // Posible asignación de referencia nula
                    Conexion_db conexion = new Conexion_db();
                    conexion.Abrir();
                    SqlCommand Query = new SqlCommand("SELECT Stock FROM dbo.Producto WHERE Codigo='" + var + "'", conexion.conx);
                    SqlDataReader Reader = Query.ExecuteReader();
                    if (Reader.Read())
                    {
                        stock = Convert.ToInt32(Reader["Stock"].ToString());
                    }
                    conexion.Cerrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (n != -1)
                {
                    stock += Convert.ToInt32(dataG_Tienda.Rows[n].Cells[2].Value);
                    try
                    {
                        Conexion_db conexion = new Conexion_db();
                        conexion.Abrir();
                        string query = "UPDATE Producto SET Stock ='" + stock + "' WHERE Codigo ='" + var + "'";
                        SqlCommand comando = new SqlCommand(query, conexion.conx);
                        comando.ExecuteNonQuery();
                        conexion.Cerrar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error al sumar stock" + ex);
                    }
                    dataG_Tienda.Rows.RemoveAt(n);
                    txt_Cantidad.Text = "";
                    txt_Codigo.Text = "";
                    txt_Precio.Text = "";
                    txt_Stock.Text = "";
                    Cbb_Productos.Text = "";
                }
                conteo--;
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar el elmento seleccionado");
            }
        }

        private void bt_FinalizarPedido_Click(object sender, EventArgs e)
        {
            if (txt_Cliente.Text == "" | txt_Cedula.Text == "")
            {
                MessageBox.Show("Faltan Datos Del Cliente");
            }
            else
            {
                int total_final = 0;
                for (int i = 0; i < conteo; i++)
                {
                    total_final += Convert.ToInt32(dataG_Tienda.Rows[i].Cells[3].Value);
                }
                if (total_final == 0)
                {
                    MessageBox.Show("Agregue Algun Producto Antes De Finalizar");
                }
                else
                {
                    Conexion_db conexion = new Conexion_db();
                    conexion.Abrir();
                    string id_ultima = "SELECT distinct TOP 1 (Numero) FROM dbo.Factura ORDER BY Numero DESC";
                    SqlCommand ejecutar = new SqlCommand(id_ultima, conexion.conx);
                    SqlDataReader leer = ejecutar.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        historial = Convert.ToInt32(leer["Numero"].ToString());
                        historial++;
                    }
                    conexion.Cerrar();
                    Fact.Nro_Factura = historial;
                    Fact.fecha = DateTime.Now.ToShortDateString();
                    Fact.hora = DateTime.Now.ToString("hh:mm:ss");
                    Fact.Total = total_final;
                    Fact.CLiente = txt_Cliente.Text;
                    Fact.Cedula = txt_Cedula.Text;
                    Factura factura = new Factura();
                    factura.Show();
                    this.Close();
                }
            }
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void txt_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
