using System;
using System.IO;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            Environment.CurrentDirectory = Environment.GetEnvironmentVariable("windir");
            DirectoryInfo info = new DirectoryInfo(".");

            Console.WriteLine("Directory Info: {0}", info.FullName);
        }

        public static void HelloUser()
        {
            Console.WriteLine("User Name: {0}", Environment.UserName); ;
        }
    }
}
