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
            Rectangles = FileReaderWriter.RectangleRead(rectanglepath);
            var res = string.Empty;
            foreach (var figure in Rectangles)
            {
                res += figure.ToStringLine();
            }
            RectangleListLabel.Text = res;
        }
        private void AddRectangle_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2, x3,y3,x4,y4;
            var textX1 = textBoxX1.Text;
            var textX2 = textBoxX2.Text;
            var textY1 = textBoxY1.Text;
            var textY2 = textBoxY2.Text;
            var textX3 = textBoxX3.Text;
            var textX4 = textBoxX4.Text;
            var textY3 = textBoxY3.Text;
            var textY4 = textBoxY4.Text;
            try
            {
                ErrorLabel.Text = string.Empty;
                x1 = double.Parse(textX1);
                x2 = double.Parse(textX2);
                y1 = double.Parse(textY1);
                y2 = double.Parse(textY2);
                x3 = double.Parse(textX3);
                x4 = double.Parse(textX4);
                y3 = double.Parse(textY3);
                y4 = double.Parse(textY4);
                if(IsRectangle(new Models.Point(x1, y1)
                    , new Models.Point(x2, y2)
                    , new Models.Point(x3, y3)
                    , new Models.Point(x4, y4)))
                {
                    Rectangles.Add(new Models.Rectangle(new Models.Point(x1, y1)
                    , new Models.Point(x2, y2)
                    , new Models.Point(x3, y3)
                    , new Models.Point(x4, y4)
                    , Color.Black));
                    FileReaderWriter.Write(Rectangles, rectanglepath);
                    
                    textBoxX1.Text = string.Empty;
                    textBoxX2.Text = string.Empty;
                    textBoxY1.Text = string.Empty;
                    textBoxY2.Text = string.Empty;
                    textBoxX3.Text = string.Empty;
                    textBoxX4.Text = string.Empty;
                    textBoxY3.Text = string.Empty;
                    textBoxY4.Text = string.Empty;
                    Refresh();
                }
                else
                {
                    ErrorLabel.ForeColor = Color.Red;
                    ErrorLabel.Text = "Кути не прямокутні";
                }
            }
            catch
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Error in data types";
            }
        }
        private static double DotProduct(Models.Point p1, Models.Point p2)
        {
            return p1.X * p2.X + p1.Y * p2.Y;
        }
        private static bool IsRectangle(Models.Point p1, Models.Point p2, Models.Point p3, Models.Point p4)
        {
            Models.Point v1 = new Models.Point(p2.X - p1.X, p2.Y - p1.Y);
            Models.Point v2 = new Models.Point(p3.X - p2.X, p3.Y - p2.Y);
            Models.Point v3 = new Models.Point(p4.X - p3.X, p4.Y - p3.Y);
            Models.Point v4 = new Models.Point(p1.X - p4.X, p1.Y - p4.Y);

            bool rightAngle1 = DotProduct(v1, v2) <= 2 && DotProduct(v1, v2) >= -2;
            bool rightAngle2 = DotProduct(v2, v3) <= 2 && DotProduct(v1, v2) >= -2;
            bool rightAngle3 = DotProduct(v3, v4) <= 2 && DotProduct(v1, v2) >= -2;
            bool rightAngle4 = DotProduct(v4, v1) <= 2 && DotProduct(v1, v2) >= -2;

            return rightAngle1 && rightAngle2 && rightAngle3 && rightAngle4;
        }
    }
}
