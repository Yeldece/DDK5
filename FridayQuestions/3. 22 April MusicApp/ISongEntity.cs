using System;
namespace MusicApp
{
    public interface ISongEntity
    {
        public DateTime LastPlayed { get; set; }
    }
}