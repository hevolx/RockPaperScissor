using UserInterface.Extras;

namespace UserInterface.Menu
{
    public class GameMenu
    {
        #region "Play game | v.3"
        internal void GamemodeMenu(GameContext context)
        {
            Console.Clear();
            Console.Write("|-------------------------------Choose gamemode---------------------------|\n" +
               $"|{ [],-28}<P> - Player vs Player{ [],-23}|\n" +
               $"|{ [],-27}<C> - Computer vs Player{ [],-22}|\n" +
               $"|-------------------------------------------------------------------------|\n");
            var mainMenuAlt = Console.ReadKey().Key;
            bool mainMenu = true;
            do
            {
                switch (mainMenuAlt)
                {
                    case ConsoleKey.P:
                        {
                            context.gamePlayer.Player(context);
                            mainMenu = false;
                            break;
                        }
                    case ConsoleKey.C:
                        {
                            context.gameComputer.Computer(context);
                            mainMenu = false;
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }
            }
            while (mainMenu);
        }
        #endregion
    }
}