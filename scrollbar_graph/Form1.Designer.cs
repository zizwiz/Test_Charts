namespace scrollbar_graph
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_zoom = new System.Windows.Forms.Button();
            this.txtbx_min = new System.Windows.Forms.TextBox();
            this.txtbx_max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_min_value = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_max_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 365);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(679, 398);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 38);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.Location = new System.Drawing.Point(12, 388);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(108, 38);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "Fill";
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_zoom
            // 
            this.btn_zoom.Location = new System.Drawing.Point(246, 398);
            this.btn_zoom.Name = "btn_zoom";
            this.btn_zoom.Size = new System.Drawing.Size(108, 38);
            this.btn_zoom.TabIndex = 3;
            this.btn_zoom.Text = "Show";
            this.btn_zoom.UseVisualStyleBackColor = true;
            this.btn_zoom.Click += new System.EventHandler(this.btn_zoom_Click);
            // 
            // txtbx_min
            // 
            this.txtbx_min.Location = new System.Drawing.Point(360, 406);
            this.txtbx_min.Name = "txtbx_min";
            this.txtbx_min.Size = new System.Drawing.Size(67, 22);
            this.txtbx_min.TabIndex = 4;
            this.txtbx_min.Text = "0";
            this.txtbx_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbx_max
            // 
            this.txtbx_max.Location = new System.Drawing.Point(459, 406);
            this.txtbx_max.Name = "txtbx_max";
            this.txtbx_max.Size = new System.Drawing.Size(67, 22);
            this.txtbx_max.TabIndex = 5;
            this.txtbx_max.Text = "100";
            this.txtbx_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Draw with mouse to ZOOM";
            // 
            // lbl_min_value
            // 
            this.lbl_min_value.AutoSize = true;
            this.lbl_min_value.Location = new System.Drawing.Point(676, 453);
            this.lbl_min_value.Name = "lbl_min_value";
            this.lbl_min_value.Size = new System.Drawing.Size(42, 17);
            this.lbl_min_value.TabIndex = 8;
            this.lbl_min_value.Text = "value";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(12, 432);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(108, 38);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // lbl_max_value
            // 
            this.lbl_max_value.AutoSize = true;
            this.lbl_max_value.Location = new System.Drawing.Point(746, 453);
            this.lbl_max_value.Name = "lbl_max_value";
            this.lbl_max_value.Size = new System.Drawing.Size(42, 17);
            this.lbl_max_value.TabIndex = 10;
            this.lbl_max_value.Text = "value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.lbl_max_value);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_min_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_max);
            this.Controls.Add(this.txtbx_min);
            this.Controls.Add(this.btn_zoom);
            this.Controls.Add(this.btn_fill);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Chart Test";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_zoom;
        private System.Windows.Forms.TextBox txtbx_min;
        private System.Windows.Forms.TextBox txtbx_max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_min_value;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_max_value;
    }
}

