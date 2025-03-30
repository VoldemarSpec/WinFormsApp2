﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class Question
    {
        public string Text { get; set; }
        public bool IsMultipleChoice { get; set; }
        public List<Answer> Answers { get; set; }

        public Question(string text, bool isMultipleChoice, List<Answer> answers)
        {
            Text = text;
            IsMultipleChoice = isMultipleChoice;
            Answers = answers;
        }
    }
}
