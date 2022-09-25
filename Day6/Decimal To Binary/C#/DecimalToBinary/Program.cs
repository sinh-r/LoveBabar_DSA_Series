// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var n = Convert.ToInt32(Console.ReadLine());

var ans = 0;
var count = 0;

while(n != 0)
{
    var bit = n & 1;

    ans += Convert.ToInt32((bit * Math.Ceiling(Math.Pow(10, count))));

    n = n >> 1;
    count++;

}

Console.WriteLine(ans);