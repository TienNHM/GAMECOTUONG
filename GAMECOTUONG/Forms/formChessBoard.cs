using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public partial class formChessBoard : Form
     {
        public formChessBoard()
        {
            InitializeComponent();
            
        }

        private void ChessBoard_Load(object sender, EventArgs e)
        {
            
        }
        public void AddChess()
        {
            for (int iRow = 0; iRow < 10; iRow++)
            {
                for (int iCol = 0; iCol < 9; iCol++)
                {
                    this.Controls.Add(Game.bBoard[iRow, iCol].Pic);
                    //if (Game.bBoard[iRow, iCol].Color == ECons.Color.Black)
                    //    Game.bBoard[iRow, iCol].Pic.Visible = true;
                }
            }
            //Add quân cờ 2 người chơi
            foreach (var player in Game.Players)
            {
                this.Controls.Add(player.PKing.Pic);
                this.Controls.Add(player.PAdvisors[0].Pic);
                this.Controls.Add(player.PAdvisors[1].Pic);
                this.Controls.Add(player.PBiShop[0].Pic);
                this.Controls.Add(player.PBiShop[1].Pic);
                this.Controls.Add(player.PKnight[0].Pic);
                this.Controls.Add(player.PKnight[1].Pic);
                this.Controls.Add(player.PRook[0].Pic);
                this.Controls.Add(player.PRook[1].Pic);
                this.Controls.Add(player.PCannon[0].Pic);
                this.Controls.Add(player.PCannon[1].Pic);
                foreach (var pawn in player.PPawn)
                    this.Controls.Add(pawn.Pic);
            }
        }
        #region Menu
        private void lbMenu_Click(object sender, EventArgs e)
        {
            formFlashScreen.menu.ShowDialog();
        }
        #endregion

        private void formChessBoard_Move(object sender, EventArgs e)
        {

        }
    }
}
