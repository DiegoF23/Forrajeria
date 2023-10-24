﻿namespace Forrajeria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            
            this.lblSubTotal = new System.Windows.Forms.Label();
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
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAplicar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCarro = new FontAwesome.Sharp.IconButton();
            this.btnPagar = new FontAwesome.Sharp.IconButton();
            this.btnCancelarCarro = new FontAwesome.Sharp.IconButton();
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
            this.gbCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCliente.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbCliente.Location = new System.Drawing.Point(0, 0);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(998, 56);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "CLIENTE";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.Location = new System.Drawing.Point(628, 17);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 23);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDireccion.Location = new System.Drawing.Point(357, 17);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 23);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNombreCliente.Location = new System.Drawing.Point(107, 17);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(145, 23);
            this.txtNombreCliente.TabIndex = 3;
            this.txtNombreCliente.Tag = "El campo es obligatorio";
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(532, 17);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(98, 26);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.Location = new System.Drawing.Point(258, 17);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(102, 26);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(19, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 26);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.btnAgregarCarro);
            this.gbProducto.Controls.Add(this.btnCancelar);
            this.gbProducto.Controls.Add(this.btnEliminar);
            this.gbProducto.Controls.Add(this.btnAplicar);
            this.gbProducto.Controls.Add(this.txtCantidadEditar);
            this.gbProducto.Controls.Add(this.lblSubTotal);
            this.gbProducto.Controls.Add(this.txtCantidad);
            this.gbProducto.Controls.Add(this.lblCantidad);
            this.gbProducto.Controls.Add(this.lblNombreProd);
            this.gbProducto.Controls.Add(this.lblPrecio);
            this.gbProducto.Controls.Add(this.txtBuscar);
            this.gbProducto.Controls.Add(this.lblBuscar);
            this.gbProducto.Controls.Add(this.dgvProductos);
            this.gbProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProducto.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.gbProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbProducto.Location = new System.Drawing.Point(0, 56);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(998, 211);
            this.gbProducto.TabIndex = 1;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "PRODUCTO";
            // 
            // txtCantidadEditar
            // 
            this.txtCantidadEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtCantidadEditar.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEditar.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCantidadEditar.Location = new System.Drawing.Point(88, 117);
            this.txtCantidadEditar.Margin = new System.Windows.Forms.Padding(0);
            this.txtCantidadEditar.Name = "txtCantidadEditar";
            this.txtCantidadEditar.Size = new System.Drawing.Size(57, 33);
            this.txtCantidadEditar.TabIndex = 11;
            this.txtCantidadEditar.Text = "1";
            this.txtCantidadEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidadEditar.Visible = false;
            this.txtCantidadEditar.TextChanged += new System.EventHandler(this.txtCantidadEditar_TextChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(165, 117);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(142, 29);
            this.lblSubTotal.TabIndex = 7;
            this.lblSubTotal.Text = "$XXXX.XX";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.txtCantidad.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.Location = new System.Drawing.Point(88, 117);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 33);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(6, 120);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(86, 23);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.Location = new System.Drawing.Point(12, 61);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(85, 23);
            this.lblNombreProd.TabIndex = 3;
            this.lblNombreProd.Text = "Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(12, 84);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(70, 23);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "$Precio";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBuscar.Location = new System.Drawing.Point(88, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(219, 23);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(11, 22);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(77, 26);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvProductos.Location = new System.Drawing.Point(314, 16);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.Size = new System.Drawing.Size(672, 189);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // gbCarrito
            // 
            this.gbCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.gbCarrito.Controls.Add(this.lblTotal);
            this.gbCarrito.Controls.Add(this.lblTotalCarrito);
            this.gbCarrito.Controls.Add(this.dgvCarrito);
            this.gbCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCarrito.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.gbCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbCarrito.Location = new System.Drawing.Point(0, 267);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(998, 370);
            this.gbCarrito.TabIndex = 2;
            this.gbCarrito.TabStop = false;
            this.gbCarrito.Text = "CARRITO";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(814, 244);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(158, 15);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Cantidad Productos: XX";
            // 
            // lblTotalCarrito
            // 
            this.lblTotalCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCarrito.AutoSize = true;
            this.lblTotalCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCarrito.Location = new System.Drawing.Point(810, 269);
            this.lblTotalCarrito.Name = "lblTotalCarrito";
            this.lblTotalCarrito.Size = new System.Drawing.Size(178, 37);
            this.lblTotalCarrito.TabIndex = 8;
            this.lblTotalCarrito.Text = "$XXXX.XX";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCarrito.Location = new System.Drawing.Point(10, 27);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.Size = new System.Drawing.Size(798, 327);
            this.dgvCarrito.TabIndex = 8;
            this.dgvCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellClick);
            // 
            // gbVenta
            // 
            this.gbVenta.Controls.Add(this.btnCancelarCarro);
            this.gbVenta.Controls.Add(this.btnPagar);
            this.gbVenta.Controls.Add(this.dtpFechaVenta);
            this.gbVenta.Controls.Add(this.lblFecha);
            this.gbVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbVenta.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.gbVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gbVenta.Location = new System.Drawing.Point(0, 571);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Size = new System.Drawing.Size(998, 66);
            this.gbVenta.TabIndex = 2;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = "FINALIZAR VENTA";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(80, 26);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(106, 21);
            this.dtpFechaVenta.TabIndex = 22;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(5, 24);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 26);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha:";
            // 
            // toolTip1
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAplicar.IconColor = System.Drawing.Color.White;
            this.btnAplicar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAplicar.IconSize = 20;
            this.btnAplicar.Location = new System.Drawing.Point(10, 159);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(86, 34);
            this.btnAplicar.TabIndex = 29;
            this.btnAplicar.Text = "APLICAR";
            this.btnAplicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Visible = false;
