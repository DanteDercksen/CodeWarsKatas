namespace Codewars_Katas;
/*Complete the solution so that it strips all text that follows any of a set of comment markers passed in. Any
 whitespace at the end of the line should also be stripped out.

Example:

Given an input string of:

apples, pears # and bananas
grapes
bananas !apples
The output expected would be:

apples, pears
grapes
bananas
The code would be called like so:

string stripped = StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new [] { "#", "!" })
// result should == "apples, pears\ngrapes\nbananas"*/

public class StripCommentsKata
{
    public static string StripComments(string text, char[] commentSymbols)
    {
        string[] textResults = text.Split(commentSymbols);
        for (int i = 0; i < textResults.Length;i++)
        {
            textResults[i] = textResults[i].Trim();
            textResults[i] = (textResults[i].Contains('\n') ? textResults[i].Prepend('/') : textResults[i]) as string ?? string.Empty;
            Console.WriteLine(textResults[i]);
        }
        return text;
    }
}

/*using System;
using System.Collections;
using NUnit.Framework;
public class StripCommentsTest
{
    [Test]
    public void StripComments()
    {
        Assert.AreEqual(
            "apples, pears\ngrapes\nbananas",
            StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

        Assert.AreEqual("a\nc\nd", StripCommentsSolution.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

    }
}*/