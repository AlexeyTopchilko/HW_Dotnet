using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace HW_13
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter("Songs.json", true);
            Song song = new Song("Hooked On A Feeling", "Blue Swede", 1992, 3, 7);
            Song song1 = new Song("B.Y.O.B.", "SOAD", 2005, 4, "rock");
            Song song2 = new Song("Kolschik", "Misha Krug", 1994, 5, "5");

            var songInfo = Song.GetSongData(song);
            var song1Info = Song.GetSongData(song1);
            var song2Info = Song.GetSongData(song2);
            
            List<dynamic> collection = new List<dynamic>
            {
                songInfo,
                song1Info,
                song2Info
            };

            foreach (var item in collection)
            {
                string json = JsonConvert.SerializeObject(item, Formatting.Indented);
                Console.WriteLine(json);
                sw.Write(json);
            }
            sw.Close();

            SongRepository sr = new SongRepository();
            sr.Create(song);
            sr.Create(song1);
            sr.Create(song2);
            sr.ReadAll();

            sr.DeleteById(3);
            sr.ReadAll();

            sr.Update(2, "SystemOfADown", "ATWA", 3, 2006, Song.Genres.Rock);
            sr.Read(5);
        }
    }
}