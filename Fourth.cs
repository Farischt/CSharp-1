using System;
namespace CSharp_TP1
{
    public class Fourth
    {
        private static string[] AskUserForParameter()
        {
            Console.WriteLine("Please enter N & M with a space between (3 12):");

            var line = Console.ReadLine();
            var data = line.Split(' ');
            var n = int.Parse(data[0]);
            var m = int.Parse(data[1]);

            return data;
        }

        public static void Square()
        {
            string[] data = AskUserForParameter();

            var M = int.Parse(data[0]);
            var N = int.Parse(data[1]);

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= M; j++)
                {
                    if ((i == 1 && j == 1) || (i == 1 && j == M) || (i == N && j == 1) || (i == N && j == M))
                    {
                        Console.Write(0);
                    }
                    else if (i == 1 || i == N)
                    {
                        Console.Write("_");
                    }
                    else if (j == 1 || j == M)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}