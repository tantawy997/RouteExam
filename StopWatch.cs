using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StopWatch
    {

        public static FinalExam startFinal(FinalExam finalExam)
        {
            //int grade = 0;
            string[] answers = new string[finalExam.NumberOfQuastions];
            for (int i = 0; i < finalExam?.NumberOfQuastions; i++)
            {
                if (finalExam.quastions[i].header == "1")
                {
                    Console.WriteLine($"true or false quastion {i+1} has " +
                        $" {finalExam.quastions[i].Mark} marks");
                }
                else
                {
                    Console.WriteLine($"mcq quastion {i+1} has {finalExam.quastions[i].Mark} marks" );

                }
                Console.WriteLine(finalExam.quastions[i].body);
                if (finalExam.quastions[i].header == "1")
                {
                    answers[i] = Console.ReadLine().Trim().ToLower();
                    

                }
                else
                {


                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"{j+1} {finalExam.quastions[i].MCQ.choices[j]}");
         
                    }
                    answers[i] = Console.ReadLine().Trim().ToLower();
                    //answers[i].Answerid = Guid.NewGuid();
                }

                if (answers[i] != finalExam.answers[i].AnswerText)
                {
                    finalExam.grade -= finalExam.quastions[i].Mark;
                }


            }

            return finalExam;
            
        }

        public static Practical startPractial(Practical practical)
        {
            //int grade = 0;
            string[] answers = new string[practical.NumberOfQuastions];
            for (int i = 0; i < practical?.NumberOfQuastions; i++)
            {
  
             
                Console.WriteLine($"** mcq quastion {i+1} has {practical.quastions[i].Mark} marks **");

                
                Console.WriteLine(practical.quastions[i].body);

                //var choices = practical.quastions.FirstOrDefault(a => a.quastionId == a.MCQ.Id);

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{j + 1} {practical.quastions[i].MCQ.choices[j]}");

                }
                answers[i] = Console.ReadLine();
            }
            
            return practical;

        }

        public static void showResultFinal(FinalExam final)
        {
            int fullGrade = 0;
            for (int i = 0; i < final.NumberOfQuastions; i++)
            {
                Console.WriteLine($"{final.quastions[i].body} answer:{final.answers[i].AnswerText}");
                fullGrade += final.quastions[i].Mark;

            }
            

            Console.WriteLine($"your grade is {final.grade} out of {fullGrade}");
        }

        public static void ShowResultPractical(Practical practical)
        {
            for (int i = 0; i < practical.answers.Count; i++)
            {
                Console.WriteLine($"the right answers for the quastion {i+1} is {practical.answers[i].AnswerText}");
            }
        }
    }
}
