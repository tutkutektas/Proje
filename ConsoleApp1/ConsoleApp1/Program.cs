using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            string link = @"http://www.n11.com/";
            driver.Navigate().GoToUrl(link);

            driver.FindElement(By.ClassName("btnSignIn")).Click();
            driver.FindElement(By.Id("email")).SendKeys("tutkutektas@hot.com");
            driver.FindElement(By.Id("password")).SendKeys("tutkutektaspassword");
            driver.FindElement(By.Id("loginButton")).Click();

        }
    }
}
