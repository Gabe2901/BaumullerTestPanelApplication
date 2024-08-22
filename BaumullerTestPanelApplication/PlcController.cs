using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace BaumullerTestPanelApplication
{
    internal class PlcController
    {
        public Plc CreatePlcObject()
        {
            Plc plc = new Plc(CpuType.S71200, "192.168.0.220", 0, 1);
            try { plc.Open(); }
            catch (Exception e)
            {
                MessageBox.Show("Error connecting to PLC: " + e.Message);
            }
            return plc;
        }
    }
}
