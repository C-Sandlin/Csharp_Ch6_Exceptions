using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calculator = new Calculator();
                int answer = calculator.Divide(42, 0);
                Console.WriteLine($"The answer is {answer}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Something went wrong! {ex.Message}");
            }
        }
    }
}
