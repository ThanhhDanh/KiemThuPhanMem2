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

namespace _18_LeThanhDanh_B7_8
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

            //18_Lê Thanh Danh
            IWebElement danh_18_user = Danh_18.FindElement(By.Id("form-username"));
            danh_18_user.SendKeys("2151050047");
            //18_Lê Thanh Danh
            IWebElement danh_18_pw = Danh_18.FindElement(By.Id("form-password"));
            danh_18_pw.SendKeys("2151050047");
            //18_Lê Thanh Danh
            IWebElement danh_18_login = Danh_18.FindElement(By.ClassName("m-loginbox-submit-btn"));
            danh_18_login.Click();
            //18_Lê Thanh Danh
            IWebElement danh_18_linkTranlate = Danh_18.FindElement(By.LinkText("English"));
            danh_18_linkTranlate.Click();
            //18_Lê Thanh Danh
        }
    }
}
