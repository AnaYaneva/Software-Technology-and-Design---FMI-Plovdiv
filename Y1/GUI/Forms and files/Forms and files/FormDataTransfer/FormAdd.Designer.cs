﻿namespace FormDataTransfer
{
    partial class FormAdd
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
            this.label_firstName = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_middleName = new System.Windows.Forms.TextBox();
            this.label_middleName = new System.Windows.Forms.Label();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(36, 39);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(55, 13);
            this.label_firstName.TabIndex = 0;
            this.label_firstName.Text = "First name";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(149, 39);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_firstName.TabIndex = 1;
            // 
            // textBox_middleName
            // 
            this.textBox_middleName.Location = new System.Drawing.Point(149, 86);
            this.textBox_middleName.Name = "textBox_middleName";
            this.textBox_middleName.Size = new System.Drawing.Size(100, 20);
            this.textBox_middleName.TabIndex = 3;
            // 
            // label_middleName
            // 
            this.label_middleName.AutoSize = true;
            this.label_middleName.Location = new System.Drawing.Point(36, 86);
            this.label_middleName.Name = "label_middleName";
            this.label_middleName.Size = new System.Drawing.Size(67, 13);
            this.label_middleName.TabIndex = 2;
            this.label_middleName.Text = "Middle name";
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(149, 136);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastName.TabIndex = 5;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(36, 136);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(56, 13);
            this.label_lastName.TabIndex = 4;
            this.label_lastName.Text = "Last name";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(149, 203);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.textBox_middleName);
            this.Controls.Add(this.label_middleName);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.label_firstName);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_middleName;
        private System.Windows.Forms.Label label_middleName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Button button_save;
    }
}