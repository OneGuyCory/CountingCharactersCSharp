using System.Text.RegularExpressions;

string path = @"C:\Users\Cory\source\repos\CountingCharacters\CountingCharactersFromFile\practiceText.txt";
string readText = File.ReadAllText(path);
string practice = readText.ToLower();
Regex.Matches(practice, "^[a - zA - Z]+$");

Dictionary<char, int> countedChars = new Dictionary<char, int>();
char[] charsInString = practice.ToLower().ToCharArray();


//loops through Dictionary, if char from array is NOT a key, adds it and sets value to 1
foreach (char c in charsInString)
{
    if (!countedChars.ContainsKey(c))
    {
        countedChars.Add(c, 1);
    }
    else
    {
        //key already exists, so it gets value of key and incremements it by 1
        countedChars[c]++;
    }
}

foreach (KeyValuePair<char, int> pair in countedChars)
{
    Console.WriteLine(pair.Key + ": " + pair.Value);
}