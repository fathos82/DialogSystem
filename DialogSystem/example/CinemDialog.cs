using System;

namespace DialogSystem.Properties.example
{
    public class CinemDialog: AbstractDialog
    {
        public CinemDialog()
            : base("Qual Filme quer assistir?")
        {
            // Permite muito bem ter 2 opções corretas
            _options.Add(new Option("Dora a aventureira!", true));  
            _options.Add(new Option("Assasino em Ação!"));   
            _options.Add(new Option("Nenhum!"));   

        }
        public override void OnCorrect()
        {
            Console.Write("Setting Film Scene...\n");
        }
        public override IDialog NextDialog() => new NullDialog();

        
    }

    
}