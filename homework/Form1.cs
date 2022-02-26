using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace homework
{
    public partial class Form1 : Form
    {
        public EventHandler<EventArgs> ItemAdd;

        public Form1()
        {
            InitializeComponent();
            ItemAdd += ListBoxItemAdded;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var snacks1 = new List<Snack>()
            {
                new Snack("Snickers", "https://cdn-icons.flaticon.com/png/512/2589/premium/2589100.png?token=exp=1645907159~hmac=a0a9a5506b797b467b06ef10a6b6f52d", 0.90),
                new Snack("Bounty", "https://cdn-icons.flaticon.com/png/512/1912/premium/1912744.png?token=exp=1645907162~hmac=0eeedbfbde9577555c3cab9f30c47023", 1.00),
                new Snack("Chips", "https://cdn-icons.flaticon.com/png/512/2137/premium/2137628.png?token=exp=1645907213~hmac=3b5a1c500c784d1dd83798b089374bbb", 1.50),
                new Snack("Coca-Cola", "https://cdn-icons-png.flaticon.com/512/1149/1149810.png", 2.00),
            };

            int x = 40, y = 20, index = default;
            var random = new Random();

            for (int i = 0; i < snacks1.Count / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    snacks.Controls.Add(new SnackBox(snacks1[index++], random.Next(50, 100), this) { Location = new Point(x, y) });
                    x += 250;
                }
                y += 210;
                x -= 250 * 2;
            }

            if (snacks1.Count % 2 != 0)
                snacks.Controls.Add(new SnackBox(snacks1[index++], random.Next(50, 100), this) { Location = new Point(x, y) });

            if (!Directory.Exists("Customers")) Directory.CreateDirectory("Customers");

            if (File.Exists("snacks.json"))
            {
                var snackCount = JsonConvert.DeserializeObject<List<int>>(File.ReadAllText("snacks.json"));
                int temp = default;

                foreach (SnackBox snackBox in snacks.Controls)
                {
                    foreach (var secondItem in snackBox.Controls)
                    {
                        if (secondItem is RadioButton count)
                        {
                            count.Text = snackCount[temp++].ToString();
                            break;
                        }
                    }
                }
            }
            else SnackSave();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is null) MessageBox.Show("you have not selected any snack!", "Invalid Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                foreach (SnackBox snackBox in snacks.Controls)
                {
                    RadioButton count = null;

                    foreach (var item in snackBox.Controls)
                    {
                        if (item is Label l)
                        {
                            if (l.Text == (listBox1.SelectedItem as Snack)?.Name)
                                count.Text = (int.Parse(count.Text) + 1).ToString();
                        }
                        if (item is RadioButton rb) count = rb;
                    }
                }

                listBox1.Items.Remove(listBox1.SelectedItem);
                ItemAdd.Invoke(this, null);
                SnackSave();
            }
        }

        private void ListBoxItemAdded(object sender, EventArgs e)
        {
            double currentMoney = Convert.ToDouble(numericUpDown1.Value), sumPrice = default;

            foreach (Snack snack in listBox1.Items) sumPrice += snack.Price;

            textBox1.Text = sumPrice.ToString();
            textBox2.Text = (currentMoney - sumPrice).ToString();

            button1.Enabled = (currentMoney - sumPrice >= 0) ? true : false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customer = new BuyInfo(numericUpDown1.Value, double.Parse(textBox2.Text));
            foreach (Snack snack in listBox1.Items) customer.Snacks.Add(snack.Name);

            listBox1.Items.Clear();
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            numericUpDown1.Value = default;
            button1.Enabled = false;

            File.WriteAllText(Directory.GetCurrentDirectory() + @"\Customers\" + customer.Time.ToShortDateString().Replace('/', '.') + ".json", JsonConvert.SerializeObject(customer, Formatting.Indented));
            MessageBox.Show($"Purchase was successfully\nRest Money: {customer.RestMoney}", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                numericUpDown1.Value += Convert.ToDecimal(btn.Text.Split()[0]);
            }
        }

        public void SnackSave()
        {
            var snackCount = new List<int>();

            foreach (SnackBox snackBox in snacks.Controls) snackCount.Add(int.Parse(snackBox.count.Text));

            var jsonStr = JsonConvert.SerializeObject(snackCount, Formatting.Indented);
            File.WriteAllText("snacks.json", jsonStr);
        }
    }
}
