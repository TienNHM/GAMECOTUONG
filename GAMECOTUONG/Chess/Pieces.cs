using System;
using System.Collections.Generic;
using System.Media;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    //Thực thi giao diện IChess
    public class Piece : IChess, ICloneable
    {
        #region Fields
        private ECons.Piece pieceType;
        private ECons.Color color;
        private int pos;
        private int row;
        private int col;
        private bool status;
        private bool trong;
        private ToolTip toolTip;
        private static SoundPlayer sound = new SoundPlayer(GAMECOTUONG.Properties.Resources.Mark);
        public static List<Move> listMove = new List<Move>();
        private Label pic = new Label()
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
        public int Pos { get => pos; set => pos = value; }
        public Label Pic { get => pic; set => pic = value; }
        public bool Trong { get => trong; set => trong = value; }
        public ECons.Point Point { get => Point; }
        public ECons.Piece PieceType { get => pieceType; set => pieceType = value; }
        public ToolTip ToolTip { get => toolTip; set => toolTip = value; }
        #endregion

        #region Constructors
        //Tạo ra 1 quân cờ 
        public Piece(ECons.Color Color)
        {
            Trong = false;
            Status = true;
            this.Color = Color;
            PieceType = ECons.Piece.Unknown;
            Pic.BackgroundImage = GAMECOTUONG.Properties.Resources.CanMove;
            Pic.BackgroundImageLayout = ImageLayout.Center;
            Pic.BackColor = System.Drawing.Color.Transparent;
            Pic.MouseClick += new MouseEventHandler(Pic_MouseClick);
            InitXY();
        }
        //Tạo ra 1 Piece (nước đi gợi ý)
        public Piece(int iRow, int iCol)
        {
            Row = iRow;
            Col = iCol;
            Trong = true;
            Status = false;
            PieceType = ECons.Piece.Unknown;
            Color = ECons.Color.Unknown;
            Pos = 0;
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
        public virtual void CreateMoves() { }
        private bool NuocDiHopLe()
        {
            int n = listMove.Count;
            for (int i = 0; i < n; i++)
                if (this.Row == listMove[i].ToRow && this.Col == listMove[i].ToCol)
                    return true;
            return false;
        }
        public object Clone()
        {
            Piece p = new Piece(this.Color);
            p.PieceType = this.PieceType;
            p.Pic.BackgroundImage = this.Pic.BackgroundImage;
            p.Row = this.Row;
            p.Col = this.Col;
            return p;
        }

        private void AI_Move()
        {
            Move AIMove = AI.DoSearch();
            if (AIMove.Piece != null)
            {
                Game.SelectedPiece = Player.GetPiece(AIMove.Piece);
                BoardControl.PickDown(Game.SelectedPiece, AIMove.ToRow, AIMove.ToCol);
                MessageBox.Show(AIMove.Piece.PieceType + "" + AIMove.ToRow + " " + AIMove.ToCol);
            }
            else
                MessageBox.Show("AIMove is null");
        }
        #endregion

        #region Events
        //Xử lý sự kiện click chuột lên quân cờ 
        public void Pic_MouseClick(Object sender, MouseEventArgs e)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            //Đã có quân cờ được chọn 
            if (Game.Marked == true)
            {
                //Đi quân hoặc ăn quân đối phương 
                if (this.Trong == true || (Game.phe == 1 && this.Color == ECons.Color.Red) || (Game.phe == 0 && this.Color == ECons.Color.Black))
                {
                    if (NuocDiHopLe() == true)
                    {
                        if (Game.music == 1)
                        {
                            if (this.PieceType != ECons.Piece.Unknown)
                                speech.SpeakAsync(this.Color + " " + this.pieceType + " is eaten!");
                            else
                                speech.SpeakAsync(Game.SelectedPiece.Color + " " + Game.SelectedPiece.pieceType + " is moved!");
                            sound.Play();
                        }
                        BoardControl.AnQuanCo(this);
                        BoardControl.HideNuocDi(listMove);
                        Game.Marked = false;
                        BoardControl.PickDown(Game.SelectedPiece, Row, Col);
                        //Đổi phe
                        Game.phe = 1 - Game.phe;
                        if (Game.ChieuTuong(Game.phe) == true)
                        {
                            if (Game.music == 1)
                                speech.SpeakAsync("Chessmate!");
                            MessageBox.Show("Chiếu!!");
                        }
                    }
                    else
                    {
                        if (Game.music == 1)
                            speech.SpeakAsync("Invalid move!");
                    }
                }
                else
                {
                    //Nước đi không hợp lệ 
                    if (Game.music == 1) speech.SpeakAsync("Invalid move!");
                }
            }
            //Chưa có quân cờ nào được chọn 
            else
            {
                if (this.Status == true)
                {
                    if ((Game.phe == 0 && this.Color == ECons.Color.Red) || (Game.phe == 1 && this.Color == ECons.Color.Black))
                    {
                        //Đang bị chiếu tướng 
                        if (Game.ChieuTuong(Game.phe) == true)
                        {
                            List<ECons.Piece> list = new List<ECons.Piece>();
                            list = Game.CuuCo(Game.phe);
                            if (list != null)
                            {
                                if (this.PieceType == ECons.Piece.King || list.Contains(this.PieceType))
                                {
                                    if (Game.music == 1)
                                        speech.SpeakAsync(this.Color + " " + this.pieceType + " is selected!");
                                    MessageBox.Show("Bị Chiếu Tướng!");
                                    CreateMoves();
                                    if (listMove.Count > 0)
                                    {
                                        Game.Marked = true;
                                        Game.SelectedPiece = this as Piece; // pass as reference 
                                        this.Pic.BackColor = System.Drawing.Color.DarkCyan;
                                        BoardControl.ShowNuocDi(listMove);
                                    }
                                }
                            }
                            else
                            {
                                if (Game.music == 1)
                                    speech.SpeakAsync("Chessmate!");
                                MessageBox.Show("Chiếu!!!");
                            }
                        }
                        else                                 //Không bị chiếu tướng
                        {
                            if (Game.music == 1)
                                speech.SpeakAsync(this.Color + " " + this.pieceType + " is selected!");
                            CreateMoves();                   //Gợi ý các nước đi 
                            if (listMove.Count > 0)
                            {
                                Game.Marked = true;
                                Game.SelectedPiece = new Piece(ECons.Color.Unknown);
                                Game.SelectedPiece = this as Piece;
                                this.Pic.BackColor = System.Drawing.Color.DarkCyan;
                                BoardControl.ShowNuocDi(listMove);
                            }
                            else
                            {
                                if (Game.music == 1)
                                    speech.SpeakAsync("No more moves available!");
                                //Đổi phe 
                                Game.phe = 1 - Game.phe;
                            }
                        }
                    }
                    else
                    {
                        if (Game.music == 1)
                            speech.SpeakAsync("Invalid move!");
                    }
                }
            }
            #region Turning
            if (Game.phe == 0 && Game.Marked == false)
            {
                frmChessBoard.lb0.Visible = true;
                frmChessBoard.lb1.Visible = false;
            }
            else if (Game.phe == 1 && Game.Marked == false)
            {
                frmChessBoard.lb0.Visible = false;
                frmChessBoard.lb1.Visible = true;
            }
            #endregion
        }
        #endregion
    }
}