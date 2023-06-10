using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni_Project_2201561067.Output;

namespace Uni_Project_2201561067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("\t\t Welcome!");
            Console.WriteLine("************************************************************");
            Menu.HomeScreen();
            for(; ; )
            { Menu.SecondMenu(); }

        }
    }
}
