namespace _07_AdittionalForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginLb = new System.Windows.Forms.Label();
            this.PasswordLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(485, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Form";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 154);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Second Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name : ";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(554, 258);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(377, 47);
            this.NameTB.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(352, 153);
            this.button2.TabIndex = 4;
            this.button2.Text = "Open Login Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password :";
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(630, 365);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(39, 41);
            this.loginLb.TabIndex = 7;
            this.loginLb.Text = "...";
            // 
            // PasswordLb
            // 
            this.PasswordLb.AutoSize = true;
            this.PasswordLb.Location = new System.Drawing.Point(630, 460);
            this.PasswordLb.Name = "PasswordLb";
            this.PasswordLb.Size = new System.Drawing.Size(39, 41);
            this.PasswordLb.TabIndex = 8;
            this.PasswordLb.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 845);
            this.Controls.Add(this.PasswordLb);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label PasswordLb;
    }
}
