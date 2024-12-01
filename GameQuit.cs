namespace RockPaperScissor
{
    public class GameQuit
    {
        #region "Quit game | Finished"
        public void Quit()
        {
            Console.Clear();
            Console.Write("|----------------------------Hope to see you soon-------------------------|\n");
            Environment.Exit(0);
        }
        #endregion
    }
}