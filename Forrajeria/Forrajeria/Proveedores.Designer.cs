namespace Forrajeria
{
    partial class Proveedores
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
            this.dgvProovedores = new System.Windows.Forms.DataGridView();
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProovedores)).BeginInit();
            this.gbProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProovedores
            // 
            this.dgvProovedores.AllowUserToAddRows = false;
            this.dgvProovedores.AllowUserToDeleteRows = false;
            this.dgvProovedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProovedores.Location = new System.Drawing.Point(437, 95);
            this.dgvProovedores.Name = "dgvProovedores";
            this.dgvProovedores.ReadOnly = true;
            this.dgvProovedores.Size = new System.Drawing.Size(470, 445);
            this.dgvProovedores.TabIndex = 1;
            this.dgvProovedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProovedores_CellClick);
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.btnEliminar);
            this.gbProveedor.Controls.Add(this.btnAplicar);
            this.gbProveedor.Controls.Add(this.btnCancelar);
            this.gbProveedor.Controls.Add(this.btnAgregar);
            this.gbProveedor.Controls.Add(this.txtTelefono);
            this.gbProveedor.Controls.Add(this.txtDireccion);
            this.gbProveedor.Controls.Add(this.txtNombre);
            this.gbProveedor.Controls.Add(this.lblTelefono);
            this.gbProveedor.Controls.Add(this.lblDireccion);
            this.gbProveedor.Controls.Add(this.lblNombre);
            this.gbProveedor.Location = new System.Drawing.Point(55, 95);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Size = new System.Drawing.Size(339, 261);
            this.gbProveedor.TabIndex = 2;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "Nuevo Proveedor";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(122, 184);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 47);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar Proveedor";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(41, 184);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 47);
            this.btnAplicar.TabIndex = 13;
            this.btnAplicar.Text = "Guardar Cambios";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Visible = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(212, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 47);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(122, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 47);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar Proveedor";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(97, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(190, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(97, 71);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(190, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(17, 116);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 74);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre :";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 576);
            this.Controls.Add(this.gbProveedor);
            this.Controls.Add(this.dgvProovedores);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProovedores)).EndInit();
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProovedores;
        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnEliminar;
    }
}