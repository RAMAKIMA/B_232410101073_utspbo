﻿namespace UTS
{
    partial class Form3
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Coolvetica Rg", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(479, 48);
            label1.TabIndex = 0;
            label1.Text = "Akun Berhasil Ditambahkan!";
            // 
            // button1
            // 
            button1.Location = new Point(201, 189);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 249);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Pop Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}