using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Quastion
    {
        public string header { get; set; } = "";

        public string body { get; set; } = "";

        public string Mark { get; set; } = ""; 

        public Answers Answers { get; set; } = new Answers();

        public Quastion() { }

        public Quastion(string _header, string _body, string _mark,Answers _answers)
        {
            header = _header;
            body = _body;
            Mark = _mark;
            Answers = _answers;
        }


    }
}
