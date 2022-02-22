
namespace _2Лабораторная
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.edEuro = new System.Windows.Forms.NumericUpDown();
            this.edDollar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial price:";
            // 
            // edEuro
            // 
            this.edEuro.DecimalPlaces = 4;
            this.edEuro.Location = new System.Drawing.Point(169, 27);
            this.edEuro.Name = "edEuro";
            this.edEuro.Size = new System.Drawing.Size(137, 22);
            this.edEuro.TabIndex = 1;
            this.edEuro.Value = new decimal(new int[] {
            730738,
            0,
            0,
            262144});
            // 
            // edDollar
            // 
            this.edDollar.DecimalPlaces = 4;
            this.edDollar.Location = new System.Drawing.Point(419, 27);
            this.edDollar.Name = "edDollar";
            this.edDollar.Size = new System.Drawing.Size(137, 22);
            this.edDollar.TabIndex = 2;
            this.edDollar.Value = new decimal(new int[] {
            711012,
            0,
            0,
            262144});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dollar";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(615, 24);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(114, 26);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.edDollar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.edEuro);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 83);
            this.panel1.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 60D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 89);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "C";
            series3.Legend = "Legend1";
            series3.Name = "Euro";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "C";
            series4.Legend = "Legend1";
            series4.Name = "Dollar";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(914, 349);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(768, 24);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(113, 26);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edEuro;
        private System.Windows.Forms.NumericUpDown edDollar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btStop;
    }
}

