using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class FinalExam : Exam
	{
		public FinalExam()
		{
		}

		public FinalExam(int _time, int numberOfquestions) : base(_time, numberOfquestions)
		{
		}

		public override void CreatListOfquestions()
		{
			ListOfQuestions = new question[NumberOfquestions];
			for(int i = 0; i < ListOfQuestions.Length; i++)
			{
				int typeOfExam;
				do
				{
					Console.WriteLine("please enter the type of question 1 for MCQ and 2 for true or false");
				} while (!int.TryParse(Console.ReadLine(), out typeOfExam) && typeOfExam > 2 || typeOfExam < 1);

				if(typeOfExam == 1)
				{
					ListOfQuestions[i] = new MCQ();

					ListOfQuestions[i].AddQuation();
				}
				else
				{
					ListOfQuestions[i] = new TrueOrFalse();
					ListOfQuestions[i].AddQuation();
				}
			}
		}

		public override void ShowExam()
		{

			foreach(var question in ListOfQuestions)
			{
				Console.WriteLine(question);
				for(int i =0; i < question.AnswersList.Length; i++)
				{
					Console.WriteLine(question.AnswersList[i]);
				}
				Console.WriteLine("--------------------------------");

				int answer;
				do
				{
					Console.WriteLine("please enter your answer number for the question");

				} while (!int.TryParse(Console.ReadLine(),out answer));

				question.UserAnswers.Answerid = answer;
				question.UserAnswers.AnswerText = question.AnswersList[answer - 1].AnswerText;

				Console.WriteLine("*********************************");

			
			}

			Console.Clear();
			int totalMarks = 0, grade = 0;
			for(int i =0; i < ListOfQuestions.Length; i++)
			{
				totalMarks += ListOfQuestions[i].Mark;
				if (ListOfQuestions[i].UserAnswers.Answerid == ListOfQuestions[i].RightAnswers.Answerid)
				{
					grade += ListOfQuestions[i].Mark;
				}

				Console.WriteLine($"question  ({i+1}) : {ListOfQuestions[i].body}");
				Console.WriteLine($"your answer = {ListOfQuestions[i].UserAnswers.AnswerText}");
				Console.WriteLine($"the right answer is {ListOfQuestions[i].RightAnswers.AnswerText}");
			}

			Console.WriteLine($"your grade is {grade} out of {totalMarks}");
		}
	}
}
