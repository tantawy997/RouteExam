using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class TrueOrFalse : question
	{
		public TrueOrFalse()
		{
			AnswersList = new Answer[2];
			AnswersList[0] = new Answer(1,"true");
			AnswersList[1] = new Answer(2, "false");

		}
		public override string header => "True or false question";

		public override void AddQuation()
		{
			Console.WriteLine(header);

			Console.WriteLine("please enter the body of the question :");

			body = Console.ReadLine();

			int num;
			do
			{
				Console.WriteLine("Please enter the mark of the question :");

			} while (!int.TryParse(Console.ReadLine(),out num));
			Mark = num;
			int AnswerId;
			do
			{
				Console.WriteLine("Please enter the id of the answer : ");
			} while (!int.TryParse(Console.ReadLine(), out AnswerId)&& AnswerId > 2 || AnswerId < 1);

			RightAnswers.Answerid = AnswerId;

			RightAnswers.AnswerText = AnswersList[AnswerId - 1].AnswerText;
			Console.Clear();
		}
	}

}
