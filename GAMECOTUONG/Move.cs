using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMECOTUONG
{
    public class Move
    {
        #region Fields
        private int fromRow;
        private int fromCol;
        private int toRow;
        private int toCol;
        #endregion

        #region Properties
        public int FromRow { get => fromRow; set => fromRow = value; }
        public int FromCol { get => fromCol; set => fromCol = value; }
        public int ToRow { get => toRow; set => toRow = value; }
        public int ToCol { get => toCol; set => toCol = value; }
        #endregion

        #region Constructors
        public Move()
        {

        }
        public Move(int fromRow, int fromCol, int toRow, int toCol)
        {
            this.FromRow = fromRow;
            this.FromCol = fromCol;
            this.ToRow = toRow;
            this.ToCol = toCol;
        }
        #endregion

        #region Methods
        public Move ReverseMove()
        {
            return new Move(ToRow, ToCol, FromRow, FromCol);
        }
        #endregion
    }
}
