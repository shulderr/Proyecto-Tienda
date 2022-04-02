using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tiendavirtual
{
    internal class ConexionDB
    {
        string cadena = "Data Source = GERALT; Initial Catalog = Crud; Integrated Security = True";
        public SqlConnection conx = new SqlConnection();
        public ConexionDB()
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
