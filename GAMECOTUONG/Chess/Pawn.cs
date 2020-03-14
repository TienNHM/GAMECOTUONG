using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAMECOTUONG
{
    public class Pawn : Piece
    {
        #region Constructor
        public Pawn(string strPos, ECons.Color Color) : base(Color)
        {
            Pos = strPos;
            Col = Convert.ToInt16(strPos);
            switch (Color)
            {
                case ECons.Color.Black:
                    Row = 3;
                    Pic.Image = GAMECOTUONG.Properties.Resources.blackPawn;
                    break;
                case ECons.Color.Red:
                    Row = 6;
                    Pic.Image = GAMECOTUONG.Properties.Resources.redPawn;
                    break;
            }
            base.InitXY();
            Game.bBoard[Row, Col].Trong = false;
            Game.bBoard[Row, Col].Color = Color;
            Game.bBoard[Row, Col].Pos = strPos;
            Game.bBoard[Row, Col].PieceType = ECons.Piece.Pawn;
        }
        #endregion

        #region Methods
        public override void CreateMoves()
        {
            listMove = new List<Move>();
            if (this.Color==ECons.Color.Black)
            {
                if (this.Row >= 0 && this.Row <= 4)
                {
                    Piece p = Game.bBoard[this.Row + 1, this.Col];
                    if (p.Trong == true || p.Color != this.Color)
                        if (BoardControl.CoQuanCheTuong(this, this.Row + 1, this.Col))
                            listMove.Add(new Move(this.Row, this.Col, this.Row + 1, this.Col));
                }
                else if (this.Row >= 5 && this.Row <= 9)
                {
                    Piece p;
                    if (this.Row + 1 <= 9)
                    {
                        p = Game.bBoard[this.Row + 1, this.Col];
                        if (p.Trong == true || p.Color != this.Color)
                            if (BoardControl.CoQuanCheTuong(this, this.Row + 1, this.Col))
                                listMove.Add(new Move(this.Row, this.Col, this.Row + 1, this.Col));
                    }
                    if (this.Col - 1 >= 0)
                    {
                        p = Game.bBoard[this.Row, this.Col - 1];
                        if (p.Trong == true || p.Color != this.Color)
                            if (BoardControl.CoQuanCheTuong(this, this.Row, this.Col - 1))
                                listMove.Add(new Move(this.Row, this.Col, this.Row, this.Col - 1));
                    }
                    if (this.Col + 1 <= 8)
                    {
                        p = Game.bBoard[this.Row, this.Col + 1];
                        if (p.Trong == true || p.Color != this.Color)
                            if (BoardControl.CoQuanCheTuong(this, this.Row, this.Col + 1))
                                listMove.Add(new Move(this.Row, this.Col, this.Row, this.Col + 1));
                    }
                }
            }
            else if (this.Color==ECons.Color.Red)
            {
                if (this.Row>=5 && this.Row<=9)
                {
                    Piece p = Game.bBoard[this.Row - 1, this.Col];
                    if (p.Trong == true || p.Color != this.Color)
                        if (BoardControl.CoQuanCheTuong(this, this.Row - 1, this.Col))
                            listMove.Add(new Move(this.Row, this.Col, this.Row - 1, this.Col));
                }
                else if (this.Row>=0 && this.Row <=4)
                {
                    Piece p;
                    if (this.Row-1>=0)
                    {
                        p = Game.bBoard[this.Row - 1, this.Col];
                        if (p.Trong == true || p.Color != this.Color)
                            if (BoardControl.CoQuanCheTuong(this, this.Row - 1, this.Col))
                                listMove.Add(new Move(this.Row, this.Col, this.Row - 1, this.Col));
                    }
                    if (this.Col-1>=0)
                    {
                        p = Game.bBoard[this.Row, this.Col - 1];
                        if (p.Trong == true || p.Color != this.Color)
                            if (BoardControl.CoQuanCheTuong(this, this.Row, this.Col - 1))
                                listMove.Add(new Move(this.Row, this.Col, this.Row, this.Col - 1));
                    }
                    if (this.Col+1<=8)
                    {
                        p = Game.bBoard[this.Row, this.Col + 1];
                        if (p.Trong == true || p.Color != this.Color)
                            if (BoardControl.CoQuanCheTuong(this, this.Row, this.Col + 1))
                                listMove.Add(new Move(this.Row, this.Col, this.Row, this.Col + 1));
                    }
                }
            }
        }
        #endregion
    }
}