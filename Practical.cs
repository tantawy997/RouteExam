using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Practical: Exam
    {
        //public int ExamId { get; set; }

        //public string[] MCQ { get; set; } = new string[0];

        public Practical() { }

         public Practical(string _time, int _NumberOfquastions,
           int _subjectId,string _subjectName,List<Quastion> _quastion, List<Answers> _answers) 
            :base(_time,_NumberOfquastions,
               _subjectId, _subjectName, _answers, _quastion)
          {


          }


        //public override string ToString()
        //{
            
            
                
        //return $"{this.Answers}";
           
        //}


    }
}
