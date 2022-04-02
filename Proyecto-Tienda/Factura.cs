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
    public partial class Factura : Form
    {  
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            txt_fecha.Text = Fact.fecha;
            txt_cliente.Text = Fact.CLiente;
            txt_cedula.Text = Fact.Cedula;
            txt_total.Text = "  $ " + Convert.ToString(Fact.Total);
            txt_fecha.Text = Fact.fecha;
            txt_hora.Text = Fact.hora;
            txt_Numfactura.Text = Convert.ToString(Fact.Nro_Factura);
        }

        private void bt_Finalizar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txt_cedula.Text);
            Conexion_db conexion = new Conexion_db();
            conexion.Abrir();
            try
            {
                SqlCommand Query = new SqlCommand("INSERT INTO dbo.Factura VALUES('" + txt_Numfactura.Text + "','" + txt_fecha.Text + "','" + txt_cliente.Text + "','" + cedula + "','" + Fact.Total + "')", conexion.conx);
                int r = Query.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Factura Guardada Exitosamente");
                }
                else
                {
                    MessageBox.Show("No Se Pudo Registrar la Producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Guardar Factura" + ex);
            }
            conexion.Cerrar();
            Application.Exit();
        }

        private void bt_NuevoPedido_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txt_cedula.Text);
            Conexion_db conexion = new Conexion_db();
            conexion.Abrir();
            try
            {
                SqlCommand Query = new SqlCommand("INSERT INTO dbo.Factura VALUES('" + txt_Numfactura.Text + "','" + txt_fecha.Text + "','" + txt_cliente.Text + "','" + cedula + "','" + Fact.Total + "')", conexion.conx);
                int r = Query.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Factura Guardada Exitosamente");
                }
                else
                {
                    MessageBox.Show("No Se Pudo Registrar la Producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Guardar Factura" + ex);
            }
            conexion.Cerrar();
            Tienda tienda = new Tienda();
            this.Close();
            tienda.Show();
        }
    }
}
