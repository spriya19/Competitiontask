using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using MarsCompetition.Pages;
using MarsCompetition.TestModel;
using MarsCompetition.Utilities;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace MarsCompetition.Test
{
    [TestFixture]
    public class EducationTest : CommonDriver
    {
#pragma warning disable CS8618


        private EducationPage educationPageObj = new EducationPage();
        private ExtentReports extent;
        [Test, Order(1)]
        public void AddEducation_Test()
        {
            CommonDriver driver = new CommonDriver();
            driver.InitializeExtentReports();
            string testName = "CreateEduPosdata";
            driver.SetupTest(testName);

            // Read test data from the JSON file using JsonHelper
            string sFile = "CreateEduPosdata.json";
            List<EducationTestModel> CreateEduPosdata = Jsonhelper.ReadTestDataFromJson<EducationTestModel>(sFile);
            Console.WriteLine(CreateEduPosdata.ToString());
            foreach (var data in CreateEduPosdata)
            {
                string university = data.University;
                Console.WriteLine(university);
                string country = data.Country;
                Console.WriteLine(country);
                string title = data.Title;
                Console.WriteLine(title);
                string degree = data.Degree;
                Console.WriteLine(degree);
                string graduationyear = data.Graduationyear;
                Console.WriteLine(graduationyear);
                string screenshotName = "CreateEduPosdata";
                driver.CaptureScreenshot(screenshotName);
                educationPageObj.addEducation(university, country, title, degree, graduationyear);
                Console.WriteLine("Education has been Added");
                string newEducationData = educationPageObj.getVerifyNewEducationData();
                Assert.AreEqual(newEducationData, country, "Actual data and Expected data do match");

            }

        }
        [Test, Order(2)]
        public void updateEducation_Test()
        {
            CommonDriver driver = new CommonDriver();
            driver.InitializeExtentReports();
            string testName = "UpdateEduPosdata";
            driver.SetupTest(testName);
            // Read test data from the JSON file using JsonHelper
            string sFile = "UpdateEduPosdata.json";
            List<EducationTestModel> UpdateEduPosdata = Jsonhelper.ReadTestDataFromJson<EducationTestModel>(sFile);
            Console.WriteLine(UpdateEduPosdata.ToString());
            foreach (var data in UpdateEduPosdata)
            {
                // Access the LoginData values
                string university = data.University;
                Console.WriteLine(university);
                string country = data.Country;
                Console.WriteLine(country);
                string title = data.Title;
                Console.WriteLine(title);
                string degree = data.Degree;
                Console.WriteLine(degree);
                string graduationyear = data.Graduationyear;
                Console.WriteLine(graduationyear);
                string screenshotName = "UpdateEduPosdata";
                driver.CaptureScreenshot(screenshotName);
                educationPageObj.updateEducation(university, country, title, degree, graduationyear);
                string newUpdatedEdu = educationPageObj.getVerifyUpdateEducation();
                Assert.AreEqual(newUpdatedEdu, country, "Actual updated data and Expected updated data do match");
            }
        }
        [Test, Order(3)]
        public void deleteEducation_Test()
        {
            CommonDriver driver = new CommonDriver();
            driver.InitializeExtentReports();
            string testName = "DeleteEducation";
            driver.SetupTest(testName);
            string screenshotName = "Delete Education";
            driver.CaptureScreenshot(screenshotName);
            educationPageObj.deleteEducation();
            string verifyDeletedData = educationPageObj.getVerifyDeletedEducation();
            Assert.AreNotEqual(verifyDeletedData, "actual data and expert data do not match");

        }
    }
}
