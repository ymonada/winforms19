using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms19.Interfaces;
using WinForms19.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms19
{
    public partial class RectangleForm : Form
    {
        public List<Models.Rectangle> Rectangles = new List<Models.Rectangle>();
        public static string rectanglepath = "D:\\zhenya\\cw\\WinForms19\\WinForms19\\Files\\rectangles.txt";
        
        public RectangleForm()
        {
            InitializeComponent();
        }

        private void RectangleForm_Load(object sender, EventArgs e)
        {
            if (Rectangles != null)
                Refresh();
        }
        public void Refresh()
        {
            var res = string.Empty;
            foreach (var figure in Rectangles)
            {
                res += figure.ToStringLine();
            }
            RectangleListLabel.Text = res;
        }
        private void AddRectangle_Click(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;
            var textX1 = textBoxX1.Text;
            var textX2 = textBoxX2.Text;
            var textY1 = textBoxY1.Text;
            var textY2 = textBoxY2.Text;
            try
            {
                ErrorLabel.Text = string.Empty;
                x1 = int.Parse(textX1);
                x2 = int.Parse(textX2);
                y1 = int.Parse(textY1);
                y2 = int.Parse(textY2);
                Rectangles.Add(new Models.Rectangle(new Point(x1, y1)
                    , new Point(x2, y1)
                    , new Point(x2, y2)
                    , new Point(x1, y2)
                    , Color.Black));
                FileReaderWriter.Write(Rectangles, rectanglepath);
                Refresh();
                textBoxX1.Text = string.Empty;
                textBoxX2.Text = string.Empty;
                textBoxY1.Text = string.Empty;
                textBoxY2.Text = string.Empty;
            }
            catch
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Error in data types";
            }
        }
    }
}
