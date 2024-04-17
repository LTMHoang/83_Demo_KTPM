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
            //i, Các lệnh điều hướng
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;

            IWebDriver driver = new ChromeDriver(chrome);

            //GoToUrl
            driver.Navigate().GoToUrl("https://drive.google.com/drive/folders/1ahJViibCl-6m2QurTIlrnPF-AS6Zisp9");

            Thread.Sleep(3000);

            //Back
            driver.Navigate().Back();

            Thread.Sleep(3000);

            //Forward
            driver.Navigate().Forward();

            Thread.Sleep(3000);

            //Refresh
            driver.Navigate().Refresh();

            Thread.Sleep(3000);

            //Close
            driver.Close();
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
    }
}
