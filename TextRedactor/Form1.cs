using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextRedactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        { 
            string rtfText = richTextBox1.Rtf;
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF Files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                string filename = openFileDialog.FileName;
                openedFilePath = openFileDialog.FileName;
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
                MessageBox.Show("Файл открыт");
            }
        }
        private string openedFilePath = null;
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openedFilePath))
            {
                richTextBox1.SaveFile(openedFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                MessageBox.Show("Нет файла для сохранения.");
            }

        }


        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "RTF Files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
                MessageBox.Show("Файл сохранен");
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
        }

        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void решитьToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = new Font("Arial", 16, FontStyle.Bold);
        }
    }
}
