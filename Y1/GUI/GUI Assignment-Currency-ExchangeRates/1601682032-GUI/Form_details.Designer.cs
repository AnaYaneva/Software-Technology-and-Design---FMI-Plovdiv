namespace _1601682032_GUI
{
    partial class Form_details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_exchangeRates = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.промениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтрийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запишиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запишиВъвФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отвориФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_currencyEnter = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_saveToFile = new System.Windows.Forms.Button();
            this.button_mainPage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton_exRate = new System.Windows.Forms.RadioButton();
            this.radioButton_date = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton_descending = new System.Windows.Forms.RadioButton();
            this.radioButton_ascending = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_sort = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_exchangeRates);
            this.panel1.Controls.Add(this.label_currencyEnter);
            this.panel1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(36, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 327);
            this.panel1.TabIndex = 1;
            // 
            // listBox_exchangeRates
            // 
            this.listBox_exchangeRates.BackColor = System.Drawing.Color.MintCream;
            this.listBox_exchangeRates.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox_exchangeRates.ForeColor = System.Drawing.Color.SeaGreen;
            this.listBox_exchangeRates.FormattingEnabled = true;
            this.listBox_exchangeRates.ItemHeight = 22;
            this.listBox_exchangeRates.Location = new System.Drawing.Point(12, 84);
            this.listBox_exchangeRates.Name = "listBox_exchangeRates";
            this.listBox_exchangeRates.Size = new System.Drawing.Size(254, 224);
            this.listBox_exchangeRates.TabIndex = 1;
            this.listBox_exchangeRates.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_exchangeRates_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиToolStripMenuItem,
            this.промениToolStripMenuItem,
            this.изтрийToolStripMenuItem,
            this.запишиToolStripMenuItem,
            this.запишиВъвФайлToolStripMenuItem,
            this.отвориФайлToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 136);
            // 
            // добавиToolStripMenuItem
            // 
            this.добавиToolStripMenuItem.Name = "добавиToolStripMenuItem";
            this.добавиToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.добавиToolStripMenuItem.Text = "добави";
            this.добавиToolStripMenuItem.Click += new System.EventHandler(this.добавиToolStripMenuItem_Click);
            // 
            // промениToolStripMenuItem
            // 
            this.промениToolStripMenuItem.Name = "промениToolStripMenuItem";
            this.промениToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.промениToolStripMenuItem.Text = "промени";
            this.промениToolStripMenuItem.Click += new System.EventHandler(this.промениToolStripMenuItem_Click);
            // 
            // изтрийToolStripMenuItem
            // 
            this.изтрийToolStripMenuItem.Name = "изтрийToolStripMenuItem";
            this.изтрийToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.изтрийToolStripMenuItem.Text = "изтрий";
            this.изтрийToolStripMenuItem.Click += new System.EventHandler(this.изтрийToolStripMenuItem_Click);
            // 
            // запишиToolStripMenuItem
            // 
            this.запишиToolStripMenuItem.Name = "запишиToolStripMenuItem";
            this.запишиToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.запишиToolStripMenuItem.Text = "запиши";
            this.запишиToolStripMenuItem.Click += new System.EventHandler(this.запишиToolStripMenuItem_Click);
            // 
            // запишиВъвФайлToolStripMenuItem
            // 
            this.запишиВъвФайлToolStripMenuItem.Name = "запишиВъвФайлToolStripMenuItem";
            this.запишиВъвФайлToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.запишиВъвФайлToolStripMenuItem.Text = "запиши във файл";
            this.запишиВъвФайлToolStripMenuItem.Click += new System.EventHandler(this.запишиВъвФайлToolStripMenuItem_Click);
            // 
            // отвориФайлToolStripMenuItem
            // 
            this.отвориФайлToolStripMenuItem.Name = "отвориФайлToolStripMenuItem";
            this.отвориФайлToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.отвориФайлToolStripMenuItem.Text = "отвори файл";
            this.отвориФайлToolStripMenuItem.Click += new System.EventHandler(this.отвориФайлToolStripMenuItem_Click);
            // 
            // label_currencyEnter
            // 
            this.label_currencyEnter.AutoSize = true;
            this.label_currencyEnter.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_currencyEnter.ForeColor = System.Drawing.Color.LightGreen;
            this.label_currencyEnter.Location = new System.Drawing.Point(7, 33);
            this.label_currencyEnter.Name = "label_currencyEnter";
            this.label_currencyEnter.Size = new System.Drawing.Size(96, 28);
            this.label_currencyEnter.TabIndex = 0;
            this.label_currencyEnter.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.button_save);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_openFile);
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_saveToFile);
            this.panel2.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(303, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 294);
            this.panel2.TabIndex = 2;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(46, 54);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(180, 60);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Добави";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Location = new System.Drawing.Point(245, 136);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(180, 60);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Запиши";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Location = new System.Drawing.Point(46, 136);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(180, 60);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Изтрий";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_openFile
            // 
            this.button_openFile.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_openFile.FlatAppearance.BorderSize = 0;
            this.button_openFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_openFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openFile.Location = new System.Drawing.Point(46, 215);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(180, 60);
            this.button_openFile.TabIndex = 5;
            this.button_openFile.Text = "Отвори файл";
            this.button_openFile.UseVisualStyleBackColor = false;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Location = new System.Drawing.Point(245, 54);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(180, 60);
            this.button_edit.TabIndex = 0;
            this.button_edit.Text = "Промени";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_saveToFile
            // 
            this.button_saveToFile.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_saveToFile.FlatAppearance.BorderSize = 0;
            this.button_saveToFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_saveToFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_saveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_saveToFile.Location = new System.Drawing.Point(245, 215);
            this.button_saveToFile.Name = "button_saveToFile";
            this.button_saveToFile.Size = new System.Drawing.Size(180, 60);
            this.button_saveToFile.TabIndex = 4;
            this.button_saveToFile.Text = "Запиши във файл";
            this.button_saveToFile.UseVisualStyleBackColor = false;
            this.button_saveToFile.Click += new System.EventHandler(this.button_saveToFile_Click);
            // 
            // button_mainPage
            // 
            this.button_mainPage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_mainPage.FlatAppearance.BorderSize = 0;
            this.button_mainPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_mainPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_mainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mainPage.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mainPage.ForeColor = System.Drawing.Color.White;
            this.button_mainPage.Location = new System.Drawing.Point(548, 444);
            this.button_mainPage.Name = "button_mainPage";
            this.button_mainPage.Size = new System.Drawing.Size(180, 60);
            this.button_mainPage.TabIndex = 3;
            this.button_mainPage.Text = "Главна страница";
            this.button_mainPage.UseVisualStyleBackColor = false;
            this.button_mainPage.Click += new System.EventHandler(this.button_mainPage_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton_exRate);
            this.panel3.Controls.Add(this.radioButton_date);
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 68);
            this.panel3.TabIndex = 3;
            // 
            // radioButton_exRate
            // 
            this.radioButton_exRate.AutoSize = true;
            this.radioButton_exRate.FlatAppearance.BorderSize = 0;
            this.radioButton_exRate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Magenta;
            this.radioButton_exRate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.radioButton_exRate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton_exRate.ForeColor = System.Drawing.Color.MintCream;
            this.radioButton_exRate.Location = new System.Drawing.Point(6, 36);
            this.radioButton_exRate.Name = "radioButton_exRate";
            this.radioButton_exRate.Size = new System.Drawing.Size(193, 26);
            this.radioButton_exRate.TabIndex = 1;
            this.radioButton_exRate.TabStop = true;
            this.radioButton_exRate.Text = "по валутен курс";
            this.radioButton_exRate.UseVisualStyleBackColor = true;
            // 
            // radioButton_date
            // 
            this.radioButton_date.AutoSize = true;
            this.radioButton_date.FlatAppearance.BorderSize = 0;
            this.radioButton_date.FlatAppearance.CheckedBackColor = System.Drawing.Color.Magenta;
            this.radioButton_date.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.radioButton_date.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton_date.ForeColor = System.Drawing.Color.MintCream;
            this.radioButton_date.Location = new System.Drawing.Point(6, 12);
            this.radioButton_date.Name = "radioButton_date";
            this.radioButton_date.Size = new System.Drawing.Size(105, 26);
            this.radioButton_date.TabIndex = 0;
            this.radioButton_date.TabStop = true;
            this.radioButton_date.Text = "по дата";
            this.radioButton_date.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton_descending);
            this.panel4.Controls.Add(this.radioButton_ascending);
            this.panel4.Location = new System.Drawing.Point(226, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 68);
            this.panel4.TabIndex = 4;
            // 
            // radioButton_descending
            // 
            this.radioButton_descending.AutoSize = true;
            this.radioButton_descending.FlatAppearance.BorderSize = 0;
            this.radioButton_descending.FlatAppearance.CheckedBackColor = System.Drawing.Color.Magenta;
            this.radioButton_descending.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.radioButton_descending.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton_descending.ForeColor = System.Drawing.Color.MintCream;
            this.radioButton_descending.Location = new System.Drawing.Point(6, 36);
            this.radioButton_descending.Name = "radioButton_descending";
            this.radioButton_descending.Size = new System.Drawing.Size(160, 26);
            this.radioButton_descending.TabIndex = 1;
            this.radioButton_descending.TabStop = true;
            this.radioButton_descending.Text = "низходящ ред";
            this.radioButton_descending.UseVisualStyleBackColor = true;
            // 
            // radioButton_ascending
            // 
            this.radioButton_ascending.AutoSize = true;
            this.radioButton_ascending.FlatAppearance.BorderSize = 0;
            this.radioButton_ascending.FlatAppearance.CheckedBackColor = System.Drawing.Color.Magenta;
            this.radioButton_ascending.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.radioButton_ascending.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButton_ascending.ForeColor = System.Drawing.Color.MintCream;
            this.radioButton_ascending.Location = new System.Drawing.Point(6, 12);
            this.radioButton_ascending.Name = "radioButton_ascending";
            this.radioButton_ascending.Size = new System.Drawing.Size(160, 26);
            this.radioButton_ascending.TabIndex = 0;
            this.radioButton_ascending.TabStop = true;
            this.radioButton_ascending.Text = "възходящ ред";
            this.radioButton_ascending.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_sort);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(36, 345);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(416, 188);
            this.panel5.TabIndex = 5;
            // 
            // button_sort
            // 
            this.button_sort.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_sort.FlatAppearance.BorderSize = 0;
            this.button_sort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_sort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sort.Location = new System.Drawing.Point(12, 99);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(180, 60);
            this.button_sort.TabIndex = 5;
            this.button_sort.Text = "Сортирай";
            this.button_sort.UseVisualStyleBackColor = false;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button_mainPage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form_details";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Детайли ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_details_FormClosing);
            this.Load += new System.EventHandler(this.Form_details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_currencyEnter;
        private System.Windows.Forms.ListBox listBox_exchangeRates;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_mainPage;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Button button_saveToFile;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton_exRate;
        private System.Windows.Forms.RadioButton radioButton_date;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton_descending;
        private System.Windows.Forms.RadioButton radioButton_ascending;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem промениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изтрийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запишиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запишиВъвФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отвориФайлToolStripMenuItem;
    }
}