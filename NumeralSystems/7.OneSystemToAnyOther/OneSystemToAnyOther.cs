//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
using System;
class OneSystemToAnyOther
{
    static void Main()
    {
        Console.WriteLine("Please select what you want to convert: ");
        Console.WriteLine("1.Decimal to binary:");
        Console.WriteLine("2.Binary to decimal:");
        Console.WriteLine("3.Decimal to hexadecimal:");
        Console.WriteLine("4.Hexadecimal to binary:");
        Console.WriteLine("5.Binary to hexadecimal:");
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            DecimalToBinary();
        }
        if (n == 2)
        {
            BinaryToDecimal();
        }
        if (n == 3)
        {
            DecimalToHexadecimal();
        }
        if (n == 4)
        {
            HexadecimalToBinary();
        }
        if (n == 5)
        {
            BinaryToHexadecimal();
        }

    }
    static void DecimalToBinary()
    {
        Console.Write("Decimal: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        int remainder;
        string result = "";
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("Binary: {0}", result);
    }
    static void BinaryToDecimal()
    {
        double sum = 0;
        int n = int.Parse(Console.ReadLine());
        int strin = n.ToString().Length;
        for (int i = 0; i < strin; i++)
        {
            int lastDigit = n % 10;
            sum = sum + lastDigit * (Math.Pow(2, i));
            n = n / 10;
        }
        Console.WriteLine(sum);
    }
    static void DecimalToHexadecimal()
    {

        Console.WriteLine("Enter to convert from decimal to hexadecimal: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("{0}=", n);
        ToHexadecimal(n);
        Console.WriteLine();
    }
    static void ToHexadecimal(int n)
    {
        if (n == 0)
            return;
        else
        {
            int r = n % 16;
            n = n / 16;
            ToHexadecimal(n);
            switch (r)
            {
                case 10:
                    Console.Write("A");
                    break;
                case 11:
                    Console.Write("B");
                    break;
                case 12:
                    Console.Write("C");
                    break;
                case 13:
                    Console.Write("D");
                    break;
                case 14:
                    Console.Write("E");
                    break;
                case 15:
                    Console.Write("F");
                    break;
                default:
                    Console.Write(r);
                    break;
            }
        }
    }
    static void HexadecimalToBinary()
    {
        Console.WriteLine("Enter hexadecimal number to be converted to biney number: ");
        string binaryVal = string.Empty;
        string strInput = Console.ReadLine();
        foreach (char ch in strInput)
        {
            binaryVal += Convert.ToString(Convert.ToInt32(ch.ToString(), 16), 2);
        }
        Console.WriteLine(binaryVal);
    }
    static void BinaryToHexadecimal()
    {
        Console.WriteLine("Enter binary number to be converted to hexadecimal: ");
        string bin = Console.ReadLine();

        int rest = bin.Length % 4;
        if (rest != 0)
            bin = new string('0', 4 - rest) + bin;

        string output = "";

        for (int i = 0; i <= bin.Length - 4; i += 4)
        {
            output += string.Format("{0:X}", Convert.ToByte(bin.Substring(i, 4), 2));
        }
        Console.WriteLine(output);
    }
}