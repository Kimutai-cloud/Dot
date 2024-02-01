using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] numbers = { { { 93, 87, 98, 95, 100 }, { 80, 83, 82, 88, 85 }, { 84, 96, 73, 85, 79 }, { 0, 92, 98, 100, 97 } } };
        string[] students = { "Sophia", "Nicolas", "Zahirah", "Jeong" };

        int numStudents = numbers.GetLength(0);
        int numSubjects = numbers.GetLength(1);
        int numScores = numbers.GetLength(2);
        int count = 0;
         
        int[,] sums = new int[numStudents, numSubjects];
        double[,] averages = new double[numStudents, numSubjects];
        Console.WriteLine("Students\tGrade");

        for (int i = 0; i < numStudents; i++)
        {
            for (int j = 0; j < numSubjects; j++)
            {
                int sum = 0;
                for (int k = 0; k < numScores; k++)
                {
                    sum += numbers[i, j, k];
                }
                sums[i, j] = sum;
                averages[i, j] = (double)sum / numScores;

                string grade = ComputeGrade(averages[i, j]);
                Console.WriteLine($"{students[i+count]}\t\t{averages[i, j]:F2}\t{grade}");
                count++;
            }
            Console.WriteLine();
        }
    }

    static string ComputeGrade(double average)
    {
        if (average >= 90)
        {
            return "A";
        }
        else if (average >= 80)
        {
            return "B";
        }
        else
        {
            return "C";
        }
    }
}
