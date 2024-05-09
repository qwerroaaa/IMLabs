using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8ballMagic__8._2_
{
    public partial class Form1 : Form
    {
        List<KeyValuePair<string, double>> pairs = new List<KeyValuePair<string, double>>()
            {
                new KeyValuePair<string, double>("Определенно да!", 0.2),
                new KeyValuePair<string, double>("Однозначно", 0.1),
                new KeyValuePair<string, double>("Да", 0.15),
                new KeyValuePair<string, double>("Не определено", 0.05),
                new KeyValuePair<string, double>("Вероятно", 0.1),
                new KeyValuePair<string, double>("Нет", 0.15),
                new KeyValuePair<string, double>("Неоднозначно", 0.15),
                new KeyValuePair<string, double>("Абсолютно нет!", 0.1)
            };
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

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
            Random random = new Random();
            double prob = random.NextDouble();

            foreach (var pair in pairs)
            {
                prob -= pair.Value;
                if (prob <= 0)
                {
                    AnswerLabel.Text = pair.Key;
                    break;
                }
            }
        }
    }
}
