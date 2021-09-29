using System;
namespace CSharp_TP1
{
    public class First
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public static void Multiplication()
        {
            int input;

            do
            {
                input = AskUserForParameter();
            } while (input >= 1000);

            Console.WriteLine($"\nTable of {input} :");

            for (int j = 1; j <= 10; j++)
            {
                int value = input * j;

                if (value % 2 == 0)
                {
                    Console.WriteLine($"{input} * {j} = {value}");
                }
            }
        }

    }
}