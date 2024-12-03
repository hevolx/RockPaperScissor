namespace UserInterface.Extras
{
    public class GameQuit
    {
        #region "Quit game | Finished"
        internal void Quit(GameContext context)
        {
            Console.Clear();
            Console.Write("|----------------------------Hope to see you soon-------------------------|\n");
            Environment.Exit(0);
        }
        #endregion
    }
}