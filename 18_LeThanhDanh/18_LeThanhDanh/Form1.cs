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

namespace _18_LeThanhDanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrl_Click(object sender, EventArgs e)
        {
            //18_Lê Thanh Danh
            ChromeDriverService TDanh_18 = ChromeDriverService.CreateDefaultService();
            TDanh_18.HideCommandPromptWindow = true;
            IWebDriver Danh_18 = new ChromeDriver(TDanh_18);
            Danh_18.Url = "https://id.ou.edu.vn/auth/login";
            Danh_18.Navigate();

        }
    }
}
