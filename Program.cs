using System;
using System.Collections.Generic;

namespace StudentGrading
{
    class Program
    {
        public static string GradingScaling(decimal studentScore)
        {
            if (studentScore >= 90)
            {
                if (studentScore >= 97)
                    return "A+";
                else if (studentScore >= 93)
                    return "A";
                else
                    return "A-";
            }
            else if (studentScore >= 80)
            {
                if (studentScore >= 87)
                    return "B+";
                else if (studentScore >= 83)
                    return "B";
                else
                    return "B-";
            }
            else if (studentScore >= 70)
            {
                if (studentScore >= 77)
                    return "C+";
                else if (studentScore >= 73)
                    return "C";
                else
                    return "C-";
            }
            else if (studentScore >= 60)
            {
                if (studentScore >= 67)
                    return "D+";
                else if (studentScore >= 63)
                    return "D";
                else
                    return "D-";
            }
            else
            {
                return "F";
            }
        }

        static void Main(string[] args)
        {
            int currentAssignments = 5;

            List<int> sophiaGrades = new List<int>();
            List<int> nicolasGrades = new List<int>();
            List<int> zahirahGrades = new List<int>();
            List<int> jeongGrades = new List<int>();

            sophiaGrades.Add(93);
            sophiaGrades.Add(87);
            sophiaGrades.Add(98);
            sophiaGrades.Add(95);
            sophiaGrades.Add(100);

            nicolasGrades.Add(80);
            nicolasGrades.Add(83);
            nicolasGrades.Add(82);
            nicolasGrades.Add(88);
            nicolasGrades.Add(85);

            zahirahGrades.Add(84);
            zahirahGrades.Add(96);
            zahirahGrades.Add(73);
            zahirahGrades.Add(85);
            zahirahGrades.Add(79);

            jeongGrades.Add(90);
            jeongGrades.Add(92);
            jeongGrades.Add(98);
            jeongGrades.Add(100);
            jeongGrades.Add(97);

            int sophiaSum = 0;
            int nicolasSum = 0;
            int zahirahSum = 0;
            int jeongSum = 0;

            foreach (int item in sophiaGrades)
            {
                sophiaSum += item;
            }

            foreach (int item in nicolasGrades)
            {
                nicolasSum += item;
            }

            foreach (int item in zahirahGrades)
            {
                zahirahSum += item;
            }

            foreach (int item in jeongGrades)
            {
                jeongSum += item;
            }

            decimal sophiastudentScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasstudentScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahstudentScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongstudentScore = (decimal)jeongSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiastudentScore + "\t" + GradingScaling(sophiastudentScore));
            Console.WriteLine("Nicolas:\t" + nicolasstudentScore + "\t" + GradingScaling(nicolasstudentScore));
            Console.WriteLine("Zahirah:\t" + zahirahstudentScore + "\t" + GradingScaling(zahirahstudentScore));
            Console.WriteLine("Jeong:\t\t" + jeongstudentScore + "\t" + GradingScaling(jeongstudentScore));
        }
    }
}