//            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 20;
            this.btnEliminar.Location = new System.Drawing.Point(107, 159);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 34);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.Location = new System.Drawing.Point(201, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 34);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAgregarCarro
            // 
            this.btnAgregarCarro.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarCarro.FlatAppearance.BorderSize = 0;
            this.btnAgregarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarro.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarro.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnAgregarCarro.IconColor = System.Drawing.Color.White;
            this.btnAgregarCarro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCarro.IconSize = 25;
            this.btnAgregarCarro.Location = new System.Drawing.Point(6, 159);
            this.btnAgregarCarro.Name = "btnAgregarCarro";
            this.btnAgregarCarro.Size = new System.Drawing.Size(297, 40);
            this.btnAgregarCarro.TabIndex = 31;
            this.btnAgregarCarro.Text = "AGREGAR AL CARRITO";
            this.btnAgregarCarro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCarro.UseVisualStyleBackColor = false;
            this.btnAgregarCarro.Click += new System.EventHandler(this.btnAgregarCarro_Click_1);
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnPagar.IconColor = System.Drawing.Color.White;
            this.btnPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagar.IconSize = 25;
            this.btnPagar.Location = new System.Drawing.Point(654, 17);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(142, 42);
            this.btnPagar.TabIndex = 31;
            this.btnPagar.Text = "PAGAR CARRITO";
            this.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click_1);
            this.toolTip1.BackColor = System.Drawing.Color.IndianRed;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Info;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(998, 637);
            this.Controls.Add(this.gbVenta);
            this.Controls.Add(this.gbCarrito);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.gbCliente);
            this.ForeColor = System.Drawing.Color.Black;
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
        private System.Windows.Forms.Label lblTotalCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCantidadEditar;
        private FontAwesome.Sharp.IconButton btnAplicar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAgregarCarro;
        private FontAwesome.Sharp.IconButton btnPagar;
        private FontAwesome.Sharp.IconButton btnCancelarCarro;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}