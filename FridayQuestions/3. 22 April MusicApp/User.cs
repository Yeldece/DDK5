using System;
namespace MusicApp
{
    public class User : BaseMusicModal
    {
        public string Name { get; set; }
        public string SirName { get; set; }
        public string EMail { get; set; }
        protected string _Password;
        public string Password { get => MusicHelpers.CreateMD5(_Password); set => _Password = value; }
        public string Address { get; set; }

    }
}