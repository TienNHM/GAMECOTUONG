using System.Collections.Generic;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    //Sỹ
    public class Advisor : Piece
    {
        #region Constructor
        public Advisor(int Pos, ECons.Color Color) : base(Color)
        {
            this.Pos = Pos / 5;
            Col = Pos;
            PieceType = ECons.Piece.Advisor;
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
            //Game.bBoard[Row, Col] = this;
            Game.bBoard[Row, Col].Trong = false;
            Game.bBoard[Row, Col].Color = Color;
            Game.bBoard[Row, Col].Pos = Pos;
            Game.bBoard[Row, Col].PieceType = ECons.Piece.Advisor;
            ToolTip = new ToolTip();
            ToolTip.SetToolTip(Pic, Color + " " + PieceType);
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
                            {
                                int value = Evaluate.GetValuePiece(this, r, c);
                                listMove.Add(new Move(this, this.Row, this.Col, r, c, value));
                            }
                    }
                }
        }
        #endregion
    }
}