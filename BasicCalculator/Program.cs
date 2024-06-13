namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Calculator calculator = new Calculator();

                Console.WriteLine("Basic Calculator");
                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /):");
                string operation = Console.ReadLine();

                try
                {
                    double result = 0;

                    switch (operation)
                    {
                        case "+":
                            result = calculator.Add(num1, num2);
                            break;
                        case "-":
                            result = calculator.Subtract(num1, num2);
                            break;
                        case "*":
                            result = calculator.Multiply(num1, num2);
                            break;
                        case "/":
                            result = calculator.Divide(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Invalid operation.");
                            return;
                    }

                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
    }
}
