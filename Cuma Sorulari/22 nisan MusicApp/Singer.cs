using System;
namespace MusicApp
{
    public class Singer : BaseMusicModal
    {
        public string Name { get; set; }
        public string SirName { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }

        public Singer(string name, string sirName)
        {
            Name = name;
            SirName = sirName;
        }
    }
}