using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentScore
{
    public class Student
    {
        private string name;
        private string subject;
        private int score;

        public Student(string name, string subject, int score)
        {
            this.name = name;
            this.subject = subject;
            this.score = score;
        }

        public string GetName()
        {
            return name;
        }

        public string GetSubject()
        {
            return subject;
        }

        public int GetScore()
        {
            return score;
        }
    }
}
