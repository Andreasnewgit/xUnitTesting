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


            string action = "";
            while (action.ToLower() != "exit")
            {
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division \n");                
                Console.WriteLine("Type exit to End Program");
                action = Console.ReadLine();
                string input_1 = "0";      

                if (action.ToLower() != "exit")
                {
                    Console.WriteLine("Enter 1st input");
                    input_1 = Console.ReadLine();
                }

                Console.Write("Ange dina tal, separerade med mellanslag: "); 
                string userInput = input_1;
                int arrLength = 0;
                string[] inputArray = userInput.Split(' ');
                int[] array1 = new int[userInput.Length];

                for (int i = 0; i < arrUserInput.Length; i++)
                {
                    array1[i] = int.Parse(arrUserInput[i]);
                }
                int intOne = arr[0];
                int intTwo = arr[1];


                int result = 0;
                int[] sumArray = new int[3];
                switch (action.ToLower())
                {
                    case "1":                        
                            result = numberHandling.Addition(input_1, input_2);
                            break;
                        
                    case "2":                  
                            result = numberHandling.Subtraction(input_1, input_2);
                            break;                       
                    case "3":                        
                            result = numberHandling.Multiplication(input_1, input_2);
                            break;                        
                    case "4":                       
                            result = numberHandling.Division(input_1, input_2);
                            break;

                }
                if(action.ToLower() != "exit")
                {
                    Console.WriteLine("The result is {0}", result);
                    Console.ReadKey();
                }
               
            }          
        }
    }
}

