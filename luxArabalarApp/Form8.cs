using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace luxArabalarApp
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IWebDriver drive = new ChromeDriver();
            drive.Navigate().GoToUrl("https://www.sahibinden.com/ilan/vasita-otomobil-bmw-tr-de-tek-156.000-km-de-dis-m-881751550/detay");
        }
    }
}
