using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentistry.user_page
{
    public partial class p_add_user : UserControl
    {
        public p_add_user()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Images Files :|*.jpg;*.PNG";
            if(file.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
            }
        }

 

        private void p_add_user_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox2.Visible = true;

                guna2Transition1.HideSync(pictureBox2);
                guna2Transition1.ShowSync(pictureBox2);


            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox6.Visible = true;
                guna2Transition1.HideSync(pictureBox6);
                guna2Transition1.ShowSync(pictureBox6);

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox3.Visible = true;
                guna2Transition1.HideSync(pictureBox3);
                guna2Transition1.ShowSync(pictureBox3);
            }

        }
    }
}
