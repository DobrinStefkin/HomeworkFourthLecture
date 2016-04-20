using System;

class SumThreeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        if (-1000 > a || a > 1000)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            double b = double.Parse(Console.ReadLine());
            if (-1000 > b || b > 1000)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                double c = double.Parse(Console.ReadLine());
                if (-1000 > c || c > 1000)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    double sum = (a + b + c);
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
