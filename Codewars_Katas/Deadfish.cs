namespace Codewars_Katas;

public class Deadfish
{
    public static int[] Parse(string data)
    {
        int result = 0;
        List<int> returnArray = new List<int>();
        char[] parsedData = data.ToCharArray();
        for (int i = 0; i < parsedData.Length; i++)
        {
            switch (parsedData[i])
            {
                case 'i':
                    result++;
                    break;
                case 'd':
                    result--;
                    break;
                case 's':
                    result *= result;
                    break;
                case 'o':
                    returnArray.Add(result);
                    break;
            }
        }
        
        return returnArray.ToArray();
    }
}