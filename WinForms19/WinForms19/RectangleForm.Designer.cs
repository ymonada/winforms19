namespace WinForms19
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
            textBoxY2 = new TextBox();
            AddRectangle = new Button();
            textBoxX2 = new TextBox();
            ErrorLabel = new Label();
            textBoxX4 = new TextBox();
            textBoxY4 = new TextBox();
            textBoxAlpha = new TextBox();
            label1 = new Label();
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
            // textBoxY2
            // 
            textBoxY2.BackColor = Color.FromArgb(50, 48, 47);
            textBoxY2.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxY2.Location = new Point(901, 116);
            textBoxY2.Name = "textBoxY2";
            textBoxY2.Size = new Size(100, 23);
            textBoxY2.TabIndex = 2;
            // 
            // AddRectangle
            // 
            AddRectangle.BackColor = Color.FromArgb(40, 40, 40);
            AddRectangle.ForeColor = Color.FromArgb(235, 219, 178);
            AddRectangle.Location = new Point(881, 619);
            AddRectangle.Name = "AddRectangle";
            AddRectangle.Size = new Size(171, 50);
            AddRectangle.TabIndex = 3;
            AddRectangle.Text = "Добавити";
            AddRectangle.UseVisualStyleBackColor = false;
            AddRectangle.Click += AddRectangle_Click;
            // 
            // textBoxX2
            // 
            textBoxX2.BackColor = Color.FromArgb(50, 48, 47);
            textBoxX2.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxX2.Location = new Point(901, 87);
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
            // textBoxX4
            // 
            textBoxX4.BackColor = Color.FromArgb(50, 48, 47);
            textBoxX4.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxX4.Location = new Point(608, 380);
            textBoxX4.Name = "textBoxX4";
            textBoxX4.Size = new Size(100, 23);
            textBoxX4.TabIndex = 8;
            // 
            // textBoxY4
            // 
            textBoxY4.BackColor = Color.FromArgb(50, 48, 47);
            textBoxY4.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxY4.Location = new Point(608, 409);
            textBoxY4.Name = "textBoxY4";
            textBoxY4.Size = new Size(100, 23);
            textBoxY4.TabIndex = 7;
            // 
            // textBoxAlpha
            // 
            textBoxAlpha.BackColor = Color.FromArgb(50, 48, 47);
            textBoxAlpha.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxAlpha.Location = new Point(901, 472);
            textBoxAlpha.Name = "textBoxAlpha";
            textBoxAlpha.Size = new Size(100, 23);
            textBoxAlpha.TabIndex = 9;
            textBoxAlpha.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(235, 219, 178);
            label1.Location = new Point(790, 472);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 10;
            label1.Text = "Кут нахилу";
            // 
            // RectangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 48, 47);
            ClientSize = new Size(1064, 681);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(textBoxAlpha);
            Controls.Add(textBoxX4);
            Controls.Add(textBoxY4);
            Controls.Add(ErrorLabel);
            Controls.Add(textBoxX2);
            Controls.Add(AddRectangle);
            Controls.Add(textBoxY2);
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
        private TextBox textBoxY2;
        private Button AddRectangle;
        private TextBox textBoxX2;
        private Label ErrorLabel;
        private TextBox textBoxX4;
        private TextBox textBoxY4;
        private TextBox textBoxAlpha;
        private Label label1;
    }
}