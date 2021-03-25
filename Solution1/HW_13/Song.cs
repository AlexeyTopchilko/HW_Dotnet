using System;

namespace HW_13
{
    class Song
    {
        private static int count { get; set; } = 1;

        public int Id { get; } 

        public string Title { get; set; }

        public int Minutes { get; set; }

        public string Author { get; set; }

        public int Year { get; set; }

        public Genres Genre { get; set; }

        public enum Genres
        {
            Unknown,
            Pop,
            Classic,
            Rock,
            Jazz,
            Chanson
        }
        static private int Length = Enum.GetNames(typeof(Genres)).Length;

        static public dynamic GetSongData(Song song)
        {
            var songsData = new
            {
                Id = song.Id,
                Title = song.Title,
                Author = song.Author,
                Minutes = song.Minutes,
                Genre = song.Genre
            };

            return songsData;
        }
        public Song(string title, string author, int year, int minutes, int genre)
        {
            Id = count;
            Title = ValidateTitleOrAuthor(title);
            Author = ValidateTitleOrAuthor(author);
            Year = ValidateYear(year);
            Minutes = ValidateMinutes(minutes);
            if (genre >= 0 && genre <= Length - 1)
                Genre = (Genres)genre;
            else
                Genre = default;
            count++;
        }

        public Song(string title, string author, int year, int minutes, string genre)
        {
            Id = count;
            Title = ValidateTitleOrAuthor(title);
            Author = ValidateTitleOrAuthor(author);
            Year = ValidateYear(year);
            Minutes = ValidateMinutes(minutes);
            Genre = ValidateGenre(genre);
            count++;
        }

        public static Genres ValidateGenre(string genre)
        {
            if (genre == null)
                return Genres.Unknown;
            else if (Int32.TryParse(genre, out int intGenre))
            {
                if (intGenre > Length - 1 || intGenre < 0)
                    return Genres.Unknown;
                return (Genres)Int32.Parse(genre);
            }
            else
            {
                bool chek = Enum.TryParse(genre, true, out Genres currentGenre);
                return currentGenre;
            }
        }

        public static int ValidateYear(int year)
        {
            if (year > DateTime.Now.Year)
                return DateTime.Now.Year;
            else
                return year;
        }

        public static string ValidateTitleOrAuthor(string name)
        {
            if (name.Equals(string.Empty) || name == null)
                return "Unknown";
            else
                return name;
        }

        public static int ValidateMinutes(int minutes)
        {
            if (minutes < 0)
                return 0;
            else
                return minutes;
        }
    }
}