using ScottPlot;
using ScottPlot.Plottables;
using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace BaumullerTestPanelApplication
{
    public partial class TestGraphWindow : Form
    {

        public string Title => "Data Streamer";
        public string Description => "Plots live streaming data as a fixed-width line plot, " +
            "shifting old data out as new data comes in.";

        readonly System.Windows.Forms.Timer AddNewDataTimer = new() { Interval = 100, Enabled = false };
        readonly System.Windows.Forms.Timer UpdatePlotTimer = new() { Interval = 250, Enabled = false };

        readonly ScottPlot.Plottables.DataStreamer Streamer1;
        readonly ScottPlot.Plottables.DataStreamer Streamer2;
        readonly ScottPlot.Plottables.DataStreamer Streamer3;
        readonly ScottPlot.Plottables.DataStreamer Streamer4;

        readonly ScottPlot.DataGenerators.RandomWalker Walker1 = new(0);
        readonly ScottPlot.DataGenerators.RandomWalker Walker2 = new(1);
        readonly ScottPlot.DataGenerators.RandomWalker Walker3 = new(2);
        readonly ScottPlot.DataGenerators.RandomWalker Walker4 = new(3);

        //readonly ScottPlot.Plottables.VerticalLine VLine;
        //readonly ScottPlot.Plottables.VerticalLine VLine2;

        DataHandler dataHandler = new DataHandler();
        


        AxisLine? PlottableBeingDragged = null;

        public void Start()
        {
            AddNewDataTimer.Start();
            UpdatePlotTimer.Start();
            dataHandler.CreateDatabase();
            dataHandler.CreateTable();
            
        }

        public void Stop()
        {
            AddNewDataTimer.Stop();
            UpdatePlotTimer.Stop();
            dataHandler.CloseConnection();
        }
        public TestGraphWindow()
        {
            InitializeComponent();

            if (Screen.AllScreens.Length == 2)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = Screen.AllScreens[1].Bounds.Location;
            }

            Streamer1 = formsPlot1.Plot.Add.DataStreamer(1000);
            Streamer2 = formsPlot1.Plot.Add.DataStreamer(1000);
            //VLine = formsPlot1.Plot.Add.VerticalLine(0, 2, ScottPlot.Colors.Red);

            Streamer1.LegendText = "Temperature 1";
            Streamer2.LegendText = "Temperature 2";

            //Vertical lines
            var h1 = formsPlot1.Plot.Add.HorizontalLine(23, 2,ScottPlot.Colors.Red,ScottPlot.LinePattern.Dashed);
            h1.IsDraggable = true;

            var h2 = formsPlot2.Plot.Add.HorizontalLine(23, 2, ScottPlot.Colors.Red, ScottPlot.LinePattern.Dashed);
            h2.IsDraggable = true;



            //Plot interactivity for lines
            formsPlot1.MouseDown += FormsPlot1_MouseDown;
            formsPlot1.MouseUp += FormsPlot1_MouseUp;
            formsPlot1.MouseMove += FormsPlot1_MouseMove;

            formsPlot2.MouseDown += FormsPlot2_MouseDown;
            formsPlot2.MouseUp += FormsPlot2_MouseUp;
            formsPlot2.MouseMove += FormsPlot2_MouseMove;

            void FormsPlot1_MouseDown(object? sender, MouseEventArgs e)
            {
                var lineUnderMouse = GetLineUnderMouse(e.X, e.Y);
                if (lineUnderMouse is not null)
                {
                    PlottableBeingDragged = lineUnderMouse;
                    formsPlot1.Interaction.Disable(); // disable panning while dragging
                }
            }

            void FormsPlot1_MouseUp(object? sender, MouseEventArgs e)
            {
                PlottableBeingDragged = null;
                formsPlot1.Interaction.Enable(); // enable panning again
                formsPlot1.Refresh();
            }

            void FormsPlot1_MouseMove(object? sender, MouseEventArgs e)
            {
                // this rectangle is the area around the mouse in coordinate units
                CoordinateRect rect = formsPlot1.Plot.GetCoordinateRect(e.X, e.Y, radius: 10);

                if (PlottableBeingDragged is null)
                {
                    // set cursor based on what's beneath the plottable
                    var lineUnderMouse = GetLineUnderMouse(e.X, e.Y);
                    if (lineUnderMouse is null) Cursor = Cursors.Default;
                    else if (lineUnderMouse.IsDraggable && lineUnderMouse is VerticalLine) Cursor = Cursors.SizeWE;
                    else if (lineUnderMouse.IsDraggable && lineUnderMouse is HorizontalLine) Cursor = Cursors.SizeNS;
                }
                else
                {
                    // update the position of the plottable being dragged
                    if (PlottableBeingDragged is HorizontalLine hl)
                    {
                        hl.Y = rect.VerticalCenter;
                        hl.Text = $"{hl.Y:0.00}";
                    }
                    else if (PlottableBeingDragged is VerticalLine vl)
                    {
                        vl.X = rect.HorizontalCenter;
                        vl.Text = $"{vl.X:0.00}";
                    }
                    formsPlot1.Refresh();
                }
            }
            void FormsPlot2_MouseDown(object? sender, MouseEventArgs e)
            {
                var lineUnderMouse = GetLineUnderMouse2(e.X, e.Y);
                if (lineUnderMouse is not null)
                {
                    PlottableBeingDragged = lineUnderMouse;
                    formsPlot2.Interaction.Disable(); // disable panning while dragging
                }
            }

            void FormsPlot2_MouseUp(object? sender, MouseEventArgs e)
            {
                PlottableBeingDragged = null;
                formsPlot2.Interaction.Enable(); // enable panning again
                formsPlot2.Refresh();
            }

            void FormsPlot2_MouseMove(object? sender, MouseEventArgs e)
            {
                // this rectangle is the area around the mouse in coordinate units
                CoordinateRect rect = formsPlot2.Plot.GetCoordinateRect(e.X, e.Y, radius: 10);

                if (PlottableBeingDragged is null)
                {
                    // set cursor based on what's beneath the plottable
                    var lineUnderMouse = GetLineUnderMouse2(e.X, e.Y);
                    if (lineUnderMouse is null) Cursor = Cursors.Default;
                    else if (lineUnderMouse.IsDraggable && lineUnderMouse is VerticalLine) Cursor = Cursors.SizeWE;
                    else if (lineUnderMouse.IsDraggable && lineUnderMouse is HorizontalLine) Cursor = Cursors.SizeNS;
                }
                else
                {
                    // update the position of the plottable being dragged
                    if (PlottableBeingDragged is HorizontalLine hl)
                    {
                        hl.Y = rect.VerticalCenter;
                        hl.Text = $"{hl.Y:0.00}";
                    }
                    else if (PlottableBeingDragged is VerticalLine vl)
                    {
                        vl.X = rect.HorizontalCenter;
                        vl.Text = $"{vl.X:0.00}";
                    }
                    formsPlot2.Refresh();
                }
            }
            // disable mouse interaction by default
            //formsPlot1.Interaction.Disable();

            // only show marker button in scroll mode
            btnMark.Visible = false;

            // setup a timer to add data to the streamer periodically
            AddNewDataTimer.Tick += (s, e) =>
            {
                int count = 5;

                // add new sample data
                Streamer1.AddRange(Walker1.Next(count));
                Streamer2.AddRange(Walker2.Next(count));

                // slide marker to the left
                formsPlot1.Plot.GetPlottables<Marker>()
                    .ToList()
                    .ForEach(m => m.X -= count);

                // remove off-screen marks
                formsPlot1.Plot.GetPlottables<Marker>()
                    .Where(m => m.X < 0)
                    .ToList()
                    .ForEach(m => formsPlot1.Plot.Remove(m));
            };

            int i = 0;
            // setup a timer to request a render periodically
            UpdatePlotTimer.Tick += (s, e) =>
            {
                
                if (Streamer1.HasNewData)
                {
                    Debug.WriteLine((Streamer1.Data.Data)[i]);
                    dataHandler.InsertTemperatureOne((Streamer1.Data.Data)[i]);
                    formsPlot1.Plot.Title($"Processed {Streamer1.Data.CountTotal:N0} points");
                    //VLine.IsVisible = Streamer1.Renderer is ScottPlot.DataViews.Wipe;
                    //VLine.Position = Streamer1.Data.NextIndex * Streamer1.Data.SamplePeriod + Streamer1.Data.OffsetX;
                    formsPlot1.Refresh();
                    i++;
                }
            };

            // setup configuration actions
            btnWipeRight.Click += (s, e) =>
            {
                Streamer1.ViewWipeRight(0.1);
                Streamer2.ViewWipeRight(0.1);
                btnMark.Visible = false;
                formsPlot1.Plot.Remove<Marker>();
            };

            btnScrollLeft.Click += (s, e) =>
            {
                Streamer1.ViewScrollLeft();
                Streamer2.ViewScrollLeft();
                btnMark.Visible = true;
            };

            btnMark.Click += (s, e) =>
            {
                double x1 = Streamer1.Count;
                double y1 = Streamer1.Data.NewestPoint;
                var marker1 = formsPlot1.Plot.Add.Marker(x1, y1);
                marker1.Size = 20;
                marker1.Shape = MarkerShape.OpenCircle;
                marker1.Color = Streamer1.LineColor;
                marker1.LineWidth = 2;

                double x2 = Streamer2.Count;
                double y2 = Streamer2.Data.NewestPoint;
                var marker2 = formsPlot1.Plot.Add.Marker(x2, y2);
                marker2.Size = 20;
                marker2.Shape = MarkerShape.OpenCircle;
                marker2.Color = Streamer2.LineColor;
                marker2.LineWidth = 2;
            };

            rbManage.CheckedChanged += (s, e) =>
            {
                bool manageAxisLimits = ((RadioButton)s!).Checked;

                if (manageAxisLimits)
                {
                    formsPlot1.Plot.Axes.ContinuouslyAutoscale = false;
                    Streamer1.ManageAxisLimits = true;
                    Streamer2.ManageAxisLimits = true;
                }
                else
                {
                    formsPlot1.Plot.Axes.ContinuouslyAutoscale = true;
                    Streamer1.ManageAxisLimits = false;
                    Streamer2.ManageAxisLimits = false;
                }
            };

            //FORMS PLOT 2
            Streamer3 = formsPlot2.Plot.Add.DataStreamer(1000);
            Streamer4 = formsPlot2.Plot.Add.DataStreamer(1000);
            //VLine2 = formsPlot2.Plot.Add.VerticalLine(0, 2, ScottPlot.Colors.Red);

     

            // only show marker button in scroll mode
            btnMark.Visible = false;

            // setup a timer to add data to the streamer periodically
            AddNewDataTimer.Tick += (s, e) =>
            {
                int count = 5;

                // add new sample data
                Streamer3.AddRange(Walker3.Next(count));
                Streamer4.AddRange(Walker4.Next(count));

                // slide marker to the left
                formsPlot2.Plot.GetPlottables<Marker>()
                    .ToList()
                    .ForEach(m => m.X -= count);

                // remove off-screen marks
                formsPlot2.Plot.GetPlottables<Marker>()
                    .Where(m => m.X < 0)
                    .ToList()
                    .ForEach(m => formsPlot2.Plot.Remove(m));
            };

            // setup a timer to request a render periodically
            UpdatePlotTimer.Tick += (s, e) =>
            {
                if (Streamer3.HasNewData)
                {
                    formsPlot2.Plot.Title($"Processed {Streamer3.Data.CountTotal:N0} points");
                    //VLine2.IsVisible = Streamer3.Renderer is ScottPlot.DataViews.Wipe;
                    //VLine2.Position = Streamer3.Data.NextIndex * Streamer3.Data.SamplePeriod + Streamer3.Data.OffsetX;
                    formsPlot2.Refresh();
                }
            };
        }

        private AxisLine? GetLineUnderMouse(float x, float y)
        {
            CoordinateRect rect = formsPlot1.Plot.GetCoordinateRect(x, y, radius: 10);

            foreach (AxisLine axLine in formsPlot1.Plot.GetPlottables<AxisLine>().Reverse())
            {
                if (axLine.IsUnderMouse(rect))
                    return axLine;
            }

            return null;
        }

        private AxisLine? GetLineUnderMouse2(float x, float y)
        {
            CoordinateRect rect = formsPlot2.Plot.GetCoordinateRect(x, y, radius: 10);

            foreach (AxisLine axLine in formsPlot2.Plot.GetPlottables<AxisLine>().Reverse())
            {
                if (axLine.IsUnderMouse(rect))
                    return axLine;
            }

            return null;
        }

        private void TestGraphWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
