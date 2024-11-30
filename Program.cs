namespace RockPaperScissor
{
    public class Program
    {
        #region "Global variables | Finished"
        public static int rock = 1;
        public static int paper = 2;
        public static int scissor = 3;
        public static int playerPoints = 0;
        public static int computerPoints = 0;
        public static int _playerScore = 0;
        public static int _computerScore = 0;
        #endregion

        static void Main(string[] args)
        {
            MainMenu();
        }

        #region "Main menu | Finished"
        public static void MainMenu()
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
                            RulesGame();
                            mainMenu = false;
                            break;
                        }
                    case ConsoleKey.P:
                        {
                            AchivedPoints();
                            mainMenu = false;
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            StartGame();
                            mainMenu = false;
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            QuitGame();
                            mainMenu = false;
                            break;
                        }
                    default:
                        {
                            do
                            {
                                Console.Write("|----------------------------Choose between-------------------------------|\n");
                                Console.Write("|                  (Rules <R>, Start game <S>, Quit <Q>)                  |\n");
                                mainMenuAlt = Console.ReadKey(true).Key;
                                if (mainMenuAlt == ConsoleKey.R)
                                {
                                    RulesGame();
                                    break;
                                }
                                else if (mainMenuAlt == ConsoleKey.S)
                                {
                                    StartGame();
                                    break;
                                }
                                else if (mainMenuAlt == ConsoleKey.Q)
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
            while (mainMenu);
        }
        #endregion

        #region "Game rules | Finished"
        public static void RulesGame()
        {
            Console.Clear();
            Console.Write("|--------------------------------Game Rules-------------------------------|\n" +
                $"| - The user chooses between (rock, paper or scissor){ [],-21}|\n" +
                $"| - The computer randomly chooses between (rock, paper or scissor){ [],-8}|\n" +
                $"| - The game shows who has won the match and points are{ [],-19}|\n" +
                $"|   awarded either to computer or player{ [],-34}|\n");
            BackToMenu();
        }
        #endregion

        #region "Points achived | Finished"
        private static void AchivedPoints()
        {
            Console.Clear();
            Console.Write("|-----------------------------Player vs Computer--------------------------|\n" +
                $"|{ [],-29}Your points: {playerPoints}{ [],-30}|\n" +
                $"|{ [],-25}Computer points: {computerPoints}{ [],-30}|\n");
            BackToMenu();
        }
        #endregion

        #region "Play game | Finished"
        public static void StartGame()
        {
            int computer;
            Console.Clear();

            Console.Write("|--------------------------Choose your game strategy----------------------|\n" +
                $"|{ [],-33}<R> - Rock{ [],-30}|\n" +
                $"|{ [],-33}<P> - Paper{ [],-29}|\n" +
                $"|{ [],-33}<S> - Scissor{ [],-27}|\n");
            do
            {
                Console.Write($"|{ [],-17}Press key (Rock <R>, Paper <P>, Scissor <S>){ [],-12}|\n");
                Console.Write("|-------------------------------------------------------------------------|\n");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.R) // Rock
                {
                    Console.Clear();
                    Console.Write("|--------------------------------Game results-----------------------------|\n" +
                        $"|{ [],-31}You chose: Rock{ [],-27}|\n", rock);
                    computer = ComputerChoice();
                    Rock(rock, computer);
                    PlayAgain();
                    break;
                }
                else if (input.Key == ConsoleKey.P) // Paper
                {
                    Console.Clear();
                    Console.Write("|--------------------------------Game results-----------------------------|\n" +
                        $"|{ [],-31}You chose: Paper{ [],-26}|\n", paper);
                    computer = ComputerChoice();
                    Paper(paper, computer);
                    PlayAgain();
                    break;
                }
                else if (input.Key == ConsoleKey.S) // Scissor
                {
                    Console.Clear();
                    Console.Write("|--------------------------------Game results-----------------------------|\n" +
                        $"|{ [],-29}You chose: Scissor{ [],-26}|\n", scissor);
                    computer = ComputerChoice();
                    Scissor(scissor, computer);
                    PlayAgain();
                    break;
                }
            }
            while (true);
        }
        #endregion

        #region "Quit game | Finished"
        public static void QuitGame()
        {
            Console.Clear();
            Console.Write("|----------------------------Hope to see you soon-------------------------|\n");
            Environment.Exit(0);
        }
        #endregion

        #region "Navigation | Finished"
        public static void BackToMenu()
        {
            do
            {
                Console.Write("|-------------------------------------------------------------------------|\n");
                Console.Write($"|{ [],-20}Click <Enter> to go back to start menu{ [],-15}|\n");
                Console.Write("|-------------------------------------------------------------------------|\n");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Enter)
                {
                    MainMenu();
                    break;
                }
                Console.Clear();
            }
            while (true);
        }
        #endregion

        #region "Game logic | Finished"
        public static int ComputerChoice()
        {
            int randomNumber;
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 4);
            if (randomNumber == 1)
            {
                Console.Write($"|{ [],-28}Computer chose: Rock{ [],-25}|\n", randomNumber);
            }
            else if (randomNumber == 2)
            {
                Console.Write($"|{ [],-27}Computer chose: Paper{ [],-25}|\n", randomNumber);
            }
            else if (randomNumber == 3)
            {
                Console.Write($"|{ [],-27}Computer chose: Scissor{ [],-23}|\n", randomNumber);
            }
            return randomNumber;
        }

        public static void Rock(int rock, int computer)
        {
            // Player: Rock | Computer: Scissor
            if (rock == 1 && computer == 3)
            {
                Console.Write($"|{ [],-26}You win! (1+ for Player){ [],-23}|\n");
                playerPoints = Scores(_playerScore);
            }
            // Player: Rock | Computer: Paper
            else if (rock == 1 && computer == 2)
            {
                Console.Write($"|{ [],-24}You lose! (1+ for Computer){ [],-22}|\n");
                computerPoints = Scores(_computerScore, true);
            }
            // Player: Rock | Computer: Rock
            else if (rock == 1 && computer == 1)
            {
                Console.WriteLine($"|{ [],-36}Tie!{ [],-33}|");
            }
        }
        public static void Paper(int paper, int nbr)
        {
            // Player: Paper | Computer: Rock
            if (paper == 2 && nbr == 1)
            {
                Console.Write($"|{ [],-26}You win! (1+ for Player){ [],-23}|\n");
                playerPoints = Scores(_playerScore);
            }
            // Player: Paper | Computer: Scissor
            else if (paper == 2 && nbr == 3)
            {
                Console.Write($"|{ [],-24}You lose! (1+ for Computer){ [],-22}|\n");
                computerPoints = Scores(_computerScore, true);
            }
            // Player: Paper | Computer: Paper
            else if (paper == 2 && nbr == 2)
            {
                Console.WriteLine($"|{ [],-36}Tie!{ [],-33}|");
            }
        }
        public static void Scissor(int scissor, int nbr)
        {
            // Player: Scissor | Computer: Paper
            if (scissor == 3 && nbr == 2)
            {
                Console.Write($"|{ [],-26}You win! (1+ for Player){ [],-23}|\n");
                playerPoints = Scores(_playerScore);
            }
            // Player: Scissor | Computer: Rock
            else if (scissor == 3 && nbr == 1)
            {
                Console.Write($"|{ [],-24}You lose! (1+ for Computer){ [],-22}|\n");
                computerPoints = Scores(_computerScore, true);
            }
            // Player: Scissor | Computer: Scissor
            else if (scissor == 3 && nbr == 3)
            {
                Console.WriteLine($"|{ [],-36}Tie!{ [],-33}|");
            }
        }
        public static int Scores(int _score)
        {
            return ++_playerScore;
        }
        public static int Scores(int _score, bool computer)
        {
            return ++_computerScore;
        }
        public static void PlayAgain()
        {
            do
            {
                Console.Write("|-------------------------------------------------------------------------|\n");
                Console.Write($"|{ [],-17}Do you wanna play again? (Yes <Y>, No <N>){ [],-14}|\n");
                Console.Write("|-------------------------------------------------------------------------|\n");
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
                Console.Clear();
            }
            while (true);
        }
    }
    #endregion
}

