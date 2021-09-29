using System;
namespace CSharp_TP1
{
    public class Third
    {
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        public static void Divide10()
        {
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    int a = 10 / PowerFunction(i);
                    Console.Write($"{a} with index {i}\n");
                }
                catch (Exception e)
                {
                    Console.Write($"Error handler: {e}\n");
                }
            }
        }
    }
}