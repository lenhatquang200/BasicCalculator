using BasicCalculator;

namespace CalculatorTest
{
    public class UnitTest1
    {
        //[Fact]
        //public void Add_TwosNumber_ReturnSumofThem()
        //{
        //    var value1 = 5;
        //    var value2 = 10;
        //    Calculator calculator = new Calculator();
        //    Assert.Equal(15,calculator.Add(value1, value2));
        //}
        [Theory]
        //[ClassData(typeof(CalculatorTestData))]
        [MemberData(nameof(DataTest))]
        public void Add_TwosNumber_ReturnSumofThem(int number1, int number2, int except)
        {
            Calculator calculator = new Calculator();
            Assert.Equal(except, calculator.Add(number1, number2));
        }
        public static IEnumerable<object[]> DataTest =>
            new List<object[]>
            {
                new object[]{1,2,3},
                new object[]{-1,2,1},
                new object[]{-1,-2,-3},
            };
    }
}