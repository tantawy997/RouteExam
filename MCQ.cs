using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MCQ:Quastion
    {
        public string[] choices { get; set; } = { };

        public MCQ(string[] _choices,string _header,string _body,string _mark,Answers _answers) 
            :base(_header,_body, _mark, _answers)
        {
            choices= _choices;
        }
    }
}
