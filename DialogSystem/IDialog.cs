using System.Collections.Generic;

namespace DialogSystem
{
    public interface IDialog
    {
        void OnCorrect();
        IDialog NextDialog();
        List<Option> GetOptions();
        string GetQuestion();


    }
}