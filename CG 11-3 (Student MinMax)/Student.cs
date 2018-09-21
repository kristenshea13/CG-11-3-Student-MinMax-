using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CG_11_3__Student_MinMax_
{
    public class Student
    {
      
            public string Name { get; set; }

            public List<int> Scores { get; set; }

            public Student(string studentData)
            {
                string[] studentdataSplit = studentData.Split("; ");
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

        public string StudentNameCap()
        {
            return char.ToUpper(this.Name[0]) + this.Name.Substring(1);
        }

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
