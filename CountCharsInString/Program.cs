string input = Console.ReadLine();

Dictionary<char, int> charsInString = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == ' ')
    {
        continue;
    }
    else if (!charsInString.ContainsKey(input[i]))
    {
        charsInString[input[i]] = 0;
    }

    charsInString[input[i]]++;
}

foreach (var character in charsInString)
{
    Console.WriteLine($"{character.Key} -> {character.Value}");
}