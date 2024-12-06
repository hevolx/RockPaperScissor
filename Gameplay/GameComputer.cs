using UserInterface.Extras;

namespace UserInterface.Gameplay
{
    public class GameComputer
    {
        internal void Computer(GameContext context)
        {
            int computer;
            int player;
            Console.Clear();

            Console.Write("|--------------------------Choose your game strategy----------------------|\n" +
                $"|{ [],-33}<R> - Rock{ [],-30}|\n" +
                $"|{ [],-33}<P> - Paper{ [],-29}|\n" +
                $"|{ [],-33}<S> - Scissor{ [],-27}|\n" +
                $"|-------------------------------------------------------------------------|\n" +
                $"|{ [],-17}Press key (Rock <R>, Paper <P>, Scissor <S>){ [],-12}|\n" +
                $"|-------------------------------------------------------------------------|\n");

            player = PlayerChoice();
            computer = ComputerChoice();
            WhoWonTheGame(context, player, computer);
            context.navigation.PlayAgain(context);
        }

        internal static int PlayerChoice()
        {
            while (true)
            {
                var input = Console.ReadKey(true);
                int playerNumber;
                string playerChoice;
                switch (input.Key)
                {
                    case ConsoleKey.R:
                        {
                            playerNumber = 0; // Rock
                            break;
                        }
                    case ConsoleKey.P:
                        {
                            playerNumber = 1; // Paper
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            playerNumber = 2; // Scissor
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }
                List<string> choices = new List<string> { "Rock", "Paper", "Scissor" };
                playerChoice = choices[playerNumber];
                if (true)
                {
                    Console.Clear();
                    Console.Write($"|--------------------------------Game results-----------------------------|\n" +
                        $"|{ [],-28}Player chose: {choices[playerNumber],-27}{ [],-4}|\n");
                }
                return playerNumber;
            }
        }
        #region "Computer | v.4"
        internal static int ComputerChoice()
        {
            int randomNumber;
            Random rnd = new Random();
            List<string> choices = new List<string> { "Rock", "Paper", "Scissor" };
            randomNumber = rnd.Next(0, choices.Count);
            Console.Write($"|{ [],-27}Computer chose: {choices[randomNumber],-26}{ [],-4}|\n");
            return randomNumber;
        }
        #endregion

        #region "Calculate winner"
        internal void WhoWonTheGame(GameContext context, int playerNbr, int computerNbr)
        {
            string resultMessage;
            if (playerNbr == computerNbr)
            {
                resultMessage = $"|{ [],-36}Tie!{ [],-33}|\n";
            }
            else if ((playerNbr == 0 && computerNbr == 2) ||
                     (playerNbr == 1 && computerNbr == 0) ||
                     (playerNbr == 2 && computerNbr == 1))
            {
                resultMessage = $"|{ [],-26}You win! (1+ for Player){ [],-23}|\n";
                context.score.playerPoints = context.score.Scores(context.score.playerScore);
            }
            else
            {
                resultMessage = $"|{ [],-24}You lose! (1+ for Computer){ [],-22}|\n";
                context.score.computerPoints = context.score.Scores(context.score.computerScore, true);
            }
            Console.Write(resultMessage);
        }
        #endregion
    }
}