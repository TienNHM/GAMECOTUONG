using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public static class BoardControl
    {
        #region Methods
        public static bool CoQuanCheTuong( Piece chessItem, int iRow, int iCol)
        {
            #region Rule
            // Nếu quân cờ hiện tại và 2 quân tướng thẳng hàng, kiểm tra xem ở giữa 2 quân tướng có quân nào khác hay không 
            // Luật: 2 tướng không trực tiếp đối mặt nhau
            #endregion
            //Quân cờ hiện tại và 2 tướng đứng thẳng hàng nhau
            if (chessItem.Col == Game.Players[0].PKing.Col && chessItem.Col == Game.Players[1].PKing.Col)
            {
                if ((iCol != chessItem.Col) && chessItem.PieceType != ECons.Piece.King)
                {
                    int count = 0;
                    for (int i = Game.Players[1].PKing.Row + 1; i != Game.Players[0].PKing.Row; i++)
                        if (Game.bBoard[i, chessItem.Col].Trong == false)
                            count++;
                    //Nếu chỉ có quân cờ chessItem đứng che giữa 2 tướng, thì không thể đi ra khỏi Col
                    if (count <= 1)
                        return false;
                }
            }
            return true;
        }
        public static bool CoQuanCheTuong(Piece[,] pieces, int redKingCol, int blackKingCol, Piece chessItem, int iRow, int iCol)
        {
            #region Rule
            // Nếu quân cờ hiện tại và 2 quân tướng thẳng hàng, kiểm tra xem ở giữa 2 quân tướng có quân nào khác hay không 
            // Luật: 2 tướng không trực tiếp đối mặt nhau
            #endregion
            //Quân cờ hiện tại và 2 tướng đứng thẳng hàng nhau
            if (chessItem.Col == redKingCol && chessItem.Col == blackKingCol)
            {
                if ((iCol != chessItem.Col) && chessItem.PieceType != ECons.Piece.King)
                {
                    int count = 0;
                    for (int i = blackKingCol + 1; i != redKingCol; i++)
                        if (pieces[i, chessItem.Col].Trong == false)
                            count++;
                    //Nếu chỉ có quân cờ chessItem đứng che giữa 2 tướng, thì không thể đi ra khỏi Col
                    if (count <= 1)
                        return false;
                }
            }
            return true;
        }
        public static void PickDown(Piece selectedPiece, int iRow, int iCol)
        {
            Game.bBoard[iRow, iCol].Trong = false;
            Game.bBoard[iRow, iCol].Color = selectedPiece.Color;
            Game.bBoard[iRow, iCol].PieceType = selectedPiece.PieceType;

            Game.bBoard[selectedPiece.Row, selectedPiece.Col].Trong = true;
            Game.bBoard[selectedPiece.Row, selectedPiece.Col].Color = ECons.Color.Unknown;
            Game.bBoard[selectedPiece.Row, selectedPiece.Col].PieceType = ECons.Piece.Unknown;

            Game.SelectedPiece.Row = iRow;
            Game.SelectedPiece.Col = iCol;
            Game.SelectedPiece.Pic.Top = 53 * iRow + 80;
            Game.SelectedPiece.Pic.Left = 53 * iCol + 61;
            
        }
        public static void PickDown(Piece[,] pieces, ref Piece selectedPiece, int iRow, int iCol)
        {
            pieces[iRow, iCol].Trong = false;
            pieces[iRow, iCol].Color = selectedPiece.Color;
            pieces[iRow, iCol].PieceType = selectedPiece.PieceType;

            pieces[selectedPiece.Row, selectedPiece.Col].Trong = true;
            pieces[selectedPiece.Row, selectedPiece.Col].Color = ECons.Color.Unknown;
            pieces[selectedPiece.Row, selectedPiece.Col].PieceType = ECons.Piece.Unknown;

            selectedPiece.Row = iRow;
            selectedPiece.Col = iCol;
            selectedPiece.Pic.Top = 53 * iRow + 80;
            selectedPiece.Pic.Left = 53 * iCol + 61;
        }
        public static void ShowNuocDi(List<Move> listMove)
        {
            if (listMove != null)
            {
                int n = listMove.Count;
                for (int i = 0; i < n; i++)
                {
                    int r = listMove[i].ToRow;
                    int c = listMove[i].ToCol;
                    if (Game.bBoard[r, c].Trong == false)
                    {
                        
                        
                    }
                    else
                        Game.bBoard[r, c].Pic.Visible = true;
                }
            }

        }
        public static void HideNuocDi(List<Move> listMove)
        {
            if (listMove != null)
            {
                int n = listMove.Count;
                for (int i = 0; i < n; i++)
                {
                    int r = listMove[i].ToRow;
                    int c = listMove[i].ToCol;
                    if (Game.bBoard[r, c].Trong == false)
                    {
                        
                    }
                    else
                        Game.bBoard[r, c].Pic.Visible = false;
                }
            }
        }
        public static void AnQuanCo(Piece piece)
        {
            piece.Status = false;//Da bi an
            piece.Pic.Visible = false;
            piece.Trong = true;
        }
        #endregion
    }
}