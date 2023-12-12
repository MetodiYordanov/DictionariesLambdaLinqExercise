Dictionary<string, List<double>> studentsWithGrades = new Dictionary<string, List<double>>();

int numberOfInputs = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfInputs; i++)
{
    string studentName = Console.ReadLine();
    double currentGrade = double.Parse(Console.ReadLine());

    if (!studentsWithGrades.ContainsKey(studentName))
    {
        studentsWithGrades[studentName] = new List<double>();
    }
    studentsWithGrades[studentName].Add(currentGrade);
}

foreach (var student in studentsWithGrades.Where(s => s.Value.Average() >= 4.50))
{
    Console.WriteLine($"{student.Key} -> {(student.Value.Average()):F2}");
}