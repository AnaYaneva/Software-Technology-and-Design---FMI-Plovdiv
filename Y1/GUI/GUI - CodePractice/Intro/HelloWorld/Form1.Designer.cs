namespace HelloWorld
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
            this.button_hello = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_getDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_hello
            // 
            this.button_hello.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_hello.Location = new System.Drawing.Point(145, 26);
            this.button_hello.Name = "button_hello";
            this.button_hello.Size = new System.Drawing.Size(74, 22);
            this.button_hello.TabIndex = 0;
            this.button_hello.Text = "Say hello";
            this.button_hello.UseVisualStyleBackColor = false;
            this.button_hello.Click += new System.EventHandler(this.button_hello_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(23, 28);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // button_getDate
            // 
            this.button_getDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_getDate.Location = new System.Drawing.Point(48, 93);
            this.button_getDate.Name = "button_getDate";
            this.button_getDate.Size = new System.Drawing.Size(129, 39);
            this.button_getDate.TabIndex = 2;
            this.button_getDate.Text = "Get Date";
            this.button_getDate.UseVisualStyleBackColor = false;
            this.button_getDate.Click += new System.EventHandler(this.button_getDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 157);
            this.Controls.Add(this.button_getDate);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hello;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_getDate;
    }
}

