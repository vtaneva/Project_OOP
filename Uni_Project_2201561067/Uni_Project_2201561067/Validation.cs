using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_Project_2201561067
{
    public class Validation
    {
        public static string ValidationYN(string name)
        {
            string answer = "";
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine($"\nDo you add more {name}?\t Answer Y/N");
                answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    validInput = true;
                }
                else if (answer.ToLower() == "n")
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("\nWrong answer! Please use Y (for YES) or N (for NO) \n");
                }
            }
            return answer;
        }
    }
}
