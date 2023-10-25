using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forrajeria
{
    public partial class Menu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Menu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            // public static Color color1 = Color.FromArgb(228,174,197);

            public static Color colorRosa = Color.FromArgb(231, 171, 154);

        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                ///////////////
                currentBtn.BackColor = Color.FromArgb(37,79, 101);
                ///////////////
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChild.IconChar = currentBtn.IconChar;
                iconCurrentChild.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                ////////////////////
                currentBtn.BackColor = Color.FromArgb(18, 38, 49);
                currentBtn.ForeColor = Color.FromArgb(235, 240, 240);
                /////////////////////
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                /////////////////////
                currentBtn.IconColor = Color.FromArgb(235, 240, 240);
                ////////////////////
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloFormularioHijo.Text=childForm.Text;
        }

       

      

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChild.IconChar = currentBtn.IconChar;
            iconCurrentChild.IconColor = Color.FromArgb(235, 240, 240);
            lblTituloFormularioHijo.Text = "Home";
        }


       

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorRosa);
            OpenChildForm(new EstadisticaControl());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorRosa);
            OpenChildForm(new Proveedores());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorRosa);
            OpenChildForm(new Productos());
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorRosa);
            OpenChildForm(new Carrito());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlControles_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Proveedores mainProveedor = new Proveedores();
            mainProveedor.ShowDialog();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
