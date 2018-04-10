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

using WMPLib;



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

        List<string> playlist;

        public JukeBoxForm() // initialising in the struct 
        {
            InitializeComponent();

            ReadMediaFile(); // empty construct b/c no value 
            // shouldn't have to look at this function now; its done

            PopulateTextBoxes(0); // Fuction (method) to read the text

            playlist = new List<string>();
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
        // "new" into the memory known as the heap from the stack
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

            int numberOfGenres = Convert.ToInt32(lines.ToArray()[0]);
            // converts integer to string 
            for (int i = 0; i < numberOfGenres; i++)
            // number of genres is less than number of titles then increment
            {
                genres.Add(new GenreContents()); // keeps adding another genre if so 
            }


            iLineCounter = 1; // 1 is the number of tracks 
            for (int genreNumber = 0; genreNumber < numberOfGenres; genreNumber++)
            // genre number is less than number of genres, 
            // genre number increment to allow to add more  
            {
                int numberOfTracks = Convert.ToInt32(lines.ToArray()[iLineCounter]);
                // an Array is in square brackets 

                iLineCounter++;

                GenreContents genreContents;
                genreContents.name = lines.ToArray()[iLineCounter]; // name of genre 
                genreContents.tracks = new List<string>(); // name of track 

                iLineCounter++;
                for (int i = 0; i < numberOfTracks; i++)
                // "iLineCounter++" 
                //increment iLineCounter if number of tracks is less then the number of genres 
                {
                    genreContents.tracks.Add(lines.ToArray()[iLineCounter]);
                    iLineCounter++;
                }
                genres[genreNumber] = genreContents;
            }
            hScrollBar1_On_JukeBoxForm.Maximum = numberOfGenres - 1;
        }


        void PopulateTextBoxes(int i)
        {
            // Genre_txtBox.Text = genre [genre]. 
            // for each genre, this is the textbox I am trying to load . name at the end 
            // Output to screen using genre[0] // zero is the first genre 

            //for(int i = 0; i < genres.Count(); i++) 
            // to get data out, to output to screen list of genres 
            {
                Genre_txtBox.Text = genres[i].name; // gets the titles for text box first  
                // Make a textbox and use genre[i].name // output to screen the name of tracks 
                for (int j = 0; j < genres[i].tracks.Count(); j++)
                {
                    // Add each track to the textbox using genres[i].tracks[j]
                    listBox_Below_Genre_txtBox.Items.Add(genres[i].tracks[j].ToString());
                    //  Environment.Newline will bring out the name and tracks of genres
                    // onto new lines in the text box if multiline is set to "true" in properties
                }
            }
        }

        private void hScrollBar1_On_JukeBoxForm_Scroll(object sender, ScrollEventArgs e)
        {
            Genre_txtBox.Text = ""; // this will clear the text box before populating 
            listBox_Below_Genre_txtBox.Items.Clear(); // this will clear the list box before populating 
            PopulateTextBoxes(hScrollBar1_On_JukeBoxForm.Value); // this will pass through populate text box
        }

        private void listBox_Below_Genre_txtBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectTrack(object sender, MouseEventArgs e) // Mouse event argument for mouse double click
        {
            int index = this.listBox_Below_Genre_txtBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                // Contains the file name for my song; this is my track file name 

                string songName = genres[hScrollBar1_On_JukeBoxForm.Value].tracks[index]; // this is my song name 
                songName = Directory.GetCurrentDirectory() + "\\Music\\" + songName; // song name is what I need to pass to boxes 


                Console.WriteLine(songName); // this is a debug feature to display when a song is playing  

                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

               
                wplayer.URL = songName;
                wplayer.controls.play();


            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Music\Media.txt\Amy Winehouse - Rehab.wav");
            //player.Play();
                
            }
            // 1 if statements to go inside of here is all i need 
            //  to make a track play when I double click on it, by using .append 
            /*
            if (axWindowsMediaPlayer1.playState) = WMPLib.WMPPlayState.wmppsPlaying;
            {
                isPlaying = true; 
            }
            else
            {
            
            }
            */

           
        }
    }
}


