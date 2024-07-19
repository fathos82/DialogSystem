using System;

namespace DialogSystem.proxies
{
    public class PlayerControllerForDialogControllerProxy
    {
        public void AddCoin(float value)
        {
            if (value < 0)
            {
                // Throw Error
                Console.Write("Can not add a negative value");
                return;
            }
            // Add coin value to player
            Console.Write("Adding coins to player");
        }
    }
}