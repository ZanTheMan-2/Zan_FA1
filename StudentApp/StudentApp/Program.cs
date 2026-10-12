String name;
int[] grades = {0,0,0};
float passRate = 50;

Console.Write("Enter student name: ");
name = Console.ReadLine();

for(int i = 0; i < grades.Length; i++)
{
    Console.Write($"Enter grade {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nResults for " + name + ":");
Console.WriteLine($"\nsStudent name: {name}" +
    $"\nTotal marks: {grades.Sum()}" +
    $"\nResult: {(grades.Average() >= passRate ? "Pass" : "Fail")}" +
    $"\nResult Issued at: {DateTime.Now}");