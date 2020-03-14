using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAMECOTUONG
{
    public static class Game
    {
        #region Fields
        public static Player[] Players;
        public static Piece[,] bBoard = new Piece[10, 9];
        public static bool Marked = false;
        public static bool NguoiDi;
        public static Piece SelectedPiece = null;
        #endregion

        #region Constructor
        static Game()
        {
            Game.NguoiDi = true;
            Game.Marked = false;
            for (int iRow = 0; iRow < 10; iRow++)
                for (int iCol = 0; iCol < 9; iCol++)
                {
                    Game.bBoard[iRow, iCol] = new Piece(iRow, iCol);
                }
        }
        #endregion

        #region Methods
        public static void InitPlayer()
        {
            Game.Players = new Player[2]
            {
                new Player(ECons.Color.Red),
                new Player(ECons.Color.Black)
            };
        }
        public static void InitPlayer(string redName, string blackName)
        {
            Game.Players[0].PlayerName = redName;
            Game.Players[1].PlayerName = blackName;
        }
        #endregion
    }
}