using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public partial class frmChessBoard : Form
    {
        #region Turning 
        public static Label lb0 = new Label()
        {
            Image = Properties.Resources.Turning,
            Top = 450,
            Left = 20,
            AutoSize = false,
            Visible = false,
            Text = "",
            Width = 32,
            Height = 32,
            BackColor = System.Drawing.Color.Transparent,
        };
        public static Label lb1 = new Label()
        {
            Image = Properties.Resources.Turning,
            Top = 200,
            Left = 20,
            AutoSize = false,
            Visible = false,
            Text = "",
            Width = 32,
            Height = 32,
            BackColor = System.Drawing.Color.Transparent,
        };
        #endregion

        #region Constructor
        public frmChessBoard()
        {
            InitializeComponent();
            #region Music 
            try
            {
                StreamReader OptionReader = File.OpenText("Options.cco");
                if (OptionReader.ReadLine() == "1")
                {
                    frmOption.NhacNen = true;
                    Game.music = 1;
                }
                else
                {
                    frmOption.NhacNen = false;
                    Game.music = 0;
                }
                frmOption.Path_NhacNen = OptionReader.ReadLine();
                OptionReader.Close();
            }
            catch (FileNotFoundException)
            {

            }
            frmOption.PlayNhacNen(frmOption.NhacNen);
            #endregion
        }
        #endregion

        #region Methods
        public void AddChess()
        {
            this.Controls.Add(lb0);
            this.Controls.Add(lb1);
            for (int iRow = 0; iRow < 10; iRow++)
            {
                for (int iCol = 0; iCol < 9; iCol++)
                {
                    Controls.Add(Game.bBoard[iRow, iCol].Pic);
                }
            }
            //Add quân cờ 2 người chơi
            foreach (var player in Game.Players)
            {
                Controls.Add(player.PKing.Pic);
                Controls.Add(player.PAdvisors[0].Pic);
                Controls.Add(player.PAdvisors[1].Pic);
                Controls.Add(player.PBiShop[0].Pic);
                Controls.Add(player.PBiShop[1].Pic);
                Controls.Add(player.PKnight[0].Pic);
                Controls.Add(player.PKnight[1].Pic);
                Controls.Add(player.PRook[0].Pic);
                Controls.Add(player.PRook[1].Pic);
                Controls.Add(player.PCannon[0].Pic);
                Controls.Add(player.PCannon[1].Pic);
                foreach (var pawn in player.PPawn)
                    Controls.Add(pawn.Pic);
            }
            this.Refresh();
        }
        #endregion

        #region Events 
        [DllImport("winmm.dll")]
        public static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        private void menuNew_Click(object sender, EventArgs e)
        {
            frmNewGame newGame = new frmNewGame();
            newGame.ShowDialog();
            menuNew.Enabled = false;
        }
        private void menuOption_Click(object sender, EventArgs e)
        {
            frmOption sound = new frmOption();
            sound.ShowDialog();
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát game ?", "Thông Báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void menuInfo_Click(object sender, EventArgs e)
        {
            frmInfo info = new frmInfo();
            info.Show();
        }
        #endregion
    }
}
