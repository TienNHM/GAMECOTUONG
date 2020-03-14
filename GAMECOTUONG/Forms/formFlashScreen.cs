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
    public partial class formFlashScreen : Form
    {
        public static formChessBoard chessBoard = new formChessBoard();
        public static frmMenu menu = new frmMenu();
        public formFlashScreen()
        {
            InitializeComponent();
        }

        private void formFlashScreen_Load(object sender, EventArgs e)
        {
            Game.InitPlayer();
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            chessBoard.Show();
            this.Hide();
        }
    }
}
