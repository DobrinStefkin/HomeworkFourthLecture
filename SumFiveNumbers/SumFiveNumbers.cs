using System;

class SumThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (-1000 > a || a > 1000)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            int b = int.Parse(Console.ReadLine());
            if (-1000 > b || b > 1000)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                int c = int.Parse(Console.ReadLine());
                if (-1000 > c || c > 1000)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int d = int.Parse(Console.ReadLine());
                    if (-1000 > d || d > 1000)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        int e = int.Parse(Console.ReadLine());
                        if (-1000 > e || e > 1000)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            int sum = (a + b + c + d + e);
                            Console.WriteLine(sum);
                        }
                    }
                }
            }
        }
    }
}