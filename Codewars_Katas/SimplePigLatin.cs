namespace Codewars_Katas;

public class SimplePigLatin
{
    public static string PigIt(string str)
    {
        string result = "";
        string[] fullString = str.Split(' ');
        foreach (var word in fullString)
        {
            if (!Char.IsLetter(word[0]))
            {
                result = $"{result} {word[0]}";
                return result;
            }
            string newWord = word.Substring(1) + word[0] + "ay";
            result = $"{result} {newWord}";
        }

        return result.Trim();
    }
}