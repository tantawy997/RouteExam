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
        public int Answerid { get; set; }

        public string AnswerText { get; set; } = "";


    }
}
