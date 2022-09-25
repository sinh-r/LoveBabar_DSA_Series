// See https://aka.ms/new-console-template for more information
var n = Convert.ToInt32(Console.ReadLine());

int i = 1;

while(i <= n)
{
    int j = i;
    while(j > 0)
    {
        Console.Write($"{j} ");
        j--;
    }
    Console.WriteLine();
    i++;
}