using System;
using System.Globalization;
namespace MusicApp
{
    public class SongManager
    {
        public string FormatLastPlayed(ISongEntity song)
        {
            return song.LastPlayed.ToString("dd MMMM yyyy, dddd", CultureInfo.CurrentCulture);
        }
        public void PlaySong(IPlayable playable)
        {
            Console.WriteLine("Playing");
            playable.Play((Song)playable);
        }
    }
}