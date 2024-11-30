using System;

namespace RockPaperScissor
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            Console.WriteLine("| Välkommen till Sten, Sax, Påse-spelet\n" +
                "| R. Rules\n" +
                "| S. Start game\n" +
                "| Q. Quit");
            var huvudMenyAlt = Console.ReadKey().Key;
            bool huvudMeny = true;
            while (huvudMeny)
            {
                switch (huvudMenyAlt)
                {
                    case ConsoleKey.R:
                        {
                            RulesGame();
                            huvudMeny = false;
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            StartGame();
                            huvudMeny = false;
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            QuitGame();
                            huvudMeny = false;
                            break;
                        }
                    default:
                        {
                            do
                            {
                                Console.Write("| Choose between (Rules <R>, Start game <S>, Quit <Q>)\n");
                                huvudMenyAlt = Console.ReadKey(true).Key;
                                if (huvudMenyAlt == ConsoleKey.R)
                                {
                                    RulesGame();
                                    break;
                                }
                                else if (huvudMenyAlt == ConsoleKey.S)
                                {
                                    StartGame();
                                    break;
                                }
                                else if (huvudMenyAlt == ConsoleKey.Q)
                                {
                                    QuitGame();
                                    break;
                                }
                            }
                            while (true);
                            break;
                        }
                }
            }
        }

        #region "Spelets regler | Klar"
        public static void RulesGame()
        {
            Console.Clear();
            Console.WriteLine("|--------------------------------Game Rules-------------------------------|\n" +
                "| - The user chooses between (rock, paper or scissor)\n" +
                "| - The computer randomly chooses between (rock, paper or scissor)\n" +
                "| - The game shows who has won the match and points are awarded");
            BackToMenu();
        }
        #endregion

        #region "Starta spel | Pågående"
        public static void StartGame()
        {
            int rock = 1;
            int paper = 2;
            int scissor = 3;
            int nbr1;
            int nbr2;
            int nbr3;
            Console.Clear();
            Console.Write("|------------------Choose between (rock, paper & scissor)-----------------|\n" +
                "| <R> - Rock\n" +
                "| <P> - Paper\n" +
                "| <S> - Scissor\n");
            do
            {
                Console.Write("| Choose between (Rock <R>, Paper <P>, Scissor <S>)\n");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.R) // Rock
                {
                    Console.Write("| You chose: Rock\n", rock);
                    nbr1 = ComputerChoice();
                    PlayAgain();
                    break;
                }
                else if (input.Key == ConsoleKey.P) // Paper
                {
                    Console.Write("| You chose: Paper\n", paper);
                    nbr2 = ComputerChoice();
                    PlayAgain();
                    break;
                }
                else if (input.Key == ConsoleKey.S) // Scissor
                {
                    Console.Write("| You chose: Scissor\n", scissor);
                    nbr3 = ComputerChoice();
                    PlayAgain();
                    break;
                }
                else
                {
                    Console.Write("| Choose between (Rock <R>, Paper <P>, Scissor <S>)\n");
                }
            }
            while (true);
            //TillbakaTillMeny();
        }
        #endregion

        #region "Avsluta spelet | Klar"
        public static void QuitGame()
        {
            Console.Clear();
            Console.WriteLine("|----------------------Hope to see you soon!---------------------|");
            Environment.Exit(0);
        }
        #endregion

        #region "Extra tillägg"
        public static void BackToMenu()
        {
            do
            {
                Console.Write("| Click <Enter> to go back to start menu\n");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Enter)
                {
                    MainMenu();
                    break;
                }
            }
            while (true);
        }
        #endregion

        #region "Datorns val"
        public static int ComputerChoice()
        {
            int randomNumber;
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 3);
            if (randomNumber == 0)
            {
                Console.Write("| Computer chose: Rock\n", randomNumber);
            }
            else if (randomNumber == 2) 
            {
                Console.Write("| Computer chose: Paper\n", randomNumber);
            }
            else
            {
                Console.Write("| Computer chose: Scissor\n", randomNumber);
            }
            return randomNumber;
        }
        public static void PlayAgain()
        {
            do
            {
                Console.Write("| Do you wanna play again? (Yes <Y>, No <N>)\n");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Y) // Yes
                {
                    StartGame();
                    break;
                }
                if (input.Key == ConsoleKey.N) // No
                {
                    MainMenu();
                    break;
                }   
            }
            while (true);
            //TillbakaTillMeny();
        }
    }
        #endregion
}

