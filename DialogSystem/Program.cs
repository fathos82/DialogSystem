using System;
using DialogSystem.Properties.example;

namespace DialogSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DialogController dialogController = new DialogController(new InitialDialog());

            while (dialogController.HasMoreDialog())
            {
                dialogController.ShowCurrentQuestion();
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    dialogController.SelectOption(choice);
                }

            }
            {
                
            }
        }
    }
}