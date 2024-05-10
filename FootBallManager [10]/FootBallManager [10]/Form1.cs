using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBallManager__10_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double GermanyLambda = -2.2;
        const double BelarusaLambda = -2.3;
        const double LatviaLambda = -2;
        const double IrelandLambda = -2.3;
        const double NetherLandLambda = -2.1;
        const double NorwayLambda = -2;
        const double RussiaLambda = -2.2;
        const double SwitherLandLambda = -2.4;

        public int GetScore(double lambda) //Пуассон
        {
            Random random = new Random();
            double S = 0;
            int score = 0;
            while (S >= lambda)
            {
                S += Math.Log(random.NextDouble());
                score++;
            }

            return score;
        }

        private double PlayMatch(double lambdaTeam1, double lambdaTeam2, PictureBox team1, PictureBox team2, PictureBox winner, Label text1, Label text2)
        {
            int team1Score = GetScore(lambdaTeam1);
            int team2Score = GetScore(lambdaTeam2);
            double winlambda = 0;
            while (team1Score == team2Score)
            {
                team1Score = GetScore(lambdaTeam1);
                team2Score = GetScore(lambdaTeam2);
            }
            text1.Text = team1Score.ToString();
            text2.Text = team2Score.ToString();
            if (team1Score > team2Score)
            {
                winner.Image = team1.Image;
                winlambda = lambdaTeam1;
            } else
            {
                winner.Image = team2.Image;
                winlambda = lambdaTeam2;
            }

            return winlambda;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            double quamatch1 = PlayMatch(GermanyLambda, BelarusaLambda, team1Box, team2Box, pf1, label5, label6);
            double quamatch2 = PlayMatch(LatviaLambda, IrelandLambda, team3Box, team4Box, pf2, label7, label8);
            double quamatch3 = PlayMatch(NetherLandLambda, NorwayLambda, team5Box, team6Box, pf3, label9, label10);
            double quamatch4 = PlayMatch(RussiaLambda, SwitherLandLambda, team7Box, team8Box, pf4, label11, label12);

            double semimatch1 = PlayMatch(quamatch1, quamatch2, pf1, pf2, finalBox1, label15, label16);
            double semimatch2 = PlayMatch(quamatch3, quamatch4, pf3, pf4, finalBox2, label13, label14);

            double final = PlayMatch(semimatch1, semimatch2, finalBox1, finalBox2, pictureBox1, label17, label18);
        }
    }
}
