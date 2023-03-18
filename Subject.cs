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
            Subject subject = new Subject();
            Exam exam = new Exam();
   
            do
            {
                Console.WriteLine("Please enter the type of exam you wanna create 1 " +
                    "for practical and 2 for final");
                flag = int.TryParse(Console.ReadLine(), out typeOfQ);

            } while (!flag && (typeOfQ != 1 || typeOfQ != 2));

            int time;
            int numberOfQuastions;
            if (typeOfQ == 1)
            {
                do
                {
                    Console.WriteLine("please enter the time of the exam");
                    flag = int.TryParse(Console.ReadLine(), out time);

                } while (!flag);
                do
                {
                    Console.WriteLine("please enter the number of quastions");

                    flag = int.TryParse(Console.ReadLine(), out numberOfQuastions);

                } while (!flag);
                Quastion quastion = new Quastion();
                
                for (int i = 0; i < numberOfQuastions; i++)
                {
                    Console.WriteLine($"Please enter the type of quastion number {i+1} 1 for true and false" +
                        $"and 2 for mcq");

                    do
                    {
                        exam.quastion[i].header = Console.ReadLine();
                    } while (exam.quastion[i].header != "1" && exam.quastion[i].header != "2");

                    Console.WriteLine($"Please enter the body of quastion number {i+1}");
                    exam.quastion[i].body = Console.ReadLine();
                    Console.WriteLine("pLease enter the mark of the quastion");
                    exam.quastion[i].Mark = Console.ReadLine();
                    Console.WriteLine("Please enter the choices of the quastion");

                    Console.WriteLine("please enter the right answer for the quastion");

                    exam.quastion[i].Answers.AnswerText = Console.ReadLine();


                }


                return new Practical();
            }

            return new FinalExam();

        }
    }
}
