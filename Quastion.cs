﻿using System;
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

        //public Answers answers { get; set; }

        public ICollection<Answers> Answers { get; set; } = new HashSet<Answers>();

        public Quastion() { }

        public Quastion(string _header, string _body, string _mark,HashSet<Answers> _answers)
        {
            header = _header;
            body = _body;
            Mark = _mark;
            Answers = _answers;
        }


    }
}