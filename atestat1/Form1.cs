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

        
        int a=0;
        private void button1_Click(object sender, EventArgs e)
        {
            string nume;
           
           nume = "problema" + a.ToString() + ".exe";
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = nume;
            p.Start();
            
        }
        private void problema1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 1;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
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

        private void problema2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 2;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema2";
            string[] cods2 = System.IO.File.ReadAllLines("enunt2.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod2.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 6;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema6";
            string[] cods2 = System.IO.File.ReadAllLines("enunt6.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod6.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 3;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema3";
            string[] cods2 = System.IO.File.ReadAllLines("enunt3.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod3.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 5;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema5";
            string[] cods2 = System.IO.File.ReadAllLines("enunt5.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod5.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void problema7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 7;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema7";
            string[] cods2 = System.IO.File.ReadAllLines("enunt7.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod7.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 8;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema8";
            string[] cods2 = System.IO.File.ReadAllLines("enunt8.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod8.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 9;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema9";
            string[] cods2 = System.IO.File.ReadAllLines("enunt9.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod9.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 10;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema10";
            string[] cods2 = System.IO.File.ReadAllLines("enunt10.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod10.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "winword";
            proc.StartInfo.Arguments = "teorie.doc";
            proc.Start();
        }

        private void problema4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            a = 4;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema4";
            string[] cods2 = System.IO.File.ReadAllLines("enunt4.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod4.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema5ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            a = 5;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema5";
            string[] cods2 = System.IO.File.ReadAllLines("enunt5.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod5.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema6ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            a = 6;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema6";
            string[] cods2 = System.IO.File.ReadAllLines("enunt6.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod6.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema7ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            a = 7;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema7";
            string[] cods2 = System.IO.File.ReadAllLines("enunt7.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod7.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema8ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            a = 8;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema8";
            string[] cods2 = System.IO.File.ReadAllLines("enunt8.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod8.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema9ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            a = 9;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema9";
            string[] cods2 = System.IO.File.ReadAllLines("enunt9.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod9.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }

        private void problema10ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            a = 10;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Visible = true;
            richTextBox1.Visible = true;
            label1.Visible = true;
            richTextBox2.Visible = true;

            label1.Text = "problema10";
            string[] cods2 = System.IO.File.ReadAllLines("enunt10.txt");
            for (int i = 0; i <= cods2.Length - 1; i++)
                richTextBox2.Text += cods2[i] + "\n";
            string[] cods1 = System.IO.File.ReadAllLines("cod10.txt");
            for (int i = 0; i <= cods1.Length - 1; i++)
                richTextBox1.Text += cods1[i] + "\n";
        }
    }
}
