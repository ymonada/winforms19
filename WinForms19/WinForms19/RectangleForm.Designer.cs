﻿namespace WinForms19
{
    partial class RectangleForm
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
            panel1 = new Panel();
            RectangleListLabel = new Label();
            textBoxX1 = new TextBox();
            textBoxY2 = new TextBox();
            AddRectangle = new Button();
            textBoxY1 = new TextBox();
            textBoxX2 = new TextBox();
            ErrorLabel = new Label();
            textBoxX3 = new TextBox();
            textBoxY3 = new TextBox();
            textBoxX4 = new TextBox();
            textBoxY4 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(RectangleListLabel);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 689);
            panel1.TabIndex = 0;
            // 
            // RectangleListLabel
            // 
            RectangleListLabel.BackColor = Color.FromArgb(50, 48, 47);
            RectangleListLabel.Font = new Font("Microsoft Sans Serif", 14.25F);
            RectangleListLabel.ForeColor = Color.FromArgb(235, 219, 178);
            RectangleListLabel.Location = new Point(0, 0);
            RectangleListLabel.Name = "RectangleListLabel";
            RectangleListLabel.Size = new Size(635, 689);
            RectangleListLabel.TabIndex = 0;
            // 
            // textBoxX1
            // 
            textBoxX1.Location = new Point(655, 96);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.Size = new Size(100, 23);
            textBoxX1.TabIndex = 1;
            // 
            // textBoxY2
            // 
            textBoxY2.Location = new Point(874, 125);
            textBoxY2.Name = "textBoxY2";
            textBoxY2.Size = new Size(100, 23);
            textBoxY2.TabIndex = 2;
            // 
            // AddRectangle
            // 
            AddRectangle.BackColor = Color.FromArgb(40, 40, 40);
            AddRectangle.ForeColor = Color.FromArgb(235, 219, 178);
            AddRectangle.Location = new Point(707, 459);
            AddRectangle.Name = "AddRectangle";
            AddRectangle.Size = new Size(171, 50);
            AddRectangle.TabIndex = 3;
            AddRectangle.Text = "Добавити";
            AddRectangle.UseVisualStyleBackColor = false;
            AddRectangle.Click += AddRectangle_Click;
            // 
            // textBoxY1
            // 
            textBoxY1.Location = new Point(655, 125);
            textBoxY1.Name = "textBoxY1";
            textBoxY1.Size = new Size(100, 23);
            textBoxY1.TabIndex = 4;
            // 
            // textBoxX2
            // 
            textBoxX2.Location = new Point(874, 96);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.Size = new Size(100, 23);
            textBoxX2.TabIndex = 5;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(689, 28);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 6;
            // 
            // textBoxX3
            // 
            textBoxX3.Location = new Point(655, 282);
            textBoxX3.Name = "textBoxX3";
            textBoxX3.Size = new Size(100, 23);
            textBoxX3.TabIndex = 8;
            // 
            // textBoxY3
            // 
            textBoxY3.Location = new Point(655, 311);
            textBoxY3.Name = "textBoxY3";
            textBoxY3.Size = new Size(100, 23);
            textBoxY3.TabIndex = 7;
            // 
            // textBoxX4
            // 
            textBoxX4.Location = new Point(874, 282);
            textBoxX4.Name = "textBoxX4";
            textBoxX4.Size = new Size(100, 23);
            textBoxX4.TabIndex = 10;
            // 
            // textBoxY4
            // 
            textBoxY4.Location = new Point(874, 311);
            textBoxY4.Name = "textBoxY4";
            textBoxY4.Size = new Size(100, 23);
            textBoxY4.TabIndex = 9;
            // 
            // RectangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 48, 47);
            ClientSize = new Size(1064, 681);
            ControlBox = false;
            Controls.Add(textBoxX4);
            Controls.Add(textBoxY4);
            Controls.Add(textBoxX3);
            Controls.Add(textBoxY3);
            Controls.Add(ErrorLabel);
            Controls.Add(textBoxX2);
            Controls.Add(textBoxY1);
            Controls.Add(AddRectangle);
            Controls.Add(textBoxY2);
            Controls.Add(textBoxX1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "RectangleForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "RectangleForm";
            Load += RectangleForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label RectangleListLabel;
        private TextBox textBoxX1;
        private TextBox textBoxY2;
        private Button AddRectangle;
        private TextBox textBoxY1;
        private TextBox textBoxX2;
        private Label ErrorLabel;
        private TextBox textBoxX3;
        private TextBox textBoxY3;
        private TextBox textBoxX4;
        private TextBox textBoxY4;
    }
}