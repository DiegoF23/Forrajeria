using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class CAD_Productos
    {
        private Conexion_DB objConexionCAD;
        private SqlDataReader leerTabla;
        private DataTable Tabla;
        private SqlCommand Comando;

        public CAD_Productos()
        {
            objConexionCAD = new Conexion_DB();
            Tabla = new DataTable();
            Comando = new SqlCommand();

        }

        public DataTable MostrarProductos()
        {
            Comando.Connection = objConexionCAD.abrirConexion();
            Comando.CommandText = "MostrarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            leerTabla = Comando.ExecuteReader();
            Tabla.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return Tabla;
        }
    }
}
