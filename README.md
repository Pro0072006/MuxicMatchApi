# MuxicMatchApi
Una librería que utiliza la Api de musixmatch, para hallar información de canciones y la letra de la misma

Search in the nuget package:  MuxicMatchApi

New features: [Features](https://github.com/pro0072006/MuxicMatchApi/blob/main/Updates_notice.md)

***DOCUMENTATION FOR MUXICMATCHAPI 2.1.0***

## Important: This library is Asynchronus

Once you installed the package, you have to know, theare 2 classes:

-MuxicMatchClient

-LyricsFinder

## MuxicMatchClient
This is a instance class, so you need this:

```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new MuxicMatchClient("Your Api key");
        }
    }
}
```
### Functions:

In this version there are 3 functions:


GetTrackAsync: This method is a instance of the class, so you have to use like this:
```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new MuxicMatchClient("Your Api key");
            var track = await client.GetTrackAsync("songTitle", "songartist");

            //It will return a class TrackModel that has this paramaters:
            /*
             *  int Track_Id 
                string Track_Name 
                string Album_Name 
                string Artist_Name
                string Track_Url 
             */
        }
    }
}
```

GetLyricsAsync: This method is an instance, like these (It will return a string containig the letter of the song):

```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new MuxicMatchClient("Your Api key");
            string track = await client.GetMusixMatchLyricsApi("songTitle", "songArtist");

        }
    }
}
```

### IMPORTANT: IF YOU HAVE A PERSONAL KEY API, IT WILL RETURN THE 30% OF THE SONG'S LYRICS, SO IF YOU WANNA THE LYRICS COMPLETE, KEEP READING

## LyricsFinder
This is a static class, it contains for now three methods to search lyrics, this means yo not have to have a key Api:

### Functions

GetOvhLyricsAsync: This will consulte the OVH.API for the lyrics
Example:
```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var lyrics = LyricsFinder.GetOvhLyricsAsync("songTitle", "songArtist");
            //It will return a string with the lyrics, or a string with a error
        }
    }
}
```
GetGeniusLyriscAsync: This will consulpe Genius for the lyrics
Example:

```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var lyrics = LyricsFinder.GetGeniusLyrics("songTitle", "songArtist");
            //It will return a string with the lyrics
        }
    }
}
```

GetGeniusLyricsWithVictoria: If you are working with [Victoria](https://github.com/Yucked/Victoria) and you need to bring you the lyrics of the song, use this method
Example:
```C#
using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var lyrics = LyricsFinder.GetGeniusLyricsWithVictoria("player.track.title");
            //this will return a string with the lyrics
        }
    }
}
```
Important: This features is Beta, this may no working well, but usually does :)

That's all for 2.1.0

Thanks for download this package

Author: Pro0072006
