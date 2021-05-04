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
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_num_points = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_overall_points = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseUp);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(679, 383);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 87);
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
            this.btn_fill.Text = "Refill";
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_zoom
            // 
            this.btn_zoom.Location = new System.Drawing.Point(12, 11);
            this.btn_zoom.Name = "btn_zoom";
            this.btn_zoom.Size = new System.Drawing.Size(79, 38);
            this.btn_zoom.TabIndex = 3;
            this.btn_zoom.Text = "Show";
            this.btn_zoom.UseVisualStyleBackColor = true;
            this.btn_zoom.Click += new System.EventHandler(this.btn_zoom_Click);
            // 
            // txtbx_min
            // 
            this.txtbx_min.Location = new System.Drawing.Point(97, 19);
            this.txtbx_min.MaxLength = 4;
            this.txtbx_min.Name = "txtbx_min";
            this.txtbx_min.Size = new System.Drawing.Size(67, 22);
            this.txtbx_min.TabIndex = 4;
            this.txtbx_min.Text = "0";
            this.txtbx_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbx_max
            // 
            this.txtbx_max.Location = new System.Drawing.Point(196, 19);
            this.txtbx_max.MaxLength = 4;
            this.txtbx_max.Name = "txtbx_max";
            this.txtbx_max.Size = new System.Drawing.Size(67, 22);
            this.txtbx_max.TabIndex = 5;
            this.txtbx_max.Text = "100";
            this.txtbx_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Draw with mouse to ZOOM";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbx_max);
            this.groupBox1.Controls.Add(this.txtbx_min);
            this.groupBox1.Controls.Add(this.btn_zoom);
            this.groupBox1.Location = new System.Drawing.Point(155, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 87);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "# x-axis Points";
            // 
            // txtbx_num_points
            // 
            this.txtbx_num_points.Location = new System.Drawing.Point(117, 22);
            this.txtbx_num_points.MaxLength = 4;
            this.txtbx_num_points.Name = "txtbx_num_points";
            this.txtbx_num_points.Size = new System.Drawing.Size(67, 22);
            this.txtbx_num_points.TabIndex = 8;
            this.txtbx_num_points.Text = "100";
            this.txtbx_num_points.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "# Overall Points";
            // 
            // txtbx_overall_points
            // 
            this.txtbx_overall_points.Location = new System.Drawing.Point(117, 50);
            this.txtbx_overall_points.MaxLength = 4;
            this.txtbx_overall_points.Name = "txtbx_overall_points";
            this.txtbx_overall_points.Size = new System.Drawing.Size(67, 22);
            this.txtbx_overall_points.TabIndex = 11;
            this.txtbx_overall_points.Text = "3000";
            this.txtbx_overall_points.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbx_overall_points);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbx_num_points);
            this.groupBox2.Location = new System.Drawing.Point(453, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 86);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "x-Axis points";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_fill);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Chart Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_num_points;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_overall_points;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

