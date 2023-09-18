using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Static_attributes
{
    internal class Songs
    {

        public string title;
        public string artist;
        public int duration;

        public static int songCount; //declared a static attributes
        public Songs(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
    }
}
