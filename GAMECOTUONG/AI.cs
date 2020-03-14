using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMECOTUONG
{
    class AI
    {
        #region Fields
        private static int level;
        private static int oponentPlayer;
        private static int computerPoint;
        private static List<ECons.Piece> listPieceName_Man = null;
        private static List<Move> listAllMove_Man = null;
        private static List<ECons.Piece> listPieceName_AI = null;
        private static List<Move> listAllMove_AI = null;
        private static Piece[,] tmpBoard = null;
        private static Player[ ] tmpPlayers = null;
        #endregion

        #region Properties
        public static int Level { get => level; set => level = value; }
        #endregion

        #region Methods
        public static void GetHeristicPoint(out ECons.Piece pieceName, int[] move)
        {
            int depth = 2 * AI.Level;
            move = null;
            pieceName = ECons.Piece.Unknown; 
            tmpBoard = Game.bBoard;
            tmpPlayers = Game.Players;
            while (depth >= 0)
            {
                Game.Players[1].CreateAllMove(listPieceName_AI, listAllMove_AI);
                AISearch(out pieceName, move);
                Game.Players[0].CreateAllMove(listPieceName_Man, listAllMove_Man);
                ManSearch();
                depth--;
            }
        }
        #region Search
        private static void AISearch(out ECons.Piece pieceName, int[] move)
        {
            int nAI = listAllMove_AI.Count;
            computerPoint = Evaluate.GetPoint(Game.Players[1]);
            int pos = 0;
            pieceName = listPieceName_AI[0];
            int max = Int32.MinValue;
            for (int i = 0; i < nAI; i++)
            {
                int from = Evaluate.GetEvaluate(listPieceName_AI[i], ECons.Color.Black, listAllMove_AI[i].FromRow, listAllMove_AI[i].FromCol);
                int to = Evaluate.GetEvaluate(listPieceName_AI[i], ECons.Color.Black, listAllMove_AI[i].ToRow, listAllMove_AI[i].ToCol);
                if (computerPoint - from + to > max)
                {
                    move[0] = listAllMove_AI[i].ToRow;
                    move[1] = listAllMove_AI[i].ToCol;
                    pieceName = listPieceName_AI[i];
                    pos = i;
                    max = computerPoint - from + to;
                }
            }
            tmpBoard[listAllMove_AI[pos].FromRow, listAllMove_AI[pos].FromCol].Trong = true;
            tmpBoard[listAllMove_AI[pos].ToRow, listAllMove_AI[pos].ToCol].Trong = false;
            listAllMove_AI.RemoveAt(pos);
            listPieceName_AI.RemoveAt(pos);
            computerPoint = max;
        }
        private static void ManSearch()
        {
            int n = listAllMove_Man.Count;
            oponentPlayer = Evaluate.GetPoint(Game.Players[0]);
            int pos = 0;
            int min = Int32.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int from = Evaluate.GetEvaluate(listPieceName_Man[i], ECons.Color.Red, listAllMove_Man[i].FromRow, listAllMove_Man[i].FromCol);
                int to = Evaluate.GetEvaluate(listPieceName_Man[i], ECons.Color.Red, listAllMove_Man[i].ToRow, listAllMove_Man[i].ToCol);
                if (oponentPlayer - from + to < min)
                {
                    pos = i;
                    min = oponentPlayer - from + to;
                }
            }
            tmpBoard[listAllMove_Man[pos].FromRow, listAllMove_Man[pos].FromCol].Trong = true;
            tmpBoard[listAllMove_Man[pos].ToRow, listAllMove_Man[pos].ToCol].Trong = false;
            listAllMove_Man.RemoveAt(pos);
            listPieceName_Man.RemoveAt(pos);
            oponentPlayer = min;
        }
        #endregion

        #endregion
    }
}
