namespace Codewars_Katas;

public class RomanNumeralsHelper
{
    private Dictionary<string, int> RomanNumerals = new Dictionary<string, int>();
    
    public void CreateRomanNumeralDictionary()
    {
        RomanNumerals.Add("M", 1000);
        RomanNumerals.Add("CM", 900);
        RomanNumerals.Add("D",500);
        RomanNumerals.Add("CD",400);
        RomanNumerals.Add("C",100);
        RomanNumerals.Add("XC",90);
        RomanNumerals.Add("L",50);
        RomanNumerals.Add("XL",40);
        RomanNumerals.Add("X",10);
        RomanNumerals.Add("IX",9);
        RomanNumerals.Add("V",5);
        RomanNumerals.Add("IV",4);
        RomanNumerals.Add("I",1);
    }
    
    public string RomanNumeralConverter(int value)
    {
        CreateRomanNumeralDictionary();
        string numericValue = value.ToString();
        string result = "";
        for (int i = numericValue.Length; i > 0; i--)
        {
            result += IndexConverter(i, numericValue[i]);
        }
        return result;
    }

    public string IndexConverter(int indexValue, char charValue)
    {
        string result = "";
        int numericValue = int.Parse(charValue.ToString());
        switch (indexValue)
        {
            case 4:
                if (numericValue > 4) numericValue = 4;
                for (int i = numericValue; i > 0; i--)
                {
                    result += "M";
                }
                break;
            case 3:
                for (int i = numericValue; i > 0; i--)
                {
                    if (numericValue == 9)
                    {
                        result += "CM";
                    }
                    else if (numericValue > 4)
                    {
                        result += "D";
                    }
                    else if (numericValue == 4)
                    {
                        result += "CD";
                    }
                    else
                    {
                        result += "C";
                    }
                }
                break;
            case 2:
                for (int i = numericValue; i > 0; i--)
                {
                    if (numericValue == 9)
                    {
                        result += "XC";
                    }
                    else if (numericValue > 4)
                    {
                        result += "L";
                    }
                    else if (numericValue == 4)
                    {
                        result += "XL";
                    }
                    else
                    {
                        result += "X";
                    }
                }
                break;
            case 1:
                for (int i = numericValue; i > 0; i--)
                {
                    if (numericValue == 9)
                    {
                        result += "IX";
                    }
                    else if (numericValue > 4)
                    {
                        result += "V";
                    }
                    else if (numericValue == 4)
                    {
                        result += "IV";
                    }
                    else
                    {
                        result += "I";
                    }
                }
                break;
        }
        return result;
    }
    
    //   Symbols | Amount
    //    M      | 1000
    //   CM      |  900
    //    D      |  500
    //   CD      |  400
    //    C      |  100
    //   XC      |   90
    //    L      |   50
    //   XL      |   40
    //    X      |   10
    //   IX      |    9
    //    V      |    5
    //   IV      |    4
    //    I      |    1
}