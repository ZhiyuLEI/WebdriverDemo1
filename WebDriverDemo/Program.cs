using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); //Implicit Wait
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


            var select2 = driver.FindElement(By.Id("select2"));
            var selectElement = new SelectElement(select2);
            selectElement.SelectByText("Frank");

            var outerTable = driver.FindElement(By.TagName("table"));
            var innerTable = outerTable.FindElement(By.TagName("table"));
            var row = innerTable.FindElements(By.TagName("td"))[1];
            Console.WriteLine(row.Text);

            var row2 = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[2]/table/tbody/tr[2]/td"));
            Console.WriteLine(row2.Text);

            
        }
    }
}
