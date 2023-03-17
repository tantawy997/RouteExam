using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FinalExam : Exam
    {
        public ICollection<Answers> Answers { get; set; } = new List<Answers>();

        public ICollection<Quastion> quastions { get; set; } = new List<Quastion>();

        public int grade { get; set; } 


    }
}
