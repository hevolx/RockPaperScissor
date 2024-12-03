namespace UserInterface
{
    public class Program
    {
        private static GameContext context = null;
        private protected static void Main(string[] args)
        {
            context = new GameContext();
            context.gameMenu.Menu(context);
        }
    }
}