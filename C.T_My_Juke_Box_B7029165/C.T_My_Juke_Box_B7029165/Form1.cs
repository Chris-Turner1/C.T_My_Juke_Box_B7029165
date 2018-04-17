using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; // used for dealing with adding files from media.txt file 
using System.Windows.Forms;
using WMPLib;
using System.Timers;

namespace C.T_My_Juke_Box_B7029165
{
    struct GenreContents // using structure (value type) to make a copy of my list of genres into my code called GenreContents
    {
        public string name; // name of genre title inside genre contents 
        public List<string> tracks; // list of strings (genres) called tracks for the track name of GenreContents
    }

    public partial class JukeBoxForm : Form
    { // squiggly bracket and underneath it is going inside that method
        List<GenreContents> genres; // list of genre contents called genres and all the data is inside genres
                                    // it's my song catalog essesntially, so every name of genre has a list of tracks (3 lists)
                                    // each genre title has a its own list of tracks basically 

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        System.Timers.Timer playWaitingTrackTimer = new System.Timers.Timer(3000);
        int currentTrack = 0; // nothing at currentTrack
        // a timer has been set-up to run every 3 seconds as a member of the clack which has been declared

        public JukeBoxForm() // initialising in the struct 
        {
            InitializeComponent();

            ReadMediaFile(); // empty construct b/c no value 
                            // shouldn't have to look at this function now; its done

            PopulateTextBoxes(0); // Fuction (method) to read the text

            playWaitingTrackTimer.Elapsed += CheckForWaitingTrack;
            playWaitingTrackTimer.AutoReset = true;
            playWaitingTrackTimer.Enabled = true;
          //Elapsed is used to check for the track every 3 seconds 
          //AutoReset everytime the timer hits 3000
          //Enabled timer so it stays always running in the background
          // Reference to timer function: https://msdn.microsoft.com/en-us/library/system.timers.timer(v=vs.110).aspx
        }
        
        // function for the timer to run below to allow tracks to go into playlist, list box
        void CheckForWaitingTrack(Object source, ElapsedEventArgs e) 
        {
            if (wplayer.playState == WMPPlayState.wmppsPlaying) { Console.WriteLine("still playing"); return; } 
            if (PlayList.Items.Count == 0) return; 
            if (currentTrack == PlayList.Items.Count) return;

            // at this point, we know that nothing is playing
            // and we know that there is something waiting in the playlist
            
            string songName = PlayList.Items[currentTrack].ToString(); 
            Console.WriteLine("about to play new song..." + songName);
            currentTrack += 1; // increment a track by 1  
            songName = Directory.GetCurrentDirectory() + "\\Music\\" + songName;
            
            wplayer.URL = songName;
            wplayer.controls.play();


            // If anything is playing don't do anything, return is to get out of the function when finished 
            // If count greater than 0 then there is something to be played, if 0 then get out of function
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
        // "new" into the memory known as the heap from the stack

        private void setUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupFrom setup = new SetupFrom();
            setup.ShowDialog(); // opens another windows form 
        }

        private void ReadMediaFile() // inside ReadMediaFile 
        {
            genres = new List<GenreContents>(); // all genres in genre of contents; genres is my songs cataloague essesntially 

            IEnumerable<string> lines = System.IO.File.ReadLines(Directory.GetCurrentDirectory() + "\\Music\\" + "Media.txt");
            // the above is to read where the media file is coming from and Ienumerable
            // will bring out the data from the folders for the "For loops"
            // "lines" is where all the information has been parsed into but no longer exists at the end of this function 
            // as genres will be the where. Lines is basically the media.txt file 

            int iLineCounter = 0; // zero is the number of titles 

            int numberOfGenres = Convert.ToInt32(lines.ToArray()[0]);  // converts integer to string

            for (int i = 0; i < numberOfGenres; i++) // number of genres is less than number of titles then increment

            {
                genres.Add(new GenreContents()); // keeps adding another genre if so 
            }


            iLineCounter = 1; // 1 is the number of tracks 
            for (int genreNumber = 0; genreNumber < numberOfGenres; genreNumber++)  // genre number is less than number of genres, 
                                                                                    // genre number increment to allow to add more  
            {
                int numberOfTracks = Convert.ToInt32(lines.ToArray()[iLineCounter]); // an Array is in square brackets 
                
                iLineCounter++; // LineCounter helps bring out the information 

                GenreContents genreContents;
                genreContents.name = lines.ToArray()[iLineCounter]; // name of genre title 
                genreContents.tracks = new List<string>(); // name of track 

                iLineCounter++;
                for (int i = 0; i < numberOfTracks; i++) // "iLineCounter++" increment iLineCounter if number of tracks is less than
                                                         // the number of genres 
                {
                    genreContents.tracks.Add(lines.ToArray()[iLineCounter]);
                    iLineCounter++;
                }
                genres[genreNumber] = genreContents;
            }
            hScrollBar1_On_JukeBoxForm.Maximum = numberOfGenres - 1; // ran out of memory on screen so added another value 
        }


        void PopulateTextBoxes(int i) // passing title of genres and tracks from the genres from array
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

        private void SelectTrack(object sender, MouseEventArgs e) // Mouse event argument for mouse double click
        {

            if (wplayer.playState != WMPPlayState.wmppsPlaying) // checking the player, if not playing then false 
            {
                int index = this.listBox_Below_Genre_txtBox.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {

                    // Contains the file name for my song; this is my track file name 
                    string songName = genres[hScrollBar1_On_JukeBoxForm.Value].tracks[index]; // this is my song name and index passes that
                    PresentlyPlaying.Text = songName;                                         //.Value helps to pass through what genre we're on
                    songName = Directory.GetCurrentDirectory() + "\\Music\\" + songName; // song name is what I need to pass to boxes now 


                    Console.WriteLine(songName); // this is a debug feature to display when a song is playing I need to remove this

                    genres[hScrollBar1_On_JukeBoxForm.Value].tracks.RemoveAt(index); // this will help refresh "RemoveAt"
                    listBox_Below_Genre_txtBox.Items.Clear(); // this will clear the list box before populating
                    for (int j = 0; j < genres[hScrollBar1_On_JukeBoxForm.Value].tracks.Count; j++) // genres j is track from genres
                    {
                        // Add each track to the textbox using genres[i].tracks[j]
                        listBox_Below_Genre_txtBox.Items.Add(genres[hScrollBar1_On_JukeBoxForm.Value].tracks[j].ToString());
                       
                    }

                    wplayer.URL = songName;
                    wplayer.controls.play();

                    //PlayList.Items.Add(songName);
                    //playWaitingTrackTimer.Start();
                    //player.Play();

                }
            }
            else // this is adding a function and this puts tracks into the list box below (the playlist)
            {
                int index = this.listBox_Below_Genre_txtBox.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {

                    // Contains the file name for my song; this is my track file name 
                    string songName = genres[hScrollBar1_On_JukeBoxForm.Value].tracks[index];
                    
                    PlayList.Items.Add(songName);


                    // Populates songs into playlist
                    // And this will play the next song when its been double clicked to the playlist
                  
                }
            }

        }
    }
}


