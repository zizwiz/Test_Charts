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

        private void Form1_Load(object sender, EventArgs e)
        {
            FillChart();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            FillChart();
        }

        private void FillChart()
        {
            int blockSize = int.Parse(txtbx_num_points.Text); //number of points in x-axis

            // generates random data (i.e. numBlocks * blockSize random numbers)
            Random rand = new Random();
            var valuesArray = Enumerable.Range(0, int.Parse(txtbx_overall_points.Text)).Select(x => rand.Next(1, 10)).ToArray();

            // clear the chart
            chart1.Series.Clear();

            Series series = chart1.Series.Add("");
            ChartArea ca = chart1.ChartAreas[series.ChartArea]; // get hold of chart

            //type of chart
            series.ChartType = SeriesChartType.FastLine; //not sure why I need this but if not I get bar chart

            
            //Populate with the random data we made
            for (int i = 0; i < valuesArray.Length; i++)
            {
                series.Points.AddXY(i, valuesArray[i]);
            }
            
            // set view range to [0,max]
            ca.AxisX.Minimum = 0;
            ca.AxisX.Maximum = valuesArray.Length;

            // enable autoscroll
            ca.AxisX.ScaleView.Zoomable = true;
            ca.CursorX.AutoScroll = true;
            ca.CursorX.IsUserSelectionEnabled = true; //adds reset button on left


            // Zoom to first 100 x-axis points
            ca.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            ca.AxisX.ScaleView.Zoom(0, blockSize-1);


            // We show the reset button on left of the scroll bars but if you want to not show it then you can
            // disable it as shown commented out below 
            //chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll; //remove reset button

            // set scrollbar small change to blockSize (e.g. 100)
            ca.AxisX.ScaleView.SmallScrollSize = blockSize;

            chart1.Legends.Clear(); //remove all legends

            txtbx_min.Text = "0";
            txtbx_max.Text = blockSize.ToString();
            
            GC.Collect(); //Cleanup in case of memory leak.
        }

        private void btn_zoom_Click(object sender, EventArgs e)
        {
            double min_val = double.Parse(txtbx_min.Text); //Zero based
            double max_val = double.Parse(txtbx_max.Text); //Zero based

           ChartArea ca = chart1.ChartAreas[0];

            // Just putting Min and Max in order in case user added incorrectly
            ca.AxisX.ScaleView.Zoom((Math.Min(min_val, max_val)+1), (Math.Max(min_val, max_val)-1));

            txtbx_min.Text = (Math.Min(min_val, max_val)).ToString();
            txtbx_max.Text = (Math.Max(min_val, max_val)).ToString();

            GC.Collect();
        }


        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            Axis ax = chart1.ChartAreas[0].AxisX;

            txtbx_min.Text = ((ax.ScaleView.ViewMinimum)+1).ToString();
            txtbx_max.Text = ((ax.ScaleView.ViewMaximum)-1).ToString();
        }
    }
}
