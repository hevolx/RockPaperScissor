namespace RockPaperScissor
{
    public class Program
    {
        private static GameContext context = null;
        static void Main(string[] args)
        {
            context = new GameContext();
            context.gameMenu.Menu(context);
        }
    }
}