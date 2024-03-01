using System.Numerics;

namespace Codewars_Katas;

public class AddingBigNumbers
{
    public static string Add(string a, string b)
    {
        BigInteger num1 = BigInteger.Parse(a), num2 = BigInteger.Parse(b);
        string result = (num1 + num2).ToString();
        return result;
    }
}