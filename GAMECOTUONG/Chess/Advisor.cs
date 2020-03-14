using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    //Sỹ
    public class Advisor : Piece 
    {
        #region Constructor
        public Advisor(string strPos, ECons.Color Color): base(Color)
       {
            Pos = strPos;
            Col = Convert.ToInt16(strPos);
            switch (Color)
            {
                case ECons.Color.Black:
                    Row = 0;
                    Pic.Image = GAMECOTUONG.Properties.Resources.blackAdvisor;
                    break;
                case ECons.Color.Red:
                    Row = 9;
                    Pic.Image = GAMECOTUONG.Properties.Resources.redAdvisor;
                    break;
            }
            base.InitXY();
            Game.bBoard[Row, Col].Trong = false;
            Game.bBoard[Row, Col].Color = Color;
            Game.bBoard[Row, Col].Pos = strPos;
            Game.bBoard[Row, Col].PieceType = ECons.Piece.Advisor;
        }
        #endregion

        #region Methods
        public override void CreateMoves()
        {
            listMove = new List<Move>();
            Piece p;
            int[] dir = { -1, 1 };
            foreach (int i in dir)
                foreach (int j in dir)
                {
                    int r = this.Row + i;
                    int c = this.Col + j;
                    if (r >= 0 && r <= 9 && c >= 3 && c <= 5)
                    {
                        p = Game.bBoard[r, c];
                        if (p.Trong == true || p.Color != this.Color)
                            if (BoardControl.CoQuanCheTuong(this, r, c))
                                listMove.Add(new Move(this.Row, this.Col, r, c));
                    }
                }
        }
        #endregion
    }
}