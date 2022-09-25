// See https://aka.ms/new-console-template for more information
int n = Convert.ToInt32(Console.ReadLine());

var i = 1;
while(i <= n)
{
    var j = 1;
    while(j <= n)
    {
        Console.Write($"{j} ");
        j++;
    }
    Console.WriteLine();
    i++;
}
