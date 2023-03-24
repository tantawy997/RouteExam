namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(01, "c#");
            Boolean flag;

                        
            int typeOfQ;
            do
            {
                Console.WriteLine("Please enter the type of exam you wanna create 1 " +
                    "for practical and 2 for final");
                flag = int.TryParse(Console.ReadLine(), out typeOfQ);

            } while (!flag && (typeOfQ != 1 || typeOfQ != 2));
            if (typeOfQ == 1)
            {
               Practical practical = subject.createPractial(typeOfQ);
                Console.Clear();
                Console.WriteLine("do you want to start the exam y | n");
                if (char.Parse(Console.ReadLine()) == 'y')
                {
                    var res= StopWatch.startPractial(practical);

                    StopWatch.ShowResultPractical(res);

                }

            }
            else
            {
                FinalExam finalExam = subject.CreateExam(typeOfQ);
                Console.Clear();
                Console.WriteLine("do you want to start the exam y | n");
                if (char.Parse(Console.ReadLine()) == 'y')
                {
                    var res = StopWatch.startFinal(finalExam);

                    StopWatch.showResultFinal(res);

                }
            }


            
            

            
        }

    }
}