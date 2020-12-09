using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KIHEDOVI_Cuestionario
{
    class DBConnection
    {
        string Cadenaconnect = "Data Source=SUN-PC;Initial Catalog=dbPenguinQ; Integrated Security=true";
        public SqlConnection conectarDB = new SqlConnection();
        
        public void abrir()
        {
            try
            {
                conectarDB.ConnectionString = Cadenaconnect;
                conectarDB.Open();
                Console.WriteLine("Conexión abierta");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al abrir la base de datos " + ex.Message);
            }
        }

        public void cerrar()
        {
            conectarDB.Close();
        }
    }
}
