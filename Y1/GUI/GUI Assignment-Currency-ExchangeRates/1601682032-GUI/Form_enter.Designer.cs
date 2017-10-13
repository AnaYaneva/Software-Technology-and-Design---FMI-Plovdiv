namespace _1601682032_GUI
{
    partial class Form_enter
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
            this.textBox_exchangeRate = new System.Windows.Forms.TextBox();
            this.label_dateEnter = new System.Windows.Forms.Label();
            this.label_currencyEnter = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_mainPage = new System.Windows.Forms.Button();
            this.button_details = new System.Windows.Forms.Button();
            this.button_saveToFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_exchangeRate);
            this.panel1.Controls.Add(this.label_dateEnter);
            this.panel1.Controls.Add(this.label_currencyEnter);
            this.panel1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.MintCream;
            this.panel1.Location = new System.Drawing.Point(31, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 125);
            this.panel1.TabIndex = 0;
            // 
            // textBox_exchangeRate
            // 
            this.textBox_exchangeRate.BackColor = System.Drawing.Color.MintCream;
            this.textBox_exchangeRate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exchangeRate.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox_exchangeRate.Location = new System.Drawing.Point(75, 63);
            this.textBox_exchangeRate.Name = "textBox_exchangeRate";
            this.textBox_exchangeRate.Size = new System.Drawing.Size(98, 29);
            this.textBox_exchangeRate.TabIndex = 2;
            this.textBox_exchangeRate.TextChanged += new System.EventHandler(this.textBox_exchangeRate_TextChanged);
            this.textBox_exchangeRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_exchangeRate_KeyDown);
            // 
            // label_dateEnter
            // 
            this.label_dateEnter.AutoSize = true;
            this.label_dateEnter.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dateEnter.ForeColor = System.Drawing.Color.LightGreen;
            this.label_dateEnter.Location = new System.Drawing.Point(35, 12);
            this.label_dateEnter.Name = "label_dateEnter";
            this.label_dateEnter.Size = new System.Drawing.Size(96, 28);
            this.label_dateEnter.TabIndex = 1;
            this.label_dateEnter.Text = "label2";
            this.label_dateEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_currencyEnter
            // 
            this.label_currencyEnter.AutoSize = true;
            this.label_currencyEnter.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_currencyEnter.Location = new System.Drawing.Point(179, 66);
            this.label_currencyEnter.Name = "label_currencyEnter";
            this.label_currencyEnter.Size = new System.Drawing.Size(76, 22);
            this.label_currencyEnter.TabIndex = 0;
            this.label_currencyEnter.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_mainPage);
            this.panel2.Controls.Add(this.button_details);
            this.panel2.Controls.Add(this.button_saveToFile);
            this.panel2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.Color.MintCream;
            this.panel2.Location = new System.Drawing.Point(71, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 307);
            this.panel2.TabIndex = 1;
            // 
            // button_mainPage
            // 
            this.button_mainPage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_mainPage.FlatAppearance.BorderSize = 0;
            this.button_mainPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_mainPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_mainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mainPage.Location = new System.Drawing.Point(35, 218);
            this.button_mainPage.Name = "button_mainPage";
            this.button_mainPage.Size = new System.Drawing.Size(180, 60);
            this.button_mainPage.TabIndex = 2;
            this.button_mainPage.Text = "Главна страница";
            this.button_mainPage.UseVisualStyleBackColor = false;
            this.button_mainPage.Click += new System.EventHandler(this.button_mainPage_Click);
            // 
            // button_details
            // 
            this.button_details.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_details.FlatAppearance.BorderSize = 0;
            this.button_details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_details.Location = new System.Drawing.Point(35, 139);
            this.button_details.Name = "button_details";
            this.button_details.Size = new System.Drawing.Size(180, 60);
            this.button_details.TabIndex = 1;
            this.button_details.Text = "Покажи детайли";
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
            this.button_saveToFile.Location = new System.Drawing.Point(35, 61);
            this.button_saveToFile.Name = "button_saveToFile";
            this.button_saveToFile.Size = new System.Drawing.Size(180, 60);
            this.button_saveToFile.TabIndex = 0;
            this.button_saveToFile.Text = "Запиши във файл";
            this.button_saveToFile.UseVisualStyleBackColor = false;
            this.button_saveToFile.Click += new System.EventHandler(this.button_saveToFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form_enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Form_enter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добави";
            this.Load += new System.EventHandler(this.Form_enter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_exchangeRate;
        private System.Windows.Forms.Label label_dateEnter;
        private System.Windows.Forms.Label label_currencyEnter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_mainPage;
        private System.Windows.Forms.Button button_details;
        private System.Windows.Forms.Button button_saveToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}