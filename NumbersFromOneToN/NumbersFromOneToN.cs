using System;

class NumbersFromOneToN
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        for (uint i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
