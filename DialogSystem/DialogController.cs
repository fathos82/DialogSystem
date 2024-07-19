    using System;
    using System.Collections.Generic;
    using DialogSystem.proxies;

    namespace DialogSystem
    {
        public class DialogController
        {
            private IDialog _currentDialog;
            private const int DefaultCoinAmount= 3;
            private PlayerControllerForDialogControllerProxy _playerProxy;

            private float _currentAmount;

            public DialogController(IDialog initialDialog)
            {
                _currentDialog = initialDialog;
                
                // Obtenha o Proxy aqui:
                _playerProxy = new PlayerControllerForDialogControllerProxy();
                _currentAmount = DefaultCoinAmount;

            }
            public void SelectOption(int optionIndex)
            {
                Option option = _currentDialog.GetOptions()[optionIndex];
                if (!option.IsCorrect)
                {
                    _currentAmount--;
                    return;
                }

                OnCorrect();
                
            }
            private void OnCorrect()
            {
                _playerProxy.AddCoin(_currentAmount);
                _currentDialog.OnCorrect();
                _currentDialog = _currentDialog.NextDialog();
                _currentAmount = DefaultCoinAmount;
            }

            
            
            
            // Futuramente talvez algun proxy necessite das questoes, 
            // sendo assim o proxy pode utilizar esses metodos:

            public List<Option> GetOptions()
            {
                return _currentDialog.GetOptions();
            }

            public string GetQuestion()
            {
                return _currentDialog.GetQuestion();
            }
            public bool HasMoreDialog() => _currentDialog.GetType() != typeof(NullDialog);
            
            // A ideia de dar acesso a esses parametros ao inves de dar diretamente acesso ao ojeto do currentDialog é evitar que os metodos 
            // OnCorrect e NextDialog seja acessado!

            public void ShowCurrentQuestion()
            {
                Console.Write(_currentDialog);
            }
        }

    }