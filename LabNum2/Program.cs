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

                //input
                bool inside = true;
                string input;

                Console.WriteLine("Enter a number between 1-100");

                input = Console.ReadLine();

                while (((Validate(input)) == false))
                {
                    Console.WriteLine("invalid input, please enter a number between 1 and 100: ");
                    Console.ReadLine();

                   
                }


                int inputNum = Convert.ToInt32(input);

                NumberThinker(inputNum);

                Console.WriteLine("type 'no' to quit");
                string quit = Console.ReadLine();
                if (quit.ToLower() == "no")
                {
                    run = false;
                }


            }
        }

        private static bool Validate(string check)
        {
            int value;
            if (int.TryParse(check, out value))
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }


        private static void NumberThinker(int Num)
        {
            if ((Num > 100) || (Num < 1))
            {
                Console.WriteLine("please enter a number between 1 and 100");

            }
            else if ((Num % 2) != 0)
            {
                Console.WriteLine("Number entered {0} is {1}. ", Num, "odd");
            }
            else if ((Num < 26))
            {
                Console.WriteLine("even and less than 25");
            }

            else
            {
                Console.WriteLine("even");
            }
        }
        
    }
}
