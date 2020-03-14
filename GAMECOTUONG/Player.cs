using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                new Advisor("3", Color),
                new Advisor("5", Color)
            };
            //Tượng (Elephent)
            PBiShop = new Bishop[2]
            {
                new Bishop("2", Color),
                new Bishop("6", Color)
            };
            //Mã
            PKnight = new Knight[2]
            {
                new Knight("1",Color),
                new Knight("7",Color)
                
            };
            //Xe
            PRook = new Rook[2] 
            {
                new Rook("0",Color),
                new Rook("8",Color)
            };
            //Pháo
            PCannon = new Cannon[2]
            {
                new Cannon("1",Color),
                new Cannon("7",Color)
            };
            //Chốt
            PPawn = new Pawn[5]
            {
                new Pawn("0",Color),
                new Pawn("2",Color),
                new Pawn("4",Color),
                new Pawn("6",Color),
                new Pawn("8",Color),
            };
            #endregion
        }
        #endregion

        #region Methods
        public void CreateAllMove(  List<ECons.Piece> listPieceName, List<Move> listAllMove)
        {
            listPieceName = null;
            listAllMove = null;
            if (PKing.Status == true)
            {
                PKing.CreateMoves();
                listAllMove.AddRange(Piece.listMove);
                int n = Piece.listMove.Count;
                for (int i = 0; i < n; i++)
                    listPieceName.Add(ECons.Piece.King);
            }

            foreach (var p in pAdvisor)
            {
                if (p.Status == true)
                {
                    p.CreateMoves();
                    listAllMove.AddRange(Piece.listMove);
                    int n = Piece.listMove.Count;
                    for (int i = 0; i < n; i++)
                        listPieceName.Add(ECons.Piece.Advisor);
                }
            }

            foreach (var p in PBiShop)
            {
                if (p.Status == true)
                {
                    p.CreateMoves();
                    listAllMove.AddRange(Piece.listMove);
                    int n = Piece.listMove.Count;
                    for (int i = 0; i < n; i++)
                        listPieceName.Add(ECons.Piece.Bishop);
                }
            }

            foreach (var p in pKnight)
            {
                if (p.Status == true)
                {
                    p.CreateMoves();
                    listAllMove.AddRange(Piece.listMove);
                    int n = Piece.listMove.Count;
                    for (int i = 0; i < n; i++)
                        listPieceName.Add(ECons.Piece.Knight);
                }
            }

            foreach (var p in PRook)
            {
                if (p.Status == true)
                {
                    p.CreateMoves();
                    listAllMove.AddRange(Piece.listMove);
                    int n = Piece.listMove.Count;
                    for (int i = 0; i < n; i++)
                        listPieceName.Add(ECons.Piece.Rook);
                }
            }

            foreach (var p in PCannon)
            {
                if (p.Status == true)
                {
                    p.CreateMoves();
                    listAllMove.AddRange(Piece.listMove);
                    int n = Piece.listMove.Count;
                    for (int i = 0; i < n; i++)
                        listPieceName.Add(ECons.Piece.Cannon);
                }
            }

            foreach (var p in PPawn)
            {
                if (p.Status == true)
                {
                    p.CreateMoves();
                    listAllMove.AddRange(Piece.listMove);
                    int n = Piece.listMove.Count;
                    for (int i = 0; i < n; i++)
                        listPieceName.Add(ECons.Piece.Pawn);
                }
            }

            #endregion

        }
    }
}