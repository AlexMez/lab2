using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNum2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {



                Console.Write("enter a number between 1 and 100: ");
                string input = Console.ReadLine();
                int inputNum = Convert.ToInt32(input);

                if ((inputNum > 100) || (inputNum < 1))
                {
                    Console.WriteLine("please enter a number between 1 and 100");

                }
                else if ((inputNum % 2) != 0)
                {
                    Console.WriteLine("Number entered {0} is {1}. ", inputNum, "odd");
                }
                else if ((inputNum < 26))
                {
                    Console.WriteLine("even and less than 25");
                }

                else
                {
                    Console.WriteLine("even");
                }

                Console.WriteLine("type 'no' to quit");
                string quit = Console.ReadLine();
                if (quit.ToLower() == "no")
                {
                    run = false;
                }


            }
        }
    }
}
