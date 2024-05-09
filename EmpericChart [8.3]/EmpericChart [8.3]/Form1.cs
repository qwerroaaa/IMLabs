using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EmpericChart__8._3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConclusionLabel.Visible = false;
            textCon.Visible = false;
            comboBox1.Items.AddRange(new string[] {
                "10",
                "100",
                "1000",
                "10000"
            });

            comboBox1.SelectedIndex = 0;
        }
        private Random rand = new Random();
        private double[] probArray = new double[5]; 
        private void StartButton_Click(object sender, EventArgs e)
        {
            ConclusionLabel.Visible = false;
            textCon.Visible = false;
            probArray[0] = double.Parse(textBox1.Text);
            probArray[1] = double.Parse(textBox2.Text);
            probArray[2] = double.Parse(textBox3.Text);
            probArray[3] = double.Parse(textBox4.Text);
            probArray[4] = 1 - (probArray[0] + probArray[1] + probArray[2] + probArray[3]);
            if (probArray[4] < 0)
            {
                MessageBox.Show("Сумма ваших вероятностей превышает 1");
                return;
            }
            textBox5.Text = probArray[4].ToString();

            int N = int.Parse(comboBox1.Text);
            int[] statistics = new int[probArray.Length];

            for (int i = 0; i < N; i++)
            {
                double randNum = rand.NextDouble();
                for (int j = 0; j < probArray.Length; j++)
                {
                    randNum -= probArray[j];
                    if (randNum <= 0)
                    {
                        statistics[j]++;
                        break;
                    }
                }
            }
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < probArray.Length; i++) 
            {
                chart1.Series[0].Points.AddXY($"Событие {i+1}", (double)statistics[i] / N);
            }
            ConclusionLabel.Visible = true;
            textCon.Visible = true;
        }
    }
}
