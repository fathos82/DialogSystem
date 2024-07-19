using System;

namespace DialogSystem.Properties.example
{
    public class InitialDialog:AbstractDialog
    {
        public InitialDialog()
            : base("Vamos ao Cinema")
        {
         _options.Add(new Option("Sim, claro!", true));  
         _options.Add(new Option("Nao, Obrigado!"));   
         _options.Add(new Option("Odeio cinema!"));   

        }
        public override void OnCorrect()
        {
            Console.WriteLine("Setting next Scene...\n");
        }
        public override IDialog NextDialog() => new CinemDialog();

        
    }


}