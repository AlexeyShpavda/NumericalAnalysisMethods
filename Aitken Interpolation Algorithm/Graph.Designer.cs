namespace Aitken_Interpolation_Algorithm
{
    partial class Graph
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
            this.AitkenInterpolation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.AitkenInterpolation)).BeginInit();
            this.SuspendLayout();
            // 
            // AitkenInterpolation
            // 
            chartArea1.Name = "ChartArea1";
            this.AitkenInterpolation.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.AitkenInterpolation.Legends.Add(legend1);
            this.AitkenInterpolation.Location = new System.Drawing.Point(12, 12);
            this.AitkenInterpolation.Name = "AitkenInterpolation";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aitken Scheme";
            this.AitkenInterpolation.Series.Add(series1);
            this.AitkenInterpolation.Size = new System.Drawing.Size(776, 426);
            this.AitkenInterpolation.TabIndex = 0;
            this.AitkenInterpolation.Text = "Aitken Interpolation";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AitkenInterpolation);
            this.Name = "Graph";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AitkenInterpolation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart AitkenInterpolation;
    }
}

