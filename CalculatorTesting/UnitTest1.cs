using BasicCalculator;
using System.Collections.Generic;

namespace CalculatorTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-1,-5,-6)]
        [InlineData(-2,-3,-5)]
        public void Add_TwosNegativeNumber_Return_SumofThem(int number1, int number2, int except)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(number1, number2);
            Assert.Equal(except, actual);
        }
        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        public void Add_TwosPostiveNumber_Return_SumofThem(int number1, int number2, int except)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(number1, number2);
            Assert.Equal(except, actual);
        }
        [Theory]
        [MemberData(nameof(Data))]
        public void Add_Twos_MemberData(int number1, int number2, int except)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(number1, number2);
            Assert.Equal(except, actual);
        }
        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] {5,6, 11},
            new object[] {10,20, 30}
        };
    }
    
}