using System;
using System.IO;
using System.Windows.Forms;

namespace GAMECOTUONG
{
    public partial class frmOption : Form
    {
        #region Fields
        public static bool NhacNen = true;
        public static string Path_NhacNen = @Application.StartupPath + "\\a.mp3";
        #endregion

        #region Constructors
        public frmOption()
        {
            InitializeComponent();
            if (NhacNen) BgMusic.Checked = true;
            if (BgMusic.Checked == false)
            {
                path.Enabled = false;
                Browse.Enabled = false;
            }
            path.Text = Path_NhacNen;
        }
        #endregion

        #region Methods
        public static void PlayNhacNen(bool NhacNen)
        {
            if (NhacNen)
            {
                string strCommand = "open \"" + Path_NhacNen + "\" type mpegvideo alias MediaFile";
                frmChessBoard.mciSendString(strCommand, null, 0, IntPtr.Zero);
                frmChessBoard.mciSendString("play MediaFile REPEAT", null, 0, IntPtr.Zero);
            }
            else
                frmChessBoard.mciSendString("close MediaFile", null, 0, IntPtr.Zero);
        }
        #endregion

        #region Events
        private void BgMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (BgMusic.Checked == true)
            {
                NhacNen = true;
                path.Enabled = false;
                Browse.Enabled = true;
            }
            else
            {
                NhacNen = false;
                path.Enabled = false;
                Browse.Enabled = false;
            }
        }
        private void path_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void Browse_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.FileName = "openFileDialog1";
            op.Filter = "MP3 Files(*.mp3)| *.mp3";//Tìm đường dẫn có đuôi là .mp3
            if (op.ShowDialog() == DialogResult.OK)
            {
                path.Text = op.FileName;//Đưa đường dẫn vào text
            }
            if (op.FileName != "openFileDialog1") path.Text = op.FileName;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream saveOptions = File.Create("Options.cco");
                StreamWriter fileWriter = new StreamWriter(saveOptions);
                Path_NhacNen = path.Text;

                Path_NhacNen = path.Text;
                if (NhacNen == true)
                {
                    //Dừng phát nhạc 
                    frmChessBoard.mciSendString("close MediaFile", null, 0, IntPtr.Zero);
                    //Phát Nhạc
                    frmChessBoard.mciSendString("open \"" + Path_NhacNen + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                    frmChessBoard.mciSendString("play MediaFile REPEAT", null, 0, IntPtr.Zero);
                }
                else
                {
                    frmChessBoard.mciSendString("close MediaFile", null, 0, IntPtr.Zero);
                }

                if (NhacNen) fileWriter.WriteLine("1");
                else fileWriter.WriteLine("0");

                //Lưu nhạc vào Text để khi mở Form_Game Thì sẽ đọc dữ liệu
                fileWriter.WriteLine(Path_NhacNen);
                fileWriter.Close();
                saveOptions.Close();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("không tim thấy file what the hell");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ckbSpeech_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSpeech.Checked) Game.music = 1;
            else Game.music = 0;
        }
        #endregion
    }
}
