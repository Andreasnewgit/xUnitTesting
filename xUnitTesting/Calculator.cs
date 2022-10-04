using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorApp
{
    class Calculator
    {
        static void Main(string[] args)
        {

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
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }

                case 5:
                    {
                        result = Addition();
                        break;
                    }


                default:
                    Console.WriteLine("Wrong action! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }

     
        //Addition  
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }



        //Overloaded Addition  
        // ***********************
        public static int Addition()
        {
            int i;
            Console.WriteLine("Please enter 3 numbers into the array to get the sum");

            int[] grades = new int[3];
            for (i = 0; i < grades.Length; i++);
            {
                grades[i] = Convert.ToInt32(Console.In.ReadLine());
            }
            for (i = 0; i < grades.Length; i++);
            {
                Console.WriteLine(grades[i] + " ");
            }
            int result = i;
            return result;
        }
        //Overloaded Addition  
        // ***********************



        //Substraction  
         public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
        //Division  
        public static int Division(int input_1, int input_2)
        {

            int result = input_1 / input_2;
            return result;
        }
    }
}

