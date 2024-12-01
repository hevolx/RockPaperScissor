using GameLogic;

namespace RockPaperScissor
{
    public class GameContext
    {
        public Score score { get; set; }
        public Player Player { get; set; }
        public GameNavigation gameNavigation { get; set; }
        public GameMenu gameMenu { get; set; }
        public GameRules gameRules { get; set; }
        public GamePoints gamePoints { get; set; }
        public GameLogic gameLogic { get; set; }
        public GameQuit gameQuit { get; set; }
        public GameContext()
        {
            score = new Score();
            Player = new Player();
            gameNavigation = new GameNavigation();
            gameMenu = new GameMenu();
            gameRules = new GameRules();
            gamePoints = new GamePoints();
            gameLogic = new GameLogic();
        }
    }
}