using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        // printed in hexadecimal, left aligned
        Console.Write("{0,-10:X}|", a);
        // printed in binary form, padded with zeroes
        Console.Write("{0}", Convert.ToString(a,2).PadLeft(10,'0'));
        // printed with 2 digits after the decimal point, right aligned
        Console.Write("|{0,10:0.00}", b);
        // printed with 3 digits after the decimal point, left aligned
        Console.Write("|{0,-10:0.000}|", c);
        Console.WriteLine();
    }
}
