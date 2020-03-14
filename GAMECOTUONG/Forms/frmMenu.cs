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
    public partial class frmMenu : Form
    {
        private static formNewGame newGame = new formNewGame();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            newGame.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btExit_MouseHover(object sender, EventArgs e)
        {

        }

        private void btNew_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btOpen_MouseHover(object sender, EventArgs e)
        {

        }

        private void btSave_MouseHover(object sender, EventArgs e)
        {

        }

        private void btOption_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
