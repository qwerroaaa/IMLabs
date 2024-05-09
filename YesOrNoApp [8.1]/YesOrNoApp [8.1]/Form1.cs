using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YesOrNoApp__8._1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] {
                "Пойти ли завтра на пару?",
                "Будет ли завтра дождь?",
                "Сделать ли лабораторную?",
                "Подешевеет ли гречка?",
                "Будет ли завтра выходной?",
                "Существует ли Бог?"
            });
            comboBox1.SelectedIndex = 0;
        }

        private void predictBtn_Click(object sender, EventArgs e)
        {
            YesLabel.Visible = false;
            NoLabel.Visible = false;
            Random random = new Random();
            double prob =  random.NextDouble();
            double p = 0.5;
            if (prob < p)
            {
                YesLabel.Visible = true;
                NoLabel.Visible = false;
            }
            else
            {
                NoLabel.Visible = true;
                YesLabel.Visible = false;
            }
        }
    }
}
