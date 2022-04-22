using System;
using System.Collections.Generic;
namespace MusicApp
{
    public class Favories : BaseMusicModal
    {
        public List<Song> Songs { get; set; }
        public User UserBy { get; set; }
    }
}