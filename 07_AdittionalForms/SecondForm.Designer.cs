﻿namespace _07_AdittionalForms
{
    partial class SecondForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserLb = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(768, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 109);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(403, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Second Form";
            // 
            // UserLb
            // 
            this.UserLb.AutoSize = true;
            this.UserLb.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLb.Location = new System.Drawing.Point(442, 337);
            this.UserLb.Name = "UserLb";
            this.UserLb.Size = new System.Drawing.Size(208, 62);
            this.UserLb.TabIndex = 4;
            this.UserLb.Text = "Hello, .....";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 109);
            this.button2.TabIndex = 5;
            this.button2.Text = "Show User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 710);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UserLb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserLb;
        private System.Windows.Forms.Button button2;
    }
}