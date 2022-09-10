using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
