using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MCQ : question
    {
		public override string header => "MCQ Question";

		public MCQ()
        {
            AnswersList = new Answer[3];
        } 


		public override void AddQuation()
		{
			//header
			Console.WriteLine(header);

			//body 
			Console.WriteLine("Please enter the body of the question");
			body= Console.ReadLine();

			//mark 
			int num;
			do
			{
				Console.WriteLine("Please enter the mark of the question");


			} while (!int.TryParse(Console.ReadLine(),out num));

			Mark = num;

			//array of answers 

			Console.WriteLine("please enter the chioces of the question");

			for(int i = 0; i < 3; i++)
			{
				AnswersList[i] = new Answer()
				{
					Answerid = i + 1,
				};

				Console.WriteLine($"please enter choice number {i+1} : ");
				AnswersList[i].AnswerText = Console.ReadLine();
			}

			int RightAnswerId;
			do
			{
				Console.WriteLine("Please specify the right answer for the question");


			} while (!int.TryParse(Console.ReadLine(),out RightAnswerId) &&RightAnswerId < 1|| RightAnswerId > 3);

			RightAnswers.Answerid = RightAnswerId;
			RightAnswers.AnswerText = AnswersList[RightAnswerId - 1].AnswerText;
			Console.Clear();
		}
	}
}
