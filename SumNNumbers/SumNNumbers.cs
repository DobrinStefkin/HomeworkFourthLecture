using System;

class SumNNumbers
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        double sum = 0;
        for (byte i = 1; i <= N; i++)
        {
            sum+= double.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}
