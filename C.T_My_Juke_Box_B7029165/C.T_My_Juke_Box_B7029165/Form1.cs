using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // used for dealing with adding files from media txt file 
using MyDialogs; // don't need this, used for inserting text boxes 
using System.Windows.Forms;

namespace C.T_My_Juke_Box_B7029165
{
    struct GenreContents
    {
        public string name;
        public List<string> tracks; // list of strings (genres) called tracks 
    }

    public partial class JukeBoxForm : Form
    { // squiggly brack and underneath it is going inside that method
        List<GenreContents> genres; // list of genre contents called genres
        // and all the data is inside genres 



        public JukeBoxForm() // initialising in the struct 
        {
            InitializeComponent();          

            ReadMediaFile(); // empty construct 

            PopulateTextBoxes(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
           
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm(); // new into the memory known as the heap from the stack
            about.ShowDialog();
        }

        private void MenuStrip_For_Juke_Box_Form_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void setUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupFrom setup = new SetupFrom();
            setup.ShowDialog(); // opens another windows form 
        }

        private void ReadMediaFile() // inside ReadMediaFile 
        {
            genres = new List<GenreContents>(); // all genres in genre of contents 

            IEnumerable<string> lines = System.IO.File.ReadLines(Directory.GetCurrentDirectory() + "\\Music\\" + "Media.txt");
            // the above is to read where the media file is coming from and Ienumerable
            // will bring out the data from the folders for the "For loops"

            int iLineCounter = 0; // zero is the number of titles 

            int numberOfGenres = Convert.ToInt32(lines.ToArray()[0]); // converts integer to string 
            for(int i = 0; i < numberOfGenres; i++) // number of genres is less than number of titles then increment
            {
                genres.Add(new GenreContents()); // keeps adding another genre if so 
            }


            iLineCounter = 1; // 1 is the number of tracks 
            for (int genreNumber = 0; genreNumber < numberOfGenres; genreNumber++) 
                // genre number is less than number of genres, genre number increment to allow to add more  
            {
                int numberOfTracks = Convert.ToInt32(lines.ToArray()[iLineCounter]); // an Array is in square brackets 

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

        void PopulateTextBoxes(int Genre_txtBox) 
        {
            // Genre_txtBox.Text = genre [genre]. // this is the textbox I am trying to load
            // Output to screen using genre[0]

            for(int i = 0; i < genres.Count(); i++) // output to screen list of genres 
            {
                // Make a textbox and use genre[i].name // output to screen the name of tracks 
                for(int j = 0; j < genres[i].tracks.Count(); j++)
                {
                    // Add each track to the textbox using genres[i].tracks[j]
                }
            }
        }
    }
}
