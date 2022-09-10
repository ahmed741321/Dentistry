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
using System.Threading;


namespace Dentistry
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }
        //تحريك الشاشة
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Frm_login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        int i = 0;
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i++;
                bunifuMaterialTextbox2.isPassword = true;
            }
            else
            {
                i--;
                bunifuMaterialTextbox2.isPassword = false;

            }
            Image Temp = guna2ImageButton1.Image;
            guna2ImageButton1.Image = guna2ImageButton1.CheckedState.Image; ;
            guna2ImageButton1.CheckedState.Image = Temp;

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
           

                timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= .01;

            }
            else
            {
                Application.Exit();

            }
        }
    }
}
