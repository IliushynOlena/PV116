using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_GuessNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Guess number";
            BackColor = Color.YellowGreen;
            ForeColor = Color.Blue;
            Size = new Size(1000, 1000);

            button1.Text = "Start";
            button1.BackColor = Color.Red;
            button1.Location = new Point(400, 400);
            button1.Size = new Size(200, 200);

            label1.Text = "Guess number. I try to guess..... ";
            label1.Location = new Point(250, 300);
            label1.Size = new Size(200, 100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberMin = 0;
            int numberMax = 1000;
            int quantity = 0;
            while (true)
            {
                quantity++;
                DialogResult res =  MessageBox.Show("Your number is more than " + ((numberMax + numberMin) / 2), "Guess number", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    numberMin = (numberMax + numberMin) / 2 + 1;
                }
                else
                {
                    numberMax = (numberMax + numberMin) / 2;
                }
                if (numberMax == numberMin) break;
            }
            MessageBox.Show("You guess " + numberMin + " Quantity = " + quantity, "Guess number", MessageBoxButtons.OK);
        }
    }
}
