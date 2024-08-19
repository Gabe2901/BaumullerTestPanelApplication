﻿using System.Data.SQLite;
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
        public void CreateTemperatureTable()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                m_dbConnection.Open();
                // Create a table (Temperature_One, Temperature_Two
                string sql = "create table BaumullerTestPanelApplication (Temperature_One double, Temperature_Two double, DriveEnd_One double, DriveEnd_Two double)";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void InsertTemperatureData(double temp1, double temp2, double driveEnd1, double driveEnd2)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "INSERT INTO BaumullerTestPanelApplication (Temperature_One, Temperature_Two, DriveEnd_One, DriveEnd_Two) VALUES (" + Convert.ToString(temp1) + ", " + Convert.ToString(temp2) + ", " + Convert.ToString(driveEnd1) + ", " + Convert.ToString(driveEnd2) + ")";
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

