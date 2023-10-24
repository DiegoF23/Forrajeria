using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class CAD_Cliente
    {
        private Conexion_DB objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable miTabla;
        private SqlCommand comando;
        public CAD_Clientes()
        {
            objConexionCAD = new Conexion_DB();
            miTabla = new DataTable();
            comando = new SqlCommand();
        }
    }
    
}
