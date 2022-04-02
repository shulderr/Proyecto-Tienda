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
    public partial class Crud : Form
    {
        public int n = 0;
        public int m = 0;
        public string data = "";
        public bool Validacion = false;
        public Crud()
        {
            InitializeComponent();
        }

        private void bt_Tienda_Click(object sender, EventArgs e)
        {
            Tienda tienda = new Tienda();
            tienda.Show();
            this.Hide();
        }

        private void bt_CerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataG_Crud.RowCount; i++)
            {
                if (dataG_Crud.Rows[i].Cells[1].Value.ToString() == txt_Producto.Text)
                {
                    Validacion = true;
                }
            }

            if (Validacion == true)
            {
                MessageBox.Show("Ya Se Encuentra Registrado Ese Prooducto");
            }
            else
            {
                Conexion_db conexion = new Conexion_db();
                conexion.Abrir();
                if (txt_Codigo.Text == "" | txt_Producto.Text == "" | txt_Precio.Text == "" | txt_Stock.Text == "")
                {
                    MessageBox.Show("Ingrese Todos Los Campos");
                }
                else
                {
                    try
                    {
                        int Precio = Convert.ToInt32(txt_Precio.Text);
                        int Stock = Convert.ToInt32(txt_Stock.Text);
                        SqlCommand Query = new SqlCommand("INSERT INTO Producto VALUES('" + txt_Codigo.Text + "','" + txt_Producto.Text + "','" + Precio + "','" + Stock + "')", conexion.conx);
                        int r = Query.ExecuteNonQuery();
                        if (r > 0)
                        {
                            MessageBox.Show("Producto Guardado Exitosamente");
                            string query2 = "SELECT * FROM Producto";
                            SqlDataAdapter adaptador = new SqlDataAdapter(query2, conexion.conx);
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            dataG_Crud.DataSource = dt;
                            txt_Codigo.Text = "";
                            txt_Precio.Text = "";
                            txt_Producto.Text = "";
                            txt_Stock.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No Se Pudo Guardar El Producto");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Al Guardar Producto" + ex);
                    }
                }
                Validacion = false;
                conexion.Cerrar();
            }         
        }

        private void Crud_Load(object sender, EventArgs e)
        {
            Conexion_db conexion = new Conexion_db();
            conexion.Abrir();
            string query2 = "SELECT * FROM Producto";
            SqlDataAdapter adaptador = new SqlDataAdapter(query2, conexion.conx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataG_Crud.DataSource = dt;
            conexion.Cerrar();
        }

        private void dataG_Crud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m = e.RowIndex;
            if (m != -1)
            {
                txt_Codigo.Text = Convert.ToString(dataG_Crud.Rows[m].Cells[0].Value);
                txt_Producto.Text = Convert.ToString(dataG_Crud.Rows[m].Cells[1].Value);
                txt_Precio.Text = Convert.ToString(dataG_Crud.Rows[m].Cells[2].Value);
                txt_Stock.Text = Convert.ToString(dataG_Crud.Rows[m].Cells[3].Value);
#pragma warning disable CS8601 // Posible asignación de referencia nula
                data = Convert.ToString(dataG_Crud.Rows[m].Cells[1].Value);
#pragma warning restore CS8601 // Posible asignación de referencia nula
            }
        }

        private void bt_Editar_Click(object sender, EventArgs e)
        {
            Conexion_db conexion = new Conexion_db();
            conexion.Abrir();
            if (txt_Codigo.Text == "" | txt_Producto.Text == "" | txt_Precio.Text == "" | txt_Stock.Text == "")
            {
                MessageBox.Show("Seleccione El Producto a Modificar");
            }
            else
            {
                try
                {
                    string query = "UPDATE Producto SET Codigo ='" + txt_Codigo.Text + "', Nombre='" + txt_Producto.Text + "', Precio='" + txt_Precio.Text + "', Stock='" + txt_Stock.Text + "' WHERE Nombre = '" + data + "'";
                    SqlCommand comando = new SqlCommand(query, conexion.conx);
                    int r = comando.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Producto Modificado Exitosamente");
                        string query2 = "SELECT * FROM Producto";
                        SqlDataAdapter adaptador = new SqlDataAdapter(query2, conexion.conx);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        dataG_Crud.DataSource = dt;
                        txt_Codigo.Text = "";
                        txt_Precio.Text = "";
                        txt_Producto.Text = "";
                        txt_Stock.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No Se Pudo Modificar El Producto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Al Modificar Producto" + ex);
                }
            }
            conexion.Cerrar();
        }

        private void bt_Borrar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text == "" | txt_Producto.Text == "" | txt_Precio.Text == "" | txt_Stock.Text == "")
            {
                MessageBox.Show("Seleccione El Producto a Eliminar");
            }
            else
            {
                Conexion_db conexion = new Conexion_db();
                conexion.Abrir();
                try
                {
                    SqlCommand query = new SqlCommand("DELETE FROM Producto WHERE Nombre= '" + data + "'", conexion.conx);
                    query.ExecuteNonQuery();
                    MessageBox.Show("Producto Eliminado Exitosamente");
                    string query2 = "SELECT * FROM Producto";
                    SqlDataAdapter adaptador = new SqlDataAdapter(query2, conexion.conx);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataG_Crud.DataSource = dt;
                    txt_Codigo.Text = "";
                    txt_Precio.Text = "";
                    txt_Producto.Text = "";
                    txt_Stock.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Al Eliminar Producto" + ex);
                }
                Validacion = false;
                conexion.Cerrar();
            }         
        }

        private void lb_Limpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_Codigo.Text = "";
            txt_Precio.Text = "";
            txt_Producto.Text = "";
            txt_Stock.Text = "";
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Cbb_Selec.Text != "")
            {
                Conexion_db conexion = new Conexion_db();
                conexion.Abrir();
                try
                {
                    string query = "SELECT * FROM Producto WHERE " + Cbb_Selec.Text + " LIKE '%" + txt_Buscar.Text + "%'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.conx);
                    DataSet ds = new DataSet();
                    adaptador.Fill(ds, "Producto");
                    dataG_Crud.DataSource = ds;
                    dataG_Crud.DataMember = "Producto";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Al Buscar Producto" + ex);
                }
                conexion.Cerrar();
            }
        }

        private void bt_VerUsuarios_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            this.Close();
            registrarse.Show();
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Stock_KeyPress(object sender, KeyPressEventArgs e)
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
