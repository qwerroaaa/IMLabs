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
using System.Windows.Forms.DataVisualization.Charting;

namespace NormDis
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
        private Random random = new Random();
        private const double alpha = 0.05;

        private double NormCount(double x, double mean, double variance)
        {
            double firstPart = 1 / (variance * Math.Sqrt(2 * Math.PI));
            double exp = Math.Exp(-(Math.Pow((x - mean), 2)/(2*variance*variance)));
            double numberCount = firstPart * exp;
            return numberCount;
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            int N = int.Parse(comboBox1.Text);
            int K = int.Parse(StepNumber.Text);
            StepNumber.Text = K.ToString();

            double mean = double.Parse(MeanBox.Text);
            double variance = double.Parse(VarBox.Text);

            int[] statistic = new int[(int)K];
            double[] probArray = new double[(int)K];
            double[] normalDist = new double[(int)N];
            for (int i = 0; i < N; i+=2) 
            {
                double a1 = random.NextDouble();
                double a2 = random.NextDouble();

                // Применение Преобразования Бокса-Мюллера
                double z1 = Math.Sqrt(-2 * Math.Log(a1)) * Math.Cos(2 * Math.PI * a2);
                double z2 = Math.Sqrt(-2 * Math.Log(a1)) * Math.Sin(2 * Math.PI * a2);

                z1 = mean + Math.Sqrt(variance) * z1;
                z2 = mean + Math.Sqrt(variance) * z2;

                normalDist[i] = z1;
                if (i+1 < N) { normalDist[i+1] = z2; }
            }
            double min = normalDist.Min();
            double max = normalDist.Max();

            double step = (max - min)/K;

            for (int i = 0; i < N; i++)
            {
                int j = 0;
                while (j < K && normalDist[i] >= min + step * j)
                {
                    j++;
                }
                statistic[j - 1]++;
            }

            chart1.Series[0].Points.Clear();
            for (int i = 0; i < K; i++)
            {
                chart1.Series[0].Points.AddXY(i, statistic[i]);
            }

            double[] freqs = statistic.Select(interval => (double)interval / N).ToArray();

            double errorMean = 0;
            double errorVariance = 0;
            for (int i = 0; i < freqs.Count(); i++) 
            {
                errorMean += freqs[i] * (min + i * step);
                errorVariance += freqs[i] * Math.Pow(min + step * i, 2);
            }
            errorVariance = errorVariance - mean - mean;

            double ChiSquare = 0;
            for (int i = 0; i < K; i++)
            {
                double a = min + i * step;
                double b = min + (i + 1) * step;
                probArray[i] = (b - a) * NormCount((b + a) / 2, mean, variance);
            }

            for (int i = 0; i < statistic.Length; i++)
            {
                if (statistic[i] > 0)
                {
                    ChiSquare += (statistic[i] - N * probArray[i]) * (statistic[i] - N * probArray[i]) / (N * probArray[i]);
                }
            }

            int df = N - 1;
            double takeChiSquareValue = ChiSquared.InvCDF(df, 1 - alpha);
            MeanValue.Text = errorMean.ToString();
            VarValue.Text = errorVariance.ToString();
            ChiValue.Text = ChiSquare.ToString();
            ErrorMeanLabel.Text = $"{(Math.Abs(errorMean - mean) / mean) * 100}%";
            ErrorVarLabel.Text = $"{(Math.Abs(errorVariance - variance) / variance) * 100}%";
            if (ChiSquare > takeChiSquareValue)
            {
                ConcValue.Text = "Отвергаем";
            }
            else
            {
                ConcValue.Text = "Не отвергается";
            }
        }
    }
}
