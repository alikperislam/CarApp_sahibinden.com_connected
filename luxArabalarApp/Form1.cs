using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luxArabalarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        int lambo_tiklanma = 0, ferrari_tiklanma = 0, bmw_tiklanma = 0,
            audi_tiklanma = 0, tesla_tiklanma = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            audi_tiklanma++;
            if (audi_tiklanma % 2 == 1)
            {
                Form10 fr = new Form10();
                getirForm(fr);
            }
            else
            {
                Form11 fr1 = new Form11();
                getirForm(fr1);
            }
        }
        private void getirForm(Form frm)
        {
            panelMain.Controls.Clear();
            frm.MdiParent = this;
            panelMain.Controls.Add(frm);
            frm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bmw_tiklanma++;
            if (bmw_tiklanma % 2 == 1)
            {
                Form8 fr = new Form8();
                getirForm(fr);
            }
            else
            {
                Form9 fr1 = new Form9();
                getirForm(fr1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tesla_tiklanma++;
            if (tesla_tiklanma % 2 == 1)
            {
                Form6 fr = new Form6();
                getirForm(fr);
            }
            else
            {
                Form7 fr1 = new Form7();
                getirForm(fr1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ferrari_tiklanma++;
            if (ferrari_tiklanma % 2 == 1)
            {
                Form4 fr = new Form4();
                getirForm(fr);
            }
            else
            {
                Form5 fr1 = new Form5();
                getirForm(fr1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lambo_tiklanma++;
            if (lambo_tiklanma%2==0)
            {
                Form2 fr = new Form2();
                getirForm(fr);
            }
            else
            {
                Form3 fr1 = new Form3();
                getirForm(fr1);
            }
        }
    }
}
