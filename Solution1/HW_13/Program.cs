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
            Song song = new Song("Hooked on a feeling", "Blue Swede", 1992, 3, 7);
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
        }
    }
}