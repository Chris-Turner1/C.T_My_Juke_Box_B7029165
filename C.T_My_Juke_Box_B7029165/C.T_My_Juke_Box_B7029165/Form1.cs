using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // used for dealing with adding files from media txt file 
using MyDialogs; 
using System.Windows.Forms;

namespace C.T_My_Juke_Box_B7029165
{
    struct GenreContents
    {
        public string name;
        public List<string> tracks;
    }

    public partial class JukeBoxForm : Form
    {
        List<GenreContents> genres;



        public JukeBoxForm()
        {
            InitializeComponent();          

            ReadMediaFile();

            PopulateTextBoxes();
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

        private void ReadMediaFile()
        {
            genres = new List<GenreContents>();

            IEnumerable<string> lines = System.IO.File.ReadLines(Directory.GetCurrentDirectory() + "\\Music\\" + "Media.txt");

            int iLineCounter = 0; // zero is the number of titles 

            int numberOfGenres = Convert.ToInt32(lines.ToArray()[0]);
            for(int i = 0; i < numberOfGenres; i++)
            {
                genres.Add(new GenreContents());
            }


            iLineCounter = 1; // 1 is the number of tracks 
            for (int genreNumber = 0; genreNumber < numberOfGenres; genreNumber++) 
                // genre number is less than number of genres, genre number increment to allow to add more  
            {
                int numberOfTracks = Convert.ToInt32(lines.ToArray()[iLineCounter]);

                iLineCounter++;

                GenreContents genreContents;
                genreContents.name = lines.ToArray()[iLineCounter];
                genreContents.tracks = new List<string>();

                iLineCounter++; // increment iLineCounter if number of tracks is less then the number of genres 
                for (int i = 0; i < numberOfTracks; i++)
                {
                    genreContents.tracks.Add(lines.ToArray()[iLineCounter]);
                    iLineCounter++;
                }
               genres[genreNumber] = genreContents;
            }
        }

        void PopulateTextBoxes()
        {
            // Output to screen using genre[0]

            for(int i = 0; i < genres.Count(); i++)
            {
                // Make a textbox and use genre[i].name
                for(int j = 0; j < genres[i].tracks.Count(); j++)
                {
                    // Add each track to the textbox using genres[i].tracks[j]
                }
            }
        }
    }
}
