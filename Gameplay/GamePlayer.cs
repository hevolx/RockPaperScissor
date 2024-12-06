using UserInterface.Extras;

namespace UserInterface.Gameplay
{
    public class GamePlayer
    {
        internal void Player(GameContext context)
        {
            int player1;
            int player2;
            //Console.Clear();

            player1 = PlayerChoice(true);
            player2 = PlayerChoice();

            List<string> choices = new List<string> { "Rock", "Paper", "Scissor" };

            Console.Clear();
            Console.Write($"|--------------------------------Game results-----------------------------|\n" +
                $"|{ [],-31}Player 1: {choices[player1],-28}{ [],-4}|\n" +
                $"|{ [],-31}Player 2: {choices[player2],-28}{ [],-4}|\n");

            WhoWonTheGame(context, player1, player2);
            context.navigation.PlayAgain(context);
        }
        public static string GameStrategy(int playerNumber)
        {
            string playerLabel;
            Console.Clear();
            if (playerNumber == 1)
            {
                playerLabel = "Player (1)";
            }
            else
            {
                playerLabel = "Player (2)";
            }
            return $"|---------------------------------{playerLabel}------------------------------|\n" +
            $"|{ [],-33}<R> - Rock{ [],-30}|\n" +
            $"|{ [],-33}<P> - Paper{ [],-29}|\n" +
            $"|{ [],-33}<S> - Scissor{ [],-27}|\n" +
            $"|-------------------------------------------------------------------------|\n" +
            $"|{ [],-17}Press key (Rock <R>, Paper <P>, Scissor <S>){ [],-12}|\n" +
            $"|-------------------------------------------------------------------------|\n";
        }
        internal static int PlayerChoice(bool player1)
        {
            Console.Write(GameStrategy(1));
            while (true)
            {
                var input = Console.ReadKey(true);
                int playerNumber;
                switch (input.Key)
                {
                    case ConsoleKey.R:
                        playerNumber = 0; // Rock
                        break;
                    case ConsoleKey.P:
                        playerNumber = 1; // Paper
                        break;
                    case ConsoleKey.S:
                        playerNumber = 2; // Scissor
                        break;
                    default:
                        continue;
                }
                return playerNumber;
            }
        }
        #region "Computer | v.3"
        internal static int PlayerChoice()
        {
            Console.Write(GameStrategy(2));
            while (true)
            {
                var input = Console.ReadKey(true);
                int playerNumber;
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
                return playerNumber;
            }
        }
        internal void WhoWonTheGame(GameContext context, int player1, int player2)
        {
            string resultMessage;
            if (player1 == player2)
            {
                resultMessage = $"|{ [],-36}Tie!{ [],-33}|\n";
            }
            else if ((player1 == 0 && player2 == 2) ||
                     (player1 == 1 && player2 == 0) ||
                     (player1 == 2 && player2 == 1))
            {
                resultMessage = $"|{ [],-31}Player 1 wins!{ [],-28}|\n";
                //context.score.playerPoints = context.score.Scores(context.score.playerScore);
            }
            else
            {
                resultMessage = $"|{ [],-31}Player 2 wins!{ [],-28}|\n";
                //context.score.computerPoints = context.score.Scores(context.score.computerScore, true);
            }
            Console.Write(resultMessage);
        }
        #endregion
    }
}