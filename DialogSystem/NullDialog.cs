using System.Collections.Generic;

namespace DialogSystem
{
    
    // Essa Classe vai representar o fim de uma consversa
    public class NullDialog: IDialog
    {
        public NullDialog()
        {

        }

        public void OnCorrect()
        {
            
        }

        public  IDialog NextDialog()
        {
            return new NullDialog();
        }

        public List<Option> GetOptions()
        {
            // Poderia trocar por uma opção padrao de voltar por exemplo!
            return new List<Option>(0);
        }

        public string GetQuestion()
        {
            return "Já Terminamos nosso dialogo!";
        }
    }
}