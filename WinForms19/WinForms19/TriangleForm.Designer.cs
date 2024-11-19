namespace WinForms19
{
    partial class TriangleForm
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
            textBoxX1 = new TextBox();
            textBoxY1 = new TextBox();
            textBoxX2 = new TextBox();
            textBoxY2 = new TextBox();
            textBoxX3 = new TextBox();
            textBoxY3 = new TextBox();
            AddTriangle = new Button();
            ErrorLabel = new Label();
            TriangleListLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxX1
            // 
            textBoxX1.BackColor = Color.FromArgb(50, 48, 47);
            textBoxX1.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxX1.Location = new Point(752, 126);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.Size = new Size(100, 23);
            textBoxX1.TabIndex = 1;
            // 
            // textBoxY1
            // 
            textBoxY1.BackColor = Color.FromArgb(50, 48, 47);
            textBoxY1.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxY1.Location = new Point(752, 97);
            textBoxY1.Name = "textBoxY1";
            textBoxY1.Size = new Size(100, 23);
            textBoxY1.TabIndex = 2;
            // 
            // textBoxX2
            // 
            textBoxX2.BackColor = Color.FromArgb(50, 48, 47);
            textBoxX2.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxX2.Location = new Point(597, 381);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.Size = new Size(100, 23);
            textBoxX2.TabIndex = 3;
            // 
            // textBoxY2
            // 
            textBoxY2.BackColor = Color.FromArgb(50, 48, 47);
            textBoxY2.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxY2.Location = new Point(597, 410);
            textBoxY2.Name = "textBoxY2";
            textBoxY2.Size = new Size(100, 23);
            textBoxY2.TabIndex = 4;
            // 
            // textBoxX3
            // 
            textBoxX3.BackColor = Color.FromArgb(50, 48, 47);
            textBoxX3.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxX3.Location = new Point(895, 410);
            textBoxX3.Name = "textBoxX3";
            textBoxX3.Size = new Size(100, 23);
            textBoxX3.TabIndex = 5;
            // 
            // textBoxY3
            // 
            textBoxY3.BackColor = Color.FromArgb(50, 48, 47);
            textBoxY3.ForeColor = Color.FromArgb(235, 219, 178);
            textBoxY3.Location = new Point(895, 381);
            textBoxY3.Name = "textBoxY3";
            textBoxY3.Size = new Size(100, 23);
            textBoxY3.TabIndex = 6;
            // 
            // AddTriangle
            // 
            AddTriangle.BackColor = Color.FromArgb(40, 40, 40);
            AddTriangle.FlatAppearance.BorderSize = 0;
            AddTriangle.ForeColor = Color.FromArgb(235, 219, 178);
            AddTriangle.Location = new Point(867, 624);
            AddTriangle.Name = "AddTriangle";
            AddTriangle.Size = new Size(185, 45);
            AddTriangle.TabIndex = 7;
            AddTriangle.Text = "Додати";
            AddTriangle.UseVisualStyleBackColor = false;
            AddTriangle.Click += AddTriangle_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.ForeColor = Color.FromArgb(251, 73, 52);
            ErrorLabel.Location = new Point(737, 9);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 8;
            // 
            // TriangleListLabel
            // 
            TriangleListLabel.BackColor = Color.FromArgb(50, 48, 47);
            TriangleListLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TriangleListLabel.ForeColor = Color.FromArgb(235, 219, 178);
            TriangleListLabel.Location = new Point(0, 0);
            TriangleListLabel.Margin = new Padding(0);
            TriangleListLabel.Name = "TriangleListLabel";
            TriangleListLabel.Size = new Size(567, 684);
            TriangleListLabel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(TriangleListLabel);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 720);
            panel1.TabIndex = 0;
            // 
            // TriangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 48, 47);
            ClientSize = new Size(1064, 681);
            ControlBox = false;
            Controls.Add(ErrorLabel);
            Controls.Add(AddTriangle);
            Controls.Add(textBoxY3);
            Controls.Add(textBoxX3);
            Controls.Add(textBoxY2);
            Controls.Add(textBoxX2);
            Controls.Add(textBoxY1);
            Controls.Add(textBoxX1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TriangleForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Load += TriangleForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxX1;
        private TextBox textBoxY1;
        private TextBox textBoxX2;
        private TextBox textBoxY2;
        private TextBox textBoxX3;
        private TextBox textBoxY3;
        private Button AddTriangle;
        private Label ErrorLabel;
        private Label TriangleListLabel;
        private Panel panel1;
    }
}