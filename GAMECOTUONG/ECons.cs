namespace GAMECOTUONG
{
    public static class ECons
    {
        public static int ChessSize = 42;
        public enum Color
        {
            Red,
            Black,
            Unknown
        }
        public enum Pos
        {
            Left = 61,
            Top = 80
        }
        public enum Piece
        {
            King,
            Advisor,
            Bishop,
            Knight,
            Rook,
            Cannon,
            Pawn,
            Unknown
        }
        public enum Point
        {
            King = 6000,
            Advisor = 120,
            Bishop = 120,
            Knight = 270,
            Rook = 600,
            Cannon = 285,
            Pawn = 30
        }
    }
}