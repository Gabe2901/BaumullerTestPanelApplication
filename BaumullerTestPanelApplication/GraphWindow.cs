using ScottPlot;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaumullerTestPanelApplication
{
    public partial class GraphWindow : Form
    {
        //private List<double> data = new List<double>();
        double[] data;
        DataHandler dataHandler;

        public GraphWindow(DataHandler passedDataHandler)

        {
            dataHandler = passedDataHandler;
            InitializeComponent();
            timer1.Enabled = false;
            dataHandler.CreateDatabase();
            data = dataHandler.GetValue();
            formsPlot1.Plot.Add.Signal(data);
            

            formsPlot1.Refresh();

        }

        private void OnGraphTimerTick(object sender, EventArgs e)
        {
            data = dataHandler.GetValue();
            formsPlot1.Plot.Clear();
            dataHandler.InsertData(data[data.Length-1]);
            formsPlot1.Plot.Add.Signal(data);
            formsPlot1.Plot.Axes.AutoScale();
            
            formsPlot1.Refresh();
        }

        public void Stop()
        {
            timer1.Enabled = false;
        }

        public void Start()
        {
            timer1.Enabled = true;
        }

        private void GraphWindow_Load(object sender, EventArgs e)
        {

        }

        private void GraphWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataHandler.CloseConnection();
            MessageBox.Show("Database connection closed, reopening the window will create a new database.");
        }
    }
}
