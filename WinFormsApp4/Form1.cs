using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        Point startLocation;
        public Form1()
        {
            InitializeComponent();
            startLocation = CSharp.Location;
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello to WinForms", "Congratulation", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void ClickButton_MouseEnter(object sender, EventArgs e)
        {
            ClickButton.BackColor = Color.Cyan;
        }

        private void ClickButton_MouseLeave(object sender, EventArgs e)
        {
            ClickButton.BackColor = Color.Lime;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close window ?", "Qustion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CSharp.Location = new Point(CSharp.Location.X + 5, CSharp.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSharp.Location = new Point(CSharp.Location.X - 5, CSharp.Location.Y);

        }

        private void CSharp_Click(object sender, EventArgs e)
        {
            CSharp.Location = startLocation;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse Position : {e.X} : {e.Y}";
            Point mouse = e.Location;
            if( mouse.X >= CSharp.Left - 20 && mouse.X <= CSharp.Left + CSharp.Width + 20 )
            {
                if(mouse.X >= CSharp.Left + (CSharp.Width/2))
                {
                    CSharp.Left = CSharp.Left - 5;
                }
                else
                {
                    CSharp.Left = CSharp.Left + 5;
                }
            }
        }
    }
}
