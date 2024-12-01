﻿namespace RockPaperScissor
{
    public class GamePoints
    {
        #region "Points achived | Finished"
        public void Points(GameContext context)
        {
            Console.Clear();
            Console.Write("|-----------------------------Player vs Computer--------------------------|\n" +
                $"|{ [],-29}Your points: {context.score.playerPoints}{ [],-30}|\n" +
                $"|{ [],-25}Computer points: {context.score.computerPoints}{ [],-30}|\n");
            context.gameNavigation.MenuNavigation(context);
        }
        #endregion
    }
}