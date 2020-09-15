using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class StaticClassAttribues
    {
        // a static attribute is a attribute about the class
        // a static attribute belongs to the class and will be the same across all instances.

        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public StaticClassAttribues (string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        // doing it like this will add it to the instance when it is created;
        public int getSongCount()
        {
            return songCount;
        }
    }
}
