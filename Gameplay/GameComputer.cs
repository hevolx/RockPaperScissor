using UserInterface.Extras;

namespace UserInterface.Gameplay
{
    public class GameComputer
    {
        #region "Play game | v.3"
        internal void Computer(GameContext context)
        {
            int computer;
            Console.Clear();

            Console.Write("|--------------------------Choose your game strategy----------------------|\n" +
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
                        $"|{ [],-31}You chose: Rock{ [],-27}|\n", context.player.Rock);
                    computer = ComputerChoice();
                    WhoWonTheGame(context, context.player.Rock, computer);
                    context.navigation.PlayAgain(context);
                    break;
                }
                else if (input.Key == ConsoleKey.P) // Paper
                {
                    Console.Clear();
                    Console.Write("|--------------------------------Game results-----------------------------|\n" +
                        $"|{ [],-31}You chose: Paper{ [],-26}|\n", context.player.Paper);
                    computer = ComputerChoice();
                    WhoWonTheGame(context, context.player.Paper, computer);
                    context.navigation.PlayAgain(context);
                    break;
                }
                else if (input.Key == ConsoleKey.S) // Scissor
                {
                    Console.Clear();
                    Console.Write("|--------------------------------Game results-----------------------------|\n" +
                        $"|{ [],-29}You chose: Scissor{ [],-26}|\n", context.player.Scissor);
                    computer = ComputerChoice();
                    WhoWonTheGame(context, context.player.Scissor, computer);
                    context.navigation.PlayAgain(context);
                    break;
                }
            }
            while (true);
        }
        #endregion

        #region "Computer | v.3"
        internal static int ComputerChoice()
        {
            int randomNumber;
            Random rnd = new Random();
            List<string> choices = new List<string> { "Rock", "Paper", "Scissor" };
            randomNumber = rnd.Next(0, choices.Count);
            if (randomNumber == 0 || randomNumber == 1 || randomNumber == 2)
            {
                Console.Write($"|{ [],-28}Computer chose: {choices[randomNumber],-25}{ [],-4}|\n", randomNumber);
            }
            return randomNumber;
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