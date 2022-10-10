using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTesting
{
    public class NumberHandling
    {

        //Addition  
        public int Addition(int input_1, int input_2)
        {

            int result = input_1 + input_2;
            return result;
        }

        //Substraction  
        public int Subtraction(int input_1, int input_2)
        {
         
            int result = input_1 - input_2 ;
            return result;
        }
        //Multiplication  
        public int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
        //Division  
        public int Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            return result;
        }

        // Overloaded Addition
        public int Addition(int input_1)
        {
            Console.WriteLine($"Type in values for the array, it can hold {input_1} items");
            Console.WriteLine("This array will add up all the numbers you type in and display the result");
            int[] sumArray = new int[input_1];
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();
            int returnSum = sumArray.Sum();
            return returnSum;
        }



        //Overloaded Subtraction

        public int Subtraction(int input_1)
        {
            int[] sumArray = new int[input_1];
            Console.WriteLine("Will sum up the array from input_1 and subtract that with input_2\n" +
                "could not think of a good way to make use of subtraction in an array.");
            Console.ReadLine();
            Console.WriteLine(sumArray.Sum());
            int returnSum = sumArray.Sum();         
            
            return returnSum;
        }
    }
}
