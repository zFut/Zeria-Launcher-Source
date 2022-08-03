using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Zeria_Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string launcherver = "0.0.2rev1";
            
            Console.Title = "Zeria launcher " + launcherver;
            Console.WriteLine("Welcome to the Zeria launcher! (" + launcherver + ")");
            Console.WriteLine("Enter game code:");
            string gamecode = Console.ReadLine();
            byte[] data = Convert.FromBase64String(gamecode);
            string joinargument = Encoding.UTF8.GetString(data);
            /*Console.WriteLine("argument: " + urmomlol);
            Console.ReadKey();*/

            Process game = new Process();
            game.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + @"Zeria13.exe";
            game.StartInfo.Arguments = joinargument;
            game.Start();

            Console.WriteLine("Zeria will launch in a few seconds.");

            Console.ReadKey();
        }
    }
}
