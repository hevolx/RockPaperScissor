namespace UserInterface.Extras
{
    public class GameRules
    {
        #region "Game rules | Finished"
        internal void Rules(GameContext context)
        {
            Console.Clear();
            Console.Write("|--------------------------------Game Rules-------------------------------|\n" +
                $"| - The user chooses between (rock, paper or scissor){ [],-21}|\n" +
                $"| - The computer randomly chooses between (rock, paper or scissor){ [],-8}|\n" +
                $"| - The game shows who has won the match and points are{ [],-19}|\n" +
                $"|   awarded either to computer or player{ [],-34}|\n");
            context.navigation.MenuNavigation(context);
        }
        #endregion
    }
}