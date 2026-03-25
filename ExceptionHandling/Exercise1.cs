using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Exercise1
    {
        public static int Divide(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new NegativeIntegerInputException();
            }
            return a / b;
        }
        public static void DivideUserInputs()
        {
            while (true)
            {
                try
                {
                    int[] inputs = GetUserInputs();
                    int result = Divide(inputs[0], inputs[1]);
                    Console.WriteLine($"Result: {result}");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero. Please try again.");
                }
                catch (NegativeIntegerInputException)
                {
                    Console.WriteLine("This operation does not accept negative values. Please try again.");
                }
                
            }
        }
        private static int[] GetUserInputs()
        {
            Console.WriteLine("Enter divisor:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter dividend:");
            int b = int.Parse(Console.ReadLine());
            return new int[] { a, b };
        }
    }
}
