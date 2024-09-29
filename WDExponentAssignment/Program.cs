using System; 

class Program
{
    static void Main(string[] args)
    {
        //Example:
        Console.WriteLine("Base: 2, Exponent: 3");
        Console.WriteLine($"Result: {Exponent(2, 3)}");
    }

    static int Exponent(int baseNum, int exponent)
    {
        // only handling exponents 1, 2, 3, or 4
        if (exponent < 1 || exponent > 4)
        {
            throw new ArgumentOutOfRangeException(nameof(exponent), "Exponent must be between 1 and 4.");
        }
        int result = 1;
        //switch element for results
        switch (exponent) 
        {
            case 1:
                result = baseNum; // power of 1.. so itself...
                break;
            case 2:
                result = baseNum * baseNum; // base number squared
                break;
            case 3:
                result = baseNum * baseNum * baseNum; // base number cubed
                break;
            case 4:
                result = baseNum * baseNum * baseNum * baseNum; // base number to the power of 4
                break;
        }

    return result;
    }
}
