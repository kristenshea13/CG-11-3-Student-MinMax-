using System;
using System.Collections.Generic;
using System.IO;

namespace CG_11_3__Student_MinMax_
{
    class Program
    {
        static void Main(string[] args)
        {

            //read text file
            string[] students = File.ReadAllLines(@"C:\Users\kstar\source\repos\CG 11-3 (Student MinMax)\CG 11-3 (Student MinMax)\studentdata.txt");

            //create a list of students and all corresponding data
            List<Student> studentData = new List<Student>();

            //loop to use data from text file to create new instances of the student class and add to List
            foreach (string item in students)
            {
                studentData.Add(new Student(item));
            }

            //loop to write out the minimum and maximum scores for each student from methods in student class
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
