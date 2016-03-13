using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PixON
{
    class PixONDb
    {
        private static SQLiteConnection pixDbConn;

        private string GetMD5(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    return Encoding.Default.GetString(md5.ComputeHash(stream));
                }
            }
        }

        public PixONDb(string pixDbName = "db/pixDb.sqlite")
        {
            if (!File.Exists(pixDbName))
            {
                string pixDbPath = Path.GetDirectoryName(pixDbName);
                Directory.CreateDirectory(pixDbPath);
                SQLiteConnection.CreateFile(pixDbName);
            }
            pixDbConn = new SQLiteConnection("Data Source=" + pixDbName);
            pixDbConn.Open();

            SQLiteCommand cmd = new SQLiteCommand(@"
CREATE TABLE IF NOT EXISTS FileDb 
(
hash char(32) NOT NULL, 
path varchar(260) NOT NULL, 
CONSTRAINT hash PRIMARY KEY (hash), 
UNIQUE (path)
)"
                , pixDbConn);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand(@"
CREATE TABLE IF NOT EXISTS InfoDb
(
hash char(32) NOT NULL, 
key varchar(255) NOT NULL, 
value varchar(8000)
)"
                , pixDbConn);
            cmd.ExecuteNonQuery();
        }

        public string AddFile(string fileName)
        {
            string md5 = GetMD5(fileName);
            SQLiteCommand cmd = new SQLiteCommand("INSERT OR REPLACE INTO FileDb (hash, path) VALUES (@Hash, @Path)", pixDbConn);
            cmd.Parameters.AddWithValue("Hash", md5);
            cmd.Parameters.AddWithValue("Path", fileName);
            cmd.ExecuteNonQuery();
            return md5;
        }

        public void AddProp(string hash, string key, string value)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM InfoDb WHERE hash=@Hash AND key=@Key AND value=@VALUE", pixDbConn);
            cmd.Parameters.AddWithValue("Hash", hash);
            cmd.Parameters.AddWithValue("Key", key);
            cmd.Parameters.AddWithValue("Value", value);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            if (rdr.GetInt32(0) == 0)
            {
                cmd = new SQLiteCommand("INSERT INTO InfoDB (hash, key, value) VALUES (@Hash, @Key, @Value)", pixDbConn);
                cmd.Parameters.AddWithValue("Hash", hash);
                cmd.Parameters.AddWithValue("Key", key);
                cmd.Parameters.AddWithValue("Value", value);
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetProp(string hash, string key)
        {
            List<string> result = new List<string>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT value FROM InfoDb WHERE hash=@Hash AND key=@Key", pixDbConn);
            cmd.Parameters.AddWithValue("Hash", hash);
            cmd.Parameters.AddWithValue("Key", key);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                result.Add(rdr.GetString(0));
            }
            return result;
        }

        public void Close()
        {
            pixDbConn.Close();
        }
    }
}
