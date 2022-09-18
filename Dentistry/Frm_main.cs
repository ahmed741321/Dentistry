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
using Dentistry.user_page;

namespace Dentistry
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
            p_homecs page = new p_homecs();
            load_page(page);
        }

        private void load_page(UserControl page)
        {
            try
            {

                panel1.Controls.Clear();
                page.Dock = DockStyle.Fill;
                panel1.Controls.Add(page);
            }

            catch
            {

            }
        }


        //تحريك الشاشة
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void gunaGradient2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd dd:MM:yyyy \n hh:mm ");
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(panel1);
            p_homecs page = new p_homecs();
            load_page(page);
            guna2Transition1.ShowSync(panel1);
        }

        private void timer2_Tick(object sender, EventArgs e)
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

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(panel1);
            p_add_user page = new p_add_user();
            load_page(page);
            guna2Transition1.ShowSync(panel1);
        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(panel1);
            p_user_maneger page = new p_user_maneger();
            load_page(page);
            guna2Transition1.ShowSync(panel1);
        }
    }
}
