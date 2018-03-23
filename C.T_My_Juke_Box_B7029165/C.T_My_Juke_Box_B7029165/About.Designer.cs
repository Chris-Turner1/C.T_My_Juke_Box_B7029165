namespace C.T_My_Juke_Box_B7029165
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.My_Juke_Box_Label = new System.Windows.Forms.Label();
            this.Juke_BoxpictureBox1 = new System.Windows.Forms.PictureBox();
            this.Description_On_Juke_Box = new System.Windows.Forms.Label();
            this.Ok_Button = new System.Windows.Forms.Button();
            this.Description_Of_Juke_Box = new System.Windows.Forms.Label();
            this.Descritption_Of_Juke_Box = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.Juke_BoxpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // My_Juke_Box_Label
            // 
            this.My_Juke_Box_Label.AutoSize = true;
            this.My_Juke_Box_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.My_Juke_Box_Label.Location = new System.Drawing.Point(336, 30);
            this.My_Juke_Box_Label.Name = "My_Juke_Box_Label";
            this.My_Juke_Box_Label.Size = new System.Drawing.Size(252, 32);
            this.My_Juke_Box_Label.TabIndex = 0;
            this.My_Juke_Box_Label.Text = "My Juke Box v2.0";
            this.My_Juke_Box_Label.Click += new System.EventHandler(this.My_Juke_Box_Label_Click);
            // 
            // Juke_BoxpictureBox1
            // 
            this.Juke_BoxpictureBox1.Image = global::C.T_My_Juke_Box_B7029165.Properties.Resources.JukeBox4;
            this.Juke_BoxpictureBox1.Location = new System.Drawing.Point(12, 30);
            this.Juke_BoxpictureBox1.Name = "Juke_BoxpictureBox1";
            this.Juke_BoxpictureBox1.Size = new System.Drawing.Size(303, 402);
            this.Juke_BoxpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Juke_BoxpictureBox1.TabIndex = 1;
            this.Juke_BoxpictureBox1.TabStop = false;
            // 
            // Description_On_Juke_Box
            // 
            this.Description_On_Juke_Box.AutoSize = true;
            this.Description_On_Juke_Box.Location = new System.Drawing.Point(364, 120);
            this.Description_On_Juke_Box.Name = "Description_On_Juke_Box";
            this.Description_On_Juke_Box.Size = new System.Drawing.Size(0, 17);
            this.Description_On_Juke_Box.TabIndex = 2;
            // 
            // Ok_Button
            // 
            this.Ok_Button.Location = new System.Drawing.Point(342, 444);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(136, 39);
            this.Ok_Button.TabIndex = 3;
            this.Ok_Button.Text = "Ok";
            this.Ok_Button.UseVisualStyleBackColor = true;
            this.Ok_Button.Click += new System.EventHandler(this.Ok_Button_Click);
            // 
            // Description_Of_Juke_Box
            // 
            this.Description_Of_Juke_Box.AutoSize = true;
            this.Description_Of_Juke_Box.Location = new System.Drawing.Point(339, 137);
            this.Description_Of_Juke_Box.Name = "Description_Of_Juke_Box";
            this.Description_Of_Juke_Box.Size = new System.Drawing.Size(0, 17);
            this.Description_Of_Juke_Box.TabIndex = 4;
            // 
            // Descritption_Of_Juke_Box
            // 
            this.Descritption_Of_Juke_Box.Location = new System.Drawing.Point(367, 137);
            this.Descritption_Of_Juke_Box.Multiline = true;
            this.Descritption_Of_Juke_Box.Name = "Descritption_Of_Juke_Box";
            this.Descritption_Of_Juke_Box.Size = new System.Drawing.Size(205, 199);
            this.Descritption_Of_Juke_Box.TabIndex = 5;
            this.Descritption_Of_Juke_Box.Text = resources.GetString("Descritption_Of_Juke_Box.Text");
            this.Descritption_Of_Juke_Box.UseWaitCursor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(575, 137);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 199);
            this.vScrollBar1.TabIndex = 6;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 495);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.Descritption_Of_Juke_Box);
            this.Controls.Add(this.Description_Of_Juke_Box);
            this.Controls.Add(this.Ok_Button);
            this.Controls.Add(this.Description_On_Juke_Box);
            this.Controls.Add(this.Juke_BoxpictureBox1);
            this.Controls.Add(this.My_Juke_Box_Label);
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Juke_BoxpictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label My_Juke_Box_Label;
        private System.Windows.Forms.PictureBox Juke_BoxpictureBox1;
        private System.Windows.Forms.Label Description_On_Juke_Box;
        private System.Windows.Forms.Button Ok_Button;
        private System.Windows.Forms.Label Description_Of_Juke_Box;
        private System.Windows.Forms.TextBox Descritption_Of_Juke_Box;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}