using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogica
{
    public class CLN_Productos
    {
        private CAD_Productos objProductosCAD;
        private DataTable Tabla;

        public CLN_Productos()
        {
            objProductosCAD = new CAD_Productos();
            Tabla = new DataTable();
        }

        public DataTable MostrarProductos()
        {
            Tabla = objProductosCAD.MostrarProductos();
            return Tabla;

        }
    }
}
