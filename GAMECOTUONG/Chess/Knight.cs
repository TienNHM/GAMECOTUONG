using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAMECOTUONG
{
    public class Knight : Piece
    {
        #region Constructor
        public Knight(string strPos, ECons.Color Color) : base(Color)
        {
            Pos = strPos;
            Col = Convert.ToInt16(strPos);
            switch (Color)
            {
                case ECons.Color.Black:
                    Row = 0;
                    Pic.Image = GAMECOTUONG.Properties.Resources.blackKnight;
                    break;
                case ECons.Color.Red:
                    Row = 9;
                    Pic.Image = GAMECOTUONG.Properties.Resources.redKnight;
                    break;
            }
            base.InitXY();
            Game.bBoard[Row, Col].Trong = false;
            Game.bBoard[Row, Col].Color = Color;
            Game.bBoard[Row, Col].Pos = strPos;
            Game.bBoard[Row, Col].PieceType = ECons.Piece.Knight;
        }
        #endregion

        #region Methods
        public override void CreateMoves()
        {
            listMove = new List<Move>();
            int[] X = { -1, -2, -2, -1, 1, 2, 2, 1 };
            int[] Y = { -2, -1, 1, 2, 2, 1, -1, -2 };
            for (int i = 0; i < 8; i++)
            {
                int r = this.Row + X[i];
                int c = this.Col + Y[i];
                if (r >= 0 && c >= 0 && r < 10 && c < 9)
                    if (BoardControl.CoQuanCheTuong(this, r, c))
                        if (Game.bBoard[this.Row + X[i] / 2, this.Col + Y[i] / 2].Trong == true)
                            if (Game.bBoard[r, c].Status == false)
                                listMove.Add(new Move(this.Row, this.Col, r, c));
            }
                
        }
        #endregion
    }
}