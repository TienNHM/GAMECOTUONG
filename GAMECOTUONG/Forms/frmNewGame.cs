using System;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public partial class frmNewGame : Form
    {
        #region Constructor
        public frmNewGame()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtbRed.Text != "" && txtbBlack.Text != "" && txtbRed.Text != txtbBlack.Text)
            {
                Game.InitPlayer(txtbRed.Text, txtbBlack.Text);
                frmFlashScreen.chessBoard.AddChess();
                frmChessBoard.lb0.Visible = true;
                this.Close();
            }
            else
            {
                if (txtbRed.Text == "" || txtbBlack.Text == "")
                    MessageBox.Show("Tên không được bỏ trống!");
                else if (txtbRed.Text == txtbBlack.Text)
                    MessageBox.Show("Tên phải khác nhau!");
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
