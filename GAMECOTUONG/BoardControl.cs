using System.Collections.Generic;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public static class BoardControl
    {
        #region Methods
        public static bool CoQuanCheTuong(Piece chessItem, int iRow, int iCol)
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
                        if (Game.bBoard[i, chessItem.Col].Trong == false) count++;
                    //Nếu chỉ có quân cờ chessItem đứng che giữa 2 tướng, thì không thể đi ra khỏi Col
                    if (count <= 1) return false;
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
            Game.SelectedPiece.Pic.BackColor = System.Drawing.Color.Transparent;
        }
        public static void PickDown(Move move)
        {
            Game.bBoard[move.ToRow, move.ToCol].Trong = false;
            Game.bBoard[move.ToRow, move.ToCol].Color = move.Piece.Color;
            Game.bBoard[move.ToRow, move.ToCol].PieceType = move.Piece.PieceType;

            Game.bBoard[move.FromRow, move.FromCol].Trong = true;
            Game.bBoard[move.FromRow, move.FromCol].Color = ECons.Color.Unknown;
            Game.bBoard[move.FromRow, move.FromCol].PieceType = ECons.Piece.Unknown;

            Game.SelectedPiece = Player.GetPiece(move.Piece);
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
                    #region cmt
                    /*
                    if (Game.bBoard[r, c].Trong == false)
                    {
                        if (Game.bBoard[r, c].Color == ECons.Color.Red)
                        {
                            switch (Game.bBoard[r, c].PieceType)
                            {
                                case ECons.Piece.King:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.redKing_marked;
                                    break;
                                case ECons.Piece.Advisor:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.redAdvisor_marked;
                                    break;
                                case ECons.Piece.Bishop:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.redBishop_marked;
                                    break;
                                case ECons.Piece.Cannon:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.redCannon_marked;
                                    break;
                                case ECons.Piece.Knight:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.redKnight_marked;
                                    break;
                                case ECons.Piece.Rook:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.redRook_marked;
                                    break;
                                case ECons.Piece.Pawn:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.redPawn_marked;
                                    break;
                            }
                        }
                        else if (Game.bBoard[r, c].Color == ECons.Color.Black)
                        {
                            switch (Game.bBoard[r, c].PieceType)
                            {
                                case ECons.Piece.King:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.blackKing_marked;
                                    break;
                                case ECons.Piece.Advisor:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.blackAdvisor_marked;
                                    break;
                                case ECons.Piece.Bishop:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.blackBishop_marked;
                                    break;
                                case ECons.Piece.Cannon:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.blackCannon_marked;
                                    break;
                                case ECons.Piece.Knight:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.blackKnight_marked;
                                    break;
                                case ECons.Piece.Rook:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.blackRook_marked;
                                    break;
                                case ECons.Piece.Pawn:
                                    Game.bBoard[r, c].Pic.Image = Properties.Resources.blackPawn_marked;
                                    break;
                            }
                        }
                    }
                    */
                    #endregion
                    if (Game.bBoard[r, c].Trong == true)
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
                        //Game.bBoard[r, c].Pic.Image = Properties.Resources.CanMove;
                    }
                    else Game.bBoard[r, c].Pic.Visible = false;
                }
            }
        }
        public static void AnQuanCo(Piece piece)
        {
            piece.Status = false;//Da bi an
            piece.Pic.Visible = false;
            piece.Trong = true;
            if (piece.PieceType == ECons.Piece.King)
            {
                string str = piece.Color == ECons.Color.Red ? "Black" : "Red";
                if (MessageBox.Show("Phe " + str + " đã thắng!", "Kết thúc ván cờ", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    Application.Exit();
            }
        }
        #endregion
    }
}