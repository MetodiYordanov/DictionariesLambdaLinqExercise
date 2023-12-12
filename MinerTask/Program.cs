Dictionary<string, int> resourcesQuantity = new Dictionary<string, int>();

int lineNumber = 1;
string lastResource = string.Empty;
string toAdd = Console.ReadLine();

while (toAdd != "stop")
{
    if (lineNumber % 2 != 0)
    {
        if (!resourcesQuantity.ContainsKey(toAdd))
        {
            resourcesQuantity[toAdd] = 0;
        }
        lastResource = toAdd;
    }
    else
    {
        resourcesQuantity[lastResource] += int.Parse(toAdd);
    }

    lineNumber++;
    toAdd = Console.ReadLine();
}

foreach (var resource in resourcesQuantity)
{
    Console.WriteLine($"{resource.Key} -> {resource.Value}");
}