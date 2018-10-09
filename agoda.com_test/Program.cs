﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace agoda.com_test
{
    class Program
    {
        static string browserkod = ConfigurationSettings.AppSettings["browser"].ToString();
        public static IWebDriver driver;

        static void Main(string[] args)
        {
            if (browserkod == "1")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("start-maximized");
                Program.driver = new ChromeDriver(options);
            }
            else
            {
                Program.driver = new EdgeDriver();
            }
            

            Extent.BasicReport.StartReport();
            Thread.Sleep(2000);
            WebLogin.Login(ConfigurationSettings.AppSettings["url"].ToString(), ConfigurationSettings.AppSettings["email"].ToString(), ConfigurationSettings.AppSettings["pasword"].ToString());


            Thread.Sleep(2000);


            OleDbConnection xlsxbaglanti = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\\bel3.xls';Extended Properties=Excel 8.0;");
            DataTable tablo = new DataTable();
            

            int kayitsay = 0; 
            xlsxbaglanti.Open(); 
            OleDbCommand komut = new OleDbCommand("SELECT * FROM [YeniSayfa$]", xlsxbaglanti); 
            OleDbDataReader oku = komut.ExecuteReader(); 
            while (oku.Read())
            {               
                string sehir = oku["Sehir"].ToString();
                string tarih = oku["Tarih1"].ToString();
                string tarih2 = oku["Tarih2"].ToString();
                string cocuksecim = oku["Cocuk"].ToString();
                string cocukyas = oku["CocukYas"].ToString();
                kayitsay++;

                rezervasyon.rezervasyondetay(sehir, tarih, tarih2, cocuksecim, cocukyas);
                Thread.Sleep(2000);
                Filtreler.Filtrele();
            }

            xlsxbaglanti.Close(); //Bağlantıyı kapatıyoruz.
            kayitsay = 0; //Sayacı sıfırlıyoruz.



            //string lokasyon,,,,
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
