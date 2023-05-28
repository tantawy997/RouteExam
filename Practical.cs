using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Practical : Exam
	{
		//public Practical()
		//{
		//}

		public Practical(int _time, int numberOfquestions) : base(_time, numberOfquestions)
		{
		}

		public override void CreatListOfquestions()
		{
			ListOfQuestions = new MCQ[NumberOfquestions];

			for (int i =0; i < ListOfQuestions.Length;i++)
			{
				ListOfQuestions[i] = new MCQ();
				ListOfQuestions[i].AddQuation();

				Console.Clear();
			}

		}

		public override void ShowExam()
		{
			foreach (var question in ListOfQuestions)
			{
				Console.WriteLine(question);

				for (int i = 0; i < question.AnswersList.Length; i++)
				{
					Console.WriteLine(question.AnswersList[i]);

				}
				Console.WriteLine("---------------------------------");
				int AnswerId;
				do
				{
					Console.WriteLine("Please enter the number of you answer : ");
				} while (!int.TryParse(Console.ReadLine(),out AnswerId));

				question.UserAnswers.Answerid = AnswerId;
				question.UserAnswers.AnswerText = question.AnswersList[AnswerId - 1].AnswerText;

				Console.WriteLine("---------------------------------------");
			}

			Console.WriteLine("Right answer : ");
			for (int i = 0; i < ListOfQuestions.Length; i++)
			{
				Console.WriteLine($"question {i+ 1} : {ListOfQuestions[i].body}");

				Console.WriteLine($"Right Answer : {ListOfQuestions[i].RightAnswers.AnswerText}");

				Console.WriteLine("______________________________________");


			}
		}
	}
}
