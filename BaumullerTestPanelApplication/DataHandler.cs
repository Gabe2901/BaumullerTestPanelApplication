using System.Data.SQLite;
using System;
using System.IO;

namespace BaumullerTestPanelApplication

{
    internal class DataHandler
    {
        // Declare the connectionString as a field
        readonly string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BaumullerTestPanelApplication.db");
        // Constructor
        public void CreateDatabase()
        {
            SQLiteConnection.CreateFile(dbPath);
        }
        public void CreateTable()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                m_dbConnection.Open();
                // Create a table (Temperature_One, Temperature_Two
                string sql = "create table BaumullerTestPanelApplication (Temperature_One double, Temperature_Two double)";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void InsertTemperatureOne(double data)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "insert into BaumullerTestPanelApplication (Temperature_One) values (" + Convert.ToString(data) + ")";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public void CloseConnection()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                m_dbConnection.Close();
            }
        }
    }
    }

