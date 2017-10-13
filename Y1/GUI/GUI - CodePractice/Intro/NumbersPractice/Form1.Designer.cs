namespace NumbersPractice
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
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_numbers = new System.Windows.Forms.ListBox();
            this.button_sum = new System.Windows.Forms.Button();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.button_average = new System.Windows.Forms.Button();
            this.textBox_average = new System.Windows.Forms.TextBox();
            this.button_min = new System.Windows.Forms.Button();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.button_max = new System.Windows.Forms.Button();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.button_sort = new System.Windows.Forms.Button();
            this.button_reverse = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(144, 69);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(53, 20);
            this.textBox_count.TabIndex = 0;
            this.textBox_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_count_KeyPress);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(203, 65);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(71, 27);
            this.button_generate.TabIndex = 1;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter how many numbers\r\nyou want to generate";
            // 
            // listBox_numbers
            // 
            this.listBox_numbers.ContextMenuStrip = this.contextMenuStrip;
            this.listBox_numbers.FormattingEnabled = true;
            this.listBox_numbers.Location = new System.Drawing.Point(15, 131);
            this.listBox_numbers.Name = "listBox_numbers";
            this.listBox_numbers.Size = new System.Drawing.Size(109, 121);
            this.listBox_numbers.TabIndex = 3;
            // 
            // button_sum
            // 
            this.button_sum.Location = new System.Drawing.Point(203, 131);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(71, 27);
            this.button_sum.TabIndex = 5;
            this.button_sum.Text = "Sum";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // textBox_sum
            // 
            this.textBox_sum.Enabled = false;
            this.textBox_sum.Location = new System.Drawing.Point(144, 135);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(53, 20);
            this.textBox_sum.TabIndex = 4;
            // 
            // button_average
            // 
            this.button_average.Location = new System.Drawing.Point(203, 164);
            this.button_average.Name = "button_average";
            this.button_average.Size = new System.Drawing.Size(71, 27);
            this.button_average.TabIndex = 7;
            this.button_average.Text = "Average";
            this.button_average.UseVisualStyleBackColor = true;
            this.button_average.Click += new System.EventHandler(this.button_average_Click);
            // 
            // textBox_average
            // 
            this.textBox_average.Enabled = false;
            this.textBox_average.Location = new System.Drawing.Point(144, 168);
            this.textBox_average.Name = "textBox_average";
            this.textBox_average.Size = new System.Drawing.Size(53, 20);
            this.textBox_average.TabIndex = 6;
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(203, 197);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(71, 27);
            this.button_min.TabIndex = 9;
            this.button_min.Text = "Min";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // textBox_min
            // 
            this.textBox_min.Enabled = false;
            this.textBox_min.Location = new System.Drawing.Point(144, 201);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(53, 20);
            this.textBox_min.TabIndex = 8;
            // 
            // button_max
            // 
            this.button_max.Location = new System.Drawing.Point(203, 230);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(71, 27);
            this.button_max.TabIndex = 11;
            this.button_max.Text = "Max";
            this.button_max.UseVisualStyleBackColor = true;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // textBox_max
            // 
            this.textBox_max.Enabled = false;
            this.textBox_max.Location = new System.Drawing.Point(144, 234);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(53, 20);
            this.textBox_max.TabIndex = 10;
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(14, 270);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(71, 27);
            this.button_sort.TabIndex = 13;
            this.button_sort.Text = "Sort";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // button_reverse
            // 
            this.button_reverse.Location = new System.Drawing.Point(15, 303);
            this.button_reverse.Name = "button_reverse";
            this.button_reverse.Size = new System.Drawing.Size(71, 27);
            this.button_reverse.TabIndex = 12;
            this.button_reverse.Text = "Reverse";
            this.button_reverse.UseVisualStyleBackColor = true;
            this.button_reverse.Click += new System.EventHandler(this.button_reverse_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(284, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumToolStripMenuItem,
            this.averageToolStripMenuItem,
            this.minToolStripMenuItem,
            this.maxToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // sumToolStripMenuItem
            // 
            this.sumToolStripMenuItem.Name = "sumToolStripMenuItem";
            this.sumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.sumToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sumToolStripMenuItem.Text = "Sum";
            this.sumToolStripMenuItem.Click += new System.EventHandler(this.sumToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.averageToolStripMenuItem.Text = "Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.minToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.minToolStripMenuItem.Text = "Min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.reverseToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 48);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reverseToolStripMenuItem.Text = "Reverse";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.reverseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 342);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.button_reverse);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.button_average);
            this.Controls.Add(this.textBox_average);
            this.Controls.Add(this.button_sum);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.listBox_numbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_numbers;
        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Button button_average;
        private System.Windows.Forms.TextBox textBox_average;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.Button button_reverse;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
    }
}

