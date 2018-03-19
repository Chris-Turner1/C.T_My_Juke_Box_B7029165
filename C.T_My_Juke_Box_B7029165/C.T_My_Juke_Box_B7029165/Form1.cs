using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.T_My_Juke_Box_B7029165
{
    public partial class JukeBoxForm : Form
    {
        public JukeBoxForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void MenuStrip_For_Juke_Box_Form_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void setUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupFrom setup = new SetupFrom();
            setup.ShowDialog();
        }
    }
}
