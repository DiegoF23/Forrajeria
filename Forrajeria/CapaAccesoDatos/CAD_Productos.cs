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
        private DataTable Tabla2;
        private DataTable Combo1;
        private SqlCommand Comando;

        public CAD_Productos()
        {
            objConexionCAD = new Conexion_DB();
            Tabla = new DataTable();
            Tabla2 = new DataTable();
            Combo1 = new DataTable();
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
        public void AgregarProducto(string Nom, decimal Precio, string Descripcion, int Stock, int IdProv)
        {
            Comando.Connection = objConexionCAD.abrirConexion();
            Comando.CommandText = "AgregarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@nombre", Nom);
            Comando.Parameters.AddWithValue("@precio", Precio);
            Comando.Parameters.AddWithValue("@descripcion", Descripcion);
            Comando.Parameters.AddWithValue("@stock", Stock);
            Comando.Parameters.AddWithValue("@idProveedor", IdProv);
            Comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();
        }
        public void EditarProductos(int IdProd,  string Nom, decimal Precio, string Descripcion, int Stock, int IdProv)
        {
            Comando.Connection = objConexionCAD.abrirConexion();
            Comando.CommandText = "EditarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idProducto", IdProd);
            Comando.Parameters.AddWithValue("@nombre", Nom);
            Comando.Parameters.AddWithValue("@precio", Precio);
            Comando.Parameters.AddWithValue("@descripcion", Descripcion);
            Comando.Parameters.AddWithValue("@stock", Stock);
            Comando.Parameters.AddWithValue("@idProveedor", IdProv);
            Comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();


        }
        public void EliminarProductos(int IdProd)
        {
            Comando.Connection = objConexionCAD.abrirConexion();
            Comando.CommandText = "EliminarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@id_producto", IdProd);
            Comando.ExecuteNonQuery();
            objConexionCAD.cerrarConexion();

        }
        public DataTable FiltrarText(string Texto)
        {
            Comando.Connection = objConexionCAD.abrirConexion();
            Comando.CommandText = "FiltroProductotexto";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@texto", Texto);
            leerTabla = Comando.ExecuteReader();
            Tabla2.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return Tabla2;

        }
        public DataTable FiltrarID(int IdProd)
        {
            Comando.Connection = objConexionCAD.abrirConexion();
            Comando.CommandText = "FiltroProductoId";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@idProducto", IdProd);
            leerTabla = Comando.ExecuteReader();
            Tabla2.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return Tabla2;

        }
        public DataTable ComboProveedores()
        {
            Comando.Connection = objConexionCAD.abrirConexion();
            Comando.CommandText = "selectProveedor";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.Clear();
            leerTabla = Comando.ExecuteReader();
            Combo1.Load(leerTabla);
            objConexionCAD.cerrarConexion();
            return Combo1;

        }
    }
}
