using System;
using System.Globalization;
using Library;
using ClothShoping;
using MusicApp;
namespace Console_review
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> mySongs = new() { new Song("Agla Halime"), new Song("Kapat Gozlerini"), new Song("Ayni Yolun Yolcusuyuz"), new Song("Kac Kadeh Kirildi"), new Song("Istanbul") };
            Artist Pamela = new Artist("Pamela", "Spenser");
            List<Song> hidraSongs = new() { new Song("Gibi"), new Song("Arkamdan Kos"), new Song("Gezegen") };
            Artist Hidra = new("Fatih", "Uslu");
            mySongs.ForEach(x => x.SingBy = Pamela);
            hidraSongs.ForEach(x => x.SingBy = Hidra);
            hidraSongs[0].PublishDate = new DateTime(2014, 4, 1);
            hidraSongs[0].LastPlayed = DateTime.Now;
            SongManager sManager = new();
            sManager.FormatLastPlayed(hidraSongs[0]);
            sManager.PlaySong(hidraSongs[0]);
            Log log = new Log();
            log.Category = ((int)LogLevel.Low);
            log.Description = "Searching for zeroday bugs ";
            log.Name = "Zeroday";
            PlayList myPlaylist = new PlayList();
            myPlaylist.Songs = hidraSongs;
            myPlaylist.Songs.AddRange(mySongs);
        }
    }
}