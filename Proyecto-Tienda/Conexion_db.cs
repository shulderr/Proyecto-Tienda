using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda
{
    internal class Conexion_db
    {
        string cadena = "Data Source = GERALT; Initial Catalog = Crud; Integrated Security = True";
        public SqlConnection conx = new SqlConnection();
        public Conexion_db()
        {
            conx.ConnectionString = cadena;
        }
        public void Abrir()
        {
            conx.Open();
        }
        public void Cerrar()
        {
            conx.Close();
        }
    }
}
