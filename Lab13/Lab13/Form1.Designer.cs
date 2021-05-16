
namespace Lab13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numericP1 = new System.Windows.Forms.NumericUpDown();
            this.lbInput = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.numericN = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelChi = new System.Windows.Forms.Label();
            this.labelVar = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericN)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericP1
            // 
            this.numericP1.Location = new System.Drawing.Point(56, 10);
            this.numericP1.Name = "numericP1";
            this.numericP1.Size = new System.Drawing.Size(47, 20);
            this.numericP1.TabIndex = 19;
            this.numericP1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(12, 12);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(36, 13);
            this.lbInput.TabIndex = 14;
            this.lbInput.Text = "param";
            // 
            // btCalculate
            // 
            this.btCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCalculate.Location = new System.Drawing.Point(16, 344);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(168, 94);
            this.btCalculate.TabIndex = 26;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = false;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // numericN
            // 
            this.numericN.Location = new System.Drawing.Point(127, 318);
            this.numericN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericN.Name = "numericN";
            this.numericN.Size = new System.Drawing.Size(57, 20);
            this.numericN.TabIndex = 25;
            this.numericN.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Number of experiments:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericP1);
            this.panel1.Controls.Add(this.lbInput);
            this.panel1.Controls.Add(this.btCalculate);
            this.panel1.Controls.Add(this.numericN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 27;
            // 
            // chart1
            // 
            chartArea2.AxisX.Maximum = 20D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(206, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(582, 355);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = " ";
            // 
            // labelChi
            // 
            this.labelChi.AutoSize = true;
            this.labelChi.Location = new System.Drawing.Point(454, 383);
            this.labelChi.Name = "labelChi";
            this.labelChi.Size = new System.Drawing.Size(78, 13);
            this.labelChi.TabIndex = 45;
            this.labelChi.Text = "Chi-squared:    ";
            // 
            // labelVar
            // 
            this.labelVar.AutoSize = true;
            this.labelVar.Location = new System.Drawing.Point(241, 409);
            this.labelVar.Name = "labelVar";
            this.labelVar.Size = new System.Drawing.Size(55, 13);
            this.labelVar.TabIndex = 44;
            this.labelVar.Text = "Variance: ";
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(241, 383);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(53, 13);
            this.labelAvg.TabIndex = 43;
            this.labelAvg.Text = "Average: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelChi);
            this.Controls.Add(this.labelVar);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericP1;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.NumericUpDown numericN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelChi;
        private System.Windows.Forms.Label labelVar;
        private System.Windows.Forms.Label labelAvg;
    }
}

