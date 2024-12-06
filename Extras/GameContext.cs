using Entities;
using UserInterface.Gameplay;
using UserInterface.Menu;

namespace UserInterface.Extras
{
    public class GameContext
    {
        internal Score score { get; set; }
        internal Player player { get; set; }
        internal MainMenu mainMenu { get; set; }
        internal GameNavigation navigation { get; set; }
        internal GameMenu gameMenu { get; set; }
        internal GameRules rules { get; set; }
        internal GamePoints points { get; set; }
        internal GameComputer gameComputer { get; set; }
        public GamePlayer gamePlayer { get; set; }
        internal GameQuit quit { get; set; }
        internal GameContext()
        {
            score = new Score();
            player = new Player();
            mainMenu = new MainMenu();
            navigation = new GameNavigation();
            gameMenu = new GameMenu();
            rules = new GameRules();
            points = new GamePoints();
            gameComputer = new GameComputer();
            gamePlayer = new GamePlayer();
            quit = new GameQuit();
        }
    }
}