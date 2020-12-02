using System;
namespace Refresher
{
    public class Song
    {
        public string title;
        public string artist;
        public int duration;
        // static attributes is information about all instances of a class; Lives on this Song class not a specific instance
        public static int songCount = 0;

        // Constructor
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++; // Everytime a song gets created/instanciated then the songCount will increase by 1
        }

        // Method
        public int getSongCount()
        {
            return songCount;
        }
    }
}
