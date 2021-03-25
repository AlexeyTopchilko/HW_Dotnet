using System;
using System.Data.SqlClient;
using static HW_13.Song;

namespace HW_13
{
    class SongRepository : ISongRepository
    {
        const string connectionString = "Data Source=User-ПК;Initial Catalog=UsersDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;

        public SongRepository()
        {
            connection = new SqlConnection(connectionString);
        }

        public void Create(Song song)
        {
            if (song != null)
            {
                connection.Open();
                Console.WriteLine("Connection opened");
                command = new SqlCommand();

                command.CommandText =
                    "INSERT INTO Songs (Id, Author, Title, Minutes, Year, Genre)" +
                    $" VALUES ('{song.Id}','{song.Author}','{song.Title}'," +
                    $"'{song.Minutes}','{song.Year}','{(int)song.Genre}')";

                command.Connection = connection;
                int num = command.ExecuteNonQuery();
                Console.WriteLine($"Added {num} object");
                connection.Close();
                Console.WriteLine("Connection closed");
            }
        }

        public void Read(int id)
        {
            connection.Open();
            Console.WriteLine("Connection opened");
            command = new SqlCommand();

            command.CommandText = $"SELECT * FROM Songs WHERE Id = '{id}'";

            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                Console.WriteLine(reader.GetValue(0) + " " + reader.GetValue(1) + " " + reader.GetValue(2) +
                     " " + reader.GetValue(3) + " " + reader.GetValue(4) + " " + (Genres)reader.GetValue(5));
            else
                Console.WriteLine("Song with this id does not exist!");

            reader.Close();
            connection.Close();
            Console.WriteLine("Connection closed");
        }

        public void ReadAll()
        {
            connection.Open();
            Console.WriteLine("Connection opened");
            command = new SqlCommand();

            command.CommandText = "SELECT * FROM Songs";

            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetValue(0) + " " + reader.GetValue(1) + " " + reader.GetValue(2) +
                        " " + reader.GetValue(3) + " " + reader.GetValue(4) + " " + (Genres)reader.GetValue(5));
                }
            }
            else
                Console.WriteLine("There is no data in DB!");

            reader.Close();
            connection.Close();
            Console.WriteLine("Connection closed");
        }

        public void Update(int id, string author, string title, int minutes, int year, Genres genre)
        {
            author = Song.ValidateTitleOrAuthor(author);
            title = Song.ValidateTitleOrAuthor(title);
            minutes = Song.ValidateMinutes(minutes);
            year = Song.ValidateYear(year);

            connection.Open();
            Console.WriteLine("Connection opened");
            command = new SqlCommand();

            command.CommandText = $"UPDATE Songs SET Author = '{author}', Title = '{title}'," +
              $" Minutes = {minutes},Year = {year}, Genre = {(int)genre} WHERE Id = '{id}'";

            command.Connection = connection;
            int num = command.ExecuteNonQuery();
            Console.WriteLine($"Updated {num} objects");
            connection.Close();
            Console.WriteLine("Connection closed");
        }

        public void DeleteById(int id)
        {
            connection.Open();
            Console.WriteLine("Connection opened");
            command = new SqlCommand();

            command.CommandText = $"DELETE  FROM Songs WHERE Id = '{id}'";

            command.Connection = connection;
            int num = command.ExecuteNonQuery();
            Console.WriteLine($"Deleted {num} objects");
            connection.Close();
            Console.WriteLine("Connection closed");
        }
    }
}