using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Controls_Lists
{
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>(); 
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            orders.Add(new Order(rand.Next(1000)));
            orders.Add(new Order(rand.Next(1000)));
            orders.Add(new Order(rand.Next(1000)));
            orders.Add(new Order(rand.Next(1000)));
            orders.Add(new Order(rand.Next(1000)));

            //OrdersComboBox.Items.AddRange(orders.ToArray());
            //OrdersComboBox.DataSource = orders;
            UpdateOrdersComboBox();
        }
        private void UpdateOrdersComboBox()
        {
            OrdersComboBox.DataSource = null;
            OrdersComboBox.DataSource = orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text + "\n" + comboBox2.Text + "\n" + comboBox3.Text);
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if (OrdersComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an order from list");
                return;
            }

            Order ?selected = OrdersComboBox.SelectedItem as Order;
            MessageBox.Show(selected.ToString(), "Order details", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (OrdersComboBox.SelectedIndex == -1) return;

            orders.RemoveAt(OrdersComboBox.SelectedIndex);
            MessageBox.Show("Order was removed");
            UpdateOrdersComboBox();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            orders.Add(new Order(numericUpDown1.Value));
            MessageBox.Show("Order was added");
            UpdateOrdersComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No selected Item!");
                return;
            }
            while(listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string res = "---------- Selected Items---------\n";
                foreach (var item in listBox1.SelectedItems)
                {
                    res += item.ToString() + Environment.NewLine;
                }
                MessageBox.Show(res);
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
            }
        }
    }
}
