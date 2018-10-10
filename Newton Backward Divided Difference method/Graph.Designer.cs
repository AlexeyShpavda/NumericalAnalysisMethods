namespace Newton_Backward_Divided_Difference_method
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
            this.NewtonPolynomial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.NewtonPolynomial)).BeginInit();
            this.SuspendLayout();
            // 
            // NewtonPolynomial
            // 
            chartArea1.Name = "ChartArea1";
            this.NewtonPolynomial.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.NewtonPolynomial.Legends.Add(legend1);
            this.NewtonPolynomial.Location = new System.Drawing.Point(12, 12);
            this.NewtonPolynomial.Name = "NewtonPolynomial";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Newton Backward divided difference formula";
            this.NewtonPolynomial.Series.Add(series1);
            this.NewtonPolynomial.Size = new System.Drawing.Size(776, 426);
            this.NewtonPolynomial.TabIndex = 0;
            this.NewtonPolynomial.Text = "Newton Polynomial";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewtonPolynomial);
            this.Name = "Graph";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NewtonPolynomial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart NewtonPolynomial;
    }
}

