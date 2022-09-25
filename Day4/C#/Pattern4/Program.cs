// See https://aka.ms/new-console-template for more information
int n = Convert.ToInt32(Console.ReadLine());

var i = 1;
while(i <= n)
{
    var j = n;
    while(j > 0)
    {
        Console.Write($"{j} ");
        j--;
    }
    Console.WriteLine();
    i++;
}
