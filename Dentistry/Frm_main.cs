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
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(gunaElipsePanel2.Width<150)
            {
                gunaElipsePanel2.Width += 3;
                gunaElipsePanel1.Width -= 3;
                gunaElipsePanel1.Left += 3;
            }
            else
            {
                timer1.Stop();
            }
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            if (gunaElipsePanel2.Width > 55)
            {
                gunaElipsePanel2.Width -= 3;
                gunaElipsePanel1.Width += 3;
                gunaElipsePanel1.Left -= 3;


            }
            else
            {
                timer2.Stop();
            }
        }
        int say = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (say == 0)
            {
                timer2.Stop();
                   say++;
                timer1.Start();

            }
            else
            {
                timer1.Stop();
                say--;
                timer2.Start();

            }

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }



        private void timer3_Tick_1(object sender, EventArgs e)
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

        private void timer4_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd dd:MM:yyyy \n hh:mm ");
        }

        private void load_page(UserControl page)
        {
            try
            {

                gunaElipsePanel1.Controls.Clear();
                page.Dock = DockStyle.Fill;
                gunaElipsePanel1.Controls.Add(page);
            }


            catch
            {



            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            p_homecs page =  new p_homecs();
            load_page(page);
        }

        //تحريك الشاشة
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Frm_main_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
