﻿namespace UserInterface
{
    public class GameMenu
    {
        #region "Play game | v.3"
        internal void GamemodeMenu(GameContext context)
        {
            Console.Write("|-------------------------------Choose gamemode---------------------------|\n" +
               $"| <P> - Player vs Player{ [],-30}|\n" +
               $"| <C> - Computer vs Player{ [],-29}|\n");
            var mainMenuAlt = Console.ReadKey().Key;
            bool mainMenu = true;
            do
            {
                switch (mainMenuAlt)
                {
                    case ConsoleKey.P:
                        {
                            //context.gameRules.Rules(context);
                            mainMenu = false;
                            break;
                        }
                    case ConsoleKey.C:
                        {
                            context.gamePoints.Points(context);
                            mainMenu = false;
                            break;
                        }
                    default:
                        {
                            do
                            {
                                Console.Clear();
                                Console.Write("|----------------------------Choose between-------------------------------|\n");
                                Console.Write("| <P> Player vs Player, <C> Computer vs Player |\n");
                                Console.Write("|-------------------------------------------------------------------------|\n");
                                mainMenuAlt = Console.ReadKey(true).Key;
                                if (mainMenuAlt == ConsoleKey.P)
                                {
                                    context.gameRules.Rules(context);
                                    break;
                                }
                                else if (mainMenuAlt == ConsoleKey.C)
                                {
                                    context.gamePoints.Points(context);
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