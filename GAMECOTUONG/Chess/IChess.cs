using System;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public interface IChess
    {
        #region Properties
        ECons.Piece PieceType { get; set; }
        ECons.Color Color { get; set; }
        int Row { get; set; }
        int Col { get; set; }
        bool Trong { get; set; }
        Label Pic { get; set; }
        #endregion

        #region Methods
        void CreateMoves();
        #endregion

        #region Event
        void Pic_MouseClick(Object sender, MouseEventArgs e);
        #endregion
    }
}