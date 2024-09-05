namespace WinForms19
{
    partial class Form1
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
            ButtonsPanel = new Panel();
            FilesButton = new Button();
            NestingButtom = new Button();
            CrossButtom = new Button();
            DrawingButtom = new Button();
            RectangleButton = new Button();
            TriangleButtom = new Button();
            HeaderLabel = new Label();
            MainPanel = new Panel();
            ButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonsPanel.BackColor = Color.FromArgb(40, 40, 40);
            ButtonsPanel.Controls.Add(FilesButton);
            ButtonsPanel.Controls.Add(NestingButtom);
            ButtonsPanel.Controls.Add(CrossButtom);
            ButtonsPanel.Controls.Add(DrawingButtom);
            ButtonsPanel.Controls.Add(RectangleButton);
            ButtonsPanel.Controls.Add(TriangleButtom);
            ButtonsPanel.Controls.Add(HeaderLabel);
            ButtonsPanel.Location = new Point(0, 0);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(200, 681);
            ButtonsPanel.TabIndex = 0;
            // 
            // FilesButton
            // 
            FilesButton.FlatAppearance.BorderSize = 0;
            FilesButton.FlatStyle = FlatStyle.Flat;
            FilesButton.ForeColor = Color.FromArgb(235, 219, 178);
            FilesButton.Location = new Point(0, 300);
            FilesButton.Name = "FilesButton";
            FilesButton.Size = new Size(200, 50);
            FilesButton.TabIndex = 6;
            FilesButton.Text = "Файли";
            FilesButton.UseVisualStyleBackColor = true;
            FilesButton.Click += FilesButton_Click;
            // 
            // NestingButtom
            // 
            NestingButtom.FlatAppearance.BorderSize = 0;
            NestingButtom.FlatStyle = FlatStyle.Flat;
            NestingButtom.ForeColor = Color.FromArgb(235, 219, 178);
            NestingButtom.Location = new Point(0, 200);
            NestingButtom.Margin = new Padding(0);
            NestingButtom.Name = "NestingButtom";
            NestingButtom.Size = new Size(200, 50);
            NestingButtom.TabIndex = 5;
            NestingButtom.Text = "Вкладеність";
            NestingButtom.UseVisualStyleBackColor = true;
            NestingButtom.Click += NestingButtom_Click;
            // 
            // CrossButtom
            // 
            CrossButtom.FlatAppearance.BorderSize = 0;
            CrossButtom.FlatStyle = FlatStyle.Flat;
            CrossButtom.ForeColor = Color.FromArgb(235, 219, 178);
            CrossButtom.Location = new Point(0, 250);
            CrossButtom.Name = "CrossButtom";
            CrossButtom.Size = new Size(200, 50);
            CrossButtom.TabIndex = 4;
            CrossButtom.Text = "Перетин";
            CrossButtom.UseVisualStyleBackColor = true;
            CrossButtom.Click += CrossButtom_Click;
            // 
            // DrawingButtom
            // 
            DrawingButtom.FlatAppearance.BorderSize = 0;
            DrawingButtom.FlatStyle = FlatStyle.Flat;
            DrawingButtom.ForeColor = Color.FromArgb(235, 219, 178);
            DrawingButtom.Location = new Point(0, 150);
            DrawingButtom.Name = "DrawingButtom";
            DrawingButtom.Size = new Size(200, 50);
            DrawingButtom.TabIndex = 3;
            DrawingButtom.Text = "Малювання";
            DrawingButtom.UseVisualStyleBackColor = true;
            DrawingButtom.Click += DrawingButtom_Click;
            // 
            // RectangleButton
            // 
            RectangleButton.FlatAppearance.BorderSize = 0;
            RectangleButton.FlatStyle = FlatStyle.Flat;
            RectangleButton.ForeColor = Color.FromArgb(235, 219, 178);
            RectangleButton.Location = new Point(0, 100);
            RectangleButton.Margin = new Padding(0);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(200, 50);
            RectangleButton.TabIndex = 2;
            RectangleButton.Text = "Чотирикутники";
            RectangleButton.UseVisualStyleBackColor = true;
            RectangleButton.Click += RectangleButton_Click;
            // 
            // TriangleButtom
            // 
            TriangleButtom.BackgroundImageLayout = ImageLayout.Zoom;
            TriangleButtom.FlatAppearance.BorderSize = 0;
            TriangleButtom.FlatStyle = FlatStyle.Flat;
            TriangleButtom.ForeColor = Color.FromArgb(235, 219, 178);
            TriangleButtom.Location = new Point(0, 50);
            TriangleButtom.Margin = new Padding(0);
            TriangleButtom.Name = "TriangleButtom";
            TriangleButtom.Size = new Size(200, 50);
            TriangleButtom.TabIndex = 1;
            TriangleButtom.Text = "Трикутники";
            TriangleButtom.UseVisualStyleBackColor = true;
            TriangleButtom.Click += TriangleButtom_Click;
            // 
            // HeaderLabel
            // 
            HeaderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HeaderLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.ForeColor = Color.FromArgb(251, 241, 199);
            HeaderLabel.Location = new Point(0, 0);
            HeaderLabel.Margin = new Padding(0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(200, 50);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "    ";
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(50, 48, 47);
            MainPanel.Location = new Point(200, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1068, 681);
            MainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 48, 47);
            ClientSize = new Size(1264, 681);
            Controls.Add(MainPanel);
            Controls.Add(ButtonsPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ButtonsPanel;
        private Button TriangleButtom;
        private Label HeaderLabel;
        private Panel MainPanel;
        private Button CrossButtom;
        private Button DrawingButtom;
        private Button RectangleButton;
        private Button NestingButtom;
        private Button FilesButton;
    }
}
