using System;
using System.IO;
using System.Linq;

namespace DockerConsole
{
    class Program
    {
        static void Main(string[] args)
        {

         

            Console.WriteLine("Local files test");
            var cur = Directory.GetCurrentDirectory();

            Console.WriteLine(cur);
            foreach (var entry in Directory.EnumerateDirectories(cur))
            {
                Console.WriteLine("Folder " + entry);
            }

            Console.WriteLine("Exists: " + Directory.Exists("/foo"));
            
           
        }
    }
}