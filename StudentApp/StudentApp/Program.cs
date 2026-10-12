String name;
int[] grades = {0,0,0};
float passRate = 50;

Console.Write("Enter student name: ");
name = Console.ReadLine();

try
{
    for (int i = 0; i < grades.Length; i++)
    {
        Console.Write($"Enter grade {i + 1}: ");
        grades[i] = int.Parse(Console.ReadLine());
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter numeric values for grades.");
    return;
}
catch (OverflowException)
{
    Console.WriteLine("Input value is too large or too small. Please enter valid grades.");
    return;
}


Console.WriteLine("\nResults for " + name + ":");
Console.WriteLine($"\nsStudent name: {name}" +
    $"\nTotal marks: {grades.Sum()}" +
    $"\nResult: {(grades.Average() >= passRate ? "Pass" : "Fail")}" +
    $"\nResult Issued at: {DateTime.Now}");