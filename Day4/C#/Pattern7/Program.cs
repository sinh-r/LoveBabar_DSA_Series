﻿// See https://aka.ms/new-console-template for more information
var n = Convert.ToInt32(Console.ReadLine());

int i = 1;
while(i <= n)
{
    int j = 1;
    while(j <= i)
    {
        Console.Write($"{i} ");
        j++;
    }
    Console.WriteLine();
    i++;
}