namespace _1601682032_GUI
{
    partial class Form_links
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
            this.linkLabel_bnb = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel_bnb
            // 
            this.linkLabel_bnb.AutoSize = true;
            this.linkLabel_bnb.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_bnb.ForeColor = System.Drawing.Color.MintCream;
            this.linkLabel_bnb.LinkColor = System.Drawing.Color.PaleTurquoise;
            this.linkLabel_bnb.Location = new System.Drawing.Point(65, 79);
            this.linkLabel_bnb.Name = "linkLabel_bnb";
            this.linkLabel_bnb.Size = new System.Drawing.Size(208, 22);
            this.linkLabel_bnb.TabIndex = 0;
            this.linkLabel_bnb.TabStop = true;
            this.linkLabel_bnb.Text = "http://www.bnb.bg/";
            this.linkLabel_bnb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_bnb_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "- Българска народна банка";
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ok.FlatAppearance.BorderSize = 0;
            this.button_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.ForeColor = System.Drawing.Color.White;
            this.button_ok.Location = new System.Drawing.Point(102, 470);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(180, 60);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Form_links
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel_bnb);
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Form_links";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Полезни връзки";
            this.Load += new System.EventHandler(this.Form_links_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_bnb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ok;
    }
}