using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace agoda.com_test
{
    class Program
    {
        public static IWebDriver driver;

        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            Program.driver = new ChromeDriver(options);

            Extent.BasicReport.StartReport();
            Thread.Sleep(2000);
            WebLogin.Login(ConfigurationSettings.AppSettings["url"].ToString(), ConfigurationSettings.AppSettings["email"].ToString(), ConfigurationSettings.AppSettings["pasword"].ToString());


            Thread.Sleep(2000);
            rezervasyon.rezervasyondetay("Roma", "20/04/2019", "23.04.2019","var",2);
            Thread.Sleep(2000);
            Filtreler.Filtrele();

            //string lokasyon,
            //DateTime dtime1,
            //DateTime dtime2,
            //string cocukcheck,
            //Int16 cocuksay);



            //ExtentDemo.BasicReport.DemoReportPass();
            //ExtentDemo.BasicReport.DemoReportFail();
            Extent.BasicReport.Getresult();
            Extent.BasicReport.EndReport();

            Console.WriteLine("test tamalandı ");




        }
    }
}
