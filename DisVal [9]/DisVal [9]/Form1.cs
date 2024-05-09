using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DisVal__9_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                chart1.Series[0].Points.AddXY($"Событие {i + 1}", (double)statistics[i] / N);
            }
            double average = 0;
            double variance = 0;
            double ChiSquare = 0;
            for (int i = 0; i < probArray.Length; i++)
            {
                average += i * ((double)statistics[i] / N);
                variance += i * i * ((double)statistics[i] / N);
                if (statistics[i] > 0) 
                {
                    ChiSquare += (statistics[i] - N * probArray[i]) * (statistics[i] - N * probArray[i]) / (N * probArray[i]);
                }
            }
            variance -= average * average;

            meanLabel.Text = average.ToString();
            varLabel.Text = variance.ToString();
            ChiLabel.Text = ChiSquare.ToString();

            double relError = Math.Abs((average - probArray.Sum()) / probArray.Sum());
            relErrorLabel.Text = relError.ToString();
            double varError =Math.Abs((variance - probArray.Sum(p => p * p)) / probArray.Sum(p => p * p));
            VarErrorLabel.Text = varError.ToString();

            double alpha = 0.05;
            int df = probArray.Length - 1;
            double takeChiSquareValue = ChiSquared.InvCDF(df, 1 - alpha);
            fromfunc.Text = takeChiSquareValue.ToString();
            if (ChiSquare > takeChiSquareValue)
            {
                otvergaem.Text = "Отвергаем";
                otvergaem.Visible = true;
                prinimaem.Visible = false;
            } 
            else
            {
                prinimaem.Text = "Не отвергается";
                prinimaem.Visible = true;
                otvergaem.Visible = false;
            }
        }
    }
}
