using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;

namespace Selenium.Screenshot
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");

            driver.Manage().Window.Maximize();

            ITakesScreenshot screen = (ITakesScreenshot)driver;
            
            screen.GetScreenshot().SaveAsFile(@"G:\google.png");

           
        }
    }
}
