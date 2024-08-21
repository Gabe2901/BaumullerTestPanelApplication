using System;
using S7.Net;

namespace BaumullerTestPanelApplication
{
    internal class DriveController
    {
        //TODO: setup the drive controller
        public void DriveStart(string DriveTag, Plc PLC)
        {
            PLC.WriteBit(DataType.Memory, 0, 0, 0, true);
        }

        public void DriveStop(string DriveTag, Plc PLC)
        {
            PLC.WriteBit(DataType.Memory, 0, 0, 0, false);
        }
        public int GetDriveNumberFromTag(string DriveTag)
        {
            return Convert.ToInt32(DriveTag.Substring(DriveTag.Length - 1));
        }
    }
}
