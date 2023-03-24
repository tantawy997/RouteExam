using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Answers
    {
        [Key]
        public Guid Answerid { get; set; }

        public string AnswerText { get; set; } = "";

        public Answers() { }

        public Answers(Guid answerid, string answerText)
        {
            Answerid = answerid;
            AnswerText = answerText;
        }
    }
}
