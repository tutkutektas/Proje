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

            //LOGİN KISMI
            
            //driver.FindElement(By.ClassName("btnSignIn")).Click();
            //driver.FindElement(By.Id("email")).SendKeys("tutkutektas@hot.com");
            //driver.FindElement(By.Id("password")).SendKeys("tutkutektaspassword");
            //driver.FindElement(By.Id("loginButton")).Click();

            //Arama sonucunda 2. sayfa seçilme işlemi ve rastgele bir ürünü seçme işlemi

            driver.FindElement(By.Id("searchData")).SendKeys("Bilgisayar");
            driver.FindElement(By.ClassName("searchBtn")).Click();
            driver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[4]/a[2]")).Click();
            //Yukardaki kodda .XPATH ile tüm sayfada döndük id si contentListing içine girip en alttaki 2. seçeneği seçtirdik.
            //Bunları yaparken contentListing içinde tek div var ona girdik sonra o divin içindede tek div var
            //3. kısımda 2 tane div var biz ortadaki olan div[2] yi seçtik. Son kısımda 4 div var. en altta sayfa geçişlerini sağlayan 4.Divi seçtik
            //4.Divin içindende sayfa adlar 'a' ile sıralanmış o yüzden a2 yi seçtik.
            driver.FindElement(By.XPath(".//*[@id='p-402919973']/div/a")).Click();

            //Son Kısım Sepet işlemleri
            driver.FindElement(By.ClassName("btnAddBasket")).Click();
            driver.FindElement(By.ClassName("myBasket")).Click();
            driver.FindElement(By.ClassName("spinnerArrow")).Click();
            driver.FindElement(By.ClassName("removeProdData")).Click();
      












        }
    }
}
