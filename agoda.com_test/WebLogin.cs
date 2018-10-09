using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agoda.com_test
{
    class WebLogin
    {
        public static void Login(string url, string email, string pasword)

        {
            try
            {
                Program.driver.Navigate().GoToUrl(url);

                try
                {
                    if (Program.driver.FindElement(By.ClassName("signin-button__text")).Displayed == true)
                        Extent.BasicReport.DemoReportPass(url + " : Adresine Giriş Yapıldı");
                        Program.driver.FindElement(By.ClassName("signin-button__text")).Click();
                }
                catch (Exception ex)
                {
                    Extent.BasicReport.DemoReportFail(ex.ToString());
                }

                Program.driver.FindElement(By.Id("signin-email-input")).SendKeys(email);
                Program.driver.FindElement(By.Id("signin-password-input")).SendKeys(pasword);
                Program.driver.FindElement(By.Id("sign-in-submit-button")).Click();

                try
                {
                    if (Program.driver.FindElement(By.ClassName("signin-text")).Displayed == true)
                        Extent.BasicReport.DemoReportPass("Müşteri Giriş Yaptı");
                }
                catch (Exception ex)
                {
                    Extent.BasicReport.DemoReportFail(ex.ToString());
                }               

            }
            catch
            {
                try
                {
                    try
                    {
                        if (Program.driver.FindElement(By.ClassName("sign-in-btn")).Displayed == true)
                            Extent.BasicReport.DemoReportPass(url + " : Adresine Giriş Yapıldı");
                        Program.driver.FindElement(By.ClassName("sign-in-btn")).Click();
                        Program.driver.FindElement(By.ClassName("sign-in-btn")).Click();
                        
                    }
                    catch (Exception ex)
                    {
                        Extent.BasicReport.DemoReportFail(ex.ToString());
                    }

                    Program.driver.FindElement(By.Id("signin-email-input")).SendKeys(email);
                    Program.driver.FindElement(By.Id("signin-password-input")).SendKeys(pasword);
                    Program.driver.FindElement(By.Id("sign-in-submit-button")).Click();

                    try
                    {
                        if (Program.driver.FindElement(By.ClassName("signin-text")).Displayed == true)
                            Extent.BasicReport.DemoReportPass("Müşteri Giriş Yaptı");
                    }
                    catch (Exception ex)
                    {
                        Extent.BasicReport.DemoReportFail(ex.ToString());
                    }

                }
                catch
                {

                }

            }

        }        

    }
}
