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

        //public Exam Exam { get; set; } = new Exam();

        public Subject() { }

        public Subject(int _subjectId, string _subjectName)
        {
            subjectId = _subjectId;
            subjectName = _subjectName;
            //Exam = _exam;
        }

       
        public FinalExam CreateExam(int typeOfQ)
        {
            //Subject subject = new Subject();

 
            int grade = 0;
            string time;
                
            Console.WriteLine("please enter the time of the exam");
            time = Console.ReadLine();

                
           
            Console.WriteLine("please enter the number of quastions");

            int numberOfQuastions = int.Parse(Console.ReadLine());
            string[] header = new string[numberOfQuastions];
            string[] body = new string[numberOfQuastions];
            int[] mark = new int[numberOfQuastions];
            string[] answers = new string[numberOfQuastions];
            Guid[] quastionId = new Guid[numberOfQuastions];
            Dictionary<Guid, string[]> choice = new Dictionary<Guid, string[]>();
            
            for (int i = 0; i < numberOfQuastions; i++)
                {

                do
                {
                    Console.WriteLine($"please enter the type of quastion {i+1} " +
                        $"enter 1 true and false" +
                        " and 2 for mcq");

                    header[i] = Console.ReadLine();
                } while (header[i] != "1" && header[i] != "2");
                quastionId[i] = Guid.NewGuid();

                Console.WriteLine($"Please enter the body of quastion number {i + 1}");
                body[i] = Console.ReadLine();
                Console.WriteLine("pLease enter the mark of the quastion");
                Boolean flage = false;
                do
                {
                    flage = int.TryParse(Console.ReadLine(), out mark[i]);

                } while (!flage);
                
                grade += mark[i];
                if (header[i] == "2")
                {

                    Console.WriteLine("Please enter the choices of the quastion");
                    string [] mcq = new string[3];

                    for (int j = 0; j < 3; j++)
                    {
                        mcq[j] = Console.ReadLine();

                    }
                    if (!choice.ContainsKey(quastionId[i]))
                    {
                        choice.Add(quastionId[i], mcq);
                    }

                    Console.WriteLine("Please enter the right answer for the quastion");

                    answers[i] = Console.ReadLine().Trim().ToLower();

                }
                else
                {
                    Console.WriteLine("please enter the right answer for the quastion");
                    answers[i] = Console.ReadLine().Trim().ToLower();

                }

                
            }

           
                Quastion[] quastions = new Quastion[numberOfQuastions];
                Answers[] rightAnswers = new Answers[numberOfQuastions];
            //MCQ[] choices = new MCQ[numberOfQuastions];
            Boolean flag = false;
                for (int i = 0; i < numberOfQuastions; i++)
                {
                    //Guid id = Guid.NewGuid();
                    rightAnswers[i] = new Answers(quastionId[i], answers[i]);

                flag = choice.TryGetValue(quastionId[i], out string[] choices);
                if (flag)
                {
                    quastions[i] = new Quastion(header[i], body[i], mark[i],
                    rightAnswers[i], quastionId[i],
                    new MCQ(quastionId[i], choice[quastionId[i]].ToList()));
                }else
                    {
                    quastions[i] = new Quastion(header[i], body[i], mark[i],
                    rightAnswers[i], quastionId[i]);
                    }

                    
                }
                FinalExam finalExam = new FinalExam(
                    grade, time??"", numberOfQuastions,
                    this.subjectId, this.subjectName, quastions.ToList(),rightAnswers.ToList()
                    );


                return finalExam;

        }


        public Practical createPractial(int typeOfQ)
        {
            //Subject subject = new Subject();


            int grade = 0;
            string time;

            Console.WriteLine("please enter the time of the exam");
            time = Console.ReadLine();



            Console.WriteLine("please enter the number of quastions");

            int numberOfQuastions = int.Parse(Console.ReadLine());
            string[] header = new string[numberOfQuastions];
            string[] body = new string[numberOfQuastions];
            int[] mark = new int[numberOfQuastions];
            string[] answers = new string[numberOfQuastions];
            Guid[] quastionId = new Guid[numberOfQuastions];
            Dictionary<Guid, string[]> choice = new Dictionary<Guid, string[]>();


            for (int i = 0; i < numberOfQuastions; i++)
            {

                header[i] = "2";
                quastionId[i] = Guid.NewGuid();

                Console.WriteLine($"Please enter the body of quastion number {i + 1}");
                body[i] = Console.ReadLine();
                Console.WriteLine("pLease enter the mark of the quastion");

                Boolean flage = false;
                do
                {
                    flage = int.TryParse(Console.ReadLine(), out mark[i]);

                } while (!flage);

                Console.WriteLine("Please enter the choices of the quastion");
                string[] mcq = new string[3];

                for (int j = 0; j < 3; j++)
                {
                    mcq[j] = Console.ReadLine();

                }
                if (!choice.ContainsKey(quastionId[i]))
                {
                    choice.Add(quastionId[i], mcq);
                }

                    Console.WriteLine("Please enter the right answer for the quastion");

                    answers[i] = Console.ReadLine();


            }


            
            Quastion[] quastions = new Quastion[numberOfQuastions];
            Answers[] rightAnswers = new Answers[numberOfQuastions];
           // string[] choices = new MCQ[numberOfQuastions]; 

                for (int i = 0; i < numberOfQuastions; i++)
                {
                    //Guid id = Guid.NewGuid();
                    rightAnswers[i] = new Answers(quastionId[i], answers[i]);
                    //choices[i].choices = choice[quastionId[i]];
                    quastions[i] = new Quastion(header[i], body[i], mark[i],
                        rightAnswers[i], quastionId[i], 
                        new MCQ(quastionId[i],choice[quastionId[i]].ToList()));

                }
                Practical exam = new Practical(time ?? "", numberOfQuastions,
                    this.subjectId, this.subjectName, quastions.ToList(), rightAnswers.ToList()
                    );


                return exam;
         

            }

        }
    }
