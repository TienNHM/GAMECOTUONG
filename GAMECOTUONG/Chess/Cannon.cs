using System.Collections.Generic;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public class Cannon : Piece
    {
        #region Constructor
        public Cannon(int Pos, ECons.Color Color) : base(Color)
        {
            this.Pos = Pos / 7;
            Col = Pos;
            PieceType = ECons.Piece.Cannon;
            switch (Color)
            {
                case ECons.Color.Black:
                    Row = 2;
                    Pic.Image = GAMECOTUONG.Properties.Resources.blackCannon;
                    break;

                case ECons.Color.Red:
                    Row = 7;
                    Pic.Image = GAMECOTUONG.Properties.Resources.redCannon;
                    break;
            }
            base.InitXY();
            Game.bBoard[Row, Col].Trong = false;
            Game.bBoard[Row, Col].Color = Color;
            Game.bBoard[Row, Col].Pos = Pos;
            Game.bBoard[Row, Col].PieceType = ECons.Piece.Cannon;
            ToolTip = new ToolTip();
            ToolTip.SetToolTip(Pic, Color + " " + PieceType);
        }
        #endregion

        #region Methods
        public override void CreateMoves()
        {
            listMove = new List<Move>();
            ECons.Color pheDich = ECons.Color.Red;
            if (this.Color == ECons.Color.Red) pheDich = ECons.Color.Black;

            #region Cùng cột 
            int iRow = Row - 1;
            while (iRow >= 0 && Game.bBoard[iRow, Col].Trong == true)
            {
                if (BoardControl.CoQuanCheTuong(this, iRow, Col))
                {
                    int value = Evaluate.GetValuePiece(this, iRow, this.Col);
                    listMove.Add(new Move(this, this.Row, this.Col, iRow, this.Col, value));
                }
                iRow--;
            }
            if (iRow >= 0)
            {
                int i = iRow - 1;
                while (i >= 0 && Game.bBoard[i, this.Col].Trong == true) i--;
                if (i >= 0 && Game.bBoard[i, this.Col].Color == pheDich)
                    if (BoardControl.CoQuanCheTuong(this, i, this.Col))
                    {
                        int value = Evaluate.GetValuePiece(this, i, this.Col);
                        listMove.Add(new Move(this, this.Row, this.Col, i, this.Col, value));
                    }
            }
            iRow = Row + 1;
            while (iRow < 10 && Game.bBoard[iRow, Col].Trong == true)
            {
                if (BoardControl.CoQuanCheTuong(this, iRow, Col))
                {
                    int value = Evaluate.GetValuePiece(this, iRow, this.Col);
                    listMove.Add(new Move(this, this.Row, this.Col, iRow, this.Col, value));
                }
                iRow++;
            }
            if (iRow < 10)
            {
                int i = iRow + 1;
                while (i < 10 && Game.bBoard[i, this.Col].Trong == true) i++;
                if (i < 10 && Game.bBoard[i, this.Col].Color == pheDich)
                    if (BoardControl.CoQuanCheTuong(this, i, this.Col))
                    {
                        int value = Evaluate.GetValuePiece(this, i, this.Col);
                        listMove.Add(new Move(this, this.Row, this.Col, i, this.Col, value));
                    }
            }
            #endregion

            #region Cùng hàng 
            int iCol = Col - 1;
            while (iCol >= 0 && Game.bBoard[Row, iCol].Trong == true)
            {
                if (BoardControl.CoQuanCheTuong(this, Row, iCol))
                {
                    int value = Evaluate.GetValuePiece(this, Row, iCol);
                    listMove.Add(new Move(this, this.Row, this.Col, this.Row, iCol, value));
                }
                iCol--;
            }
            if (iCol >= 0)
            {
                int i = iCol - 1;
                while (i >= 0 && Game.bBoard[this.Row, i].Trong == true) i--;
                if (i >= 0 && Game.bBoard[Row, iCol].Color == pheDich)
                    if (BoardControl.CoQuanCheTuong(this, Row, i))
                    {
                        int value = Evaluate.GetValuePiece(this, Row, i);
                        listMove.Add(new Move(this, this.Row, this.Col, this.Row, i, value));
                    }
            }
            iCol = Col + 1;
            while (iCol < 9 && Game.bBoard[Row, iCol].Trong == true)
            {
                if (BoardControl.CoQuanCheTuong(this, Row, iCol))
                {
                    int value = Evaluate.GetValuePiece(this, Row, iCol);
                    listMove.Add(new Move(this, this.Row, this.Col, this.Row, iCol, value));
                }
                iCol++;
            }
            if (iCol < 9)
            {
                int i = iCol + 1;
                while (i < 9 && Game.bBoard[this.Row, i].Trong == true) i++;
                if (i < 9 && Game.bBoard[Row, iCol].Color == pheDich)
                    if (BoardControl.CoQuanCheTuong(this, Row, i))
                    {
                        int value = Evaluate.GetValuePiece(this, Row, i);
                        listMove.Add(new Move(this, this.Row, this.Col, this.Row, i, value));
                    }
            }
            #endregion
        }
        #endregion
    }
}