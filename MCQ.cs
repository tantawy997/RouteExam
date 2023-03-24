using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MCQ
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public List<string> choices { get; set; } = new List<string>();


        public MCQ() { } 

        public MCQ(Guid _id,List<string> _choices) 
            
        {
            Id = _id;
            choices= _choices;
        }

          

        public  MCQ GetChoices(Guid id)
        {
            MCQ choices = new MCQ();
            Console.WriteLine("Please enter the choices of the quastion");
            if (id == this.Id)
            {
                for (int i = 0; i < 3; i++)
                {
                    choices.choices[i] = Console.ReadLine();

                }
            }

            return choices;


        }
    }
}
