using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatabaseSQLMusicAPP
{
    internal class AlbumsDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=;database=music;";

        public List<Album> getAllAlbums()
        {
            List<Album> returnThese = new List<Album>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("SELECT ID,ALBUM_TITLE,ARTIST,YEAR,IMAGE_NAME,DESCRIPTION FROM ALBUMS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };
                    a.Tracks = getTracksForAlbum(a.ID);

                    returnThese.Add(a);
                }
            }
                   connection.Close(); 
                    return returnThese;
        }

        public List<Album> searchTitles(String searchTerm) 
        {
            List<Album> returnThese = new List<Album>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String searchWildPhrase = "%" + searchTerm + "%";
            //define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID,ALBUM_TITLE,ARTIST,YEAR,IMAGE_NAME,DESCRIPTION FROM ALBUMS WHERE ALBUM_TITLE LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection=connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();
            return returnThese;
        }

        internal int addOneAlbum(Album album)
        {
            {
                int newRows = 0;

                // Use a using statement to ensure the connection is properly closed even if an exception occurs
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL statement to insert a new album
                    string query = "INSERT INTO `albums` (`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumtitle, @artist, @year, @imageURL, @description)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@albumtitle", album.AlbumName);
                        command.Parameters.AddWithValue("@artist", album.ArtistName);
                        command.Parameters.AddWithValue("@year", album.year);
                        command.Parameters.AddWithValue("@imageURL", album.ImageURL);
                        command.Parameters.AddWithValue("@description", album.Description);

                        // Execute the command and get the number of affected rows
                        newRows = command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                return newRows;
            }
        }

        public List<Track> getTracksForAlbum(int albumID)
        {
            List<Track> returnThese = new List<Track>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM TRACKS WHERE albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                        
                    };
                    returnThese.Add(t);
                }
            }
            connection.Close();
            return returnThese;
        }

        public List<JObject> getTracksUsingJoin(int albumID)
        {
            List<JObject> returnThese = new List<JObject>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                // Define the SQL statement to fetch all tracks for a specific album
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "SELECT tracks.ID as trackID, albums.ALBUM_TITLE, track_title, video_url FROM tracks JOIN albums ON tracks.albums_ID = albums.ID WHERE albums_ID = @albumid";
                command.Parameters.AddWithValue("@albumid", albumID);
                command.Connection = connection;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        JObject newTrack = new JObject();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string columnName = reader.GetName(i);
                            newTrack.Add(columnName, JToken.FromObject(reader.GetValue(i)));
                        }

                        returnThese.Add(newTrack);
                    }
                }
            }
            finally
            {
                connection.Close();
            }

            return returnThese;
        }

        internal int deleteTrack(int trackID)
        {
            int result = 0; 

            // Use a using statement to ensure the connection is properly closed even if an exception occurs
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL statement to delete a track
                string query = "DELETE FROM `tracks` WHERE `tracks`.`ID` = @trackID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@trackID", trackID);

                    // Execute the query and get the number of affected rows
                    result = command.ExecuteNonQuery();
                }

                // Connection will be closed automatically when the using block ends
            }

            return result;
        }

    }
}
