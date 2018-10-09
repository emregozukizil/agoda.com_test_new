using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agoda.com_test
{
    public static class Extent
    {
            [TestFixture]
            public static class BasicReport
            {
                public static ExtentReports extent;
                public static ExtentTest test;

                [OneTimeSetUp]
                public static void StartReport()
                {
                    string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                    string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
                    string projectPath = new Uri(actualPath).LocalPath;

                    string reportPath = projectPath + "Report\\MyOwnReport.html";
                    extent = new ExtentReports(reportPath, true);

                    extent.AddSystemInfo("Host Name", "Yasin ")
                        .AddSystemInfo("Environment", "Palmiye")
                        .AddSystemInfo("User Name", "Yasin ERAYDIN");

                    extent.LoadConfig(projectPath + "extent-config.xml");

                }

                [Test]
                public static void DemoReportPass(string mesaj)
                {
                    test = extent.StartTest("DemoReportPass");
                    Assert.IsTrue(true);
                    test.Log(LogStatus.Pass, mesaj);
                }

                [Test]
                public static void DemoReportFail(string ex)
                {
                    try
                    {
                        test = extent.StartTest("DemoReportFail");
                        Assert.IsTrue(false);
                        // test.Log(LogStatus.Pass, ex + "Assert Pass as condition is False");
                    }
                    catch
                    {
                        test.Log(LogStatus.Pass, "Hata :" + ex);
                    }
                }

                [TearDown]
                public static void Getresult()
                {
                    var status = TestContext.CurrentContext.Result.Outcome.Status;
                    var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
                    var errorMessage = TestContext.CurrentContext.Result.Message;

                    if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
                    {
                        test.Log(LogStatus.Fail, stackTrace + errorMessage);
                    }

                    extent.EndTest(test);
                }

                [OneTimeTearDown]
                public static void EndReport()
                {
                    extent.Flush();
                    extent.Close();
                }
        }
    }
}
