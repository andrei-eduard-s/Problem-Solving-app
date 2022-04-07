using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace atestat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void problemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            button1.Visible = false;

        }

        private void problema1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema1";
           string[] cods2 = System.IO.File.ReadAllLines("enunt1.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod1.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume;
            
            nume = "problema" +  "1.exe";
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = nume;
            p.Start();
            
        }
    }
}
