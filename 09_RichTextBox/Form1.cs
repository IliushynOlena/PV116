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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _09_RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(FontFamily.GenericMonospace, 15, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.GreenYellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionRightIndent++;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = checkBox1.Checked;
        }
        public string DecktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(DecktopPath + @"\DOCFile.rtf", RichTextBoxStreamType.RichText);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(DecktopPath + @"\DOCFile.rtf", RichTextBoxStreamType.RichText);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Green;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (greenToolStripMenuItem.Checked == true)
                BackColor = Color.Green;
            else
                BackColor = Color.LightGray;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.CreatePrompt = true;
            save.DefaultExt = ".rtf";
            save.OverwritePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();

            }
        }
    }
}
