using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace BaumullerTestPanelApplication
{
    internal class PlcController
    {
        public Plc CreatePlcObject()
        {
            Plc plc = new Plc(CpuType.S71200, "192.168.0.220", 0, 1);
            return plc;
        }

        public bool IsPlcOpen(Plc plc)
        {
            return plc.IsConnected;
        }
    }
}
