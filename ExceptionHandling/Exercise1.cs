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
                catch (NegativeIntegerInputException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }
        private static int[] GetUserInputs()
        {
            Console.WriteLine("Enter divisor:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter dividend:");
            int b = int.Parse(Console.ReadLine());
            if (a < 0 && b < 0)
            {
                throw new NegativeIntegerInputException(new int[] { a, b });

            }
            else if (a < 0)
            {
                throw new NegativeIntegerInputException(new int[] { a });
            }
            if (b < 0)
            {
                throw new NegativeIntegerInputException(new int[] { b });
            }
            return new int[] { a, b };
        }
    }
}
