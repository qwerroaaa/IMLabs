using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Agents__14_
{
    public partial class Form1 : Form
    {
        public class Client
        {
            public int TimeNeed { get; set; }
            public string Name { get; set; }

            public Client()
            {
                Random rnd = new Random();
                TimeNeed = rnd.Next(1, 10);
                Name = "Client_" + rnd.Next(1, 1000).ToString();
            }
        }

        public class Operator
        {
            public bool IsAvailable { get; set; }
            public string Name { get; set; }
        }

        private Queue<Operator> availableOperators = new Queue<Operator>();
        private Queue<Client> clientQueue = new Queue<Client>();
        private Random random = new Random();
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = table;
            table.Columns.Add("Оператор", typeof(string));
            table.Columns.Add("Клиент", typeof(string));
        }

        bool started = false;

        private void StopStartButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                if (!started)
                {
                    started = true;
                }

                int NumbersOfOperator = int.Parse(textBox1.Text);
                availableOperators.Clear();

                for (int i = 0; i < NumbersOfOperator; i++)
                {
                    var op = new Operator { IsAvailable = true, Name = "Operator_" + i.ToString() };
                    availableOperators.Enqueue(op);
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Добавляем клиента в очередь
            if (Convert.ToBoolean(random.Next(0, 2)))
            {
                clientQueue.Enqueue(new Client());
                var numberofClients = Convert.ToInt32(NumberOfClientLabel.Text);
                numberofClients += 1;
                NumberOfClientLabel.Text = numberofClients.ToString();
                AssignClientToOperator();
            }
        }

        private void AssignClientToOperator()
        {
            if (clientQueue.Count > 0 && availableOperators.Count > 0)
            {
                Operator op = availableOperators.Dequeue();
                Client client = clientQueue.Dequeue();

                var numberofClients = Convert.ToInt32(NumberOfClientLabel.Text);
                numberofClients -= 1;
                NumberOfClientLabel.Text = numberofClients.ToString();

                // Добавляем строку с именами оператора и клиента в таблицу
                DataRow row = table.NewRow();
                row["Оператор"] = op.Name;
                row["Клиент"] = client.Name;
                table.Rows.Add(row);

                // Освобождаем оператора через определенное время
                Timer clientTimer = new Timer();
                clientTimer.Interval = client.TimeNeed * 350; // время в миллисекундах
                clientTimer.Tick += (s, args) =>
                {
                    op.IsAvailable = true;
                    availableOperators.Enqueue(op);
                    clientTimer.Stop();
                    clientTimer.Dispose();
                    table.Rows.Remove(row);
                    AssignClientToOperator(); // Проверяем, есть ли еще клиенты для назначения
                };
                clientTimer.Start();
            }
        }
    }
}
