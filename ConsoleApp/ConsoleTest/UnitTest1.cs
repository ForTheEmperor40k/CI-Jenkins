using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace ConsoleTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = @"Directory Info: ";
        private const string ExpectedSecond = @"User Name: ";

        [TestMethod]
        public void TestMethod1()
        {
            Environment.CurrentDirectory = Environment.GetEnvironmentVariable("windir");
            DirectoryInfo info = new DirectoryInfo(".");

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp.Program.Main();

                var result = sw.ToString().Trim();

                Assert.AreEqual(Expected + info.FullName,
                    result, "Strings are not equal");
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp.Program.HelloUser();

                var result = sw.ToString().Trim();

                Assert.AreEqual(ExpectedSecond + Environment.UserName,
                   result, "Strings are not equal");
            }
        }
    }
}
