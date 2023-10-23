using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forrajeria
{
    public partial class FacturaForm : Form
    {
        private int numeroFactura;
        private string cliente;
        private string direccionCliente;
        private string telefonoCliente;
        private DataTable detallesFactura;
        private decimal importeTotal;

        public FacturaForm(int numeroFactura, string cliente, string direccionCliente, string telefonoCliente, DataTable detallesFactura, decimal importeTotal)
        {
            this.numeroFactura = numeroFactura;
            this.cliente = cliente;
            this.direccionCliente = direccionCliente;
            this.telefonoCliente = telefonoCliente;
            this.detallesFactura = detallesFactura;
            this.importeTotal = importeTotal;

            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Configura el tamaño del formulario y otros detalles visuales
            this.Size = new Size(600, 400);
            this.Text = "Factura";

            // Crea un botón para imprimir la factura
            Button imprimirButton = new Button();
            imprimirButton.Text = "Imprimir";
            imprimirButton.Location = new Point(10, 10);
            imprimirButton.Click += ImprimirButton_Click;
            this.Controls.Add(imprimirButton);

            // Agrega los detalles de la factura en un DataGridView
            DataGridView dgvDetallesFactura = new DataGridView();
            dgvDetallesFactura.DataSource = detallesFactura;
            dgvDetallesFactura.Location = new Point(10, 50);
            dgvDetallesFactura.Size = new Size(560, 250);
            this.Controls.Add(dgvDetallesFactura);
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(GenerarFactura_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void GenerarFactura_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Dibuja la factura en la página de impresión
            Graphics g = e.Graphics;

            // Configura la fuente y las coordenadas para dibujar el contenido de la factura
            Font font = new Font("Arial", 12);
            float x = 10;
            float y = 10;

            g.DrawString($"Factura #{numeroFactura}", font, Brushes.Black, x, y);
            y += font.GetHeight();

            g.DrawString($"Cliente: {cliente}", font, Brushes.Black, x, y);
            y += font.GetHeight();

            g.DrawString($"Dirección: {direccionCliente}", font, Brushes.Black, x, y);
            y += font.GetHeight();

            g.DrawString($"Teléfono: {telefonoCliente}", font, Brushes.Black, x, y);
            y += font.GetHeight();

            // Dibuja los detalles de la factura desde la DataTable
            foreach (DataRow row in detallesFactura.Rows)
            {
                string producto = row["Producto"].ToString();
                string cantidad = row["Cantidad"].ToString();
                string precioUnitario = row["Precio unitario"].ToString();
                string subtotal = row["Subtotal"].ToString();

                g.DrawString(producto, font, Brushes.Black, x, y);
                g.DrawString(cantidad, font, Brushes.Black, x + 200, y);
                g.DrawString(precioUnitario, font, Brushes.Black, x + 300, y);
                g.DrawString(subtotal, font, Brushes.Black, x + 400, y);

                y += font.GetHeight();
            }

            // Dibuja el importe total al final de la factura
            y += 20;
            g.DrawString($"Importe Total: {importeTotal:C}", font, Brushes.Black, x, y);
        }
    }
}
