namespace UserInterface
{
    public class MainMenu
    {
        #region "Main menu | Finished"
        internal void StartMenu(GameContext context)
        {
            Console.Clear();
            Console.Write("|---------------------------Rock, paper & scissor-------------------------|\n" +
                $"| R. Rules{ [],-64}|\n" +
                $"| P. Points{ [],-63}|\n" +
                $"| S. Start game{ [],-59}|\n" +
                $"| Q. Quit{ [],-65}|\n" +
                "|-------------------------------------------------------------------------|\n");
            var mainMenuAlt = Console.ReadKey().Key;
            bool mainMenu = true;
            do
            {
                switch (mainMenuAlt)
                {
                    case ConsoleKey.R:
                        {
                            context.gameRules.Rules(context);
                            mainMenu = false;
                            break;
                        }
                    case ConsoleKey.P:
                        {
                            context.gamePoints.Points(context);
                            mainMenu = false;
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            context.gameLogic.StartGame(context);
                            mainMenu = false;
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            context.gameQuit.Quit(context);
                            mainMenu = false;
                            break;
                        }
                    default:
                        {
                            do
                            {
                                Console.Clear();
                                Console.Write("|----------------------------Choose between-------------------------------|\n");
                                Console.Write("|                  (Rules <R>, Start game <S>, Quit <Q>)                  |\n");
                                Console.Write("|-------------------------------------------------------------------------|\n");
                                mainMenuAlt = Console.ReadKey(true).Key;
                                if (mainMenuAlt == ConsoleKey.R)
                                {
                                    context.gameRules.Rules(context);
                                    break;
                                }
                                else if (mainMenuAlt == ConsoleKey.P)
                                {
                                    context.gamePoints.Points(context);
                                    break;
                                }
                                else if (mainMenuAlt == ConsoleKey.S)
                                {
                                    context.gameLogic.StartGame(context);
                                    break;
                                }
                                else if (mainMenuAlt == ConsoleKey.Q)
                                {
                                    context.gameQuit.Quit(context);
                                    break;
                                }
                            }
                            while (true);
                            break;
                        }
                }
            }
            while (mainMenu);
        }
        #endregion
    }
}