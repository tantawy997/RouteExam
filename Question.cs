using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class question
    {
        public int questionId { get; set; }    

        public abstract string header { get; } 

        public string body { get; set; } = "";

        public int Mark { get; set; } 

        public Answer RightAnswers { get; set; } 

        public Answer UserAnswers { get; set; }
        public Answer[] AnswersList { get; set; }

		public abstract void AddQuation();



		public question()
		{
			RightAnswers = new Answer();
			UserAnswers = new Answer();
		}

        public override string ToString()
        {
            return $"{header} \t Mark({Mark})\n" +
            "-------------------------------------" +
            $" \n{body}\n";
		}

	}
}
