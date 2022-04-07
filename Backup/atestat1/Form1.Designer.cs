namespace atestat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.problemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problema1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problema2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problema3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.problemaToolStripMenuItem,
            this.problemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // problemaToolStripMenuItem
            // 
            this.problemaToolStripMenuItem.Name = "problemaToolStripMenuItem";
            this.problemaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.problemaToolStripMenuItem.Text = "Teorie";
            // 
            // problemeToolStripMenuItem
            // 
            this.problemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.problema1ToolStripMenuItem,
            this.problema2ToolStripMenuItem,
            this.problema3ToolStripMenuItem});
            this.problemeToolStripMenuItem.Name = "problemeToolStripMenuItem";
            this.problemeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.problemeToolStripMenuItem.Text = "Probleme";
            this.problemeToolStripMenuItem.Click += new System.EventHandler(this.problemeToolStripMenuItem_Click);
            // 
            // problema1ToolStripMenuItem
            // 
            this.problema1ToolStripMenuItem.Name = "problema1ToolStripMenuItem";
            this.problema1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.problema1ToolStripMenuItem.Text = "Problema 1";
            this.problema1ToolStripMenuItem.Click += new System.EventHandler(this.problema1ToolStripMenuItem_Click);
            // 
            // problema2ToolStripMenuItem
            // 
            this.problema2ToolStripMenuItem.Name = "problema2ToolStripMenuItem";
            this.problema2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.problema2ToolStripMenuItem.Text = "Problema2";
            // 
            // problema3ToolStripMenuItem
            // 
            this.problema3ToolStripMenuItem.Name = "problema3ToolStripMenuItem";
            this.problema3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.problema3ToolStripMenuItem.Text = "Problema 3 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(207, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 256);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(44, 97);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(141, 216);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Executa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Parcugerea grafurilor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem problemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problema1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problema2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problema3ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

