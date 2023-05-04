using System;
using System.Threading.Tasks;
using MuxicMatchApi;

namespace test__delete_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var lyrics = await LyricsFinder.GetGeniusLyrics("songTitle", "songArtist");
            Console.WriteLine(lyrics);
        }
    }
}
