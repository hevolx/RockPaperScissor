namespace UserInterface.Extras
{
    public class GameNavigation
    {
        #region "Menu-Navigation | Finished"
        internal void MenuNavigation(GameContext context)
        {
            do
            {
                Console.Write("|-------------------------------------------------------------------------|\n");
                Console.Write($"|{ [],-19}Click <Enter> to go back to start menu{ [],-16}|\n");
                Console.Write("|-------------------------------------------------------------------------|\n");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Enter)
                {
                    context.mainMenu.StartMenu(context);
                    break;
                }
                Console.Clear();
            }
            while (true);
        }
        #endregion

        #region "Play again-Navigation | Finished
        internal void PlayAgain(GameContext context)
        {
            do
            {
                Console.Write("|-------------------------------------------------------------------------|\n");
                Console.Write($"|{ [],-17}Do you wanna play again? (Yes <Y>, No <N>){ [],-14}|\n");
                Console.Write("|-------------------------------------------------------------------------|\n");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Y) // Yes
                {
                    context.gameMenu.GamemodeMenu(context);
                    break;
                }
                if (input.Key == ConsoleKey.N) // No
                {
                    context.mainMenu.StartMenu(context);
                    break;
                }
                Console.Clear();
            }
            while (true);
        }
        #endregion
    }
}
