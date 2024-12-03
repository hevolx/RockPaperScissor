using Entities;

namespace UserInterface
{
    public class GameContext
    {
        internal Score score { get; set; }
        internal Player Player { get; set; }
        internal GameNavigation gameNavigation { get; set; }
        internal MainMenu gameMenu { get; set; }
        internal GameRules gameRules { get; set; }
        internal GamePoints gamePoints { get; set; }
        internal ComputerVsPlayer computerVsPlayer { get; set; }
        internal GameQuit gameQuit { get; set; }
        internal GameContext()
        {
            score = new Score();
            Player = new Player();
            gameNavigation = new GameNavigation();
            gameMenu = new MainMenu();
            gameRules = new GameRules();
            gamePoints = new GamePoints();
            gameLogic = new ComputerVsPlayer();
            gameQuit = new GameQuit();
        }
    }
}