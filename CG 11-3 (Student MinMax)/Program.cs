using System;
using System.Collections.Generic;
using System.IO;

namespace CG_11_3__Student_MinMax_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the text file studentdata.txt write a program that calculates the 
            //minimum and maximum score for each student. Print out their name as well.Be sure to use a Student class.



            string[] students = File.ReadAllLines(@"C:\Users\kstar\source\repos\CG 11-2 (Student Grades)
                                                    \CG 11-2 (Student Grades)\studentdata.txt");

            List<Student> studentData = new List<Student>();

            foreach (string item in students)
            {
                studentData.Add(new Student(item));

            }

            foreach (Student student in studentData)
            {
                Console.WriteLine($"{student.StudentNameCap()}: \n " +
                    $"Lowest exam score: {student.MinScore()}\n " +
                    $"Highest exam score: {student.MaxScore()} ");
                
            }

            Console.ReadLine();

        }
    }
}
