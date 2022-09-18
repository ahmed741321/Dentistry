using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentistry
{
    public partial class Frm_start : Form
    {
        public Frm_start()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuProgressBar1.Value % 50 == 0)
            {
                label1.Text = "Loading Data.";
            }

            else if (bunifuProgressBar1.Value % 50 == 20)
            {
                label1.Text = "Loading Data..";
            }
            else if (bunifuProgressBar1.Value % 50 == 30)
            {
                label1.Text = "Loading Data...";
            }


            if (bunifuProgressBar1.Value == 99)
            {
                label1.Text = "The program is ready";
                bunifuProgressBar1.Value = bunifuProgressBar1.Value + 1;

            }

            else if (bunifuProgressBar1.Value == 100)
            {
                label1.Text = "The program is ready";
                timer1.Stop();
                Thread.Sleep(900);



                Frm_login login = new Frm_login();
                login.Show();

                this.Hide();

            }
            else
            {
                bunifuProgressBar1.Value = bunifuProgressBar1.Value + 1;

            }

        }

        //تحريك الشاشة
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
