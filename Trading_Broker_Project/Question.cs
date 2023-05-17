using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Broker_Project
{
    internal class Question
    {
        public string Text { get; }
        public List<string> Answers { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string text, List<string> answers, int correctAnswerIndex)
        {
            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
