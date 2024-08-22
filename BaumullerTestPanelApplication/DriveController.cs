using System;
using System.Windows.Forms;
using S7.Net;

namespace BaumullerTestPanelApplication
{
    internal class DriveController
    {
        PlcController PlcControllerObject = new PlcController();
        //TODO: setup the drive controller
        public void DriveStart(string DriveTag, Plc PLC)
        {
            if (PLC.IsConnected)
            {
                PLC.WriteBit(DataType.Memory, 0, 0, 0, true);
            }
            else
            {
                MessageBox.Show("Error connecting to PLC");
            }
        }

        public void DriveStop(string DriveTag, Plc PLC)
        {
            if (PLC.IsConnected)
            {
                PLC.WriteBit(DataType.Memory, 0, 0, 0, false);
            }
            else
            {
                MessageBox.Show("Error connecting to PLC");
            }

        }
        public int GetDriveNumberFromTag(string DriveTag)
        {
            return Convert.ToInt32(DriveTag.Substring(DriveTag.Length - 1));
        }
    }
}
