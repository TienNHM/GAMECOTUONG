using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public static class Game
    {
        #region Fields
        public static Player[] Players;
        public static Piece[,] bBoard = new Piece[10, 9];
        public static bool Marked = false;
        public static Piece SelectedPiece = null;
        public static int phe;
        public static int level;
        public static int music;
        #endregion

        #region Constructor
        static Game()
        {
            InitBoardGame();
        }
        #endregion

        #region Methods
        public static void InitBoardGame()
        {
            Game.Marked = false;
            phe = 0;
            for (int iRow = 0; iRow < 10; iRow++)
                for (int iCol = 0; iCol < 9; iCol++)
                {
                    Game.bBoard[iRow, iCol] = new Piece(iRow, iCol);
                }
        }
        public static void InitPlayer()
        {
            level = 3;
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
        public static int ChangeSide(int side)
        {
            return 1 - side;
        }
        public static bool ChieuTuong(int pheHienTai)
        {
            List<Move> listMoves = new List<Move>();
            Game.Players[1 - pheHienTai].CreateMoves(ref listMoves, 1 - pheHienTai);
            int row = Players[pheHienTai].PKing.Row;
            int col = Players[pheHienTai].PKing.Col;
            string msg = null;
            foreach(var p in listMoves)
            {
                msg += p.ToRow + " " + p.ToCol + "\t\t";
                if (p.ToRow == row && p.ToCol == col)
                    return true;
            }
            //MessageBox.Show(msg);
            return false;
        }
        public static List<ECons.Piece> CuuCo(int pheHienTai)
        {
            List<Move> listMoves = new List<Move>();
            Game.Players[1 - pheHienTai].CreateMoves(ref listMoves, 1 - pheHienTai);
            List<ECons.Piece> list = new List<ECons.Piece>();
            foreach (var p in listMoves)
            {
                if (p.ToRow == Game.Players[pheHienTai].PKing.Row || p.ToCol == Game.Players[pheHienTai].PKing.Col)
                    if (list.Contains(p.Piece.PieceType) == false)
                    {
                        list.Add(p.Piece.PieceType);
                    }
            }
            return list;
        }
        #endregion
    }
}