using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace agoda.com_test
{
    class Filtreler
    {
        public static void Filtrele()
        {
            Thread.Sleep(4000);
            Program.driver.FindElement(By.Id("price_box_1")).Clear();
            Thread.Sleep(1000);
            Program.driver.FindElement(By.Id("price_box_1")).SendKeys("500");
            Thread.Sleep(1000);
            Program.driver.FindElement(By.XPath("//*[@class='filter-item-react']")).Click();
            Thread.Sleep(1000);
            Program.driver.FindElement(By.XPath("//*[@class='radio-icon']")).Click();
            Thread.Sleep(1000);

            
            //var element = driver.FindElement(By.id("element-id"));
            var element = Program.driver.FindElement(By.XPath("//*[@id='paymentoptionFilterList']/div[2]/ul/li[2]/span/span[2]"));
            Actions actions = new Actions(Program.driver);
            actions.MoveToElement(element);
            actions.Perform();
            Program.driver.FindElement(By.XPath("//*[@id='paymentoptionFilterList']/div[2]/ul/li[2]/span/span[2]")).Click();
            Thread.Sleep(5000);
            Program.driver.FindElement(By.XPath("//*[@id='hotel-1255297-container']/div/div/section/div[3]/ul/li[1]/h3")).Click();
            Thread.Sleep(1000);         
            element = Program.driver.FindElement(By.ClassName("ChildRoomsList-bookButtonInput"));
            actions.MoveToElement(element);
            actions.Perform();
            Thread.Sleep(1000);
        }
    }
}
