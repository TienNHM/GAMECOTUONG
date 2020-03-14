using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public class Player
    {
        #region Fields
        private string playerName;
        private ECons.Color color;
        private int point;
        private King pKing;
        private Cannon[] pCannon;
        private Bishop[] pBiShop;
        private Advisor[] pAdvisor;
        private Knight[] pKnight;
        private Rook[] pRook;
        private Pawn[] pPawn;
        private List<Piece> availablePiece;
        #endregion

        #region Properties
        public King PKing { get => pKing; set => pKing = value; }
        public Cannon[] PCannon { get => pCannon; set => pCannon = value; }
        public Bishop[] PBiShop { get => pBiShop; set => pBiShop = value; }
        public Advisor[] PAdvisors { get => pAdvisor; set => pAdvisor = value; }
        public Knight[] PKnight { get => pKnight; set => pKnight = value; }
        public Rook[] PRook { get => pRook; set => pRook = value; }
        public Pawn[] PPawn { get => pPawn; set => pPawn = value; }
        public ECons.Color Color { get => color; set => color = value; }
        public int Point { get => point; set => point = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public List<Piece> AvailablePiece { get => availablePiece; set => availablePiece = value; }

        #endregion

        #region Constructors
        public Player(ECons.Color Color)
        {
            this.Color = Color;
            Point = 0;
            
            #region Tạo các quân cờ
            //Tướng
            PKing = new King(Color);
            //Sỹ
            PAdvisors = new Advisor[2]
            {
                new Advisor(3, Color),
                new Advisor(5, Color)
            };
            //Tượng (Elephent)
            PBiShop = new Bishop[2]
            {
                new Bishop(2, Color),
                new Bishop(6, Color)
            };
            //Mã
            PKnight = new Knight[2]
            {
                new Knight(1,Color),
                new Knight(7,Color)
                
            };
            //Xe
            PRook = new Rook[2] 
            {
                new Rook(0,Color),
                new Rook(8,Color)
            };
            //Pháo
            PCannon = new Cannon[2]
            {
                new Cannon(1,Color),
                new Cannon(7,Color)
            };
            //Chốt
            PPawn = new Pawn[5]
            {
                new Pawn(0,Color),
                new Pawn(2,Color),
                new Pawn(4,Color),
                new Pawn(6,Color),
                new Pawn(8,Color),
            };
            #endregion
        }
        #endregion

        #region Methods
        public void CreateAllMove(ref List<Move> listAllMove, int side)
        {

            listAllMove = new List<Move>();
            #region color
            ECons.Color color = ECons.Color.Unknown;
            if (side == 0)
                color = ECons.Color.Red;
            else if (side == 1)
                color = ECons.Color.Black;
            #endregion
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Piece p = Game.bBoard[i, j] as Piece;
                    if (p.Trong == false && p.Color == color)
                    {
                        if (p.PieceType == ECons.Piece.King)
                        {
                            p.CreateMoves();
                            listAllMove.AddRange(King.listMove);
                        }
                        else if (p.PieceType == ECons.Piece.Advisor)
                        {
                            p.CreateMoves();
                            listAllMove.AddRange(Advisor.listMove);
                        }
                        else if (p.PieceType == ECons.Piece.Bishop)
                        {
                            p.CreateMoves();
                            listAllMove.AddRange(Bishop.listMove);
                        }
                        else if (p.PieceType == ECons.Piece.Knight)
                        {
                            p.CreateMoves();
                            listAllMove.AddRange(Knight.listMove);
                        }
                        else if (p.PieceType == ECons.Piece.Rook)
                        {
                            p.CreateMoves();
                            listAllMove.AddRange(Rook.listMove);
                        }
                        else if (p.PieceType == ECons.Piece.Cannon)
                        {
                            p.CreateMoves();
                            listAllMove.AddRange(Cannon.listMove);
                        }
                        else if (p.PieceType == ECons.Piece.Pawn)
                        {
                            p.CreateMoves();
                            listAllMove.AddRange(Pawn.listMove);
                        }
                    }
                }
            }
        }
        public void CreateMoves(ref List<Move> listMoves, int side)
        {
            listMoves = new List<Move>();
            if (Game.Players[side].PKing.Status == true)
            {
                Game.Players[side].PKing.CreateMoves();
                listMoves.AddRange(King.listMove);
            }
            for (int i = 0; i < 2; i++)
            {
                if (Game.Players[side].PAdvisors[i].Status == true)
                {
                    Game.Players[side].PAdvisors[0].CreateMoves();
                    listMoves.AddRange(Advisor.listMove);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                if (Game.Players[side].PBiShop[i].Status)
                {
                    Game.Players[side].PBiShop[i].CreateMoves();
                    listMoves.AddRange(Bishop.listMove);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                if (Game.Players[side].PCannon[i].Status == true)
                {
                    Game.Players[side].PCannon[i].CreateMoves();
                    listMoves.AddRange(Cannon.listMove);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                if (Game.Players[side].PRook[i].Status == true)
                {
                    Game.Players[side].PRook[i].CreateMoves();
                    listMoves.AddRange(Rook.listMove);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                if (Game.Players[side].PKnight[i].Status == true)
                {
                    Game.Players[side].PKnight[i].CreateMoves();
                    listMoves.AddRange(Knight.listMove);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (Game.Players[side].PPawn[i].Status == true)
                {
                    Game.Players[side].PPawn[i].CreateMoves();
                    listMoves.AddRange(Pawn.listMove);
                }
            }
        }
        public static Piece GetPiece(Piece piece)
        {
            Piece p = null;
            int row = piece.Row;
            int col = piece.Col;
            int phe = 0;
            if (piece.Color == ECons.Color.Black) phe = 1;
            Player player = Game.Players[phe];
            if (player.PKing.Row == row && player.PKing.Col == col)
                return player.PKing;
            for (int i = 0; i < 2; i++)
                if (player.PAdvisors[i].Status == true && player.PAdvisors[i].Row == row && player.PAdvisors[i].Col == col)
                    return player.PAdvisors[i];
            for (int i = 0; i < 2; i++)
                if (player.PBiShop[i].Status == true && player.PBiShop[i].Row == row && player.PBiShop[i].Col == col)
                    return player.PBiShop[i];
            for (int i = 0; i < 2; i++)
                if (player.PCannon[i].Status == true && player.PCannon[i].Row == row && player.PCannon[i].Col == col)
                    return player.PCannon[i];
            for (int i = 0; i < 2; i++)
                if (player.PKnight[i].Status == true && player.PKnight[i].Row == row && player.PKnight[i].Col == col)
                    return player.PKnight[i];
            for (int i = 0; i < 2; i++)
                if (player.PAdvisors[i].Status == true && player.PAdvisors[i].Row == row && player.PAdvisors[i].Col == col)
                    return player.PAdvisors[i];
            for (int i = 0; i < 2; i++)
                if (player.PRook[i].Status == true && player.PRook[i].Row == row && player.PRook[i].Col == col)
                    return player.PRook[i];
            for (int i = 0; i < 5; i++)
                if (player.PPawn[i].Status == true && player.PPawn[i].Row == row && player.PPawn[i].Col == col)
                    return player.PPawn[i];
            return p;
        }
        #endregion
    }
}