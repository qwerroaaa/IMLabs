namespace NormDis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MeanBox = new System.Windows.Forms.TextBox();
            this.VarBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StepNumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.MeanValue = new System.Windows.Forms.Label();
            this.VarValue = new System.Windows.Forms.Label();
            this.ChiValue = new System.Windows.Forms.Label();
            this.ConcValue = new System.Windows.Forms.Label();
            this.ErrorMeanLabel = new System.Windows.Forms.Label();
            this.ErrorVarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(338, 49);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(687, 505);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите значения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Среднее:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дисперсия:";
            // 
            // MeanBox
            // 
            this.MeanBox.Location = new System.Drawing.Point(119, 87);
            this.MeanBox.Name = "MeanBox";
            this.MeanBox.Size = new System.Drawing.Size(100, 20);
            this.MeanBox.TabIndex = 4;
            this.MeanBox.Text = "0";
            // 
            // VarBox
            // 
            this.VarBox.Location = new System.Drawing.Point(119, 118);
            this.VarBox.Name = "VarBox";
            this.VarBox.Size = new System.Drawing.Size(100, 20);
            this.VarBox.TabIndex = 5;
            this.VarBox.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Размер выборки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Число интервалов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Выборочное среднее:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Выборочная дисперсия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Хи-квадрат:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Вывод:";
            // 
            // StepNumber
            // 
            this.StepNumber.Location = new System.Drawing.Point(119, 180);
            this.StepNumber.Name = "StepNumber";
            this.StepNumber.Size = new System.Drawing.Size(100, 20);
            this.StepNumber.TabIndex = 12;
            this.StepNumber.Text = "5";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.StartBtn.Location = new System.Drawing.Point(118, 459);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(96, 43);
            this.StartBtn.TabIndex = 14;
            this.StartBtn.Text = "Начать";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MeanValue
            // 
            this.MeanValue.AutoSize = true;
            this.MeanValue.Location = new System.Drawing.Point(136, 257);
            this.MeanValue.Name = "MeanValue";
            this.MeanValue.Size = new System.Drawing.Size(0, 13);
            this.MeanValue.TabIndex = 15;
            // 
            // VarValue
            // 
            this.VarValue.AutoSize = true;
            this.VarValue.Location = new System.Drawing.Point(148, 288);
            this.VarValue.Name = "VarValue";
            this.VarValue.Size = new System.Drawing.Size(0, 13);
            this.VarValue.TabIndex = 16;
            // 
            // ChiValue
            // 
            this.ChiValue.AutoSize = true;
            this.ChiValue.Location = new System.Drawing.Point(98, 319);
            this.ChiValue.Name = "ChiValue";
            this.ChiValue.Size = new System.Drawing.Size(0, 13);
            this.ChiValue.TabIndex = 17;
            // 
            // ConcValue
            // 
            this.ConcValue.AutoSize = true;
            this.ConcValue.Location = new System.Drawing.Point(79, 347);
            this.ConcValue.Name = "ConcValue";
            this.ConcValue.Size = new System.Drawing.Size(0, 13);
            this.ConcValue.TabIndex = 18;
            // 
            // ErrorMeanLabel
            // 
            this.ErrorMeanLabel.AutoSize = true;
            this.ErrorMeanLabel.Location = new System.Drawing.Point(268, 257);
            this.ErrorMeanLabel.Name = "ErrorMeanLabel";
            this.ErrorMeanLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorMeanLabel.TabIndex = 19;
            // 
            // ErrorVarLabel
            // 
            this.ErrorVarLabel.AutoSize = true;
            this.ErrorVarLabel.Location = new System.Drawing.Point(268, 288);
            this.ErrorVarLabel.Name = "ErrorVarLabel";
            this.ErrorVarLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorVarLabel.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 566);
            this.Controls.Add(this.ErrorVarLabel);
            this.Controls.Add(this.ErrorMeanLabel);
            this.Controls.Add(this.ConcValue);
            this.Controls.Add(this.ChiValue);
            this.Controls.Add(this.VarValue);
            this.Controls.Add(this.MeanValue);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.StepNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VarBox);
            this.Controls.Add(this.MeanBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MeanBox;
        private System.Windows.Forms.TextBox VarBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StepNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label MeanValue;
        private System.Windows.Forms.Label VarValue;
        private System.Windows.Forms.Label ChiValue;
        private System.Windows.Forms.Label ConcValue;
        private System.Windows.Forms.Label ErrorMeanLabel;
        private System.Windows.Forms.Label ErrorVarLabel;
    }
}

