using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    class AI
    {
        #region Fields
        private static int level;
        #endregion

        #region Properties
        public static int Level { get => level; set => level = value; }
        #endregion

        #region Methods
        static string msg = null;
        static int count = 0;
        public static Move DoSearch()
        {
            int depth = 2;
            List<Move> listAllMove = new List<Move>();
            Game.Players[1].CreateMoves(ref listAllMove, 1);
            if (listAllMove.Count == 0)
            {
                MessageBox.Show("NULL");
                return null;
            }
            Move bestMove = new Move(Int32.MinValue);
            foreach (var move in listAllMove)
            {
                Piece eatenPiece = Game.bBoard[move.ToRow, move.ToCol];
                //MessageBox.Show(move.Piece.PieceType + " " + move.Piece.Row + " " + move.Piece.Col);
                BoardControl.PickDown(move);
                //int value = Evaluate.GetPlayerPoint(1);
                int value = AlphaBetaSearch(depth, Int32.MinValue, Int32.MaxValue, 1); 
                msg += value + "\t";
                if (value > bestMove.Value)
                {
                    bestMove = move;
                    bestMove.Value = value;
                }
                BoardControl.PickDown(move.ReverseMove());
                if (eatenPiece.PieceType != ECons.Piece.Unknown)
                {
                    Game.bBoard[eatenPiece.Row, eatenPiece.Col] = eatenPiece;
                }
            }
            //MessageBox.Show(msg); 
            //MessageBox.Show(count + "..." + bestMove.Value);
            return bestMove;
        }
        public static Move _DoSearch()
        {
            int depth = 1;
            Move bestMove = new Move(Int32.MinValue);
            List<Move> listAllMove = new List<Move>();
            Game.Players[1].CreateMoves(ref listAllMove, 1);
            foreach (var move in listAllMove)
            {
                Piece eatenPiece = Game.bBoard[move.ToRow, move.ToCol] as Piece;
                BoardControl.PickDown(move);
                move.Value = AlphaBetaSearch(depth, Int32.MinValue, Int32.MaxValue, 0);
                if (move.Value > bestMove.Value)
                {
                    bestMove = move;
                }
                BoardControl.PickDown(move.ReverseMove());
                if (eatenPiece.PieceType != ECons.Piece.Unknown)
                {
                    Game.bBoard[eatenPiece.Row, eatenPiece.Col] = eatenPiece;
                }
            }
            return bestMove;
        }
        private static int AlphaBetaSearch(int depth, int alpha, int beta, int side)
        {
            if (depth == 0)
            {
                count++;
                return Evaluate.GetPlayerPoint(side);
            }
            List<Move> listAllMove = new List<Move>();
            Game.Players[side].CreateMoves(ref listAllMove, side);
            foreach(var move in listAllMove)
            {
                Piece eatenPiece = Game.bBoard[move.ToRow, move.ToCol] as Piece;
                //MessageBox.Show(Game.bBoard[move.ToRow, move.ToCol].PieceType.ToString());
                BoardControl.PickDown(move);
                if (side == 1)
                    alpha = Math.Max(alpha, AlphaBetaSearch(depth - 1, alpha, beta, 0));
                else
                    beta = Math.Min(beta, AlphaBetaSearch(depth - 1, alpha, beta, 1));
                BoardControl.PickDown(move.ReverseMove());
                if (eatenPiece.PieceType != ECons.Piece.Unknown)
                {
                    Game.bBoard[eatenPiece.Row, eatenPiece.Col] = eatenPiece;
                    //MessageBox.Show(Game.bBoard[move.ToRow, move.ToCol].PieceType.ToString());
                }
            }
            //if (alpha <= beta)
                return (side == 1) ? alpha : beta;
            //return (side == 1) ? Int32.MinValue : Int32.MaxValue;
        }
        public static Move _AlphaBetaSearch()
        {
            //int depth = 2 * AI.Level;
            int depth = 2;
            Move bestMove = new Move(Int32.MinValue);
            int bestValue = Int32.MinValue;
            List<Move> listAllMove = new List<Move>();
            Game.Players[1].CreateAllMove(ref listAllMove, 1);
            foreach (Move tmp in listAllMove)
            {
                int tmpValue = MaxSearch(depth, 1, Int32.MinValue, Int32.MaxValue);
                if (tmpValue > bestValue)
                {
                    bestMove = tmp;
                    bestValue = tmpValue;
                }
            }
            return bestMove;
        }
        #region Search
        private static int MaxSearch(int depth, int side, int alpha, int beta)
        {
            List<Move> listAllMove = new List<Move>();

            if (depth == 1)
            {
                return Move.GetBestMove(listAllMove).Value;
            }

            int newAlpha = alpha;
            int newBeta = beta;
            Move max = new Move(alpha);
            int n = listAllMove.Count;

            for (int i = 0; i < n; i++)
            {
                //Giả sử chọn nước đi thứ i
                Move selectedMove = listAllMove[i];
                BoardControl.PickDown(selectedMove);
                Game.Players[side].CreateAllMove(ref listAllMove, side);
                //Đệ quy, duyệt các nút con
                int newValue = MinSearch(depth - 1, Game.ChangeSide(side), newAlpha, newBeta);
                //Quay lui
                BoardControl.PickDown(selectedMove.ReverseMove());
                if (newValue > newAlpha)
                {
                    max.Value = newValue;
                    newAlpha = newValue;
                }
                //Cắt tỉa
                if (newBeta <= newAlpha)
                    return max.Value;
            }
            return max.Value;
        }
        private static int MinSearch(int depth, int side, int alpha, int beta)
        {
            List<Move> listAllMove = new List<Move>();

            if (depth == 1)
            {
                return Move.GetWorstMove(listAllMove).Value;
            }

            int newAlpha = alpha;
            int newBeta = beta;
            Move min = new Move(beta);
            int n = listAllMove.Count;

            for (int i = 0; i < n; i++)
            {
                //Giả sử chọn nước đi thứ i
                Move selectedMove = listAllMove[i];
                BoardControl.PickDown(selectedMove);
                Game.Players[side].CreateAllMove(ref listAllMove, side);
                //Đệ quy, duyệt các nút con
                Move newMove = new Move(Int32.MaxValue);
                int newValue = MaxSearch(depth - 1, Game.ChangeSide(side), newAlpha, newBeta);
                //Quay lui
                BoardControl.PickDown(selectedMove.ReverseMove());
                if (newValue < newBeta)
                {
                    min.Value = newValue;
                    newBeta = newValue;
                }
                //Cắt tỉa
                if (newBeta <= newAlpha)
                    return min.Value;
                
            }
            return min.Value;
        }
        #endregion

        #endregion
    }

    //Mở đầu: giới thiệu môn học, cá nhân, bla bla....
    //giải thích chương trình dùng làm gì (mô tả chung chung)
    //các chức năng (mà chương trình có)
    //mô tả các chức năng (chương trình chạy ntn, chạy demo: người chơi ntn, người thắng cuộc ntn, người thua cuộc ntn, ...)
    //những gì đạt được, hiểu được
}
