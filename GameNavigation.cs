namespace RockPaperScissor
{
    public class GameNavigation
    {
        #region "Menu-Navigation | Finished"
        public void MenuNavigation(GameContext context)
        {
            do
            {
                Console.Write("|-------------------------------------------------------------------------|\n");
                Console.Write($"|{ [],-20}Click <Enter> to go back to start menu{ [],-15}|\n");
                Console.Write("|-------------------------------------------------------------------------|\n");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Enter)
                {
                    context.gameMenu.Menu(context);
                    break;
                }
                Console.Clear();
            }
            while (true);
        }
        #endregion

        #region "Play again-Navigation | Finished
        public void PlayAgain(GameContext context)
        {
            do
            {
                Console.Write("|-------------------------------------------------------------------------|\n");
                Console.Write($"|{ [],-17}Do you wanna play again? (Yes <Y>, No <N>){ [],-14}|\n");
                Console.Write("|-------------------------------------------------------------------------|\n");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Y) // Yes
                {
                    context.gameLogic.StartGame(context);
                    break;
                }
                if (input.Key == ConsoleKey.N) // No
                {
                    context.gameMenu.Menu(context);
                    break;
                }
                Console.Clear();
            }
            while (true);
        }
        #endregion
    }
}
