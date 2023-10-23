﻿using CapaLogica;
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
    public partial class Carrito : Form
    {
        private CLN_Carrito objCarrito_CLN;
        private DataTable Tabla;
        private DataTable Tabla2;
        private DataTable Carro;
        private string nombre;
        private string direccion;
        private string telefono;
        private int indice;
        private int idProd;
        decimal precio;
        int cantidad;
        int c;
        decimal a;
        decimal subtotal;
        int stock;
        int stockTotal;
        int stockeditar;


        public Carrito()
        {
            InitializeComponent();
            objCarrito_CLN = new CLN_Carrito();
            Tabla = new DataTable();
            Tabla2 = new DataTable();
            Carro = new DataTable();
            c = 0;
            a = 0;
            nombre = "";
            direccion = "";
            telefono = "";
            MostrarProductos();
        }


        private void MostrarProductos()
        {
            Tabla.Clear();
            Tabla = objCarrito_CLN.ProductosDisponibles();
            dgvProductos.DataSource = Tabla;

        }

        private void Filtrar()
        {
            string texto = txtBuscar.Text;
            if (int.TryParse(texto, out int numero))
            {
                Tabla.Clear();
                Tabla = objCarrito_CLN.FiltrarId(numero);
                dgvProductos.DataSource = Tabla;
            }
            else
            {
                Tabla.Clear();
                Tabla = objCarrito_CLN.FiltrarText(texto);
                dgvProductos.DataSource = Tabla;
            }


        }
        private void CantidadChange()
        {
            string texto = txtCantidad.Text;
            if (texto == "")
            {
                texto = "0";
            }
            if (int.TryParse(texto, out int numero))
            {
                if (numero > stock)
                {
                    MessageBox.Show("La cantidad ingresada no puede superar al stock del producto");
                }
                else
                {

                    subtotal = objCarrito_CLN.PrecioXcantidad(numero, precio);
                    lblSubTotal.Text = "$" + Convert.ToString(subtotal);
                }
            }
        
        }
        private void CantidadChange2()
        {
            string texto = txtCantidadEditar.Text;
            
            
            //MessageBox.Show(stockTotal.ToString());
            if (texto == "")
            {
                texto = "0";
                stockTotal = (Convert.ToInt32(texto)) + stock;
            }
            else if (int.TryParse(texto, out int numero))
            {
                stockTotal = (Convert.ToInt32(texto)) + stock;
                if (numero > stockTotal)
                {
                    MessageBox.Show("La cantidad ingresada no puede superar al stock del producto");
                }
                else
                {

                    subtotal = objCarrito_CLN.PrecioXcantidad(numero, precio);
                    lblSubTotal.Text = "$" + Convert.ToString(subtotal);
                    
                }
            }

        }
        private void EditarCarro()
        {
            string texto = txtCantidadEditar.Text;
            if (int.TryParse(texto, out int numero))
            {
                if (numero != stockeditar)
                {
                    if (numero > stockeditar)
                    {
                        objCarrito_CLN.RestarStock(idProd, numero - stockeditar);
                        Carro = objCarrito_CLN.EditarCarrito(indice,Convert.ToDecimal(lblPrecio.Text),numero);
                        dgvCarrito.DataSource = Carro;


                    }
                    else if (stockeditar > numero)
                    {
                        objCarrito_CLN.RestaurarStock(idProd, stockeditar - numero);
                        Carro = objCarrito_CLN.EditarCarrito(indice, Convert.ToDecimal(lblPrecio.Text), numero);
                        dgvCarrito.DataSource = Carro;
                    }
                    MostrarProductos();
                    MessageBox.Show("Se aplicaron los cambios al carrito");
                   
                    c = 0;
                    a = 0;
                    foreach (DataRow row in Carro.Rows)
                    {
                        a += (decimal)row["Total"];
                        c += (int)row["Cantidad"];
                    }
                    lblTotal.Text = "Cantidad Productos: " + c;
                    lblTotalCarrito.Text = "$" + a;




                }

            }
        }
        private void EliminarItemCarro()
        {
            Carro = objCarrito_CLN.EliminarItemCarro(indice);
            MessageBox.Show("se elimino el producto del carrito");
            MostrarProductos();
            dgvCarrito.DataSource = Carro;
            c = 0;
            a = 0;
            foreach (DataRow row in Carro.Rows)
            {
                a += (decimal)row["Total"];
                c += (int)row["Cantidad"];
            }
            lblTotal.Text = "Cantidad Productos: " + c;
            lblTotalCarrito.Text = "$" + a;
        }

        private void AgregarAlCarrito(int IDProducto)
        {
            string texto = txtCantidad.Text;
            if (int.TryParse(texto, out int numero))
            {
                if (numero > stock) 
                {
                    MessageBox.Show("La cantidad ingresada no puede superar al stock del producto");
                }
                else
                {
                    
                    Carro = objCarrito_CLN.DetalleCarrito(IDProducto, numero);
                    objCarrito_CLN.RestarStock(IDProducto, numero);
                    MostrarProductos();
                    c += numero;
                    a = 0;
                    foreach (DataRow row in Carro.Rows)
                    {
                        a += (decimal)row["Total"];
                    }
                    lblTotal.Text = "Cantidad Productos: " + c;
                    lblTotalCarrito.Text ="$" + a;
                    dgvCarrito.DataSource = Carro;
                    
                }
                    
            }
            else
            {
                MessageBox.Show("Ingrese una Cantidad Valida");
            }
            
        }



        private void limpiarCampos()
        {
            txtBuscar.Text = "";
            lblNombreProd.Text = "Producto";
            txtCantidad.Text = "1";
            lblSubTotal.Text = "$0.00";
            lblPrecio.Text = "Precio";
            btnAgregarCarro.Visible = true;
            btnAplicar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = false;
            txtCantidadEditar.Visible = false;
            txtCantidad.Visible = true;
        }


        private void PagarCarrito()
        {
            int ClienteID = objCarrito_CLN.InsertCliente(txtNombreCliente.Text, txtDireccion.Text, txtTelefono.Text);
            int VentaID = objCarrito_CLN.insertVenta(dtpFechaVenta.Value.ToString(),ClienteID);
            foreach (DataRow row in Carro.Rows)
            {
                objCarrito_CLN.insertDetallesVenta(VentaID,(int)row["Codigo"],(int)row["Cantidad"], (decimal)row["Precio"]);
            }

            MessageBox.Show("Cliente,Venta y detalles insertados");
            GenerarFactura();
            limpiarCampos();
            MostrarProductos();
            lblTotal.Text = "Cantidad Productos: 0" ;
            lblTotalCarrito.Text = "$0.00" ;
            Carro.Clear();
            dgvCarrito.DataSource = Carro;

        }

       

        ////////////////////////////////////////////////////////////////////////////////////////

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            nombre=txtNombreCliente.Text;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            direccion= txtDireccion.Text;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            telefono=txtTelefono.Text;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            txtCantidad.Text = "1";
            if (indice > -1)
            {
                idProd = Convert.ToInt32(dgvProductos.Rows[indice].Cells[0].Value);
                lblNombreProd.Text = dgvProductos.Rows[indice].Cells[1].Value.ToString();
                lblPrecio.Text ="$"+ dgvProductos.Rows[indice].Cells[4].Value.ToString();
                stock = Convert.ToInt32(dgvProductos.Rows[indice].Cells[3].Value);
                precio = Convert.ToDecimal(dgvProductos.Rows[indice].Cells[4].Value);
                cantidad = Convert.ToInt32(txtCantidad.Text);
                subtotal = objCarrito_CLN.PrecioXcantidad(cantidad,precio);
                lblSubTotal.Text ="$"+ Convert.ToString(subtotal);
                btnAgregarCarro.Visible = true;
                txtCantidad.Visible = true;
                txtCantidadEditar.Visible = false;
                btnAplicar.Visible = false;
                btnEliminar.Visible = false;
                btnCancelar.Visible = false;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CantidadChange();
        }

        private void btnAgregarCarro_Click(object sender, EventArgs e)
        {
            AgregarAlCarrito(idProd);

            limpiarCampos();
        }

        private void dgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice > -1)
            {
                btnAgregarCarro.Visible = false;
                idProd = Convert.ToInt32(dgvCarrito.Rows[indice].Cells[0].Value);
                lblNombreProd.Text = dgvCarrito.Rows[indice].Cells[1].Value.ToString();
                lblPrecio.Text = dgvCarrito.Rows[indice].Cells[2].Value.ToString();
                precio = Convert.ToDecimal(dgvCarrito.Rows[indice].Cells[2].Value);
                cantidad = Convert.ToInt32(dgvCarrito.Rows[indice].Cells[3].Value);
                stock = objCarrito_CLN.StockActual(idProd);
                txtCantidadEditar.Text = dgvCarrito.Rows[indice].Cells[3].Value.ToString();
                stockeditar=Convert.ToInt32(dgvCarrito.Rows[indice].Cells[3].Value);
                txtCantidadEditar.Visible = true;
                btnAplicar.Visible=true;
                btnEliminar.Visible=true;
                btnCancelar.Visible=true;
               
            }
        }

        private void txtCantidadEditar_TextChanged(object sender, EventArgs e)
        {
            CantidadChange2();

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            EditarCarro();
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarItemCarro();
            limpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            PagarCarrito();
           
        }

        private void btnCancelarCarro_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            
            lblTotal.Text = "Cantidad Productos: 0";
            lblTotalCarrito.Text = "$0.00";
            foreach (DataRow row in Carro.Rows)
            {
                int prodID;
                int cant;
                prodID = Convert.ToInt32(row["Codigo"]);
                cant = Convert.ToInt32(row["Cantidad"]);
                objCarrito_CLN.RestaurarStock(prodID, cant);
            }
            Carro.Clear();
            dgvCarrito.DataSource = Carro;
            MostrarProductos();
        }

        private void GenerarFactura()
        {
           
            string cliente = nombre;
            string direccionCliente = direccion;
            string telefonoCliente = telefono;

            int numeroFactura = objCarrito_CLN.ObtenerNumeroFactura(); 

            DataTable detallesFactura = new DataTable();
            detallesFactura.Columns.Add("Producto");
            detallesFactura.Columns.Add("Cantidad");
            detallesFactura.Columns.Add("Precio unitario");
            detallesFactura.Columns.Add("Subtotal");
            decimal importeTotal = 0;
            foreach (DataRow row in Carro.Rows)
            {
                string producto = row["Nombre"].ToString();
                int cantidad = (int)row["Cantidad"];
                decimal precioUnitario = (decimal)row["Precio"];
                decimal subtotal = cantidad * precioUnitario;

                detallesFactura.Rows.Add(producto, cantidad, precioUnitario, subtotal);
                importeTotal += subtotal;
            }

            FacturaForm facturaForm = new FacturaForm(numeroFactura, cliente, direccionCliente, telefonoCliente, detallesFactura, importeTotal);
            facturaForm.ShowDialog();

        }
    }
}
