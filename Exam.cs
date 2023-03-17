using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exam
    {
        public string Time { get; set; } = "";

        public int NumberOfQuastions { get; set; }

        public ICollection<Quastion> Quastions { get; set; } = new List<Quastion>();

        public Exam() 
        {

        
        }

        public Exam(string time, string _time, int numberOfQuastions, List<Quastion> _quastion)
        {
            Time = time;
            NumberOfQuastions = numberOfQuastions;
            Quastions = _quastion;

        }
        public Exam CreateExam()
        {
            Boolean flag = false;
            int typeOfQ;

            do
            {
                Console.WriteLine("Please enter the type of exam you wanna create 1 for practical and 2 for final");
                flag = int.TryParse(Console.ReadLine(), out typeOfQ);

            } while (!flag && (typeOfQ != 1|| typeOfQ != 2 ));
            
            if (typeOfQ == 1)
            {

                return new Practical();
            }

            return new FinalExam();

        }

    }
}
