using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Answer
    {
        [Key]
        public int Answerid { get; set; }

        public string AnswerText { get; set; } = "";

        public Answer() { }

        public Answer(int answerid, string answerText)
        {
            Answerid = answerid;
            AnswerText = answerText;
        }

		public override string ToString()
		{
            return $"{Answerid} _ {AnswerText}";
		}
	}
}
