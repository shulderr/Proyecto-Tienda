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
    public partial class Registrarse : Form
    {
        public int n = 0;
        public int Variable = 0;
        public bool Validacion = false;
        public string data = "";
        public Registrarse()
        {
            InitializeComponent();
        }

        private void bt_Registrarse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataG_Usuarios.RowCount; i++)
            {
                if (dataG_Usuarios.Rows[i].Cells[0].Value.ToString() == txt_NuevoUsuario.Text)
                {
                    Validacion = true;
                }
            }

            if (Validacion == true)
            {
                MessageBox.Show("Ya Se Encuentra Un Usuario Registrado Con El Mismo Nombre");
            }
            else
            {
                Conexion_db conexion = new Conexion_db();
                conexion.Abrir();
                if (txt_NuevoUsuario.Text == "" | txt_Contraseña.Text == "" | txt_ConfirmarContraseña.Text == "" | (Rdb_Empleado.Checked == false & Rdb_Administrador.Checked == false))
                {
                    MessageBox.Show("Ingrese Todos Los Campos Solicitados");
                }
                else
                {
                    if (txt_Contraseña.Text == txt_ConfirmarContraseña.Text)
                    {
                        if (Rdb_Administrador.Checked == true)
                        {
                            Variable = 1;
                            SqlCommand Query = new SqlCommand("INSERT INTO Usuarios VALUES('" + txt_NuevoUsuario.Text + "','" + txt_Contraseña.Text + "','" + Variable + "')", conexion.conx);
                            int r = Query.ExecuteNonQuery();
                            if (r > 0)
                            {
                                MessageBox.Show("Usuario Guardado Exitosamente");
                                string query2 = "SELECT * FROM Usuarios";
                                SqlDataAdapter adaptador = new SqlDataAdapter(query2, conexion.conx);
                                DataTable dt = new DataTable();
                                adaptador.Fill(dt);
                                dataG_Usuarios.DataSource = dt;
                                txt_NuevoUsuario.Text = "";
                                txt_Contraseña.Text = "";
                                txt_ConfirmarContraseña.Text = "";
                                Rdb_Administrador.Checked = false;
                                Rdb_Empleado.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No Se Guardo El Nuevo Usuario");
                            }
                        }
                        else if (Rdb_Empleado.Checked == true)
                        {
                            Variable = 0;
                            SqlCommand Query = new SqlCommand("INSERT INTO Usuarios VALUES('" + txt_NuevoUsuario.Text + "','" + txt_Contraseña.Text + "','" + Variable + "')", conexion.conx);
                            int r = Query.ExecuteNonQuery();
                            if (r > 0)
                            {
                                MessageBox.Show("Usuario Guardado Exitosamente");
                                txt_NuevoUsuario.Text = "";
                                txt_Contraseña.Text = "";
                                txt_ConfirmarContraseña.Text = "";
                                Rdb_Administrador.Checked = false;
                                Rdb_Empleado.Checked = false;
                            }
                            else
                            {
                                MessageBox.Show("No Se Guardo El Nuevo Usuario");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las Contraseñas Ingresadas No Coinciden");
                    }
                }
                conexion.Cerrar();
                Validacion = false;
            }          
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            Conexion_db conexion = new Conexion_db();
            conexion.Abrir();
            string query2 = "SELECT * FROM Usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(query2, conexion.conx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataG_Usuarios.DataSource = dt;
            conexion.Cerrar();
        }

        private void dataG_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                txt_NuevoUsuario.Text = Convert.ToString(dataG_Usuarios.Rows[n].Cells[0].Value);
                txt_Contraseña.Text = Convert.ToString(dataG_Usuarios.Rows[n].Cells[1].Value);
#pragma warning disable CS8601 // Posible asignación de referencia nula
                data = Convert.ToString(dataG_Usuarios.Rows[n].Cells[0].Value);
#pragma warning restore CS8601 // Posible asignación de referencia nula
            }
        }

        private void bt_Editar_Click(object sender, EventArgs e)
        {
            Conexion_db conexion = new Conexion_db();
            conexion.Abrir();
            if (txt_NuevoUsuario.Text == "" | txt_Contraseña.Text == "" | txt_ConfirmarContraseña.Text == "" | (Rdb_Empleado.Checked == false & Rdb_Administrador.Checked == false))
            {
                MessageBox.Show("Faltan Datos Del Usuario a Editar");
            }
            else
            {
                try
                {
                    if (Rdb_Administrador.Checked == true)
                    {
                        Variable = 1;
                    }
                    else if (Rdb_Empleado.Checked == true)
                    {
                        Variable = 0;
                    }
                    string query = "UPDATE Usuarios SET Usuario ='" + txt_NuevoUsuario.Text + "', Contraseña='" + txt_Contraseña.Text + "', Rol ='" + Variable + "' WHERE Usuario = '" + data + "'";
                    SqlCommand comando = new SqlCommand(query, conexion.conx);
                    int r = comando.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Usuario Modificado Exitosamente");
                        string query2 = "SELECT * FROM Usuarios";
                        SqlDataAdapter adaptador = new SqlDataAdapter(query2, conexion.conx);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);
                        dataG_Usuarios.DataSource = dt;
                        txt_NuevoUsuario.Text = "";
                        txt_Contraseña.Text = "";
                        txt_ConfirmarContraseña.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No Se Pudo Modificar El Usuario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Al Modificar Usuario" + ex);
                }
            }
            conexion.Cerrar();
        }

        private void bt_Borrar_Click(object sender, EventArgs e)
        {
            if (txt_NuevoUsuario.Text == "" | txt_Contraseña.Text == "")
            {
                MessageBox.Show("Seleccione El Usuario a Eliminar");
            }
            else
            {
                Conexion_db conexion = new Conexion_db();
                conexion.Abrir();
                try
                {
                    SqlCommand query = new SqlCommand("DELETE FROM Usuarios WHERE Usuario= '" + data + "'", conexion.conx);
                    query.ExecuteNonQuery();
                    MessageBox.Show("Usuario Eliminado Exitosamente");
                    string query2 = "SELECT * FROM Usuarios";
                    SqlDataAdapter adaptador = new SqlDataAdapter(query2, conexion.conx);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataG_Usuarios.DataSource = dt;
                    txt_NuevoUsuario.Text = "";
                    txt_Contraseña.Text = "";
                    txt_ConfirmarContraseña.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Al Eliminar Usuario" + ex);
                }
                Validacion = false;
                conexion.Cerrar();
            }
        }

        private void bt_CerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void bt_Tienda_Click(object sender, EventArgs e)
        {
            Tienda tienda = new Tienda();
            this.Close();
            tienda.Show();
        }

        private void bt_Regresar_Click(object sender, EventArgs e)
        {
            Crud crud = new Crud();
            this.Close();
            crud.Show();
        }

        private void lb_Limpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_NuevoUsuario.Text = "";
            txt_Contraseña.Text = "";
            txt_ConfirmarContraseña.Text = "";
            Rdb_Administrador.Checked = false;
            Rdb_Empleado.Checked = false;
        }
    }
}
