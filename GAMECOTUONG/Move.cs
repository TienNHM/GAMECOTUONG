using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMECOTUONG
{
    public class Move
    {
        #region Fields
        private int fromRow;
        private int fromCol;
        private int toRow;
        private int toCol;
        private int value;
        private Piece piece;
        #endregion

        #region Properties
        public int FromRow { get => fromRow; set => fromRow = value; }
        public int FromCol { get => fromCol; set => fromCol = value; }
        public int ToRow { get => toRow; set => toRow = value; }
        public int ToCol { get => toCol; set => toCol = value; }
        public int Value { get => value; set => this.value = value; }
        public Piece Piece { get => piece; set => piece = value; }
        #endregion

        #region Constructors
        public Move(int Value)
        {
            this.Value = Value;
        }
        public Move(Piece piece, int fromRow, int fromCol, int toRow, int toCol, int value)
        {
            this.Piece = piece;
            this.FromRow = fromRow;
            this.FromCol = fromCol;
            this.ToRow = toRow;
            this.ToCol = toCol;
            this.Value = value;
        }
        #endregion

        #region Methods
        public Move ReverseMove()
        {
            return new Move(Piece, ToRow, ToCol, FromRow, FromCol, Value);
        }
        public void Sort(List<Move> moves)
        {
            int n = moves.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (moves[i].Value > moves[j].Value)
                    {
                        Move tmp = moves[i];
                        moves[i] = moves[j];
                        moves[j] = tmp;
                    }
        }
        public static Move GetBestMove(List<Move> listMoves)
        {
            if (listMoves.Count == 0) return null;
            Move bestMove = listMoves[0];
            int n = listMoves.Count;
            for (int i = 1; i < n; i++)
                if (listMoves[i].Value > bestMove.Value) bestMove = listMoves[i];
            return bestMove;
        }
        public static Move GetWorstMove(List<Move> listMoves)
        {
            Move worstMove = listMoves[0];
            int n = listMoves.Count;
            for (int i = 1; i < n; i++)
            {
                if (listMoves[i].Value < worstMove.Value)
                    worstMove = listMoves[i];
            }
            return worstMove;
        }
        #endregion
    }
}
