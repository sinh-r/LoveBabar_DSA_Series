// See https://aka.ms/new-console-template for more information
int n;
n = Convert.ToInt32(Console.ReadLine());


var i = 0;
while(i < n)
{
    var j = 0;
    while(j < n)
    {
        Console.Write("* ");
        j++;
    }
    Console.WriteLine();
    i++;
}
