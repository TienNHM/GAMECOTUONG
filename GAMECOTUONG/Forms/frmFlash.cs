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
    public partial class Flash : Form
    {
        public Flash()
        {
            InitializeComponent();
            Method();
            
        }

        private void Flash_Load(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        public void Method()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 800*Game.level;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            timer1.Start();
            timer1.Interval = 800 * Game.level;
            while (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += progressBar1.Step;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}
