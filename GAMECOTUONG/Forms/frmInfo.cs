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
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
            
            string path = Application.StartupPath + "/rules(VN).rtf";
            try
            {
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
                richTextBox1.Show();
            }
            catch
            {
                
            }
            richTextBox1.ReadOnly = true;
        }

        private void frmInfo_SizeChanged(object sender, EventArgs e)
        {
            richTextBox1.Height = this.Height - 20;
            richTextBox1.Width = this.Width - 20;
        }
    }
}
