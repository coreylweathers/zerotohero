using System.Linq;

namespace _12_Inheritance
{
    public class Student: Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores) :base(firstName,lastName,id)
        {
            testScores = scores;
        }

        public char calculate()
        {
            double avg = testScores.Average();
            char grade = default(char);
            if (avg >= 90 && avg <= 100)
                grade = 'O';
            else if (avg >= 80 && avg < 90)
                grade = 'E';
            else if (avg >= 70 && avg < 80)
                grade = 'A';
            else if (avg >= 55 && avg < 70)
                grade = 'P';
            else if (avg >= 40 && avg < 55)
                grade = 'D';                    
            else
                grade = 'T';
            return grade;
        }

    } 
}