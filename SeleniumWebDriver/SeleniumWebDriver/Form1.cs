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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////i, Các lệnh điều hướng
            //ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            //chrome.HideCommandPromptWindow = true;

            //IWebDriver driver = new ChromeDriver(chrome);

            ////GoToUrl
            //driver.Navigate().GoToUrl("https://drive.google.com/drive/folders/1ahJViibCl-6m2QurTIlrnPF-AS6Zisp9");

            //Thread.Sleep(3000);

            ////Back
            //driver.Navigate().Back();

            //Thread.Sleep(3000);

            ////Forward
            //driver.Navigate().Forward();

            //Thread.Sleep(3000);

            ////Refresh
            //driver.Navigate().Refresh();

            //Thread.Sleep(3000);

            ////Close
            //driver.Close();
        }

        private void btn_Open_83_Hoang_Click(object sender, EventArgs e)
        {
            // Điều hướng trình duyệt
            //Vào cài đặt trên Chrome để cập nhật phiên bản mới nhất
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://github.com/LTMHoang/83_Demo_KTPM");
        }

        private void btn_Open_Url_83_Hoang_Click(object sender, EventArgs e)
        {
            //Vào cài đặt trên Chrome để cập nhật phiên bản mới nhất

            //Bài 1

            //d, Đóng màn hình đen khi chạy
            //Tắt màn hình đen cmd
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //a, Nhập url sau đó nhấn open
            // Điều hướng trình duyệt
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl(txt_Url_83_Hoang.Text);

            //c, Đóng trình duyệt
            driver.Close();

            //e, Đóng mọi cửa sổ liên kết
            driver.Quit();

            //f, Lấy url
            String link_current = driver.Url;
            Console.WriteLine(link_current);
        }

        private void btn_Open_Url_Null_83_Hoang_Click(object sender, EventArgs e)
        {
            //d, Đóng màn hình đen khi chạy
            //Tắt màn hình đen cmd
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //b, Không nhập url, nhấn open sẽ lấy url đã code sẵn
            // Điều hướng trình duyệt
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl("https://drive.google.com/drive/folders/1ahJViibCl-6m2QurTIlrnPF-AS6Zisp9");

            ////c, Đóng trình duyệt
            //driver.Close();

            ////e, Đóng mọi cửa sổ liên kết
            //driver.Quit();

            //f, Lấy url
            String linkCurrent = driver.Url;
            Console.WriteLine(linkCurrent);

            //g, Lấy title
            String urlTitle = driver.Title;
            txt_Title_83_Hoang.Text = urlTitle;

            ////h, Lấy page source
            //String pageSource = driver.PageSource;
            //Console.WriteLine(pageSource);
        }

        private void btn_Bai2_83_Hoang_Click(object sender, EventArgs e)
        {
            //Bài 2

            //Điều hướng đến Google.com
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");

            //Nhập giá trị vào ô tìm kiếm
            IWebElement element = driver.FindElement(By.Name("q"));
            //Truyền vào 1 phần tử trên web với giá trị được nhập sẵn trên code
            if (txt_Bai2_Url_83_Hoang.Text == "" && txt_Bai2_Input_83_Hoang.Text == "")
                element.SendKeys("tu hoc java");
            else //Nhập giá trị bất kỳ của 1 chuỗi sau đó truyền vào 1 phần tử trên web
                element.SendKeys(txt_Bai2_Input_83_Hoang.Text);
        }

        private void btn_Bai3_83_Hoang_Click(object sender, EventArgs e)
        {
            //Bài 3

            //Tắt màn hình đen cmd
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //Điều hướng đến trang web id.ou.edu.vn
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Navigate().GoToUrl("https://www.netflix.com/login");

            //Nhập thông tin của ô tài khoản
            IWebElement e_username = driver.FindElement(By.Name("userLoginId"));
            e_username.SendKeys("underbargamer@gmail.com");

            //Nhập thông tin của ô mật khẩu
            IWebElement e_password = driver.FindElement(By.Name("password"));
            e_password.SendKeys("654321hmn");

            //Đăng nhập
            IWebElement e_login = driver.FindElement(By.CssSelector(".default-ltr-cache-r033w1"));
            e_login.Click();
        }

        private void btn_Bai4_83_Hoang_Click(object sender, EventArgs e)
        {
            //Bài 4

            //Tắt màn hình đen cmd
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            //Điều hướng đến trang web id.ou.edu.vn
            IWebDriver web = new ChromeDriver(chrome);
            web.Navigate().GoToUrl("https://www.netflix.com/login");

            ////Id, name
            //web.FindElement(By.Id(":r0:")).SendKeys("underbargamer@gmail.com");
            //web.FindElement(By.Name("password")).SendKeys("654321hmn");

            ////Class name
            //web.FindElement(By.ClassName("default-ltr-cache-fmygl2 ea3diy34")).SendKeys("test class name by 83_Hoang");

            ////Linktext
            //web.FindElement(By.LinkText("Forgot password?")).Click();

            ////CSS Selector
            //web.FindElement(By.CssSelector("input[type='email']")).SendKeys("Test email by cssselector 83_Hoang");
            //web.FindElement(By.CssSelector("input[type='password']")).SendKeys("Test password by cssselector 83_Hoang");

            ////Xpath
            //web.FindElement(By.XPath("//*[@id=\":r0:\"]")).SendKeys("Test Xpath by 83_Hoang");
        }
    }
}
