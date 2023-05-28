using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Exam
    {
        public int Time { get; set; }

        public int NumberOfquestions { get; set; }


        public question[] ListOfQuestions { get; set; } 

        //public List<Answer> Answers { get; set; } = new List<Answer>();

        public Exam() 
        {

        
        }

        public Exam(int _time, int numberOfquestions)
        {
            Time = _time;
            NumberOfquestions = numberOfquestions;
        }

        public abstract void ShowExam();

        public abstract void CreatListOfquestions();
    }
}
