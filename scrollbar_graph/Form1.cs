using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace scrollbar_graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            int blockSize = 100; //number of points in x-axis

            // generates random data (i.e. 30 * blockSize random numbers)
            Random rand = new Random();
            var valuesArray = Enumerable.Range(0, blockSize * 30).Select(x => rand.Next(1, 10)).ToArray();

            // clear the chart
            chart1.Series.Clear();

            Series series = chart1.Series.Add("");
            ChartArea ca = chart1.ChartAreas[series.ChartArea];  // get hold of chart

            //type of chart
            series.ChartType = SeriesChartType.FastLine;  //not sure why I need this but if not I get bar chart


            //Populate with the random data we made
            for (int i = 0; i < valuesArray.Length; i++)
                series.Points.AddXY(i, valuesArray[i]);
            

            // set view range to [0,max]
            ca.AxisX.Minimum = 0;
            ca.AxisX.Maximum = valuesArray.Length;

            // enable autoscroll
            ca.AxisX.ScaleView.Zoomable = true;
            ca.CursorX.AutoScroll = true;
            ca.CursorX.IsUserSelectionEnabled = true; //adds reset button on left

            // Zoom to first 100 x-axis points
            ca.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            int position = 0;
            int size = blockSize; //adjust this to show how many are first shown
            ca.AxisX.ScaleView.Zoom(position, size);

            // We show the reset button on left of the scroll bars but if you want to not show it then you can
            // disable it as shown commented out below 
            //chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll; //remove reset button

            // set scrollbar small change to blockSize (e.g. 100)
            ca.AxisX.ScaleView.SmallScrollSize = blockSize;

            chart1.Legends.Clear(); //remove all legends

            GC.Collect(); //Cleanup in case of memory leak.
        }

        private void btn_zoom_Click(object sender, EventArgs e)
        {
            double min_val = double.Parse(txtbx_min.Text) + 1; //Zero based
            double max_val = double.Parse(txtbx_max.Text) + 1; //Zero based


            ChartArea ca = chart1.ChartAreas[0];

            // Just putting Min and Max in order in case user added incorrectly
            ca.AxisX.ScaleView.Zoom(Math.Min(min_val, max_val), Math.Max(min_val, max_val));
            GC.Collect();
        }

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            ChartArea ca = chart1.ChartAreas[0];

            lbl_min_value.Text = ca.AxisX.Minimum.ToString();
            lbl_max_value.Text = ca.AxisX.Maximum.ToString();

            // lbl_min_value.Text = e.X.ToString();
        }
    }
}
