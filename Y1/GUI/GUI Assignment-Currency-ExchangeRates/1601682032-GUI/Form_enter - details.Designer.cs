namespace _1601682032_GUI
{
    partial class Form_enter_details
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
            this.label_ = new System.Windows.Forms.Label();
            this.label_chooseDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_exchangeRate = new System.Windows.Forms.TextBox();
            this.label_currencyEnter = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_details = new System.Windows.Forms.Button();
            this.button_saveToFile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.въведетеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покажиДетайлиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаСтраницаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оносноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.относноАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полезниЛинковеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_);
            this.panel1.Controls.Add(this.label_chooseDate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox_exchangeRate);
            this.panel1.Controls.Add(this.label_currencyEnter);
            this.panel1.Location = new System.Drawing.Point(70, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 193);
            this.panel1.TabIndex = 0;
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_.ForeColor = System.Drawing.Color.LightGreen;
            this.label_.Location = new System.Drawing.Point(21, 1);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(96, 28);
            this.label_.TabIndex = 8;
            this.label_.Text = "label2";
            this.label_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_chooseDate
            // 
            this.label_chooseDate.AutoSize = true;
            this.label_chooseDate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_chooseDate.ForeColor = System.Drawing.Color.LightGreen;
            this.label_chooseDate.Location = new System.Drawing.Point(22, 51);
            this.label_chooseDate.Name = "label_chooseDate";
            this.label_chooseDate.Size = new System.Drawing.Size(208, 22);
            this.label_chooseDate.TabIndex = 7;
            this.label_chooseDate.Text = "Моля изберете дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.SeaGreen;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.MintCream;
            this.dateTimePicker1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 29);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox_exchangeRate
            // 
            this.textBox_exchangeRate.BackColor = System.Drawing.Color.MintCream;
            this.textBox_exchangeRate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exchangeRate.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox_exchangeRate.Location = new System.Drawing.Point(26, 144);
            this.textBox_exchangeRate.Name = "textBox_exchangeRate";
            this.textBox_exchangeRate.Size = new System.Drawing.Size(68, 29);
            this.textBox_exchangeRate.TabIndex = 2;
            this.textBox_exchangeRate.TextChanged += new System.EventHandler(this.textBox_exchangeRate_TextChanged);
            this.textBox_exchangeRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_exchangeRate_KeyDown);
            // 
            // label_currencyEnter
            // 
            this.label_currencyEnter.AutoSize = true;
            this.label_currencyEnter.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_currencyEnter.ForeColor = System.Drawing.Color.MintCream;
            this.label_currencyEnter.Location = new System.Drawing.Point(100, 147);
            this.label_currencyEnter.Name = "label_currencyEnter";
            this.label_currencyEnter.Size = new System.Drawing.Size(76, 22);
            this.label_currencyEnter.TabIndex = 0;
            this.label_currencyEnter.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_details);
            this.panel2.Controls.Add(this.button_saveToFile);
            this.panel2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(104, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 250);
            this.panel2.TabIndex = 1;
            // 
            // button_details
            // 
            this.button_details.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_details.FlatAppearance.BorderSize = 0;
            this.button_details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_details.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_details.ForeColor = System.Drawing.Color.White;
            this.button_details.Location = new System.Drawing.Point(3, 146);
            this.button_details.Name = "button_details";
            this.button_details.Size = new System.Drawing.Size(180, 60);
            this.button_details.TabIndex = 1;
            this.button_details.Text = "Затвори";
            this.button_details.UseVisualStyleBackColor = false;
            this.button_details.Click += new System.EventHandler(this.button_details_Click);
            // 
            // button_saveToFile
            // 
            this.button_saveToFile.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_saveToFile.Enabled = false;
            this.button_saveToFile.FlatAppearance.BorderSize = 0;
            this.button_saveToFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_saveToFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_saveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_saveToFile.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_saveToFile.ForeColor = System.Drawing.Color.White;
            this.button_saveToFile.Location = new System.Drawing.Point(3, 57);
            this.button_saveToFile.Name = "button_saveToFile";
            this.button_saveToFile.Size = new System.Drawing.Size(180, 60);
            this.button_saveToFile.TabIndex = 0;
            this.button_saveToFile.Text = "Запази";
            this.button_saveToFile.UseVisualStyleBackColor = false;
            this.button_saveToFile.Click += new System.EventHandler(this.button_saveToFile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.въведетеToolStripMenuItem,
            this.оносноToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // въведетеToolStripMenuItem
            // 
            this.въведетеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.покажиДетайлиToolStripMenuItem,
            this.главнаСтраницаToolStripMenuItem});
            this.въведетеToolStripMenuItem.Name = "въведетеToolStripMenuItem";
            this.въведетеToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.въведетеToolStripMenuItem.Text = "запиши във файл";
            // 
            // покажиДетайлиToolStripMenuItem
            // 
            this.покажиДетайлиToolStripMenuItem.Name = "покажиДетайлиToolStripMenuItem";
            this.покажиДетайлиToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.покажиДетайлиToolStripMenuItem.Text = "покажи детайли";
            // 
            // главнаСтраницаToolStripMenuItem
            // 
            this.главнаСтраницаToolStripMenuItem.Name = "главнаСтраницаToolStripMenuItem";
            this.главнаСтраницаToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.главнаСтраницаToolStripMenuItem.Text = "главна страница";
            // 
            // оносноToolStripMenuItem
            // 
            this.оносноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.относноАвтораToolStripMenuItem,
            this.полезниЛинковеToolStripMenuItem});
            this.оносноToolStripMenuItem.Name = "оносноToolStripMenuItem";
            this.оносноToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.оносноToolStripMenuItem.Text = "оносно";
            // 
            // относноАвтораToolStripMenuItem
            // 
            this.относноАвтораToolStripMenuItem.Name = "относноАвтораToolStripMenuItem";
            this.относноАвтораToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.относноАвтораToolStripMenuItem.Text = "относно автора";
            // 
            // полезниЛинковеToolStripMenuItem
            // 
            this.полезниЛинковеToolStripMenuItem.Name = "полезниЛинковеToolStripMenuItem";
            this.полезниЛинковеToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.полезниЛинковеToolStripMenuItem.Text = "полезни линкове";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form_enter_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Form_enter_details";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добави";
            this.Load += new System.EventHandler(this.Form_enter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_exchangeRate;
        private System.Windows.Forms.Label label_currencyEnter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_details;
        private System.Windows.Forms.Button button_saveToFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem въведетеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покажиДетайлиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главнаСтраницаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оносноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem относноАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полезниЛинковеToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_chooseDate;
        private System.Windows.Forms.Label label_;
    }
}