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

namespace _18_LeThanhDanh_Bai_2_5_B7_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnURL_Click(object sender, EventArgs e)
        {
            //Bài 3: Tìm tagname
            //18_Lê Thanh Danh
            ChromeDriverService TDanh_18 = ChromeDriverService.CreateDefaultService();
            TDanh_18.HideCommandPromptWindow = true;
            IWebDriver Danh_18 = new ChromeDriver(TDanh_18);
            Danh_18.Url = "https://www.demo.guru99.com/test/delete_customer.php";
            Danh_18.Navigate();

            //18_Lê Thanh Danh
            /*IReadOnlyCollection<IWebElement> danh_18_tagname = Danh_18.FindElements(By.TagName("h2"));
            foreach( var item in danh_18_tagname)
            {
                Console.WriteLine(item.Text);
            }*/


            //Bài 4:Upload picture or file in Selenium - SendKeys Selenium
            //18_Lê Thanh Danh
            /* Danh_18.FindElement(By.Name("uploadfile_0")).SendKeys(@"D:\113.jpg");
             //18_Lê Thanh Danh
             IWebElement danh_18_check =  Danh_18.FindElement(By.Name("terms"));
             danh_18_check.Click();
             //18_Lê Thanh Danh
             IWebElement danh_18_submit = Danh_18.FindElement(By.Name("send"));
             danh_18_submit.Click();*/

            //Bài 5: Selenium Alert & Popup Window Handling: How to Handle?
            //18_Lê Thanh Danh
            Danh_18.FindElement(By.Name("cusid")).SendKeys("53920");
            IWebElement danh_18_submit = Danh_18.FindElement(By.Name("submit"));
            danh_18_submit.Click();
            Danh_18.SwitchTo().Alert().Accept();
        }
    }
}
