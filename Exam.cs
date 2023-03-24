using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exam:Subject
    {
        public string Time { get; set; } = "";

        public int NumberOfQuastions { get; set; }


        public List<Quastion> quastions { get; set; } = new List<Quastion>();

        public List<Answers> answers { get; set; } = new List<Answers>();

        public Exam() 
        {

        
        }

        public Exam(string _time, int numberOfQuastions,
            int _subjectId, string _subjectName, List<Answers> _answers
            , List<Quastion> _quastions):base(_subjectId,_subjectName)
        {
            Time = _time;
            NumberOfQuastions = numberOfQuastions;
            answers = _answers;
            quastions = _quastions;

        }

    }
}
