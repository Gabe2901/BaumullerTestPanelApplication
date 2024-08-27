using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BaumullerTestPanelApplication

{
    public class DataHandler(DriveController driveController)
    {
        // Declare the connectionString as a field
        readonly string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DateTime.Now.ToString("hh_m_ddMMMyy")+ "DATABASE.db");
        // Constructor
        private List<double> data = new List<double>();

        public void CreateDatabase()
        {
            if (!File.Exists(dbPath))
            {
                try
                {
                    SQLiteConnection.CreateFile(dbPath);
                    using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                    {
                        m_dbConnection.Open();
                        string sql = "create table BaumullerTestPanelApplication (Temperature_One double, Temperature_Two double, DriveEnd_One double, DriveEnd_Two double)";
                        SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                        command.ExecuteNonQuery();
                        CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Debug.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void InsertData(double drive1)
        {
            try
            {
                using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    m_dbConnection.Open();
                    string sql = "INSERT INTO BaumullerTestPanelApplication (DriveEnd_One) VALUES (" + Convert.ToString(drive1) + ")";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Debug.WriteLine("Error: " + ex.Message);
            }
        }
        public void CloseConnection()
        {
            try
            {
                using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    m_dbConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        public void SaveFile()
        {
            DialogResult saveFileOptionMsgBox = MessageBox.Show("Would you like to save the data to a file?", "Save Data", MessageBoxButtons.YesNo);
            if(saveFileOptionMsgBox == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Save data to a file";
                saveFileDialog.ShowDialog();

                if(saveFileDialog.FileName != "")
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                        {
                            using (SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                            {
                                m_dbConnection.Open();
                                string sql = "SELECT * FROM BaumullerTestPanelApplication";
                                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                                SQLiteDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    sw.WriteLine(reader["DriveEnd_One"]);
                                }
                                CloseConnection();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        Debug.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        public double[] GetValue() {

            //var bProcessBytes = PLC.ReadBytes(DataType.Input, 0, 64, 2);

            data.Add(Convert.ToDouble(driveController.GetData()));
            return data.ToArray();
        }

    }
}

