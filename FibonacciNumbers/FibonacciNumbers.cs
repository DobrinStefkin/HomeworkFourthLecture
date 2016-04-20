using System;

class FibonacciNumbers
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        if (N > 0)
        {
            Console.Write("0");
        }
        if (N > 1)
        {
            Console.Write(", 1");    
        }
        if (N > 2)
        {
            uint number1 = 0;
            uint number2 = 1;
            for (int i = 3; i <= N; i++)
            {
                uint sum = number1 + number2;
                Console.Write(", {0}", sum);
                number1 = number2;
                number2 = sum;
            }
        }
    }
}
