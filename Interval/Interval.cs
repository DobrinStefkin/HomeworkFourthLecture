using System;

class Interval
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        uint M = uint.Parse(Console.ReadLine());

        uint DivisibleBy5 = 0;
        for (uint i = N + 1; i < M; i++)
        {
            if (i % 5 == 0)
            {
                ////for printing the numbers
                //Console.Write(i);
                //if (i < M - 3)
                //{
                //    // for not printing comma in the end
                //    Console.Write(", ");
                //}
                DivisibleBy5++;
            }
        }
        //Console.WriteLine();

        Console.WriteLine(DivisibleBy5);
    }
}
