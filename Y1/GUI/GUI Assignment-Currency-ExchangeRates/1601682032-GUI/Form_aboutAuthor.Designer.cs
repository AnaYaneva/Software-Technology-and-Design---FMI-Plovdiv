namespace _1601682032_GUI
{
    partial class Form_aboutAuthor
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
            this.label_creator = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.pictureBox_about = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_about)).BeginInit();
            this.SuspendLayout();
            // 
            // label_creator
            // 
            this.label_creator.AutoSize = true;
            this.label_creator.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_creator.ForeColor = System.Drawing.Color.MintCream;
            this.label_creator.Location = new System.Drawing.Point(12, 222);
            this.label_creator.Name = "label_creator";
            this.label_creator.Size = new System.Drawing.Size(307, 66);
            this.label_creator.TabIndex = 5;
            this.label_creator.Text = "Създал:  Ана Христова Янева\r\ne-mail:  ana_yaneva@abv.bg\r\nФН:      1601682032";
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_ok.FlatAppearance.BorderSize = 0;
            this.button_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.ForeColor = System.Drawing.Color.MintCream;
            this.button_ok.Location = new System.Drawing.Point(311, 453);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(180, 60);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // pictureBox_about
            // 
            this.pictureBox_about.Image = global::_1601682032_GUI.Properties.Resources.nova_sgrada__1_;
            this.pictureBox_about.Location = new System.Drawing.Point(358, 33);
            this.pictureBox_about.Name = "pictureBox_about";
            this.pictureBox_about.Size = new System.Drawing.Size(331, 255);
            this.pictureBox_about.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_about.TabIndex = 6;
            this.pictureBox_about.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(8, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Факултет по математика и информатика към\r\nПловдивски университет \"Паисий Хилендар" +
    "ски\"\r\n";
            // 
            // Form_aboutAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_about);
            this.Controls.Add(this.label_creator);
            this.Controls.Add(this.button_ok);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form_aboutAuthor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Относно автора";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_about)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_about;
        private System.Windows.Forms.Label label_creator;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label1;
    }
}