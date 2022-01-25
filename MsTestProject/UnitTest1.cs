using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestProject.Models;
using System;
using System.Drawing;
using System.IO;

namespace MsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private string url = Environment.GetEnvironmentVariable("testUrl");

        private TestDataModel testData = new TestDataModel();

        [TestMethod]
        public void TestMethod1()
        {
            AqualityServices.Browser.GoTo(url);
            AqualityServices.Browser.Maximize();
            string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\") +
                @"Screenshots\");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            byte[] image = AqualityServices.Browser.GetScreenshot();
            using (var memory = new MemoryStream(image))
            {
                Image imageIn = Image.FromStream(memory);
                Bitmap bmp = new Bitmap(imageIn);
                bmp.Save(path + "1.png", System.Drawing.Imaging.ImageFormat.Png);
            }

            AqualityServices.Browser.Quit();
        }

        [TestMethod]
        public void TestMethod2()
        {
            string expectedUrl = "https://www.a1qa.by/";
            Assert.AreEqual(expectedUrl, url, "Links don't match");
        }

        [TestMethod]
        [Ignore("Ignore this test")]
        public void IgnoreTest()
        {
            Assert.IsTrue(true, "Not true");
        }

        [TestMethod]
        public void FailTest()
        {
            Assert.Fail("Test failed");
        }

        [TestMethod]
        public void GetDataTest()
        {
            const string login = "mail@mail.com";
            const string password = "qwerty123";

            Assert.AreEqual(login, testData.Login, $"Logins do not match. Was -{testData.Login}");
            Assert.AreEqual(password, testData.Password, $"Logins do not match. Was -{testData.Password}");
        }
    }
}
