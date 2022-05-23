using System;
namespace MusicApp
{
    public abstract class BaseMusicModal
    {
        protected int IDCounter = 1;
        public int ID { get; init; }
        protected DateTime _AddDate = DateTime.Now;
        public DateTime AddDate { get => _AddDate; set => _AddDate = value; }
        public BaseMusicModal()
        {
            ID = IDCounter++;
        }
    }
}