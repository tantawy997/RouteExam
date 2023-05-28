using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Subject
    {
        public int subjectId { get; set; } 

        public string subjectName { get; set; } = string.Empty; 

        public Exam SubjectExam { get; set; }

        public Subject() 
        {
            
        }

        public Subject(int _subjectId, string _subjectName)
        {
            subjectId = _subjectId;
            subjectName = _subjectName;
        }

        public void CReateExam()
        {
            int Time, ExamType, numberOfQeustions;
            do
            {
                Console.WriteLine("Please enter the Time of exam must be between 30 min and 180 min");
            } while (!int.TryParse(Console.ReadLine(),out Time )&& Time < 30 ||Time > 180);
			do
			{
				Console.WriteLine("Please enter the type of exam (1 for practical and 2 for final exam)");
			} while (!int.TryParse(Console.ReadLine(), out ExamType));

			do
			{
				Console.WriteLine("Please enter the number of questions");
			} while (!int.TryParse(Console.ReadLine(), out numberOfQeustions));


            if (ExamType == 1)
                SubjectExam = new Practical(Time,numberOfQeustions);
            else
            {
                SubjectExam = new FinalExam(Time, numberOfQeustions);
            }
            Console.Clear();

            SubjectExam.CreatListOfquestions();


		}
    
    }
}
