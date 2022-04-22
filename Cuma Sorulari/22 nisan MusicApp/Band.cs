using System;
using System.Collections.Generic;
namespace MusicApp
{
    public class Band : BaseMusicModal
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Artist> Artists { get; set; }
        public Band(string name)
        {
            Name = name;
        }
    }
}