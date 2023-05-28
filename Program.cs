using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(01, "c#");
            Boolean flag;
            subject.CReateExam();
                        
            int typeOfQuestion;

			Console.WriteLine("do you want to start the exam y | n : ");
			if (char.Parse(Console.ReadLine()) == 'y' || (Console.ReadLine() == "Y"))
			{
				Console.Clear();
                Stopwatch sw = new Stopwatch(); 
                sw.Start();
				subject.SubjectExam.ShowExam();

                Console.WriteLine($"the taken time {sw.Elapsed}");

			}
            else
            {
                Console.WriteLine("Thank you for your time");


            }


		}

    }
}