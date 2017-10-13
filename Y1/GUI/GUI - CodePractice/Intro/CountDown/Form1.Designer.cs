namespace CountDown
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
            this.components = new System.ComponentModel.Container();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label_info = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_seconds = new System.Windows.Forms.Label();
            this.label_timesUp = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(137, 15);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(83, 20);
            this.textBox_time.TabIndex = 0;
            this.textBox_time.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_time_KeyDown);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(21, 18);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(93, 13);
            this.label_info.TabIndex = 1;
            this.label_info.Text = "Enter start number";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(42, 56);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(165, 35);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_seconds
            // 
            this.label_seconds.AutoSize = true;
            this.label_seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_seconds.Location = new System.Drawing.Point(107, 125);
            this.label_seconds.Name = "label_seconds";
            this.label_seconds.Size = new System.Drawing.Size(21, 20);
            this.label_seconds.TabIndex = 3;
            this.label_seconds.Text = "...";
            // 
            // label_timesUp
            // 
            this.label_timesUp.AutoSize = true;
            this.label_timesUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_timesUp.ForeColor = System.Drawing.Color.Red;
            this.label_timesUp.Location = new System.Drawing.Point(70, 172);
            this.label_timesUp.Name = "label_timesUp";
            this.label_timesUp.Size = new System.Drawing.Size(87, 19);
            this.label_timesUp.TabIndex = 4;
            this.label_timesUp.Text = "Time\'s up!";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(42, 225);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(165, 25);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 262);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label_timesUp);
            this.Controls.Add(this.label_seconds);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.textBox_time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_seconds;
        private System.Windows.Forms.Label label_timesUp;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button_reset;
    }
}

