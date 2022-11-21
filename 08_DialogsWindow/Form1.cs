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

namespace _08_DialogsWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if( color.ShowDialog() == DialogResult.OK )
            {
                this.BackColor = color.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog() == DialogResult.OK )
            {
                var selected = font.Font;

                button1.Font = selected;
                button2.Font = selected;
                button3.Font = selected;
                button4.Font = selected;
                button5.Font = selected;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt||";
            open.FilterIndex = 2;

            if(open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(open.FileName);
                textBox1.Text =  reader.ReadToEnd();
                reader.Close();                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.CreatePrompt = true;
            save.DefaultExt = ".txt";
            save.OverwritePrompt = true;

            if(save.ShowDialog()== DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(textBox1.Text);
                writer.Close();
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.Desktop;

            if (folder.ShowDialog()== DialogResult.OK)
            {
                listBox1.Items.Clear();

                foreach (var item in Directory.GetFiles(folder.SelectedPath))
                {
                    listBox1.Items.Add(Path.GetFileName(item));
                } 

            }
        }
    }
}
