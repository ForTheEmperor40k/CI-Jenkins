using Aquality.Selenium.Browsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.IO;

namespace MsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var url = Environment.GetEnvironmentVariable("testUrl");
            AqualityServices.Browser.GoTo(url);
            AqualityServices.Browser.Maximize();

            byte[] image = AqualityServices.Browser.GetScreenshot();
            using (var memory = new MemoryStream(image))
            {
                Image imageIn = Image.FromStream(memory);
                Bitmap bmp = new Bitmap(imageIn);
                bmp.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
            }

            AqualityServices.Browser.Quit();
        }

        [TestMethod]
        public void TestMethod2()
        {
            var currentUrl = Environment.GetEnvironmentVariable("testUrl");
            string expectedUrl = "https://www.a1qa.by/";
            Assert.AreEqual(expectedUrl, currentUrl, "Links don't match");
        }
    }
}
