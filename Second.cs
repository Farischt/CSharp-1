using System;
namespace CSharp_TP1
{
    public class Second
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public static int Menu()
        {
            int choice;

            Console.WriteLine("Welcome to question 2 menu.");
            Console.WriteLine("1 - List of prime numbers.");
            Console.WriteLine("2 - Fibonacci function.");
            Console.WriteLine("3 - Factorial function");

            do
            {
                Console.WriteLine("Please choose a valid option :");
                int.TryParse(Console.ReadLine(), out var result);
                choice = result;
            } while (choice > 3 ^ choice < 1);

            return choice;
        }


        public static void PrimeNumbers()
        {
            int input;

            do
            {
                input = AskUserForParameter();
            } while (input >= 1000);

            for (int j = 0; j <= input; j++)
            {
                bool isPrime = true;

                for (int index = 2; index <= Math.Sqrt(j); index++)
                {
                    if (j % index == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == true)
                {
                    Console.Write($"{j}, ");
                }
            }
        }


        public static int Fibonacci()
        {
            int input;

            do
            {
                input = AskUserForParameter();
            } while (input >= 1000);

            int next = 0;
            int n0 = 0;
            int n1 = 1;

            for (int i = 0; i <= input - 1; i++)
            {
                Console.Write($"{next}, ");
                next = n0 + n1;
                n0 = n1;
                n1 = next;
            }

            return next;
        }

        public static int Factorial()
        {
            int input = AskUserForParameter();
            int factor = 1;

            for (int i = 1; i <= input; i++)
            {
                factor *= i;
            }

            Console.Write(factor);
            return factor;
        }

    }
}