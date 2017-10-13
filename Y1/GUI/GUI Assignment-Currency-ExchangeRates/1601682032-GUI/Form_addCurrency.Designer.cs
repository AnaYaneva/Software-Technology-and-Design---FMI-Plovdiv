namespace _1601682032_GUI
{
    partial class Form_addCurrency
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
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_saveC = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.listBox_currency = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изтрийВалутатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_add
            // 
            this.textBox_add.BackColor = System.Drawing.Color.MintCream;
            this.textBox_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox_add.Location = new System.Drawing.Point(78, 15);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(180, 29);
            this.textBox_add.TabIndex = 0;
            this.textBox_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_add_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_saveC);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.listBox_currency);
            this.panel1.Controls.Add(this.textBox_add);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 524);
            this.panel1.TabIndex = 1;
            // 
            // button_saveC
            // 
            this.button_saveC.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_saveC.FlatAppearance.BorderSize = 0;
            this.button_saveC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_saveC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_saveC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_saveC.ForeColor = System.Drawing.Color.White;
            this.button_saveC.Location = new System.Drawing.Point(78, 381);
            this.button_saveC.Name = "button_saveC";
            this.button_saveC.Size = new System.Drawing.Size(180, 60);
            this.button_saveC.TabIndex = 5;
            this.button_saveC.Text = "Запази";
            this.button_saveC.UseVisualStyleBackColor = false;
            this.button_saveC.Click += new System.EventHandler(this.button_saveC_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(78, 293);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(180, 60);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Изтрий валута";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // listBox_currency
            // 
            this.listBox_currency.BackColor = System.Drawing.Color.MintCream;
            this.listBox_currency.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox_currency.ForeColor = System.Drawing.Color.SeaGreen;
            this.listBox_currency.FormattingEnabled = true;
            this.listBox_currency.ItemHeight = 22;
            this.listBox_currency.Location = new System.Drawing.Point(78, 127);
            this.listBox_currency.Name = "listBox_currency";
            this.listBox_currency.Size = new System.Drawing.Size(180, 158);
            this.listBox_currency.TabIndex = 2;
            this.listBox_currency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_currency_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изтрийВалутатаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 26);
            // 
            // изтрийВалутатаToolStripMenuItem
            // 
            this.изтрийВалутатаToolStripMenuItem.Name = "изтрийВалутатаToolStripMenuItem";
            this.изтрийВалутатаToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.изтрийВалутатаToolStripMenuItem.Text = "изтрий валутата";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(78, 447);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(180, 60);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Отмени";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(78, 50);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(180, 60);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Добави валута";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Form_addCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Form_addCurrency";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добави/изтрий валута";
            this.Load += new System.EventHandler(this.Form_addCurrency_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ListBox listBox_currency;
        private System.Windows.Forms.Button button_saveC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изтрийВалутатаToolStripMenuItem;
    }
}