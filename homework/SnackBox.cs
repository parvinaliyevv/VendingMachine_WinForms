using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class SnackBox : UserControl
    {
        public Form1 reference { get; set; }

        public SnackBox(Snack snack, int count, Form1 listbox)
        {
            InitializeComponent();

            this.name.Text = snack.Name;
            this.image.LoadAsync(snack.Url);
            this.price.Text = snack.Price.ToString() + " AZN";
            this.count.Text = count.ToString();
            reference = listbox;
        }

        private void SnackBox_Click(object sender, EventArgs e)
        {
            var snack = new Snack
            {
                Name = name.Text,
                Price = double.Parse(price.Text.Split()[0])
            };
            count.Text = (int.Parse(count.Text) - 1).ToString();

            reference.listBox1.Items.Add(snack);
            reference.ItemAdd.Invoke(this, null);
            reference.SnackSave();
        }
    }
}
