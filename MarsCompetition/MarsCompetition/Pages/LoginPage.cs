using DocumentFormat.OpenXml.Bibliography;
using MarsCompetition.Utilities;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsCompetition.Pages
{
    public class LoginPage : CommonDriver
    {
        private static IWebElement signInButton => driver.FindElement(By.XPath("//a[text()='Sign In']"));
        private static IWebElement emailTextBox => driver.FindElement(By.Name("email"));
        private static IWebElement passwordTextBox => driver.FindElement(By.Name("password"));
        private static IWebElement loginButton => driver.FindElement(By.XPath("//button[text()='Login']"));

        public void InitializeDriver()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

        }

        public void LoginSteps()
        {

            // Read login credentials from the JSON file
            string jsonFilePath = "C:\\ICProject\\Marsqatask\\Competitiontask\\MarsCompetition\\MarsCompetition\\Jsondatafiles\\Logindata.json";
            // Deserialize the JSON content into LoginCredentials object
            string jsonContent = File.ReadAllText(jsonFilePath);

            // Parse JSON using JObject
            JObject jsonObject = JObject.Parse(jsonContent);
#pragma warning disable CS8602

            string email = jsonObject["email"].ToString();
            string password = jsonObject["password"].ToString();

            signInButton.Click();

            // Enter the provided email
            emailTextBox.SendKeys(email);

            // Enter the provided password
            passwordTextBox.SendKeys(password);

            // Click the "Login" button
            //Wait.WaitToBeClickable(driver, "XPath", "//button[text()='Login']", 5);
            loginButton.Click();
        }

    }
}
