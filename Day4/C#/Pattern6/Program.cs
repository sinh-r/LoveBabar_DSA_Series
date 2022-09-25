// See https://aka.ms/new-console-template for more information
var n = Convert.ToInt32(Console.ReadLine());

var i = 1;
while(i <= n)
{
    var j = 1;
    while(j <= i)
    {
        Console.Write("* ");
        j++;
    }
    Console.WriteLine();
    i++;
}
