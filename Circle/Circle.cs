using System;

class Circle
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double p = 2 * Math.PI * r;
        double a = Math.PI * r * r;
        Console.WriteLine("{0:0.00} {1:0.00}", p, a);
    }
}
