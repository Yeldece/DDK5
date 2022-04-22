using System;
namespace MusicApp
{
    public abstract class BaseMusicModal
    {
        public int ID { get; set; }
        protected DateTime _AddDate = DateTime.Now;
        public DateTime AddDate { get => _AddDate; set => _AddDate = value; }
    }
}