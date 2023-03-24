using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Quastion
    {
        public Guid quastionId { get; set; }    

        public string header { get; set; } = "";

        public string body { get; set; } = "";

        public int Mark { get; set; } 

        public Answers RightAnswers { get; set; } = new Answers();

        //public List<string> choices { get; set; } = new List<string>();
        public MCQ MCQ = new MCQ();
        //public TrueOrFalse TrueOrFalse { get; set; } 

        public Quastion() { }

        public Quastion(string _header, string _body, int _mark,Answers _answers,Guid _quastionId
            , MCQ _choices )
        {
            header = _header;
            body = _body;
            Mark = _mark;
            RightAnswers = _answers;
            quastionId = _quastionId;
            MCQ = _choices;
        }

        public Quastion(string _header, string _body, int _mark, Answers _answers, Guid _quastionId)
            :this()
        {
            header = _header;
            body = _body;
            Mark = _mark;
            RightAnswers = _answers;
            quastionId = _quastionId;
        }


    }
}
