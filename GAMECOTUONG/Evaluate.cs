using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public static class Evaluate
    {
        #region Static Value
        private static int[,] KingPositionValue =
        {
            { 0, 0, 0,15,20,15, 0, 0, 0 },
            { 0, 0, 0,10,10,10, 0, 0, 0 },
            { 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },

            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };
        private static int[,] RookPositionValue =
        {
            { 150,160,150,160,150,160,150,160,150 },
            { 160,170,160,160,150,160,160,170,160 },
            { 170,180,170,170,160,170,170,180,170 },
            { 170,190,200,220,240,220,200,190,170 },
            { 180,220,210,240,250,240,210,220,180 },

            { 180,220,210,240,250,240,210,220,180 },
            { 180,220,210,240,250,240,210,220,180 },
            { 170,190,200,220,240,220,200,190,170 },
            { 170,180,170,190,250,190,170,180,170 },
            { 160,170,160,150,150,150,160,170,160 }
        };
        private static int[,] AdvisorPositionValue =
        {
             { 0, 0, 0,30, 0,30, 0, 0, 0 },
             { 0, 0, 0, 0,22, 0, 0, 0, 0 },
             { 0, 0, 0,30, 0,30, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },

             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        };
        private static int[,] BishopPositionValue =
        {
             { 0, 0,30, 0, 0, 0,30, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             {20, 0, 0, 0,35, 0, 0, 0,20 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0,25, 0, 0, 0,25, 0, 0 },

             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };
        private static int[,] KnightPositionValue =
        {
            { 60, 70, 75, 70, 60, 70, 75, 70, 60 },
            { 70, 75, 75, 70, 50, 70, 75, 75, 70 },
            { 80, 80, 90, 90, 80, 90, 90, 80, 80 },
            { 80, 90,100,100, 90,100,100, 90, 80 },
            { 90,100,100,110,100,110,100,100, 90 },

            { 90,110,110,120,100,120,110,110, 90 },
            { 90,100,120,130,110,130,120,100, 90 },
            { 90,100,120,125,120,125,120,100, 90 },
            { 80,110,125, 90, 70, 90,125,110, 80 },
            { 70, 80, 90, 80, 70, 80, 90, 80, 70 }
        };
        private static int[,] PawnPositionValue =
        {
            { 0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0 },
            { 10,0,10,0,15,0,10,0,10 },
            { 10,0,15,0,15,0,15,0,10 },

            { 15,20,20,20,20,20,20,20,15 },
            { 20,25,25,30,30,30,25,25,20 },
            { 25,30,30,40,40,40,30,30,25 },
            { 25,30,40,50,60,50,40,30,25 },
            { 10,10,10,20,25,20,10,10,10 }
        };
        private static int[,] CannonPositionValue =
        {
            { 80,90,80,70,60,70,80,90,80 },
            { 80,90,80,70,65,70,80,90,80 },
            { 90,100,80,80,70,80,80,100,90 },
            { 90,100,90,90,110,90,90,100,90 },
            { 90,100,90,110,130,110,90,100,90 },

            { 90,110,90,110,130,110,90,110,90 },
            { 90,110,90,110,130,110,90,110,90 },
            { 100,120,90,80,80,80,90,120,100 },
            { 110,125,100,70,60,70,100,125,110 },
            { 125,130,100,70,60,70,100,130,125 }
        };
        #endregion

        #region Methods
        public static int GetPlayerPoint(int side)
        {
            ECons.Color color = ECons.Color.Black;
            ECons.Color opColor = ECons.Color.Red;
            if (side == 0)
            {
                color = ECons.Color.Red;
                opColor = ECons.Color.Black;
            }
            int point = 0, opPoint = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Piece p = Game.bBoard[i, j] as Piece;
                    if (p.Trong == false && p.Color == color)
                    {
                        point += GetEvaluate(p) + Convert.ToInt32(p.PieceType);
                    }
                    else if (p.Trong == false && p.Color == opColor)
                    {
                        opPoint += GetEvaluate(p) + Convert.ToInt32(p.PieceType); 
                    }
                }
            }
            
            return point - opPoint;
        }
        public static int GetPoint(Player player)
        {

            int result = 0;
            foreach (var p in player.PPawn)
            {
                if (p.Status==true)
                {
                    if (p.Color==ECons.Color.Black)
                        result += Convert.ToInt32(p.Point) + PawnPositionValue[p.Row, p.Col];
                    else
                        result += Convert.ToInt32(p.Point) + PawnPositionValue[9 - p.Row, p.Col];
                }
            }
            foreach (var p in player.PCannon)
            {
                if (p.Status==true)
                {
                    if (p.Color==ECons.Color.Black)
                        result += Convert.ToInt32(p.Point) + CannonPositionValue[p.Row, p.Col];
                    else
                        result += Convert.ToInt32(p.Point) + CannonPositionValue[9 - p.Row, p.Col];
                }
            }
            foreach (var p in player.PRook)
            {
                if (p.Status == true)
                {
                    if (p.Color == ECons.Color.Black)
                        result += Convert.ToInt32(p.Point) + RookPositionValue[p.Row, p.Col];
                    else
                        result += Convert.ToInt32(p.Point) + RookPositionValue[9 - p.Row, p.Col];
                }
            }
            foreach (var p in player.PKnight)
            {
                if (p.Status == true)
                {
                    if (p.Color == ECons.Color.Black)
                        result += Convert.ToInt32(p.Point) + KnightPositionValue[p.Row, p.Col];
                    else
                        result += Convert.ToInt32(p.Point) + KnightPositionValue[9 - p.Row, p.Col];
                }
            }
            foreach (var p in player.PBiShop)
            {
                if (p.Status == true)
                {
                    if (p.Color == ECons.Color.Black)
                        result += Convert.ToInt32(p.Point) + BishopPositionValue[p.Row, p.Col];
                    else
                        result += Convert.ToInt32(p.Point) + BishopPositionValue[9 - p.Row, p.Col];
                }
            }
            foreach (var p in player.PAdvisors)
            {
                if (p.Status == true)
                {
                    if (p.Color == ECons.Color.Black)
                        result += Convert.ToInt32(p.Point) + AdvisorPositionValue[p.Row, p.Col];
                    else
                        result += Convert.ToInt32(p.Point) + AdvisorPositionValue[9 - p.Row, p.Col];
                }
            }
            if (player.PKing.Status == true)
            {
                if (player.PKing.Color == ECons.Color.Black)
                    result += Convert.ToInt32(player.PKing.Point) + KingPositionValue[player.PKing.Row, player.PKing.Col];
                else
                    result += Convert.ToInt32(player.PKing.Point) + KingPositionValue[9 - player.PKing.Row, player.PKing.Col];
            }
            return result;
        }
        public static int GetEvaluate(Piece piece)
        {
            
            int[,] arr = new int[10, 9];

            #region Tham Chieu
            if (piece.PieceType == ECons.Piece.King)
                Array.Copy(KingPositionValue, 0, arr, 0, KingPositionValue.Length);
            else if (piece.PieceType == ECons.Piece.Rook)
                Array.Copy(RookPositionValue, 0, arr, 0, RookPositionValue.Length);
            else if (piece.PieceType == ECons.Piece.Advisor)
                Array.Copy(AdvisorPositionValue, 0, arr, 0, AdvisorPositionValue.Length);
            else if (piece.PieceType == ECons.Piece.Bishop)
                Array.Copy(BishopPositionValue, 0, arr, 0, BishopPositionValue.Length);
            else if (piece.PieceType == ECons.Piece.Knight)
                Array.Copy(KnightPositionValue, 0, arr, 0, KnightPositionValue.Length);
            else if (piece.PieceType == ECons.Piece.Pawn)
                Array.Copy(PawnPositionValue, 0, arr, 0, PawnPositionValue.Length);
            else if (piece.PieceType == ECons.Piece.Cannon)
                Array.Copy(CannonPositionValue, 0, arr, 0, CannonPositionValue.Length);
            #endregion

            if (piece.Color == ECons.Color.Black)
                return arr[piece.Row, piece.Col];
            return arr[9 - piece.Row, piece.Col];
        }
        public static int GetValuePiece(Piece piece, int Row, int Col)
        {
            int posValue = GetEvaluate(piece);
            int staticValue = Convert.ToInt32((ECons.Point)piece.PieceType);
            int recievedValue = GetEvaluate(Game.bBoard[Row, Col]);
            if (Game.bBoard[Row, Col].Trong == false)
                return staticValue + posValue + recievedValue;
            return posValue;
        }
        #endregion
    }
}
 