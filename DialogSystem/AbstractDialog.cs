using System;
using System.Collections.Generic;

namespace DialogSystem.Properties
{
    public abstract class AbstractDialog : IDialog
    {
        private string question;
        protected List<Option> _options;

        public AbstractDialog(string question)
        {
            this.question = question;
            _options = new List<Option>();
        }

        public AbstractDialog(string question, params Option[] options)
        {
            this.question = question;
            _options = new List<Option>(options);
        }

        public abstract void OnCorrect();

        public abstract IDialog NextDialog();

        public List<Option> GetOptions()
        {
            return _options;
        }

        public string GetQuestion()
        {
            return question;
        }
        public override string ToString()
        {
            string result = $"Question: {question}\nOptions:";
            foreach (var option in _options)
            {
                result += $"\n - {option.Description}";
            }
            return result;
        }
        public void ShowOptions()
        {
            Console.WriteLine($"Question: {question}");
            for (int i = 0; i < _options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_options[i].Description}");
            }
        }
    }
}﻿
