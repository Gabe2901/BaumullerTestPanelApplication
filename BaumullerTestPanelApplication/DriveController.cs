using System;
using System.Diagnostics;
using System.Windows.Forms;
using S7.Net;

namespace BaumullerTestPanelApplication
{
    public class DriveController
    {

        Plc PLC = new Plc(CpuType.S71200, "192.168.0.220", 0, 1);

        public DriveController()
        {
            try
            {
                PLC.Open();

            }
            catch (Exception)
            {

                throw;
            }
        }

        //TODO: setup the drive controller
        public void DriveStart(string DriveTag)
        {
            if (PLC.IsConnected)
            {
                try
                {
                    PLC.WriteBit(DataType.Memory, 0, 0, 0, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Debug.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error connecting to PLC");
            }
        }

        public void DriveStop(string DriveTag)
        {
            if (PLC.IsConnected)
            {
                try
                {
                    PLC.WriteBit(DataType.Memory, 0, 0, 0, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Debug.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error connecting to PLC");
            }

        }

        public Int16 GetData()
        {
            try
            {
                byte[] bProcessBytes = PLC.ReadBytes(DataType.Input, 0, 64, 2);
                Array.Reverse(bProcessBytes, 0, bProcessBytes.Length);
                Debug.WriteLine(BitConverter.ToInt16(bProcessBytes, 0));
                return BitConverter.ToInt16(bProcessBytes, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Debug.WriteLine("Error: " + ex.Message);
            }
            return 0;
        }

            public int GetDriveNumberFromTag(string DriveTag)
        {
            return Convert.ToInt32(DriveTag.Substring(DriveTag.Length - 1));
        }
    }
}
