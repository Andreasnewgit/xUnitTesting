using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitTesting;

namespace CalculatorApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            NumberHandling numberHandling = new NumberHandling();

            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
            Console.WriteLine("Press 5 for Overloaded Addition \n");
            Console.WriteLine("Press 6 for Overloaded Subtraction \n");
            Console.WriteLine("Press 0 to End Program");
            int action = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());         
            int input_3 = 0;
            
            
            int result = 0;
            int[] sumArray = new int[3];
            switch (action)
            {
                case 1:
                    {
                        result = numberHandling.Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = numberHandling.Subtraction(input_1, input_2, input_3);
                        break;
                    }
                case 3:
                    {
                        result = numberHandling.Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = numberHandling.Division(input_1, input_2);
                        break;
                    }

                case 5:
                    {
                        result = numberHandling.Addition(input_1);
                        break;
                    }
                case 6:
                    {
                        result = numberHandling.Subtraction(input_1);
                        break;
                    }



                default:
                    Console.WriteLine("Wrong action! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }
    }
}

