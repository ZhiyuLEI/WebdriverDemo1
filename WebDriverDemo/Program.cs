using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = @"file:///E:/Massey%20Semester%202/Industry_Connect_Tester_Programme/Automation_Scripts/WebDriverDemo/WebDriverDemo/TestPage.html";

            var radioButtons = driver.FindElements(By.Name("color"));
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Selected)
                {
                    Console.WriteLine(radioButton.GetAttribute("value"));
                }
            }

            var checkBox = driver.FindElement(By.Id("check1"));
            checkBox.Click();

            var select = driver.FindElement(By.Id("select1"));
            var tomOption = select.FindElements(By.TagName("option"))[2];
            tomOption.Click();
        }
    }
}
