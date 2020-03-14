using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMECOTUONG 
{
    public partial class PictureBoxCustomize : PictureBox
    {
        public PictureBoxCustomize() : base()
        {
            this.DoubleBuffered = true;
        }
    }
}
