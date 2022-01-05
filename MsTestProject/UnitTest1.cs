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
        private string url = Environment.GetEnvironmentVariable("testUrl");

        [TestMethod]
        public void TestMethod1()
        {
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
            string expectedUrl = "https://www.a1qa.by/";
            Assert.AreEqual(expectedUrl, url, "Links don't match");
        }
    }
}
