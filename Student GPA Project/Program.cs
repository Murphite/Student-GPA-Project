using System.Diagnostics;
using System.Text; // Add this namespace for StringBuilder

int gradeA = 5;
int gradeB = 4;
int gradeC = 3;
int gradeD = 2;
int gradeE = 1;
int gradeF = 0;

int totalQualityPoints = 0; // Initialize total quality points
int totalSubjectUnits = 0;  // Initialize total subject units

string studentName;
string subject;
int subjectScore;
int subjectUnit;

string anotherSubject; // Add a variable to check if the user wants to input another subject

Console.Write("Enter your name: ");
studentName = Console.ReadLine();

// Create a StringBuilder to accumulate the table details
var tableBuilder = new StringBuilder();

tableBuilder.AppendLine("-----------------------------------------------------");
tableBuilder.AppendLine("|  Subject     |  Unit    |   Score    |  Grade     |");
tableBuilder.AppendLine("-----------------------------------------------------");


do
{
    Console.Write("Enter subject: ");
    subject = Console.ReadLine();

    Console.Write("Enter score for subject: ");
    subjectScore = int.Parse(Console.ReadLine());

    Console.Write("Enter unit for subject: ");
    subjectUnit = int.Parse(Console.ReadLine());

    int subjectQualityPoint = 0; // Initialize quality points for the current subject
    string grade = ""; // Initialize the grade

    // Calculate quality points and grade based on the score for the current subject
    if (subjectScore >= 70)
    {
        subjectQualityPoint = gradeA * subjectUnit;
        grade = "A";
    }
    else if (subjectScore >= 60 && subjectScore <= 69)
    {
        subjectQualityPoint = gradeB * subjectUnit;
        grade = "B";
    }
    else if (subjectScore >= 50 && subjectScore <= 59)
    {
        subjectQualityPoint = gradeC * subjectUnit;
        grade = "C";
    }
    else if (subjectScore >= 45 && subjectScore <= 50)
    {
        subjectQualityPoint = gradeD * subjectUnit;
        grade = "D";
    }
    else if (subjectScore >= 40 && subjectScore <= 45)
    {
        subjectQualityPoint = gradeE * subjectUnit;
        grade = "E";
    }
    else if (subjectScore < 40)
    {
        subjectQualityPoint = gradeF * subjectUnit;
        grade = "F";
    }

    // Update the total quality points and total subject units
    totalQualityPoints += subjectQualityPoint;
    totalSubjectUnits += subjectUnit;

    // Append the details of the current subject to the tableBuilder
    tableBuilder.AppendLine("---------------------------------------------------");
    tableBuilder.AppendLine($"|   {subject,-10} |   {subjectUnit,-6} |   {subjectScore,-7} |   {grade,-8} |");
    tableBuilder.AppendLine("---------------------------------------------------");

    Console.Write("Enter another subject (Y/N): ");
    anotherSubject = Console.ReadLine().ToUpper(); // Convert the input to uppercase

} while (anotherSubject == "Y");

// Calculate GPA
double gpa = (double)totalQualityPoints / totalSubjectUnits;

// Print the accumulated table
    Console.WriteLine(tableBuilder.ToString());

Console.WriteLine($"Expected Result For: {studentName}");
Console.WriteLine($"Total Quality Points: {totalQualityPoints}");
Console.WriteLine($"Total Subject Units: {totalSubjectUnits}");
Console.WriteLine($"GPA: {gpa:F2}"); // Format GPA to two decimal places


