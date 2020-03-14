namespace GAMECOTUONG
{
    partial class frmChessBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChessBoard));
            this.menuNew = new System.Windows.Forms.Label();
            this.menuOption = new System.Windows.Forms.Label();
            this.menuExit = new System.Windows.Forms.Label();
            this.menuInfo = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // menuNew
            // 
            this.menuNew.BackColor = System.Drawing.Color.Transparent;
            this.menuNew.Image = global::GAMECOTUONG.Properties.Resources.play;
            this.menuNew.Location = new System.Drawing.Point(138, 24);
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(35, 35);
            this.menuNew.TabIndex = 8;
            this.toolTip.SetToolTip(this.menuNew, "Play");
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOption
            // 
            this.menuOption.BackColor = System.Drawing.Color.Transparent;
            this.menuOption.Image = global::GAMECOTUONG.Properties.Resources.Option;
            this.menuOption.Location = new System.Drawing.Point(238, 24);
            this.menuOption.Name = "menuOption";
            this.menuOption.Size = new System.Drawing.Size(35, 35);
            this.menuOption.TabIndex = 8;
            this.toolTip.SetToolTip(this.menuOption, "Options");
            this.menuOption.Click += new System.EventHandler(this.menuOption_Click);
            // 
            // menuExit
            // 
            this.menuExit.BackColor = System.Drawing.Color.Transparent;
            this.menuExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuExit.Image = global::GAMECOTUONG.Properties.Resources.Exit;
            this.menuExit.Location = new System.Drawing.Point(438, 24);
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(35, 35);
            this.menuExit.TabIndex = 8;
            this.toolTip.SetToolTip(this.menuExit, "Exit");
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.BackColor = System.Drawing.Color.Transparent;
            this.menuInfo.Image = global::GAMECOTUONG.Properties.Resources.help;
            this.menuInfo.Location = new System.Drawing.Point(341, 24);
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(35, 35);
            this.menuInfo.TabIndex = 8;
            this.toolTip.SetToolTip(this.menuInfo, "Info");
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // frmChessBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GAMECOTUONG.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(595, 630);
            this.Controls.Add(this.menuInfo);
            this.Controls.Add(this.menuExit);
            this.Controls.Add(this.menuOption);
            this.Controls.Add(this.menuNew);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChessBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Tướng";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label menuNew;
        private System.Windows.Forms.Label menuOption;
        private System.Windows.Forms.Label menuExit;
        private System.Windows.Forms.Label menuInfo;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

