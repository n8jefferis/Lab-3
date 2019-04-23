using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number between 1 and 100");
                int i = int.Parse(Console.ReadLine());

                
                if (i < 25 && i % 2 == 0)
                {
                    Console.WriteLine(i +" is even and less than 25");
                    //continue;
                }
                else if (i > 25 && i % 2 == 0)
                {
                    Console.WriteLine(i +" is Even");
                    //continue;
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(i +" is odd");
                    //continue;
                }

                Console.WriteLine("Do you want to continue?");
                string answer = Console.ReadLine();

                if (answer == "yes" || answer == "Yes" || answer == "y" || answer == "Y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}
