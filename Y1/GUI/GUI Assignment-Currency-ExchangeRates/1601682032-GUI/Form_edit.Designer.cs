namespace _1601682032_GUI
{
    partial class Form_edit
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
            this.label_date = new System.Windows.Forms.Label();
            this.label_Currency = new System.Windows.Forms.Label();
            this.label_ = new System.Windows.Forms.Label();
            this.textBox_exchangeRate = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_Currency);
            this.panel1.Controls.Add(this.label_);
            this.panel1.Controls.Add(this.textBox_exchangeRate);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 197);
            this.panel1.TabIndex = 1;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date.ForeColor = System.Drawing.Color.LightGreen;
            this.label_date.Location = new System.Drawing.Point(47, 77);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(68, 28);
            this.label_date.TabIndex = 6;
            this.label_date.Text = "date";
            // 
            // label_Currency
            // 
            this.label_Currency.AutoSize = true;
            this.label_Currency.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Currency.ForeColor = System.Drawing.Color.LightGreen;
            this.label_Currency.Location = new System.Drawing.Point(47, 40);
            this.label_Currency.Name = "label_Currency";
            this.label_Currency.Size = new System.Drawing.Size(124, 28);
            this.label_Currency.TabIndex = 5;
            this.label_Currency.Text = "currency";
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_.ForeColor = System.Drawing.Color.MintCream;
            this.label_.Location = new System.Drawing.Point(178, 150);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(65, 22);
            this.label_.TabIndex = 2;
            this.label_.Text = "/ EUR";
            // 
            // textBox_exchangeRate
            // 
            this.textBox_exchangeRate.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_exchangeRate.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox_exchangeRate.Location = new System.Drawing.Point(78, 147);
            this.textBox_exchangeRate.Name = "textBox_exchangeRate";
            this.textBox_exchangeRate.Size = new System.Drawing.Size(96, 29);
            this.textBox_exchangeRate.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_cancel);
            this.panel2.Controls.Add(this.button_save);
            this.panel2.Location = new System.Drawing.Point(80, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 254);
            this.panel2.TabIndex = 2;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.ForeColor = System.Drawing.Color.MintCream;
            this.button_cancel.Location = new System.Drawing.Point(26, 149);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(180, 60);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Отмени";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.ForeColor = System.Drawing.Color.MintCream;
            this.button_save.Location = new System.Drawing.Point(26, 60);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(180, 60);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Запамети";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Form_edit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Промяна";
            this.Load += new System.EventHandler(this.Form_edit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.TextBox textBox_exchangeRate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_Currency;
        private System.Windows.Forms.Label label_date;
    }
}