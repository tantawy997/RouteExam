using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FinalExam : Exam
    {
        
        public int grade { get; set; }

        //public string[] MCQ { get; set; } = new string[0];
        

        public FinalExam()
        {

        }

        public FinalExam(
            /*string[] _mCQ,*/int _grade ,string _time,int numberOfQuastions,
            int _subjectId,string _subjectName, List<Quastion> _quastions, List<Answers> _answers
            ) 
            :base(_time,numberOfQuastions, _subjectId,_subjectName, _answers, _quastions )
            
        {
            //MCQ= _mCQ;
            quastions = _quastions;
            grade = _grade;
        }
    }
}
