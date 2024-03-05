string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');
string result = "";
foreach (var word in words)
{
    // Reverse the word and add it to the result
    char[] wordArray = word.ToCharArray();
    Array.Reverse(wordArray);
    result += new string(wordArray) + " ";
}

Console.WriteLine(result);
