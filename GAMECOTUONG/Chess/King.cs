using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public class King : Piece
    {
        #region Constructor
        public King(ECons.Color Color) : base(Color)
        {
            Pos = 0;
            Col = 4;
            PieceType = ECons.Piece.King;
            switch (Color)
            {
                case ECons.Color.Black:
                    Row = 0;
                    Pic.Image = GAMECOTUONG.Properties.Resources.blackKing;
                    break;
                case ECons.Color.Red:
                    Row = 9;
                    Pic.Image = GAMECOTUONG.Properties.Resources.redKing;
                    break;
            }
            base.InitXY();
            //Game.bBoard[Row, Col] = this;
            Game.bBoard[Row, Col].Trong = false;
            Game.bBoard[Row, Col].Color = Color;
            Game.bBoard[Row, Col].Pos = 0;
            Game.bBoard[Row, Col].PieceType = ECons.Piece.King;
            ToolTip = new ToolTip();
            ToolTip.SetToolTip(Pic, Color + " " + PieceType);
        }
        #endregion

        #region Methods
        public override void CreateMoves()
        {
            listMove = new List<Move>();
            int startRow = 0, endRow = 9;
            if (this.Color == ECons.Color.Black)
            {
                startRow = 0;
                endRow = 2;
            }
            else if (this.Color == ECons.Color.Red)
            {
                startRow = 7;
                endRow = 9;
            }
            if (this.Row-1 >=startRow && this.Col>= 3 && this.Col<=5)
            {
                if (Game.bBoard[this.Row - 1, this.Col].Trong == true || Game.bBoard[this.Row - 1, this.Col].Color != this.Color)
                {
                    int value = Evaluate.GetValuePiece(this, this.Row - 1, this.Col);
                    listMove.Add(new Move(this, this.Row, this.Col, this.Row - 1, this.Col, value));
                }
            }
            if (this.Row + 1 <= endRow && this.Col >= 3 && this.Col <= 5)
            {
                if (Game.bBoard[this.Row + 1, this.Col].Trong == true || Game.bBoard[this.Row + 1, this.Col].Color != this.Color)
                {
                    int value = Evaluate.GetValuePiece(this, this.Row + 1, this.Col);
                    listMove.Add(new Move(this, this.Row, this.Col, this.Row + 1, this.Col, value));
                }
            }
            if (this.Col-1 >= 3)
            {
                if (Game.bBoard[this.Row, this.Col - 1].Trong == true || Game.bBoard[this.Row, this.Col - 1].Color != this.Color)
                    if (BoardControl.CoQuanCheTuong(this, this.Row, this.Col - 1))
                    {
                        int value = Evaluate.GetValuePiece(this, this.Row, this.Col - 1);
                        listMove.Add(new Move(this, this.Row, this.Col, this.Row, this.Col - 1, value));
                    }
            }
            if (this.Col + 1 <= 5)
            {
            if (Game.bBoard[this.Row, this.Col + 1].Trong == true || Game.bBoard[this.Row, this.Col + 1].Color != this.Color)
                if (BoardControl.CoQuanCheTuong(this, this.Row, this.Col + 1))
                    {
                        int value = Evaluate.GetValuePiece(this, this.Row, this.Col + 1);
                        listMove.Add(new Move(this, this.Row, this.Col, this.Row, this.Col + 1, value));
                    }
            }
        }
        #endregion 
    }
}