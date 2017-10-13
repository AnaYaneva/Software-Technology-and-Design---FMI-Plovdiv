namespace _1601682032_GUI
{
    partial class Form_main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_details = new System.Windows.Forms.Button();
            this.button_enter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.въведетеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавиизтрийВалутаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.въведиКурсЗаДеняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покажиДетайлиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.въведиОтФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оносноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.относноАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полезниЛинковеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label_chooseDate = new System.Windows.Forms.Label();
            this.comboBox_currency = new System.Windows.Forms.ComboBox();
            this.label_chooseCurrency = new System.Windows.Forms.Label();
            this.dateTimePicker_main = new System.Windows.Forms.DateTimePicker();
            this.button_addCurr = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.button_openFile);
            this.panel1.Controls.Add(this.button_details);
            this.panel1.Controls.Add(this.button_enter);
            this.panel1.Location = new System.Drawing.Point(170, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 182);
            this.panel1.TabIndex = 5;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_close.CausesValidation = false;
            this.button_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_close.Location = new System.Drawing.Point(236, 107);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(180, 60);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Изход";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_openFile
            // 
            this.button_openFile.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_openFile.CausesValidation = false;
            this.button_openFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_openFile.FlatAppearance.BorderSize = 0;
            this.button_openFile.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_openFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_openFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openFile.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_openFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_openFile.Location = new System.Drawing.Point(236, 28);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(180, 60);
            this.button_openFile.TabIndex = 6;
            this.button_openFile.Text = "Отвори файл";
            this.button_openFile.UseVisualStyleBackColor = false;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // button_details
            // 
            this.button_details.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_details.CausesValidation = false;
            this.button_details.Enabled = false;
            this.button_details.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_details.FlatAppearance.BorderSize = 0;
            this.button_details.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_details.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_details.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_details.Location = new System.Drawing.Point(39, 107);
            this.button_details.Name = "button_details";
            this.button_details.Size = new System.Drawing.Size(180, 60);
            this.button_details.TabIndex = 1;
            this.button_details.Text = "Покажи детайли";
            this.button_details.UseVisualStyleBackColor = false;
            this.button_details.Click += new System.EventHandler(this.button_details_Click);
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_enter.CausesValidation = false;
            this.button_enter.Enabled = false;
            this.button_enter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_enter.FlatAppearance.BorderSize = 0;
            this.button_enter.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enter.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_enter.Location = new System.Drawing.Point(39, 28);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(180, 60);
            this.button_enter.TabIndex = 0;
            this.button_enter.Text = "Въведи курс";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.въведетеToolStripMenuItem,
            this.оносноToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 26);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // въведетеToolStripMenuItem
            // 
            this.въведетеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиизтрийВалутаToolStripMenuItem,
            this.въведиКурсЗаДеняToolStripMenuItem,
            this.покажиДетайлиToolStripMenuItem,
            this.въведиОтФайлToolStripMenuItem});
            this.въведетеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.въведетеToolStripMenuItem.Name = "въведетеToolStripMenuItem";
            this.въведетеToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.въведетеToolStripMenuItem.Text = "валута";
            // 
            // добавиизтрийВалутаToolStripMenuItem
            // 
            this.добавиизтрийВалутаToolStripMenuItem.Name = "добавиизтрийВалутаToolStripMenuItem";
            this.добавиизтрийВалутаToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.добавиизтрийВалутаToolStripMenuItem.Text = "добави/изтрий валута";
            this.добавиизтрийВалутаToolStripMenuItem.Click += new System.EventHandler(this.добавиизтрийВалутаToolStripMenuItem_Click);
            // 
            // въведиКурсЗаДеняToolStripMenuItem
            // 
            this.въведиКурсЗаДеняToolStripMenuItem.Name = "въведиКурсЗаДеняToolStripMenuItem";
            this.въведиКурсЗаДеняToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.въведиКурсЗаДеняToolStripMenuItem.Text = "въведи курс за деня";
            this.въведиКурсЗаДеняToolStripMenuItem.Click += new System.EventHandler(this.въведиКурсЗаДеняToolStripMenuItem_Click);
            // 
            // покажиДетайлиToolStripMenuItem
            // 
            this.покажиДетайлиToolStripMenuItem.Name = "покажиДетайлиToolStripMenuItem";
            this.покажиДетайлиToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.покажиДетайлиToolStripMenuItem.Text = "покажи детайли";
            this.покажиДетайлиToolStripMenuItem.Click += new System.EventHandler(this.покажиДетайлиToolStripMenuItem_Click);
            // 
            // въведиОтФайлToolStripMenuItem
            // 
            this.въведиОтФайлToolStripMenuItem.Name = "въведиОтФайлToolStripMenuItem";
            this.въведиОтФайлToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.въведиОтФайлToolStripMenuItem.Text = "въведи от файл";
            this.въведиОтФайлToolStripMenuItem.Click += new System.EventHandler(this.въведиОтФайлToolStripMenuItem_Click);
            // 
            // оносноToolStripMenuItem
            // 
            this.оносноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.относноАвтораToolStripMenuItem,
            this.полезниЛинковеToolStripMenuItem});
            this.оносноToolStripMenuItem.Name = "оносноToolStripMenuItem";
            this.оносноToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.оносноToolStripMenuItem.Text = "оносно";
            // 
            // относноАвтораToolStripMenuItem
            // 
            this.относноАвтораToolStripMenuItem.Name = "относноАвтораToolStripMenuItem";
            this.относноАвтораToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.относноАвтораToolStripMenuItem.Text = "относно автора";
            this.относноАвтораToolStripMenuItem.Click += new System.EventHandler(this.относноАвтораToolStripMenuItem_Click);
            // 
            // полезниЛинковеToolStripMenuItem
            // 
            this.полезниЛинковеToolStripMenuItem.Name = "полезниЛинковеToolStripMenuItem";
            this.полезниЛинковеToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.полезниЛинковеToolStripMenuItem.Text = "полезни линкове";
            this.полезниЛинковеToolStripMenuItem.Click += new System.EventHandler(this.полезниЛинковеToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label_chooseDate
            // 
            this.label_chooseDate.AutoSize = true;
            this.label_chooseDate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_chooseDate.ForeColor = System.Drawing.Color.LightGreen;
            this.label_chooseDate.Location = new System.Drawing.Point(84, 170);
            this.label_chooseDate.Name = "label_chooseDate";
            this.label_chooseDate.Size = new System.Drawing.Size(208, 22);
            this.label_chooseDate.TabIndex = 2;
            this.label_chooseDate.Text = "Моля изберете дата";
            // 
            // comboBox_currency
            // 
            this.comboBox_currency.BackColor = System.Drawing.Color.MintCream;
            this.comboBox_currency.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_currency.ForeColor = System.Drawing.Color.SeaGreen;
            this.comboBox_currency.FormattingEnabled = true;
            this.comboBox_currency.Location = new System.Drawing.Point(6, 42);
            this.comboBox_currency.Name = "comboBox_currency";
            this.comboBox_currency.Size = new System.Drawing.Size(345, 30);
            this.comboBox_currency.TabIndex = 1;
            this.comboBox_currency.SelectedIndexChanged += new System.EventHandler(this.comboBox_currency_SelectedIndexChanged);
            this.comboBox_currency.Click += new System.EventHandler(this.comboBox_currency_Click);
            // 
            // label_chooseCurrency
            // 
            this.label_chooseCurrency.AutoSize = true;
            this.label_chooseCurrency.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_chooseCurrency.ForeColor = System.Drawing.Color.LightGreen;
            this.label_chooseCurrency.Location = new System.Drawing.Point(74, 18);
            this.label_chooseCurrency.Name = "label_chooseCurrency";
            this.label_chooseCurrency.Size = new System.Drawing.Size(230, 22);
            this.label_chooseCurrency.TabIndex = 3;
            this.label_chooseCurrency.Text = "Моля изберете валута";
            // 
            // dateTimePicker_main
            // 
            this.dateTimePicker_main.CalendarForeColor = System.Drawing.Color.SeaGreen;
            this.dateTimePicker_main.CalendarMonthBackground = System.Drawing.Color.MintCream;
            this.dateTimePicker_main.CalendarTitleForeColor = System.Drawing.Color.SeaGreen;
            this.dateTimePicker_main.CalendarTrailingForeColor = System.Drawing.Color.SeaGreen;
            this.dateTimePicker_main.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_main.Location = new System.Drawing.Point(6, 194);
            this.dateTimePicker_main.Name = "dateTimePicker_main";
            this.dateTimePicker_main.Size = new System.Drawing.Size(345, 29);
            this.dateTimePicker_main.TabIndex = 0;
            this.dateTimePicker_main.ValueChanged += new System.EventHandler(this.dateTimePicker_main_ValueChanged);
            // 
            // button_addCurr
            // 
            this.button_addCurr.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_addCurr.CausesValidation = false;
            this.button_addCurr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_addCurr.FlatAppearance.BorderSize = 0;
            this.button_addCurr.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_addCurr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_addCurr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_addCurr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addCurr.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addCurr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addCurr.Location = new System.Drawing.Point(6, 78);
            this.button_addCurr.Name = "button_addCurr";
            this.button_addCurr.Size = new System.Drawing.Size(345, 60);
            this.button_addCurr.TabIndex = 8;
            this.button_addCurr.Text = "Добави/изтрий валута";
            this.button_addCurr.UseVisualStyleBackColor = false;
            this.button_addCurr.Click += new System.EventHandler(this.button_addCurr_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_addCurr);
            this.panel2.Controls.Add(this.dateTimePicker_main);
            this.panel2.Controls.Add(this.label_chooseCurrency);
            this.panel2.Controls.Add(this.comboBox_currency);
            this.panel2.Controls.Add(this.label_chooseDate);
            this.panel2.Location = new System.Drawing.Point(216, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 259);
            this.panel2.TabIndex = 6;
            // 
            // Form_main
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form_main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Избор на валута";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_details;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem въведетеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оносноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem относноАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полезниЛинковеToolStripMenuItem;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ToolStripMenuItem добавиизтрийВалутаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem въведиКурсЗаДеняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покажиДетайлиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem въведиОтФайлToolStripMenuItem;
        private System.Windows.Forms.Label label_chooseDate;
        private System.Windows.Forms.ComboBox comboBox_currency;
        private System.Windows.Forms.Label label_chooseCurrency;
        private System.Windows.Forms.DateTimePicker dateTimePicker_main;
        private System.Windows.Forms.Button button_addCurr;
        private System.Windows.Forms.Panel panel2;
    }
}

