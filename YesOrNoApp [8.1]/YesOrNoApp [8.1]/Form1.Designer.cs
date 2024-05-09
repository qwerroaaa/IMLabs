namespace YesOrNoApp__8._1_
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
            this.predictBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NoLabel = new System.Windows.Forms.Label();
            this.YesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // predictBtn
            // 
            this.predictBtn.Location = new System.Drawing.Point(249, 152);
            this.predictBtn.Name = "predictBtn";
            this.predictBtn.Size = new System.Drawing.Size(123, 25);
            this.predictBtn.TabIndex = 0;
            this.predictBtn.Text = "Спрогнозировать";
            this.predictBtn.UseVisualStyleBackColor = true;
            this.predictBtn.Click += new System.EventHandler(this.predictBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(122, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите вас интересующий вопрос";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(383, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // NoLabel
            // 
            this.NoLabel.AutoSize = true;
            this.NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.NoLabel.ForeColor = System.Drawing.Color.Red;
            this.NoLabel.Location = new System.Drawing.Point(283, 219);
            this.NoLabel.Name = "NoLabel";
            this.NoLabel.Size = new System.Drawing.Size(50, 26);
            this.NoLabel.TabIndex = 3;
            this.NoLabel.Text = "Нет";
            this.NoLabel.Visible = false;
            // 
            // YesLabel
            // 
            this.YesLabel.AutoSize = true;
            this.YesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.YesLabel.ForeColor = System.Drawing.Color.Green;
            this.YesLabel.Location = new System.Drawing.Point(283, 219);
            this.YesLabel.Name = "YesLabel";
            this.YesLabel.Size = new System.Drawing.Size(41, 26);
            this.YesLabel.TabIndex = 4;
            this.YesLabel.Text = "Да";
            this.YesLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 349);
            this.Controls.Add(this.YesLabel);
            this.Controls.Add(this.NoLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predictBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button predictBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label NoLabel;
        private System.Windows.Forms.Label YesLabel;
    }
}

