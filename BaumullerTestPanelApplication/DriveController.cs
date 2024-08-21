using System;
using S7.Net;

namespace BaumullerTestPanelApplication
{
    internal class DriveController
    {
        //TODO: setup the drive controller
        public void DriveStart(string DriveTag, Plc PLC)
        {
            PLC.Open();
            PLC.WriteBit(DataType.Memory, 0, 0, 0, true);
            PLC.Close();
        }

        public void DriveStop(string DriveTag, Plc PLC)
        {
            PLC.Open();
            PLC.WriteBit(DataType.Memory, 0, 0, 0, false);
            PLC.Close();
        }
        public int GetDriveNumberFromTag(string DriveTag)
        {
            return Convert.ToInt32(DriveTag.Substring(DriveTag.Length - 1));
        }
    }
}
