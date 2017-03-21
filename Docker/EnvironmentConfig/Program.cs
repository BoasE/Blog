using System;
using System.IO;
using System.Linq;

namespace DockerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
			
            Console.WriteLine("Local env test");
            var cur = Directory.GetCurrentDirectory();

            Console.WriteLine(cur);
            var val = Environment.GetEnvironmentVariable("mydb");
            Console.WriteLine("env: " +val);
           
        }
    }
}