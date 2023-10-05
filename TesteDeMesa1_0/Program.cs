using System;

namespace TesteDeMesa1_0
{
    class Program
    {
        static void Main(string[] args)
        {
                int a = 10, b = 20, c;
                c = (a + b) / 2;
                Console.WriteLine(c);
                c = c - 40;
                int[] v = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    if (i == 3)
                    {
                        v[i] = a + b + c;
                    }
                }
            Console.WriteLine(v[3]);
        }
    }
}
