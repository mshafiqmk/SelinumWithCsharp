using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelinumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Reference to for Our WebBrowser
            IWebDriver driver = new ChromeDriver();

            //Navigate to Google Page
            driver.Navigate().GoToUrl("https://www.google.com/");

            //Find the element 
            var element = driver.FindElement(By.Name("q"));

            //perorm operation
            element.SendKeys("shafiqkhuidad");

            driver.Close();
        }
    }
}
