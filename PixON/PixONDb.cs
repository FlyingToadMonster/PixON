﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace PixON
{
    class PixONDb
    {
        private static SQLiteConnection pixDbConn;

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

        public string AddFile(string fileName, string md5 = "")
        {
            if (md5 == "") md5 = Format.GetMD5(fileName);
            SQLiteCommand cmd = new SQLiteCommand("INSERT OR REPLACE INTO FileDb (hash, path) VALUES (@Hash, @Path)", pixDbConn);
            cmd.Parameters.AddWithValue("Hash", md5);
            cmd.Parameters.AddWithValue("Path", fileName);
            cmd.ExecuteNonQuery();
            return md5;
        }

        public void AddProp(string hash, string key, string value)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT OR REPLACE INTO InfoDB (hash, key, value) VALUES (@Hash, @Key, @Value)", pixDbConn);
            cmd.Parameters.AddWithValue("Hash", hash);
            cmd.Parameters.AddWithValue("Key", key);
            cmd.Parameters.AddWithValue("Value", value);
            cmd.ExecuteNonQuery();
        }

        public void DelProp(string hash)
        {
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM InfoDB WHERE hash=@Hash", pixDbConn);
            cmd.Parameters.AddWithValue("Hash", hash);
            cmd.ExecuteNonQuery();
        }

        public List<List<string>> GetProp(string hash)
        {
            List<List<string>> result = new List<List<string>>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT key,value FROM InfoDb WHERE hash=@Hash", pixDbConn);
            cmd.Parameters.AddWithValue("Hash", hash);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                List<string> item = new List<string>();
                item.Add(rdr.GetString(0));
                item.Add(rdr.GetString(1));
                result.Add(item);
            }
            return result;
        }

        public HashSet<string> GetFile(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            HashSet<string> result = new HashSet<string>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT path FROM FileDb JOIN InfoDB ON FileDb.hash=InfoDb.hash WHERE InfoDb.value LIKE @Value", pixDbConn);
            cmd.Parameters.AddWithValue("Value", "%" + value + "%");
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
