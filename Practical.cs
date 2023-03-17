using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Practical: Exam
    {
        public ICollection<Answers> Answers { get; set; } = new List<Answers>();
        
        public int Count { get; set; } 

        public Practical() { }

        Practical(ICollection<Answers> answers, int count, string _time, int _NumberOfquastions,
            List<Quastion> _quastion):base(_time, _NumberOfquastions, _quastion)
        {
            Answers = answers;
            Count = count;
        }


    }
}
