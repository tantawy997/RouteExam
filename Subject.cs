using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Subject
    {
        public int subjectId { get; set; } 

        public string subjectName { get; set; } = string.Empty; 

        public Exam Exam { get; set; } = new Exam();

        public Subject() { }

        public Subject(int _subjectId, string _subjectName, Exam _exam)
        {
            subjectId = _subjectId;
            subjectName = _subjectName;
            Exam = _exam;
        }


        public Exam CreateExam()
        {
            Boolean flag = false;
            int typeOfQ;

            do
            {
                Console.WriteLine("Please enter the type of exam you wanna create 1 for practical and 2 for final");
                flag = int.TryParse(Console.ReadLine(), out typeOfQ);

            } while (!flag && (typeOfQ != 1 || typeOfQ != 2));

            if (typeOfQ == 1)
            {
                
                return new Practical();
            }

            return new FinalExam();

        }
    }
}
