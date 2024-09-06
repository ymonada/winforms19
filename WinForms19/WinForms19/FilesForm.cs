using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms19.Models;

namespace WinForms19
{
    public partial class FilesForm : Form
    {
        public FilesForm()
        {
            InitializeComponent();
        }
        string TrianglePath = TriangleForm.trianglepath;
        string RectAnglePath = RectangleForm.rectanglepath;
        string FinalPath = Form1.finalpath;
        string curentPath = string.Empty;

        private void FilesForm_Load(object sender, EventArgs e)
        {

        }

        private void TrianglesFileButtom_Click(object sender, EventArgs e)
        {
            curentPath = TrianglePath;
            string content = FileReaderWriter.ReadText(curentPath);
            FileTextBox.Text = content;
        }

        private void RectanglesFileButton_Click(object sender, EventArgs e)
        {
            curentPath = RectAnglePath;
            string content = FileReaderWriter.ReadText(curentPath);
            FileTextBox.Text = content;
        }

        private void FinalFileButton_Click(object sender, EventArgs e)
        {
            curentPath = FinalPath;
            string content = FileReaderWriter.ReadText(curentPath);
            FileTextBox.Text = content;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            var result = FileTextBox.Text;
            FileReaderWriter.WriteText(result, curentPath);
        }

        private void FileTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
