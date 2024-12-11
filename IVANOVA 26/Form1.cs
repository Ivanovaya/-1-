using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ26_KIRILLOV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            {
                if (openFileDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK &&
                openFileDialog1.FileName.Length > 0)
                {
                    try
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName,
                        RichTextBoxStreamType.RichText);
                    }
                    catch (System.ArgumentException ex)
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName,
                        RichTextBoxStreamType.PlainText);
                    }
                    this.Text = "Файл [" + openFileDialog1.FileName + "]";
                }

            }
        }
    }
}
