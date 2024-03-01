//Deadfish Kata
int[] deadFish = Deadfish.Parse("iiisdoso");
foreach (var num in deadFish)
{
    Console.WriteLine(num);
}
//----------------------------------------------------------------------------------------------------------------------

//SimplePigLatin Kata
string pigLatin = SimplePigLatin.PigIt("Pig latin is cool");
Console.WriteLine(pigLatin);
//----------------------------------------------------------------------------------------------------------------------

//AddingBigNumbers Kata
string bigNumbers = AddingBigNumbers.Add("123456789", "987654322");
Console.WriteLine(bigNumbers);
//----------------------------------------------------------------------------------------------------------------------

// StripComments Kata
var strippedComments = StripCommentsKata.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", 
    new [] { '#', '!' });
Console.WriteLine(strippedComments); 
//----------------------------------------------------------------------------------------------------------------------