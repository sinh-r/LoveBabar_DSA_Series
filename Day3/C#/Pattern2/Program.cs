// See https://aka.ms/new-console-template for more information
int n = Convert.ToInt32(Console.ReadLine());

var i = 1;
while(i <= n)
{
    var j = 0;
    while(j < n)
    {
        Console.Write(i);
        j++;
    }
    Console.WriteLine();
    i++;
}
