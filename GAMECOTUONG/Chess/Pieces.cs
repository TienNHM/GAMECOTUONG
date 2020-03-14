using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading ;
using System.Windows.Forms;
using System.Drawing;

namespace GAMECOTUONG
{
    public class Piece : IChess
    {
        #region Fields
        private ECons.Piece pieceType;
        private ECons.Color color;
        private string pos;
        private int row;
        private int col;
        private bool status;
        private bool trong;
        private ECons.Point point;
        private int[,] posValue;
        private static SoundPlayer sound = new SoundPlayer(GAMECOTUONG.Properties.Resources.Mark);
        public static List<Move> listMove = new List<Move> ();
        private PictureBoxCustomize pic = new PictureBoxCustomize()
        {
            Width = 42,
            Height = 42,
            BackColor = System.Drawing.Color.Transparent,
            Cursor = Cursors.Hand,

        };
        #endregion

        #region Properties
        public ECons.Color Color { get => color; set => color = value; }
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public bool Status { get => status; set => status = value; }
        public string Pos { get => pos; set => pos = value; }
        public PictureBoxCustomize Pic { get => pic; set => pic = value; }
        public bool Trong { get => trong; set => trong = value; }
        public ECons.Point Point { get => point; }
        public int[,] PosValue { get => posValue; }
        public ECons.Piece PieceType { get => pieceType; set => pieceType = value; }

        #endregion

        #region Constructors
        public Piece(ECons.Color Color)
        {
            Trong = false;
            Status = true;
            this.Color = Color;
            Status = true;
            PieceType = ECons.Piece.Unknown;
            Pic.BackgroundImage = GAMECOTUONG.Properties.Resources.CanMove;
            Pic.BackgroundImageLayout = ImageLayout.Center;
            Pic.BackColor = System.Drawing.Color.Transparent;
            Pic.MouseClick += new MouseEventHandler(Pic_MouseClick);
            InitXY();
        }
        public Piece(int iRow, int iCol)
        {
            Row = iRow;
            Col = iCol;
            Trong = true;
            PieceType = ECons.Piece.Unknown;
            Color = ECons.Color.Unknown;
            Pos = null;
            Pic.BackgroundImage = GAMECOTUONG.Properties.Resources.CanMove;
            Pic.BackgroundImageLayout = ImageLayout.Center;
            Pic.BackColor = System.Drawing.Color.Transparent;
            Pic.Visible = false;
            Pic.MouseClick += new MouseEventHandler(Pic_MouseClick);
            InitXY();
        }
        #endregion

        #region Methods
        public void InitXY()
        {
            Pic.Top = 53 * this.Row + Convert.ToInt32(ECons.Pos.Top);
            Pic.Left = 53 * this.Col + Convert.ToInt32(ECons.Pos.Left);
            Pic.Width = ECons.ChessSize;
            Pic.Height = ECons.ChessSize;
            Pic.Cursor = Cursors.Hand;
        }

        #region virtual
        public virtual bool kiemTra(int iRow, int iCol)
        {
            return false;
        }

        public virtual bool TuongAnToan(int iRow, int iCol)
        {
            return false;
        }
        public  virtual void CreateMoves()
        {
            
        }
        
        #endregion

        private bool NuocDiHopLe()
        {
            int n = listMove.Count;
            for (int i = 0; i < n; i++)
                if (this.Row == listMove[i].ToRow && this.Col == listMove[i].ToCol)
                    return true;
            return false;
        }
        
        #endregion

        #region Events
        public void Pic_MouseClick(Object sender, MouseEventArgs e)
        {
            if (Game.Marked == true)
            {
                if (this.Trong == true || this.Color == ECons.Color.Black)
                    if (NuocDiHopLe() == true)
                    {
                        sound.Play();
                        BoardControl.AnQuanCo(this);
                        BoardControl.HideNuocDi(listMove);
                        Game.Marked = false;
                        this.Status = false;
                        //Game.NguoiDi = false;
                        BoardControl.PickDown(Game.SelectedPiece, Row, Col);           
                    }
            }
            else
            {
                if (this.Status == true && Game.NguoiDi==true && this.Color==ECons.Color.Red)
                {
                    Game.Marked = true;
                    Game.SelectedPiece = this as Piece;
                    CreateMoves();
                    if (listMove.Count > 0)
                        BoardControl.ShowNuocDi(listMove);
                    else
                    {
                        //Game.NguoiDi = false;
                        Game.Marked = false;
                    }
                }
            }
        }
        #endregion
    }
}