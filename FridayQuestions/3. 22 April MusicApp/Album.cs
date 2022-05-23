using System;
using System.Collections.Generic;
namespace MusicApp
{
    public class Album : BaseMusicModal
    {
        public string Name { get; set; }
        public List<Song> Songs = new();
        public int NumberOfSongs { get => Songs.Count(); }
        public string ImagePath { get; set; }
        public Artist SingBy { get; set; }
    }
}