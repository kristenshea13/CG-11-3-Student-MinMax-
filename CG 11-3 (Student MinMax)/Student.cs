using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CG_11_3__Student_MinMax_
{
    public class Student
    {
            //properties for student class, string name and an int List of scores

            public string Name { get; set; }

            public List<int> Scores { get; set; }
            
            /// constructor to split student name and scores(int) from text file
            public Student(string studentData)
            {
                //splits data at ;
                string[] studentdataSplit = studentData.Split("; ");
                
                //initiate int list for scores
                Scores = new List<int>();

                for (int i = 0; i < studentdataSplit.Length; i++)
                {
                    if (i == 0)
                    {
                        Name = studentdataSplit[i];
                    }
                    else
                    {
                        int score = int.Parse(studentdataSplit[i]);
                        Scores.Add(score);
                    }

                }

            }

        /// <summary>
        /// capitalize the first letter only of name
        /// </summary>
        /// <returns>name with first letter capitalized</returns>
        public string StudentNameCap()
        {
            return char.ToUpper(this.Name[0]) + this.Name.Substring(1);
        }

        /// <summary>
        /// determine lowest exam score from list of scores for each student
        /// </summary>
        /// <returns>lowest score for each student</returns>
        public int MinScore()
        {
            int minScore = Scores.First();

            foreach (int score in Scores)
            {
                if (score < minScore)
                    minScore = score;

            }
            return minScore;
        }

        /// <summary>
        /// determine highest exam score for each student
        /// </summary>
        /// <returns>highest exam score for each student</returns>
        public int MaxScore()
        {
            int maxScore = 0;
            foreach (int score in Scores)
            {
                if (score > maxScore)
                    maxScore = score;
            }
            return maxScore;
        }

    }
}
