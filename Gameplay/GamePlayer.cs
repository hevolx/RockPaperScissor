using UserInterface.Extras;

namespace UserInterface.Gameplay
{
    public class GamePlayer
    {
        #region "Play game | v.3"
        internal void Player(GameContext context)
        {
            int player2;
            Console.Clear();
            Console.Write("|----------------------------------Player 1-------------------------------|\n" +
                $"|{ [],-33}<R> - Rock{ [],-30}|\n" +
                $"|{ [],-33}<P> - Paper{ [],-29}|\n" +
                $"|{ [],-33}<S> - Scissor{ [],-27}|\n");
            do
            {
                Console.Write("|-------------------------------------------------------------------------|\n");
                Console.Write($"|{ [],-17}Press key (Rock <R>, Paper <P>, Scissor <S>){ [],-12}|\n");
                Console.Write("|-------------------------------------------------------------------------|\n");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.R) // Rock
                {
                    Console.Clear();
                    Console.Write("|--------------------------------Game results-----------------------------|\n" +
                        $"|{ [],-31}Player 1: Rock{ [],-27}|\n", context.player.Rock);
                    player2 = ComputerChoice();
                    WhoWonTheGame(context, context.player.Rock, player2);
                    context.navigation.PlayAgain(context);
                    break;
                }
                else if (input.Key == ConsoleKey.P) // Paper
                {
                    Console.Clear();
                    Console.Write("|--------------------------------Game results-----------------------------|\n" +
                        $"|{ [],-31}Player 1: Paper{ [],-26}|\n", context.player.Paper);
                    player2 = ComputerChoice();
                    WhoWonTheGame(context, context.player.Paper, player2);
                    context.navigation.PlayAgain(context);
                    break;
                }
                else if (input.Key == ConsoleKey.S) // Scissor
                {
                    Console.Clear();
                    Console.Write("|--------------------------------Game results-----------------------------|\n" +
                        $"|{ [],-29}Player 1: Scissor{ [],-26}|\n", context.player.Scissor);
                    player2 = Player2Choice();
                    WhoWonTheGame(context, context.player.Scissor, player2);
                    context.navigation.PlayAgain(context);
                    break;
                }
            }
            while (true);
        }
        #endregion

        #region "Computer | v.3"
        internal static int Player2Choice()
        {
            int player2Number;
            List<string> choices = new List<string> { "Rock", "Paper", "Scissor" };
            Console.Write("|----------------------------------Player 1-------------------------------|\n" +
               $"|{ [],-33}<R> - Rock{ [],-30}|\n" +
               $"|{ [],-33}<P> - Paper{ [],-29}|\n" +
               $"|{ [],-33}<S> - Scissor{ [],-27}|\n");
            do
            {
                Console.Write("|-------------------------------------------------------------------------|\n");
                Console.Write($"|{ [],-17}Press key (Rock <R>, Paper <P>, Scissor <S>){ [],-12}|\n");
                Console.Write("|-------------------------------------------------------------------------|\n");
                var input = Console.ReadKey(true);
                int player2Choice = -1;

                if (input.Key == ConsoleKey.R) // Rock
                {
                    player2Choice = 0;
                }
                else if (input.Key == ConsoleKey.P) // Paper
                {
                    player2Choice = 1;
                }
                else if (input.Key == ConsoleKey.S) // Scissor
                {
                    player2Choice = 2;
                }
                player2Number = player2Choice;
                if (player2Number == 0 || player2Number == 1 || player2Number == 2)
                {
                    Console.Write($"|{ [],-28}Player 2: {choices[player2Number],-25}{ [],-4}|\n", player2Number);
                }
                return player2Number;
            }
            while (true);
        }
        #endregion

        #region "Calculates who won | v.2"
        internal void WhoWonTheGame(GameContext context, int playerNbr, int computerNbr)
        {
            switch (playerNbr)
            {
                case 0:
                    {
                        // Player: Rock | Computer: Scissor
                        if (context.player.Rock == 0 && computerNbr == 2)
                        {
                            Console.Write($"|{ [],-26}You win! (1+ for Player){ [],-23}|\n");
                            context.score.playerPoints = context.score.Scores(context.score.playerScore);
                        }
                        // Player: Rock | Computer: Paper
                        else if (context.player.Rock == 0 && computerNbr == 1)
                        {
                            Console.Write($"|{ [],-24}You lose! (1+ for Computer){ [],-22}|\n");
                            context.score.computerPoints = context.score.Scores(context.score.computerScore, true);
                        }
                        // Player: Rock | Computer: Rock
                        else if (context.player.Rock == 0 && computerNbr == 0)
                        {
                            Console.WriteLine($"|{ [],-36}Tie!{ [],-33}|");
                        }
                        break;
                    }
                case 1: // Paper
                    {
                        // Player: Paper | Computer: Rock
                        if (context.player.Paper == 1 && computerNbr == 0)
                        {
                            Console.Write($"|{ [],-26}You win! (1+ for Player){ [],-23}|\n");
                            context.score.playerPoints = context.score.Scores(context.score.playerScore);
                        }
                        // Player: Paper | Computer: Scissor
                        else if (context.player.Paper == 1 && computerNbr == 2)
                        {
                            Console.Write($"|{ [],-24}You lose! (1+ for Computer){ [],-22}|\n");
                            context.score.computerPoints = context.score.Scores(context.score.computerScore, true);
                        }
                        // Player: Paper | Computer: Paper
                        else if (context.player.Paper == 1 && computerNbr == 1)
                        {
                            Console.WriteLine($"|{ [],-36}Tie!{ [],-33}|");
                        }
                        break;
                    }
                case 2: // Scissor
                    {
                        // Player: Scissor | Computer: Paper
                        if (context.player.Scissor == 2 && computerNbr == 1)
                        {
                            Console.Write($"|{ [],-26}You win! (1+ for Player){ [],-23}|\n");
                            context.score.playerPoints = context.score.Scores(context.score.playerScore);
                        }
                        // Player: Scissor | Computer: Rock
                        else if (context.player.Scissor == 2 && computerNbr == 0)
                        {
                            Console.Write($"|{ [],-24}You lose! (1+ for Computer){ [],-22}|\n");
                            context.score.computerPoints = context.score.Scores(context.score.computerScore, true);
                        }
                        // Player: Scissor | Computer: Scissor
                        else if (context.player.Scissor == 2 && computerNbr == 2)
                        {
                            Console.WriteLine($"|{ [],-36}Tie!{ [],-33}|");
                        }
                        break;
                    }
            }

        }
        #endregion
    }
}