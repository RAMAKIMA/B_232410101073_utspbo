﻿namespace UTS
{
    partial class Form6
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Coolvetica Rg", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 109);
            label1.Name = "label1";
            label1.Size = new Size(724, 48);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang di Task Management App!";
            // 
            // button1
            // 
            button1.Location = new Point(321, 221);
            button1.Name = "button1";
            button1.Size = new Size(145, 29);
            button1.TabIndex = 1;
            button1.Text = "Daftar Tugas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(343, 185);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Pilih Menu:";
            // 
            // button2
            // 
            button2.Location = new Point(321, 268);
            button2.Name = "button2";
            button2.Size = new Size(145, 29);
            button2.TabIndex = 3;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(321, 314);
            button3.Name = "button3";
            button3.Size = new Size(145, 29);
            button3.TabIndex = 4;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(321, 360);
            button4.Name = "button4";
            button4.Size = new Size(145, 29);
            button4.TabIndex = 5;
            button4.Text = "Keluar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "TaskManagementApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}