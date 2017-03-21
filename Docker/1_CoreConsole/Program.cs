using System;
using System.Linq;

namespace DockerConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            foreach (var key in Environment.GetEnvironmentVariables().Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();


            Console.WriteLine("Hello World!");
        }
    }
}