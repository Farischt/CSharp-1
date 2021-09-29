using System;

namespace CSharp_TP1
{
    class Program
    {

        public static int Menu()
        {

            int choice;
            Console.WriteLine("\n\nWelcome to TP1 program by Faris CHTATOU !");
            Console.WriteLine("1 - Question 1.");
            Console.WriteLine("2 - Question 2.");
            Console.WriteLine("3 - Question 3.");
            Console.WriteLine("4 - Question 4.");
            Console.WriteLine("5 - Question 5.");
            Console.WriteLine("6 - Quit.");

            do
            {
                Console.WriteLine("Please choose a valid option :");
                int.TryParse(Console.ReadLine(), out var result);
                choice = result;
            } while (choice < 1 ^ choice > 6);
            return choice;

        }

        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 6)
            {

                choice = Program.Menu();

                if (choice == 1)
                {
                    First.Multiplication();
                }

                else if (choice == 2)
                {
                    int secondChoice = Second.Menu();
                    if (secondChoice == 1)
                    {
                        Second.PrimeNumbers();
                    }
                    else if (secondChoice == 2)
                    {
                        Second.Fibonacci();
                    }
                    else
                    {
                        Second.Factorial();
                    }

                }

                else if (choice == 3)
                {
                    Third.Divide10();
                }

                else if (choice == 4)
                {
                    Fourth.Square();
                }

                else if (choice == 5)
                {
                    Fifth.JSONParse();
                }
            }

            Console.WriteLine("\nThanks for testing !");



        }
    }
}
