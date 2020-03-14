namespace GAMECOTUONG
{
    partial class frmNewGame
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
            this.lbRed = new System.Windows.Forms.Label();
            this.lbBlack = new System.Windows.Forms.Label();
            this.txtbRed = new System.Windows.Forms.TextBox();
            this.txtbBlack = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.lbNewGame = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRed.Location = new System.Drawing.Point(13, 63);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(61, 16);
            this.lbRed.TabIndex = 0;
            this.lbRed.Text = "Quân đỏ";
            // 
            // lbBlack
            // 
            this.lbBlack.AutoSize = true;
            this.lbBlack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlack.Location = new System.Drawing.Point(13, 103);
            this.lbBlack.Name = "lbBlack";
            this.lbBlack.Size = new System.Drawing.Size(69, 16);
            this.lbBlack.TabIndex = 0;
            this.lbBlack.Text = "Quân đen";
            // 
            // txtbRed
            // 
            this.txtbRed.Location = new System.Drawing.Point(111, 59);
            this.txtbRed.Name = "txtbRed";
            this.txtbRed.Size = new System.Drawing.Size(150, 20);
            this.txtbRed.TabIndex = 0;
            // 
            // txtbBlack
            // 
            this.txtbBlack.Location = new System.Drawing.Point(111, 99);
            this.txtbBlack.Name = "txtbBlack";
            this.txtbBlack.Size = new System.Drawing.Size(150, 20);
            this.txtbBlack.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(111, 140);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(51, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbNewGame
            // 
            this.lbNewGame.AutoSize = true;
            this.lbNewGame.Font = new System.Drawing.Font("Tahoma", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewGame.ForeColor = System.Drawing.Color.DarkRed;
            this.lbNewGame.Location = new System.Drawing.Point(32, 13);
            this.lbNewGame.Name = "lbNewGame";
            this.lbNewGame.Size = new System.Drawing.Size(206, 27);
            this.lbNewGame.TabIndex = 3;
            this.lbNewGame.Text = "TẠO VÁN CỜ MỚI";
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btCancel.Location = new System.Drawing.Point(186, 140);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(61, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // formNewGame
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 175);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbNewGame);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.txtbBlack);
            this.Controls.Add(this.txtbRed);
            this.Controls.Add(this.lbBlack);
            this.Controls.Add(this.lbRed);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formNewGame";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo ván cờ mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Label lbBlack;
        private System.Windows.Forms.TextBox txtbRed;
        private System.Windows.Forms.TextBox txtbBlack;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbNewGame;
        private System.Windows.Forms.Button btCancel;
    }
}