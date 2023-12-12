Dictionary<string, string> usersWithLicensePlates = new Dictionary<string, string>();

int numberOfInputs = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfInputs; i++)
{
    string[] input = Console.ReadLine()
                     .Split(' ')
                     .ToArray();

    if (input[0] == "register")
    {
        if (usersWithLicensePlates.ContainsKey(input[1]))
        {
            Console.WriteLine($"ERROR: already registered with plate number {usersWithLicensePlates[input[1]]}");
        }
        else
        {
            usersWithLicensePlates[input[1]] = input[2];
            Console.WriteLine($"{input[1]} registered {input[2]} successfully");
        }
    }
    else if (input[0] == "unregister")
    {
        if (!usersWithLicensePlates.ContainsKey(input[1]))
        {
            Console.WriteLine($"ERROR: user {input[1]} not found");
        }
        else
        {
            usersWithLicensePlates.Remove(input[1]);
            Console.WriteLine($"{input[1]} unregistered successfully");
        }
    }
}

foreach (var user in usersWithLicensePlates)
{
    Console.WriteLine($"{user.Key} => {user.Value}");
}