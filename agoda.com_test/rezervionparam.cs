﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace agoda.com_test
{
    public static class rezervasyon
    {

        public static void rezervasyondetay(string lokasyon, string dtime1, string dtime2,string cocukcheck, string cocuksay)
            {

            Program.driver.FindElement(By.ClassName(Constants.lokasyon)).SendKeys(lokasyon.ToString());
            Thread.Sleep(4000);
            Program.driver.FindElement(By.ClassName("Suggestion__categoryName")).Click();
            Thread.Sleep(2000);
            Program.driver.FindElement(By.ClassName("SearchBoxTextDescription")).Click();
            Thread.Sleep(2000);
            // Thread.Sleep(5000);

           // Program.driver.FindElement(By.ClassName("SearchBoxTextDescription__title")).Click();
           //// Program.driver.Manage().Timeouts().ImplicitWait(10, TimeUnit.SECONDS);
           // for (int i = 0; i < 5; i++)
           // {
           //     Program.driver.FindElement(By.CssSelector("span.DayPicker-NavButton.DayPicker-NavButton--next.ficon.ficon-18.ficon-edge-arrow-right")).Click();
           //    // Program.driver.FindElement(By.CssSelector("span.DayPicker-NavButton.DayPicker-NavButton--next.ficon.ficon-18.ficon-edge-arrow-right").timeouts().implicitlyWait(10, TimeUnit.SECONDS);
           // }
           // Program.driver.FindElement(By.CssSelector(".DayPicker-Months .DayPicker-Month:nth-of-type(2) .DayPicker-Week:nth-of-type(3) .DayPicker-Day--weekends:nth-of-type(6) .DayPicker-Day__label")).Click();
           // // 
            // Program.driver.FindElement(By.ClassName("DayPicker-NavButton")).Click();            
            // Program.driver.FindElement(By.ClassName("DayPicker-NavButton")).Click();
            // IJavaScriptExecutor js = (IJavaScriptExecutor)Program.driver;
            // js.ExecuteScript("document.querySelector('#SearchBoxTextDescription__title').value='20 Nis 2019'");            
            //IWebElement BirthDate = Program.driver.FindElement(By.ClassName(Constants.checkin));
            // //BirthDate.Clear();
            // BirthDate.SendKeys("20-Aug-1985"); 
            //Enter this date details with valid date format
            // Program.driver.FindElement(By.ClassName(Constants.checkin)).SendKeys(dtime1.ToString());
            // Program.driver.FindElement(By.ClassName(Constants.checkout)).SendKeys(dtime2.ToString());


            //Program.driver.FindElement(By.ClassName(Constants.kisisay)).Click();
            //if (cocukcheck == "1")
            //{
            //    Program.driver.FindElement(By.ClassName(Constants.cocukcheck)).Click();
            //    Program.driver.FindElement(By.ClassName(Constants.cocukyas)).Click();
            //    Program.driver.FindElement(By.ClassName("DropdownInput__option")).Click();
            //    Program.driver.FindElement(By.XPath(".//*[@id='DropdownInput__option']/value='2'")).Click();
            //}
            Program.driver.FindElement(By.ClassName("Searchbox__searchButton__text")).Click();            
        }

    }

    //public static class rezervasyonparam2
    //{
    //    static Int16 kisisay = 2;
    //    static DateTime dtime1 = DateTime.Parse("20.04.2019");
    //    static DateTime dtime2 = DateTime.Parse("23.04.2019");
    //    static string lokasyon = "Paris";
    //    static Int32 butce = 500;
    //}



}
