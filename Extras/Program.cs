namespace UserInterface.Extras
{
    public class Program
    {
        private static GameContext context = null;
        private protected static void Main(string[] args)
        {
            context = new GameContext();
            context.mainMenu.StartMenu(context);
        }
    }
}