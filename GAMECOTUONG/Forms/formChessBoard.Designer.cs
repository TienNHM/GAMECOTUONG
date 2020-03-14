namespace GAMECOTUONG
{
    partial class formChessBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChessBoard));
            this.lbMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.BackColor = System.Drawing.Color.Transparent;
            this.lbMenu.Font = new System.Drawing.Font("Wide Latin", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMenu.Location = new System.Drawing.Point(80, 21);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(426, 46);
            this.lbMenu.TabIndex = 6;
            this.lbMenu.Text = "Menu";
            this.lbMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMenu.Click += new System.EventHandler(this.lbMenu_Click);
            // 
            // formChessBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GAMECOTUONG.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(869, 631);
            this.Controls.Add(this.lbMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formChessBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Tướng";
            this.Load += new System.EventHandler(this.ChessBoard_Load);
            this.Move += new System.EventHandler(this.formChessBoard_Move);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbMenu;
    }
}

