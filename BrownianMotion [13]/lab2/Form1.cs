using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double nu = 0.01;
        private double sigma = 0.05;
        private double deltaT = 1.0;

        private double NormalDistribution(Random random)
        {
            //Бокс-Мюллер
            double u1 = 1 - random.NextDouble();
            double u2 = 1 - random.NextDouble();
            return Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
        }
        private double predictValue(double rate)
        {
            Random rand = new Random();
            double normalRandom = Math.Sqrt(deltaT) * NormalDistribution(rand);
            return rate * Math.Exp((nu - 0.5 * Math.Pow(sigma, 2)) * deltaT + sigma * normalRandom);
        }

        double Dollar, Euro;
        int y = 1;
        bool started = false;
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                if (!started)
                {
                    Dollar = Convert.ToDouble(inputDollar.Text);
                    Euro = Convert.ToDouble(inputEuro.Text);
                    chart1.Series[0].Points.AddXY(y, Dollar);
                    chart1.Series[1].Points.AddXY(y, Euro);
                    started = true;
                    
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dollar = predictValue(Dollar);
            Euro = predictValue(Euro);
            y++;
            chart1.Series[0].Points.AddXY(y, Dollar);
            chart1.Series[1].Points.AddXY(y, Euro);
        }
    }
}
