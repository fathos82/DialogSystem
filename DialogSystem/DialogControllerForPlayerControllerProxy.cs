namespace DialogSystem
{
    public class DialogControllerForPlayerControllerProxy
    {
        private DialogController _controller;

        public void SelectOption(int optionIndex)
        {
            _controller.SelectOption(optionIndex);
            
        }

    }
}