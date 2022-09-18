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
    public partial class p_user_maneger : UserControl
    {
        public p_user_maneger()
        {
            InitializeComponent();
        }
        private void p_user_maneger_Load(object sender, EventArgs e)
        {
            isimler();
        }
        DataTable Table = new DataTable();
        Database db = new Database();


        public void isimler()
        {
            Table.Clear();
            Table = db.readData("select * from isimler ", "");
            for (int i = 0; i < 9; i++)
            {

                string name = "i" + (i + 1).ToString();
                Control ctn = this.Controls[name];
                if (Table.Rows.Count <= i)
                {
                    ctn.Text = "";
                }
                else
                {
                    ctn.Text = Table.Rows[i][0].ToString();

                }

            }
        }
        int k = 0;
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            k += 9;

            Table.Clear();
            Table = db.readData("select * from isimler ", "");
            for (int i = 0; i < 9; i++)
            {

                string name = "i" + (i + 1).ToString();
                Control ctn = this.Controls[name];
                if (Table.Rows.Count <= i+k && k <= Table.Rows.Count)
                {
                    ctn.Text = "";
                }
                else if ( k > Table.Rows.Count && Table.Rows.Count <= i + k)
                {
                    k -= 9;
                }
                else
                {
                    ctn.Text = Table.Rows[i+k][0].ToString();

                }

            }
        }



        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            k -= 9;

            Table.Clear();
            Table = db.readData("select * from isimler ", "");
            for (int i = 0; i < 9; i++)
            {

                string name = "i" + (i + 1).ToString();
                Control ctn = this.Controls[name];
                if (Table.Rows.Count <= i + k)
                {
                    ctn.Text = "";
                }
                else if (k < 0)
                {
                    k += 9;
                }
                else
                {
                    ctn.Text = Table.Rows[i + k][0].ToString();

                }


            }
        }
    }
}
