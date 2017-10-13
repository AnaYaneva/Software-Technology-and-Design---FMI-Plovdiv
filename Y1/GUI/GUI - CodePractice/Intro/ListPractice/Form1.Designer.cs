namespace ListPractice
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
            this.listBox_items = new System.Windows.Forms.ListBox();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_update = new System.Windows.Forms.TextBox();
            this.button_deleteMultiselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_items
            // 
            this.listBox_items.FormattingEnabled = true;
            this.listBox_items.Items.AddRange(new object[] {
            "1",
            "123",
            "sad",
            "asd"});
            this.listBox_items.Location = new System.Drawing.Point(12, 60);
            this.listBox_items.Name = "listBox_items";
            this.listBox_items.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_items.Size = new System.Drawing.Size(120, 95);
            this.listBox_items.TabIndex = 0;
            this.listBox_items.SelectedIndexChanged += new System.EventHandler(this.listBox_items_SelectedIndexChanged);
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(17, 16);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(115, 20);
            this.textBox_add.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(151, 16);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(103, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(151, 60);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(103, 23);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(151, 187);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(103, 23);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_update
            // 
            this.textBox_update.Location = new System.Drawing.Point(17, 187);
            this.textBox_update.Name = "textBox_update";
            this.textBox_update.Size = new System.Drawing.Size(115, 20);
            this.textBox_update.TabIndex = 4;
            // 
            // button_deleteMultiselect
            // 
            this.button_deleteMultiselect.Location = new System.Drawing.Point(151, 89);
            this.button_deleteMultiselect.Name = "button_deleteMultiselect";
            this.button_deleteMultiselect.Size = new System.Drawing.Size(103, 23);
            this.button_deleteMultiselect.TabIndex = 6;
            this.button_deleteMultiselect.Text = "Delete multiselect";
            this.button_deleteMultiselect.UseVisualStyleBackColor = true;
            this.button_deleteMultiselect.Click += new System.EventHandler(this.button_deleteMultiselect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 262);
            this.Controls.Add(this.button_deleteMultiselect);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.listBox_items);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_items;
        private System.Windows.Forms.TextBox textBox_add;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_update;
        private System.Windows.Forms.Button button_deleteMultiselect;
    }
}

