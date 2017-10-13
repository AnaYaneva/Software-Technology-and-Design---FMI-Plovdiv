namespace Calculator
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
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_sign = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(14, 25);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(55, 20);
            this.textBox_a.TabIndex = 0;
            this.textBox_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_a_KeyPress);
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(115, 25);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(55, 20);
            this.textBox_b.TabIndex = 1;
            this.textBox_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_b_KeyPress);
            // 
            // textBox_result
            // 
            this.textBox_result.Enabled = false;
            this.textBox_result.Location = new System.Drawing.Point(217, 25);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(55, 20);
            this.textBox_result.TabIndex = 2;
            // 
            // label_sign
            // 
            this.label_sign.AutoSize = true;
            this.label_sign.Location = new System.Drawing.Point(88, 28);
            this.label_sign.Name = "label_sign";
            this.label_sign.Size = new System.Drawing.Size(16, 13);
            this.label_sign.TabIndex = 3;
            this.label_sign.Text = "...";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(186, 32);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(13, 13);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "=";
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(14, 61);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(32, 35);
            this.button_plus.TabIndex = 5;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(52, 61);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(32, 35);
            this.button_minus.TabIndex = 6;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_product
            // 
            this.button_product.Location = new System.Drawing.Point(91, 61);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(32, 35);
            this.button_product.TabIndex = 7;
            this.button_product.Text = "*";
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(129, 61);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(32, 35);
            this.button_division.TabIndex = 8;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(189, 61);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(83, 35);
            this.button_result.TabIndex = 9;
            this.button_result.Text = "=";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(189, 118);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(83, 28);
            this.button_close.TabIndex = 10;
            this.button_close.Text = "Close form";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_sign);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_sign;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_close;
    }
}

