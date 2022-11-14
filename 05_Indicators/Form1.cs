﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTimer = System.Windows.Forms.Timer;

namespace _05_Indicators
{
    public partial class Form1 : Form
    {
        MyTimer timer = null;
        public Form1()
        {
         
            InitializeComponent();
            timer = new MyTimer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            UpdateColor();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;
            else
                progressBar1.Value++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 50;
            progressBar1.Step = 1;

            for (int i = 0; i <= 50; i++)
            {
                progressBar1.PerformStep();
                label1.Text = "Value = " + progressBar1.Value.ToString();
                this.Update();
                Thread.Sleep(50);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            decimal max = numericUpDown1.Value > progressBar1.Maximum ?
                progressBar1.Maximum : numericUpDown1.Value;
            progressBar1.Style = ProgressBarStyle.Blocks;
            while (progressBar1.Value < max)
            {
                progressBar1.Value++;
                progressBar1.Update();
                Thread.Sleep(50);
            }
            progressBar1.Style = ProgressBarStyle.Marquee;

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void UpdateColor()
        {
            Color c = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.BackColor = c;
            button1.BackColor = c;
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBar4.Value / 100.0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
