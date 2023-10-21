using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forrajeria
{
    public partial class Productos : Form
    {
        private CLN_Productos objProductos_CLN;
        private DataTable Tabla;
        public Productos()
        {
            InitializeComponent();
            objProductos_CLN = new CLN_Productos();
            Tabla = new DataTable();
            MostrarProductos();
        }
        private void MostrarProductos()
        {
            Tabla.Clear();
            Tabla = objProductos_CLN.MostrarProductos();
            dgvProductos.DataSource = Tabla;

        }
    }
}
