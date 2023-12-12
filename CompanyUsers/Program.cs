Dictionary<string, List<string>> companiesAndEmployees = new Dictionary<string, List<string>>();

string[] command = Console.ReadLine()
                   .Split(" -> ")
                   .ToArray();

while (command[0] != "End")
{
    if (!companiesAndEmployees.ContainsKey(command[0]))
    {
        companiesAndEmployees[command[0]] = new List<string>();
    }
    if (companiesAndEmployees[command[0]].Contains(command[1]))
    {
        command = Console.ReadLine()
                  .Split(" -> ")
                  .ToArray();
        continue;
    }
    companiesAndEmployees[command[0]].Add(command[1]);

    command = Console.ReadLine()
              .Split(" -> ")
              .ToArray();
}

foreach (var company in companiesAndEmployees)
{
    Console.WriteLine(company.Key);
    foreach (string employeeID in company.Value)
    {
        Console.WriteLine($"-- {employeeID}");
    }
}