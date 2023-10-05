// See https://aka.ms/new-console-template for more information
using System;
{
    int a = 7;
    int b = a - 6;
    int[] v = new int[6];
    while (b < a)
    {
        v[b] = b + a;
        b = b + 2;
        Console.WriteLine($"o resultado: {b}");
    }
}
//ex03
