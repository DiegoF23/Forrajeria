namespace Forrajeria
{
    partial class Carrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.txtCantidadEditar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnAgregarCarro = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gbCarrito = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCarrito = new System.Windows.Forms.Label();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.btnCancelarCarro = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbCliente.SuspendLayout();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.gbVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtTelefono);
            this.gbCliente.Controls.Add(this.txtDireccion);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.lblTelefono);
            this.gbCliente.Controls.Add(this.lblDireccion);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Location = new System.Drawing.Point(18, 10);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(1028, 60);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(574, 19);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(322, 20);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 20);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(77, 20);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(145, 20);
            this.txtNombreCliente.TabIndex = 3;
            this.txtNombreCliente.Tag = "El campo es obligatorio";
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(516, 20);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(261, 23);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.txtCantidadEditar);
            this.gbProducto.Controls.Add(this.btnCancelar);
            this.gbProducto.Controls.Add(this.btnEliminar);
            this.gbProducto.Controls.Add(this.btnAplicar);
            this.gbProducto.Controls.Add(this.lblSubTotal);
            this.gbProducto.Controls.Add(this.btnAgregarCarro);
            this.gbProducto.Controls.Add(this.txtCantidad);
            this.gbProducto.Controls.Add(this.lblCantidad);
            this.gbProducto.Controls.Add(this.lblNombreProd);
            this.gbProducto.Controls.Add(this.lblPrecio);
            this.gbProducto.Controls.Add(this.txtBuscar);
            this.gbProducto.Controls.Add(this.lblBuscar);
            this.gbProducto.Controls.Add(this.dgvProductos);
            this.gbProducto.Location = new System.Drawing.Point(18, 76);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(1028, 223);
            this.gbProducto.TabIndex = 1;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Producto";
            // 
            // txtCantidadEditar
            // 
            this.txtCantidadEditar.Location = new System.Drawing.Point(97, 136);
            this.txtCantidadEditar.Name = "txtCantidadEditar";
            this.txtCantidadEditar.Size = new System.Drawing.Size(57, 20);
            this.txtCantidadEditar.TabIndex = 11;
            this.txtCantidadEditar.Text = "1";
            this.txtCantidadEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidadEditar.Visible = false;
            this.txtCantidadEditar.TextChanged += new System.EventHandler(this.txtCantidadEditar_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 38);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(138, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 38);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(26, 169);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(73, 38);
            this.btnAplicar.TabIndex = 8;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Visible = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(174, 127);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(142, 29);
            this.lblSubTotal.TabIndex = 7;
            this.lblSubTotal.Text = "$XXXX.XX";
            // 
            // btnAgregarCarro
            // 
            this.btnAgregarCarro.Location = new System.Drawing.Point(26, 169);
            this.btnAgregarCarro.Name = "btnAgregarCarro";
            this.btnAgregarCarro.Size = new System.Drawing.Size(290, 28);
            this.btnAgregarCarro.TabIndex = 7;
            this.btnAgregarCarro.Text = "Agregar al Carro";
            this.btnAgregarCarro.UseVisualStyleBackColor = true;
            this.btnAgregarCarro.Click += new System.EventHandler(this.btnAgregarCarro_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(97, 136);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(23, 141);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 15);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.Location = new System.Drawing.Point(27, 67);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(64, 15);
            this.lblNombreProd.TabIndex = 3;
            this.lblNombreProd.Text = "Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(27, 100);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 15);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "$Precio";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(77, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(239, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(23, 38);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(340, 38);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(619, 159);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // gbCarrito
            // 
            this.gbCarrito.Controls.Add(this.lblTotal);
            this.gbCarrito.Controls.Add(this.lblTotalCarrito);
            this.gbCarrito.Controls.Add(this.dgvCarrito);
            this.gbCarrito.Location = new System.Drawing.Point(18, 305);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(1028, 218);
            this.gbCarrito.TabIndex = 2;
            this.gbCarrito.TabStop = false;
            this.gbCarrito.Text = "Carrito";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(794, 101);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(158, 15);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Cantidad Productos: XX";
            // 
            // lblTotalCarrito
            // 
            this.lblTotalCarrito.AutoSize = true;
            this.lblTotalCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCarrito.Location = new System.Drawing.Point(790, 142);
            this.lblTotalCarrito.Name = "lblTotalCarrito";
            this.lblTotalCarrito.Size = new System.Drawing.Size(178, 37);
            this.lblTotalCarrito.TabIndex = 8;
            this.lblTotalCarrito.Text = "$XXXX.XX";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(6, 33);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.Size = new System.Drawing.Size(748, 159);
            this.dgvCarrito.TabIndex = 8;
            this.dgvCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellClick);
            // 
            // gbVenta
            // 
            this.gbVenta.Controls.Add(this.btnCancelarCarro);
            this.gbVenta.Controls.Add(this.btnPagar);
            this.gbVenta.Controls.Add(this.dtpFechaVenta);
            this.gbVenta.Controls.Add(this.lblFecha);
            this.gbVenta.Location = new System.Drawing.Point(18, 529);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Size = new System.Drawing.Size(1028, 100);
            this.gbVenta.TabIndex = 2;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = "Finalizar Venta";
            // 
            // btnCancelarCarro
            // 
            this.btnCancelarCarro.Location = new System.Drawing.Point(893, 26);
            this.btnCancelarCarro.Name = "btnCancelarCarro";
            this.btnCancelarCarro.Size = new System.Drawing.Size(93, 62);
            this.btnCancelarCarro.TabIndex = 23;
            this.btnCancelarCarro.Text = "Cancelar Carrito";
            this.btnCancelarCarro.UseVisualStyleBackColor = true;
            this.btnCancelarCarro.Click += new System.EventHandler(this.btnCancelarCarro_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(779, 26);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(98, 62);
            this.btnPagar.TabIndex = 8;
            this.btnPagar.Text = "Pagar Carrito";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(155, 44);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(106, 21);
            this.dtpFechaVenta.TabIndex = 22;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(79, 49);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 15);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha:";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.IndianRed;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Info;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 641);
            this.Controls.Add(this.gbVenta);
            this.Controls.Add(this.gbCarrito);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.gbCliente);
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbCarrito.ResumeLayout(false);
            this.gbCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.gbVenta.ResumeLayout(false);
            this.gbVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.GroupBox gbCarrito;
        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnAgregarCarro;
        private System.Windows.Forms.Label lblTotalCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCancelarCarro;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.TextBox txtCantidadEditar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}