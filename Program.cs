using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void GradingScaling(decimal studentScore)
        {

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

            decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
            decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
            decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
            decimal jeongScore = (decimal)jeongSum / currentAssignments;

            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\t" + GradingScaling(sophiaScore));
            Console.WriteLine("Nicolas:\t" + nicolasScore + "\t" + GradingScaling(nicolasScore));
            Console.WriteLine("Zahirah:\t" + zahirahScore + "\t" + GradingScaling(zahirahScore));
            Console.WriteLine("Jeong:\t\t" + jeongScore + "\t" + GradingScaling(jeongScore));
        }
    }
}
