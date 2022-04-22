using System;
using System.Collections.Generic;
namespace MusicApp
{
    public class PlayList : BaseMusicModal, ISongEntity
    {
        public List<Song> Songs { get; set; }
        public User UserBy { get; set; }
        public int NumberOfSongs { get => Songs.Count(); }
        public DateTime LastPlayed { get; set; }
    }
}