namespace C.T_My_Juke_Box_B7029165
{
    partial class JukeBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JukeBoxForm));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.About_txtBox = new System.Windows.Forms.TextBox();
            this.Setup_TxtBox = new System.Windows.Forms.TextBox();
            this.PresentlyPlaying = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Genre_txtBox = new System.Windows.Forms.TextBox();
            this.CopyRightNoticeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(193, 29);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(242, 45);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PlayList.FormattingEnabled = true;
            this.PlayList.ItemHeight = 16;
            this.PlayList.Location = new System.Drawing.Point(177, 380);
            this.PlayList.Name = "PlayList";
            this.PlayList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.PlayList.Size = new System.Drawing.Size(288, 148);
            this.PlayList.TabIndex = 2;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.About_txtBox);
            this.Menu.Controls.Add(this.Setup_TxtBox);
            this.Menu.Location = new System.Drawing.Point(0, 659);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(650, 57);
            this.Menu.TabIndex = 1;
            this.Menu.TabStop = false;
            // 
            // About_txtBox
            // 
            this.About_txtBox.Location = new System.Drawing.Point(97, 9);
            this.About_txtBox.Name = "About_txtBox";
            this.About_txtBox.Size = new System.Drawing.Size(46, 22);
            this.About_txtBox.TabIndex = 1;
            this.About_txtBox.Text = "About";
            // 
            // Setup_TxtBox
            // 
            this.Setup_TxtBox.Location = new System.Drawing.Point(28, 9);
            this.Setup_TxtBox.Name = "Setup_TxtBox";
            this.Setup_TxtBox.Size = new System.Drawing.Size(48, 22);
            this.Setup_TxtBox.TabIndex = 0;
            this.Setup_TxtBox.Text = "Setup";
            // 
            // PresentlyPlaying
            // 
            this.PresentlyPlaying.BackColor = System.Drawing.Color.Lime;
            this.PresentlyPlaying.Location = new System.Drawing.Point(177, 344);
            this.PresentlyPlaying.Multiline = true;
            this.PresentlyPlaying.Name = "PresentlyPlaying";
            this.PresentlyPlaying.ReadOnly = true;
            this.PresentlyPlaying.Size = new System.Drawing.Size(288, 31);
            this.PresentlyPlaying.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(205, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(227, 84);
            this.listBox1.TabIndex = 4;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(193, 313);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(250, 25);
            this.hScrollBar1.TabIndex = 5;
            // 
            // Genre_txtBox
            // 
            this.Genre_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Genre_txtBox.Location = new System.Drawing.Point(207, 192);
            this.Genre_txtBox.Multiline = true;
            this.Genre_txtBox.Name = "Genre_txtBox";
            this.Genre_txtBox.ReadOnly = true;
            this.Genre_txtBox.Size = new System.Drawing.Size(219, 34);
            this.Genre_txtBox.TabIndex = 6;
            // 
            // CopyRightNoticeLabel
            // 
            this.CopyRightNoticeLabel.AutoSize = true;
            this.CopyRightNoticeLabel.BackColor = System.Drawing.Color.Black;
            this.CopyRightNoticeLabel.ForeColor = System.Drawing.Color.White;
            this.CopyRightNoticeLabel.Location = new System.Drawing.Point(427, 9);
            this.CopyRightNoticeLabel.Name = "CopyRightNoticeLabel";
            this.CopyRightNoticeLabel.Size = new System.Drawing.Size(205, 17);
            this.CopyRightNoticeLabel.TabIndex = 7;
            this.CopyRightNoticeLabel.Text = "Copyright 2018 © Chris Turner.";
            // 
            // JukeBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C.T_My_Juke_Box_B7029165.Properties.Resources.JukeBox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 701);
            this.Controls.Add(this.CopyRightNoticeLabel);
            this.Controls.Add(this.Genre_txtBox);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PresentlyPlaying);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.MaximizeBox = false;
            this.Name = "JukeBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Juke Box v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox PlayList;
        private new System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.TextBox About_txtBox;
        private System.Windows.Forms.TextBox Setup_TxtBox;
        private System.Windows.Forms.TextBox PresentlyPlaying;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox Genre_txtBox;
        private System.Windows.Forms.Label CopyRightNoticeLabel;
    }
}

