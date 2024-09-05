namespace WinForms19
{
    partial class FilesForm
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
            TrianglesFileButtom = new Button();
            RectanglesFileButton = new Button();
            FinalFileButton = new Button();
            FileTextBox = new TextBox();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // TrianglesFileButtom
            // 
            TrianglesFileButtom.FlatAppearance.BorderSize = 0;
            TrianglesFileButtom.FlatStyle = FlatStyle.Flat;
            TrianglesFileButtom.ForeColor = Color.FromArgb(235, 219, 178);
            TrianglesFileButtom.Location = new Point(0, 0);
            TrianglesFileButtom.Margin = new Padding(0);
            TrianglesFileButtom.Name = "TrianglesFileButtom";
            TrianglesFileButtom.Size = new Size(200, 50);
            TrianglesFileButtom.TabIndex = 0;
            TrianglesFileButtom.Text = "Трикутники";
            TrianglesFileButtom.UseVisualStyleBackColor = true;
            TrianglesFileButtom.Click += TrianglesFileButtom_Click;
            // 
            // RectanglesFileButton
            // 
            RectanglesFileButton.FlatAppearance.BorderSize = 0;
            RectanglesFileButton.FlatStyle = FlatStyle.Flat;
            RectanglesFileButton.ForeColor = Color.FromArgb(235, 219, 178);
            RectanglesFileButton.Location = new Point(0, 50);
            RectanglesFileButton.Margin = new Padding(0);
            RectanglesFileButton.Name = "RectanglesFileButton";
            RectanglesFileButton.Size = new Size(200, 50);
            RectanglesFileButton.TabIndex = 1;
            RectanglesFileButton.Text = "Прямокутники";
            RectanglesFileButton.UseVisualStyleBackColor = true;
            RectanglesFileButton.Click += RectanglesFileButton_Click;
            // 
            // FinalFileButton
            // 
            FinalFileButton.FlatAppearance.BorderSize = 0;
            FinalFileButton.FlatStyle = FlatStyle.Flat;
            FinalFileButton.ForeColor = Color.FromArgb(235, 219, 178);
            FinalFileButton.Location = new Point(0, 100);
            FinalFileButton.Margin = new Padding(0);
            FinalFileButton.Name = "FinalFileButton";
            FinalFileButton.Size = new Size(200, 50);
            FinalFileButton.TabIndex = 2;
            FinalFileButton.Text = "Кінцеві трикутники";
            FinalFileButton.UseVisualStyleBackColor = true;
            FinalFileButton.Click += FinalFileButton_Click;
            // 
            // FileTextBox
            // 
            FileTextBox.BackColor = Color.FromArgb(50, 48, 47);
            FileTextBox.BorderStyle = BorderStyle.None;
            FileTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FileTextBox.ForeColor = Color.FromArgb(235, 219, 178);
            FileTextBox.Location = new Point(203, 0);
            FileTextBox.Margin = new Padding(0);
            FileTextBox.Multiline = true;
            FileTextBox.Name = "FileTextBox";
            FileTextBox.ScrollBars = ScrollBars.Vertical;
            FileTextBox.Size = new Size(861, 679);
            FileTextBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.ForeColor = Color.FromArgb(235, 219, 178);
            SaveButton.Location = new Point(0, 150);
            SaveButton.Margin = new Padding(0);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(200, 50);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Зберегти";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // FilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1064, 681);
            ControlBox = false;
            Controls.Add(SaveButton);
            Controls.Add(FileTextBox);
            Controls.Add(FinalFileButton);
            Controls.Add(RectanglesFileButton);
            Controls.Add(TrianglesFileButtom);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FilesForm";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "FilesForm";
            Load += FilesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TrianglesFileButtom;
        private Button RectanglesFileButton;
        private Button FinalFileButton;
        private TextBox FileTextBox;
        private Button SaveButton;
    }
}