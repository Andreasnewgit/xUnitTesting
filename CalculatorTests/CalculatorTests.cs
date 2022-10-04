using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit.Sdk;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        string message = ("Expected to fail");

        [Fact]
        // Expect to pass.
        public void AdditionTestOne()
        {
            Assert.Equal(4, Addition(2, 2));
        }

        [Fact]
        // Expect to fail.
        public void AdditionTestFail()
        {
            Assert.Equal(4, Addition(2, 3));
        }
        // Expect to pass.
        [Fact]
        public void SubtractionTestOne()
        {
            Assert.Equal(4, Subtraction(12, 8));
        }

        // Expect to fail.
        [Fact]
        public void SubtractionTestFail()
        {           
            Assert.Equal(4, Subtraction(8, 12));
            
        }

        // Expect to pass.
        [Fact]
        public void MultiplicationTestOne()
        {
            Assert.Equal(60, Multiplication(5, 12));
           
        }

        // Expect to fail.
        [Fact]
        public void MultiplicationTestFail()
        {
            Assert.Equal(72, Multiplication(5, 12));
            Assert.False(true, message = "Expect to fail");
        }

        // Expect to pass.
        [Fact]
        public void DivisionTestOne()
        {
            Assert.Equal(10, Division(100, 10));

        }

        // Expect to fail.
        [Fact]
        public void DivisionTestFail()
        {
            //Assert.Equal(10, Division(100, 100));
            Assert.Throws<TrueException>(() => Assert.Equal(10, Division(100, 100)));
            
        }


        // Expect to fail.
        [Fact]
        public void DivideByZero()
        {
            //Assert.Equal(10, Division(100, 0));
            Assert.Throws<DivideByZeroException>(() => Assert.Equal(10, Division(100, 0)));

        }



        // Methods To Be Tested
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        // Methods To Be Tested


        //Addition  
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }

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