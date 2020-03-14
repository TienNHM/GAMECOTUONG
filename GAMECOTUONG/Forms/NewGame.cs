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
    public partial class formNewGame : Form
    {
        public formNewGame()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtbRed.Text != "" && txtbBlack.Text != "" && txtbRed.Text!= txtbBlack.Text)
            {
                Game.InitPlayer(txtbRed.Text, txtbBlack.Text);
                formFlashScreen.chessBoard.AddChess();
                this.Close();
                formFlashScreen.menu.Close();
            }
            else
                MessageBox.Show("Xin nhập tên người chơi!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void formNewGame_Load(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
