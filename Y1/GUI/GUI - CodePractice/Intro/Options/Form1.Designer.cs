namespace Options
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
            this.label_question = new System.Windows.Forms.Label();
            this.radioButton_informatics = new System.Windows.Forms.RadioButton();
            this.radioButton_science = new System.Windows.Forms.RadioButton();
            this.radioButton_math = new System.Windows.Forms.RadioButton();
            this.button_submit = new System.Windows.Forms.Button();
            this.radioButton_plovdiv = new System.Windows.Forms.RadioButton();
            this.radioButton_sofia = new System.Windows.Forms.RadioButton();
            this.groupBox_city = new System.Windows.Forms.GroupBox();
            this.checkBox_sofia = new System.Windows.Forms.CheckBox();
            this.checkBox_plovdiv = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_submitCheckboxes = new System.Windows.Forms.Button();
            this.groupBox_city.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Location = new System.Drawing.Point(19, 26);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(112, 13);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "What you\'re studying?";
            // 
            // radioButton_informatics
            // 
            this.radioButton_informatics.AutoSize = true;
            this.radioButton_informatics.Location = new System.Drawing.Point(37, 51);
            this.radioButton_informatics.Name = "radioButton_informatics";
            this.radioButton_informatics.Size = new System.Drawing.Size(76, 17);
            this.radioButton_informatics.TabIndex = 1;
            this.radioButton_informatics.TabStop = true;
            this.radioButton_informatics.Text = "Informatics";
            this.radioButton_informatics.UseVisualStyleBackColor = true;
            // 
            // radioButton_science
            // 
            this.radioButton_science.AutoSize = true;
            this.radioButton_science.Location = new System.Drawing.Point(37, 74);
            this.radioButton_science.Name = "radioButton_science";
            this.radioButton_science.Size = new System.Drawing.Size(64, 17);
            this.radioButton_science.TabIndex = 2;
            this.radioButton_science.TabStop = true;
            this.radioButton_science.Text = "Science";
            this.radioButton_science.UseVisualStyleBackColor = true;
            // 
            // radioButton_math
            // 
            this.radioButton_math.AutoSize = true;
            this.radioButton_math.Location = new System.Drawing.Point(37, 97);
            this.radioButton_math.Name = "radioButton_math";
            this.radioButton_math.Size = new System.Drawing.Size(49, 17);
            this.radioButton_math.TabIndex = 3;
            this.radioButton_math.TabStop = true;
            this.radioButton_math.Text = "Math";
            this.radioButton_math.UseVisualStyleBackColor = true;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(22, 135);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(91, 30);
            this.button_submit.TabIndex = 4;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // radioButton_plovdiv
            // 
            this.radioButton_plovdiv.AutoSize = true;
            this.radioButton_plovdiv.Location = new System.Drawing.Point(20, 54);
            this.radioButton_plovdiv.Name = "radioButton_plovdiv";
            this.radioButton_plovdiv.Size = new System.Drawing.Size(60, 17);
            this.radioButton_plovdiv.TabIndex = 7;
            this.radioButton_plovdiv.TabStop = true;
            this.radioButton_plovdiv.Text = "Plovdiv";
            this.radioButton_plovdiv.UseVisualStyleBackColor = true;
            // 
            // radioButton_sofia
            // 
            this.radioButton_sofia.AutoSize = true;
            this.radioButton_sofia.Location = new System.Drawing.Point(20, 31);
            this.radioButton_sofia.Name = "radioButton_sofia";
            this.radioButton_sofia.Size = new System.Drawing.Size(49, 17);
            this.radioButton_sofia.TabIndex = 6;
            this.radioButton_sofia.TabStop = true;
            this.radioButton_sofia.Text = "Sofia";
            this.radioButton_sofia.UseVisualStyleBackColor = true;
            // 
            // groupBox_city
            // 
            this.groupBox_city.Controls.Add(this.radioButton_plovdiv);
            this.groupBox_city.Controls.Add(this.radioButton_sofia);
            this.groupBox_city.Enabled = false;
            this.groupBox_city.Location = new System.Drawing.Point(158, 20);
            this.groupBox_city.Name = "groupBox_city";
            this.groupBox_city.Size = new System.Drawing.Size(117, 94);
            this.groupBox_city.TabIndex = 8;
            this.groupBox_city.TabStop = false;
            this.groupBox_city.Text = "Where are you from?";
            // 
            // checkBox_sofia
            // 
            this.checkBox_sofia.AutoSize = true;
            this.checkBox_sofia.Location = new System.Drawing.Point(22, 239);
            this.checkBox_sofia.Name = "checkBox_sofia";
            this.checkBox_sofia.Size = new System.Drawing.Size(50, 17);
            this.checkBox_sofia.TabIndex = 9;
            this.checkBox_sofia.Text = "Sofia";
            this.checkBox_sofia.UseVisualStyleBackColor = true;
            // 
            // checkBox_plovdiv
            // 
            this.checkBox_plovdiv.AutoSize = true;
            this.checkBox_plovdiv.Location = new System.Drawing.Point(22, 262);
            this.checkBox_plovdiv.Name = "checkBox_plovdiv";
            this.checkBox_plovdiv.Size = new System.Drawing.Size(61, 17);
            this.checkBox_plovdiv.TabIndex = 10;
            this.checkBox_plovdiv.Text = "Plovdiv";
            this.checkBox_plovdiv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Where are you from?";
            // 
            // button_submitCheckboxes
            // 
            this.button_submitCheckboxes.Location = new System.Drawing.Point(22, 293);
            this.button_submitCheckboxes.Name = "button_submitCheckboxes";
            this.button_submitCheckboxes.Size = new System.Drawing.Size(109, 30);
            this.button_submitCheckboxes.TabIndex = 12;
            this.button_submitCheckboxes.Text = "Submit checkboxes";
            this.button_submitCheckboxes.UseVisualStyleBackColor = true;
            this.button_submitCheckboxes.Click += new System.EventHandler(this.button_submitCheckboxes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.Controls.Add(this.button_submitCheckboxes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_plovdiv);
            this.Controls.Add(this.checkBox_sofia);
            this.Controls.Add(this.groupBox_city);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.radioButton_math);
            this.Controls.Add(this.radioButton_science);
            this.Controls.Add(this.radioButton_informatics);
            this.Controls.Add(this.label_question);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_city.ResumeLayout(false);
            this.groupBox_city.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.RadioButton radioButton_informatics;
        private System.Windows.Forms.RadioButton radioButton_science;
        private System.Windows.Forms.RadioButton radioButton_math;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.RadioButton radioButton_plovdiv;
        private System.Windows.Forms.RadioButton radioButton_sofia;
        private System.Windows.Forms.GroupBox groupBox_city;
        private System.Windows.Forms.CheckBox checkBox_sofia;
        private System.Windows.Forms.CheckBox checkBox_plovdiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_submitCheckboxes;
    }
}

