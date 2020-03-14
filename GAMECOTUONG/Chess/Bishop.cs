using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAMECOTUONG
{
    //Tượng 
    public class Bishop : Piece
    {
        #region Constructor
        public Bishop(string strPos, ECons.Color Color) : base(Color)
        {
            Pos = strPos;
            Col = Convert.ToInt16(strPos);
            switch (Color)
            {
                case ECons.Color.Black:
                    Row = 0;
                    Pic.Image = GAMECOTUONG.Properties.Resources.blackBishop;
                    break;
                case ECons.Color.Red:
                    Row = 9;
                    Pic.Image = GAMECOTUONG.Properties.Resources.redBishop;
                    break;
            }
            base.InitXY();
            Game.bBoard[Row, Col].Trong = false;
            Game.bBoard[Row, Col].Color = Color;
            Game.bBoard[Row, Col].Pos = strPos;
            Game.bBoard[Row, Col].PieceType = ECons.Piece.Bishop;
        }
        #endregion

        #region Methods
        public override void CreateMoves()
        {
            listMove = new List<Move>();
            int[] dir = { -2, 2 };
            foreach (int i in dir)
                foreach (int j in dir)
                {
                    int startRow = 0, endRow = 9;
                    if (this.Color==ECons.Color.Black)
                    {
                        startRow = 0;
                        endRow = 4;
                    }
                    else if (this.Color==ECons.Color.Red)
                    {
                        startRow = 5;
                        endRow = 9;
                    }
                    if (this.Row + i >= startRow && this.Row + i <= endRow && this.Col + j >= 0 && this.Col + j <= 8)
                    {
                        int r = this.Row + i;
                        int c = this.Col + j;
                        if (Game.bBoard[this.Row + i / 2, this.Col + j / 2].Trong == true)
                            if (Game.bBoard[r, c].Trong == true || Game.bBoard[r, c].Color != this.Color)
                                if (BoardControl.CoQuanCheTuong(this, r, c))
                                    listMove.Add(new Move(this.Row, this.Col, r, c));
                    }
                }
        }
        #endregion
    }
}