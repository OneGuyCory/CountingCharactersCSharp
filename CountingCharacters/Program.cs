string practice = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
    "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue." +
    " Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. " +
    "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

Dictionary<char, int> countedChars = new Dictionary<char, int>();
char[] charsInString = practice.ToCharArray();

//loops through Dictionary, if char from array is NOT a key, adds it and sets value to 1
foreach (char c in charsInString )
{
    if (!countedChars.ContainsKey(c))
    {
        countedChars.Add(c, 1);
    } else
    {
        //key already exists, so it gets value of key and incremements it by 1
        countedChars[c]++;
    }
}

foreach (KeyValuePair<char, int> pair in countedChars)
{
    Console.WriteLine(pair.Key + ": " + pair.Value);
}