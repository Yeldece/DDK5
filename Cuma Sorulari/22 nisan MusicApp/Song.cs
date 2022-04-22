using System;
namespace MusicApp
{
    public class Song : BaseMusicModal, IPlayable, ISongEntity
    {
        public DateTime LastPlayed { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime AnnounceDate { get; set; }
        public double Duration { get; set; }
        public Singer SingBy { get; set; }
        public Song(string name)
        {
            Name = name;
        }
        public void Play(Song song)
        {

        }
    }
}