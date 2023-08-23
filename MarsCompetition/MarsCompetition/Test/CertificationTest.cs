using AventStack.ExtentReports;
using MarsCompetition.Pages;
using MarsCompetition.TestModel;
using MarsCompetition.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsCompetition.Test
{
    public class CertificationTest : CommonDriver
    {
#pragma warning disable CS8618

        private CertificationPage certificationPageObj = new CertificationPage();
        private ExtentReports extent;
        [Test, Order(1)]
        public void AddCertification_Test()
        {
            CommonDriver driver = new CommonDriver();
            driver.InitializeExtentReports();
            string testName = "AddCertification";
            driver.SetupTest(testName);
            string sFile = "AddCerPosdata.json";
            // Read test data from the JSON file using JsonHelper
            List<CertificationTestModel> AddCerPosdata = Jsonhelper.ReadTestDataFromJson<CertificationTestModel>(sFile);
            Console.WriteLine(AddCerPosdata.ToString());
            foreach (var data in AddCerPosdata)
            {
                // Access individual test data properties
                string certificate = data.certificate;
                Console.WriteLine(certificate);
                string certifiedFrom = data.certifiedFrom;
                Console.WriteLine(certifiedFrom);
                string year = data.year;
                Console.WriteLine(year);
                string screenshotName = "AddCerPosdata";
                driver.CaptureScreenshot(screenshotName);
                certificationPageObj.addCertifications(certificate, certifiedFrom, year);
                string newCertificate = certificationPageObj.getVerifyCertificationList();
                Assert.AreEqual(newCertificate, certificate, "actucal data and Expected data do match");
            }
        }
        [Test, Order(2)]
        public void UpdateCertification_Test()
        {
            CommonDriver driver = new CommonDriver();
            driver.InitializeExtentReports();
            string testName = "UpdateCertification";
            driver.SetupTest(testName);
            string sFile = "EditCerPosdata.json";
            // Read test data from the JSON file using JsonHelper
            List<CertificationTestModel> EditCerPosdata = Jsonhelper.ReadTestDataFromJson<CertificationTestModel>(sFile);
            Console.WriteLine(EditCerPosdata.ToString());
            foreach (var data in EditCerPosdata)
            {
                // Access individual test data properties
                string certificate = data.certificate;
                Console.WriteLine(certificate);
                string certifiedFrom = data.certifiedFrom;
                Console.WriteLine(certifiedFrom);
                string year = data.year;
                Console.WriteLine(year);
                string screenshotName = "EditCerPosdata";
                driver.CaptureScreenshot(screenshotName);
                certificationPageObj.updateCertifications(certificate, certifiedFrom, year);
                string newUpdatedCertificate = certificationPageObj.getVerifyUpdateCertificationsList();
                Assert.AreEqual(newUpdatedCertificate, certificate, "actucal data and Expected data do match");
            }
        }
        [Test, Order(3)]
        public void deleteCertification_Test()
        {
            CommonDriver driver = new CommonDriver();
            driver.InitializeExtentReports();
            string testName = "DeleteCertification";
            driver.SetupTest(testName);
            string screenshotName = "Delete Certificate";
            driver.CaptureScreenshot(screenshotName);
            certificationPageObj.deleteCertification();
            string verifyDeletedData = certificationPageObj.getVerifyDeleteCertificationList();
            Assert.AreNotEqual(verifyDeletedData, "actual data and expert data do not match");

        }
        

    }
}
