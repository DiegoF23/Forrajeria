namespace Forrajeria
{
    partial class Menu
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
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductos.Location = new System.Drawing.Point(309, 176);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(187, 49);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProveedor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProveedor.Location = new System.Drawing.Point(309, 263);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(187, 49);
            this.btnProveedor.TabIndex = 5;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnProductos);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedor;
    }
}