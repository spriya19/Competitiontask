using AventStack.ExtentReports;
using MarsCompetition.Pages;
using MarsCompetition.TestModel;
using MarsCompetition.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsCompetition.Test
{
    public class NegativeTest : CommonDriver
    {
#pragma warning disable CS8618


        private EducationPage educationPageObj = new EducationPage();
        private CertificationPage certificationPageObj = new CertificationPage();
        private ExtentReports extent;
        [Test, Order(1)]
        public void AddNegativeEducation_Test()
        {
            CommonDriver driver = new CommonDriver();
            driver.InitializeExtentReports();
            string testName = "AddNegativeEducation";
            driver.SetupTest(testName);

            // Read test data from the JSON file using JsonHelper
            string sFile = "AddEduNegdata.json";
            List<EducationTestModel> AddEduNegdata = Jsonhelper.ReadTestDataFromJson<EducationTestModel>(sFile);
            Console.WriteLine(AddEduNegdata.ToString());
            foreach (var data in AddEduNegdata)
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
                string screenshotName = "AddEduNegdata";
                driver.CaptureScreenshot(screenshotName);
                educationPageObj.addNegativeEdu(university, country, title, degree, graduationyear);

            }

        }
        [Test, Order(2)]
        public void updateNegativeEducation_Test()
        {
            CommonDriver driver = new CommonDriver();
            driver.InitializeExtentReports();
            string testName = "UpdateNegativeEducation";
            driver.SetupTest(testName);
            // Read test data from the JSON file using JsonHelper
            string sFile = "UpdateEduNegdata.json";
            List<EducationTestModel> UpdateEduNegdata = Jsonhelper.ReadTestDataFromJson<EducationTestModel>(sFile);
            Console.WriteLine(UpdateEduNegdata.ToString());
            foreach (var data in UpdateEduNegdata)
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
                string screenshotName = "UpdateEduNegdata";
                driver.CaptureScreenshot(screenshotName);
                educationPageObj.updateNegativeEdu(university, country, title, degree, graduationyear);
            }

        }
        [Test, Order(3)]
        public void AddNegativeCertification_Test()
        {
            CommonDriver driver = new CommonDriver();
            driver.InitializeExtentReports();
            string testName = "AddNegativeCertification";
            driver.SetupTest(testName);
            string sFile = "AddCerNegdata.json";
            // Read test data from the JSON file using JsonHelper
            List<CertificationTestModel> AddCerNegdata = Jsonhelper.ReadTestDataFromJson<CertificationTestModel>(sFile);
            Console.WriteLine(AddCerNegdata.ToString());
            foreach (var data in AddCerNegdata)
            {
                // Access individual test data properties
                string certificate = data.certificate;
                Console.WriteLine(certificate);
                string certifiedFrom = data.certifiedFrom;
                Console.WriteLine(certifiedFrom);
                string year = data.year;
                Console.WriteLine(year);
                string screenshotName = "AddCerNegdata";
                driver.CaptureScreenshot(screenshotName);
                certificationPageObj.addNegativeCertifications(certificate, certifiedFrom, year);

            }
        }
        [Test, Order(4)]
        public void UpdateNegativeCertification_Test()
        {
            CommonDriver driver = new CommonDriver();
            driver.InitializeExtentReports();
            string testName = "UpdateNegativeCertification";
            driver.SetupTest(testName);
            string sFile = "UpdateCerNegdata.json";
            // Read test data from the JSON file using JsonHelper
            List<CertificationTestModel> UpdateCerNegdata = Jsonhelper.ReadTestDataFromJson<CertificationTestModel>(sFile);
            Console.WriteLine(UpdateCerNegdata.ToString());
            foreach (var data in UpdateCerNegdata)
            {
                // Access individual test data properties
                string certificate = data.certificate;
                Console.WriteLine(certificate);
                string certifiedFrom = data.certifiedFrom;
                Console.WriteLine(certifiedFrom);
                string year = data.year;
                Console.WriteLine(year);
                string screenshotName = "UpdateCerNegdata";
                driver.CaptureScreenshot(screenshotName);
                certificationPageObj.updateNegativeCertifications(certificate, certifiedFrom, year);

            }
        }
    }
}
