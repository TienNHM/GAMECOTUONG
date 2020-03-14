namespace GAMECOTUONG
{
    partial class frmOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BgMusic = new System.Windows.Forms.CheckBox();
            this.path = new System.Windows.Forms.MaskedTextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckbSpeech = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BgMusic
            // 
            this.BgMusic.AutoSize = true;
            this.BgMusic.BackColor = System.Drawing.Color.Transparent;
            this.BgMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BgMusic.ForeColor = System.Drawing.Color.DarkRed;
            this.BgMusic.Location = new System.Drawing.Point(26, 100);
            this.BgMusic.Margin = new System.Windows.Forms.Padding(2);
            this.BgMusic.Name = "BgMusic";
            this.BgMusic.Size = new System.Drawing.Size(89, 19);
            this.BgMusic.TabIndex = 0;
            this.BgMusic.Text = "Nhạc Nền";
            this.BgMusic.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BgMusic.UseVisualStyleBackColor = false;
            this.BgMusic.CheckedChanged += new System.EventHandler(this.BgMusic_CheckedChanged);
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.Color.White;
            this.path.Location = new System.Drawing.Point(26, 65);
            this.path.Margin = new System.Windows.Forms.Padding(2);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(192, 20);
            this.path.TabIndex = 1;
            this.path.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.path_MaskInputRejected);
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.Color.Maroon;
            this.Browse.Location = new System.Drawing.Point(248, 65);
            this.Browse.Margin = new System.Windows.Forms.Padding(2);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(68, 25);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.Maroon;
            this.OK.Location = new System.Drawing.Point(57, 160);
            this.OK.Margin = new System.Windows.Forms.Padding(2);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(49, 22);
            this.OK.TabIndex = 3;
            this.OK.Text = "Lưu";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(150, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đóng ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "BACKGROUND MUSIC";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ckbSpeech
            // 
            this.ckbSpeech.AutoSize = true;
            this.ckbSpeech.BackColor = System.Drawing.Color.Transparent;
            this.ckbSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSpeech.ForeColor = System.Drawing.Color.DarkRed;
            this.ckbSpeech.Location = new System.Drawing.Point(26, 123);
            this.ckbSpeech.Margin = new System.Windows.Forms.Padding(2);
            this.ckbSpeech.Name = "ckbSpeech";
            this.ckbSpeech.Size = new System.Drawing.Size(130, 19);
            this.ckbSpeech.TabIndex = 0;
            this.ckbSpeech.Text = "Đọc tên quân cờ";
            this.ckbSpeech.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ckbSpeech.UseVisualStyleBackColor = false;
            this.ckbSpeech.CheckedChanged += new System.EventHandler(this.ckbSpeech_CheckedChanged);
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GAMECOTUONG.Properties.Resources.backgroundOptions;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(327, 202);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.path);
            this.Controls.Add(this.ckbSpeech);
            this.Controls.Add(this.BgMusic);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOption";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sound_Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox BgMusic;
        private System.Windows.Forms.MaskedTextBox path;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ckbSpeech;
    }
}