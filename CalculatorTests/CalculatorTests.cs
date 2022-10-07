using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit.Sdk;
using xUnitTesting;

namespace CalculatorTests
{
    public class CalculatorTests
    {
      
       NumberHandling numberHandling = new NumberHandling();

        [Fact]
        // Expect to pass.
        public void AdditionTestOne()
        {
            Assert.Equal(4, numberHandling.Addition(2, 2));
        }

  
        // Expect to pass.
        [Fact]
        public void SubtractionTestOne()
        {
            Assert.Equal(4, numberHandling.Subtraction(12, 8, 0));
        }


        // Expect to pass.
        [Fact]
        public void MultiplicationTestOne()
        {
            Assert.Equal(60, numberHandling.Multiplication(5, 12));
           
        }


        // Expect to pass.
        [Fact]
        public void DivisionTestOne()
        {
            Assert.Equal(10, numberHandling.Division(100, 10));

        }

        [Theory]
        [InlineData(2, 2, 0, 4)]
        void AdditionTest(int input_1, int input_2, int input_3, int expected)
        {
            int x1 = input_1;
            int x2 = input_2;
            int x3 = input_3;
            int result = numberHandling.Addition(x1, x2);

            Assert.Equal(expected, result);
        }

        //[Theory]
        //[InlineData(40, 8, 5)]
        //void Divide(int value1, int value2, int value3)
        //{
        //    //arrange
        //    int x1 = value1;
        //    int x2 = value2;
        //    int expected = value3;

        //    //act
        //    int actual = numberHandling.Division(x1, x2);

        //    //assert
        //    Assert.Equal(expected, actual, 0);
        //}





        // Methods To Be Tested
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        // Methods To Be Tested


        ////Addition  
        //public static int Addition(int input_1, int input_2)
        //{
        //    int result = input_1 + input_2;
        //    return result;
        //}

        ////Substraction  
        //public static int Subtraction(int input_1, int input_2)
        //{
        //    int result = input_1 - input_2;
        //    return result;
        //}

        ////Multiplication  
        //public static int Multiplication(int input_1, int input_2)
        //{
        //    int result = input_1 * input_2;
        //    return result;
        //}

        ////Division  
        //public static int Division(int input_1, int input_2)
        //{
        //    int result = input_1 / input_2;
        //    return result;
        //}


    }
}