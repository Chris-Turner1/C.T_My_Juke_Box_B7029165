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
            this.PresentlyPlaying = new System.Windows.Forms.TextBox();
            this.listBox_Below_Genre_txtBox = new System.Windows.Forms.ListBox();
            this.Genre_txtBox = new System.Windows.Forms.TextBox();
            this.CopyRightNoticeLabel = new System.Windows.Forms.Label();
            this.MenuStrip_For_Juke_Box_Form = new System.Windows.Forms.MenuStrip();
            this.setUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hScrollBar1_On_JukeBoxForm = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.MenuStrip_For_Juke_Box_Form.SuspendLayout();
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
            this.axWindowsMediaPlayer1.Visible = false;
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
            // listBox_Below_Genre_txtBox
            // 
            this.listBox_Below_Genre_txtBox.FormattingEnabled = true;
            this.listBox_Below_Genre_txtBox.ItemHeight = 16;
            this.listBox_Below_Genre_txtBox.Location = new System.Drawing.Point(205, 226);
            this.listBox_Below_Genre_txtBox.MultiColumn = true;
            this.listBox_Below_Genre_txtBox.Name = "listBox_Below_Genre_txtBox";
            this.listBox_Below_Genre_txtBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_Below_Genre_txtBox.Size = new System.Drawing.Size(227, 84);
            this.listBox_Below_Genre_txtBox.TabIndex = 4;
            this.listBox_Below_Genre_txtBox.SelectedIndexChanged += new System.EventHandler(this.listBox_Below_Genre_txtBox_SelectedIndexChanged);
            this.listBox_Below_Genre_txtBox.DoubleClick += new System.EventHandler(this.SelectTrack);
            // 
            // Genre_txtBox
            // 
            this.Genre_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Genre_txtBox.Location = new System.Drawing.Point(207, 192);
            this.Genre_txtBox.Multiline = true;
            this.Genre_txtBox.Name = "Genre_txtBox";
            this.Genre_txtBox.ReadOnly = true;
            this.Genre_txtBox.Size = new System.Drawing.Size(225, 34);
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
            // MenuStrip_For_Juke_Box_Form
            // 
            this.MenuStrip_For_Juke_Box_Form.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuStrip_For_Juke_Box_Form.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip_For_Juke_Box_Form.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuStrip_For_Juke_Box_Form.Location = new System.Drawing.Point(0, 673);
            this.MenuStrip_For_Juke_Box_Form.Name = "MenuStrip_For_Juke_Box_Form";
            this.MenuStrip_For_Juke_Box_Form.Size = new System.Drawing.Size(644, 28);
            this.MenuStrip_For_Juke_Box_Form.TabIndex = 8;
            this.MenuStrip_For_Juke_Box_Form.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_For_Juke_Box_Form_ItemClicked);
            // 
            // setUpToolStripMenuItem
            // 
            this.setUpToolStripMenuItem.Name = "setUpToolStripMenuItem";
            this.setUpToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.setUpToolStripMenuItem.Text = "Set up";
            this.setUpToolStripMenuItem.Click += new System.EventHandler(this.setUpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // hScrollBar1_On_JukeBoxForm
            // 
            this.hScrollBar1_On_JukeBoxForm.LargeChange = 1;
            this.hScrollBar1_On_JukeBoxForm.Location = new System.Drawing.Point(205, 310);
            this.hScrollBar1_On_JukeBoxForm.Name = "hScrollBar1_On_JukeBoxForm";
            this.hScrollBar1_On_JukeBoxForm.Size = new System.Drawing.Size(230, 25);
            this.hScrollBar1_On_JukeBoxForm.TabIndex = 5;
            this.hScrollBar1_On_JukeBoxForm.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_On_JukeBoxForm_Scroll);
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
            this.Controls.Add(this.hScrollBar1_On_JukeBoxForm);
            this.Controls.Add(this.listBox_Below_Genre_txtBox);
            this.Controls.Add(this.PresentlyPlaying);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.MenuStrip_For_Juke_Box_Form);
            this.MainMenuStrip = this.MenuStrip_For_Juke_Box_Form;
            this.MaximizeBox = false;
            this.Name = "JukeBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Juke Box v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.MenuStrip_For_Juke_Box_Form.ResumeLayout(false);
            this.MenuStrip_For_Juke_Box_Form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.TextBox PresentlyPlaying;
        private System.Windows.Forms.ListBox listBox_Below_Genre_txtBox;
        private System.Windows.Forms.TextBox Genre_txtBox;
        private System.Windows.Forms.Label CopyRightNoticeLabel;
        private System.Windows.Forms.MenuStrip MenuStrip_For_Juke_Box_Form;
        private System.Windows.Forms.ToolStripMenuItem setUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.HScrollBar hScrollBar1_On_JukeBoxForm;
    }
}

