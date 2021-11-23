using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Bloknot : Form
    {
        public string filePath = "";
        public Bloknot()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = " текстовые файлы (*.txt)|*.txt|Все файлы  (*.*)|*.*|Мои файлы (*.myfile*)|*.myfile*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            //if (openFileDialog1.ShowDialog( )== DialogResult.Cancel)
            //{ 
            //    return;            
            //}
            //textBox1.Text = File.ReadAllText(openFileDialog1.FileName);         
            //if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;

            }
            textBox1.Font = fontDialog1.Font;
        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*|Мои файлы (*.myfile*)|*.myfile*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }          
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;

            }
            textBox1.BackColor = colorDialog1.Color;
        }

        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;

            }
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = " текстовые файлы (*.txt)|*.txt|Все файлы  (*.*)|*.*|Мои файлы (*.myfile*)|*.myfile*";
            //openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    return;

            //}
            //textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }
        }

        private void сохранитьКакТестовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = " текстовые файлы (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*|Мои файлы (*.myfile*)|*.myfile*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите очистить?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Clear();
            }


            //textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }
    }
}
