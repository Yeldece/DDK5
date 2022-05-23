using System;
namespace MusicApp
{
    public class Artist : BaseMusicModal
    {
        public string Name { get; set; }
        public string SirName { get; set; }
        public string? Country { get; set; }
        public DateTime BirthDate { get; set; }

        public Artist(string name, string sirName)
        {
            Name = name;
            SirName = sirName;
        }
        public override string ToString()
        {
            return $"{Name} {SirName}";
        }
    }
}