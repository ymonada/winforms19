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
        public static string rectanglepath = "Files\\rectangles.txt";

        public RectangleForm()
        {
            InitializeComponent();
            Paint += (s, e) =>
            {
                var g = e.Graphics;
                var pen = new Pen(Color.DodgerBlue, 3);
                g.DrawLine(pen, 650, 150, 950, 150);
                g.DrawLine(pen, 950, 150, 950, 370);
                g.DrawLine(pen, 950, 370, 650, 370);
                g.DrawLine(pen, 650, 370, 650, 150);
            };
        }

        private void RectangleForm_Load(object sender, EventArgs e)
        {
            if (Rectangles.Count < 1)
                AddFigure();
        }
        public void AddFigure()
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
            double x1, x2, y1, y2, x3, y3, x4, y4;           
            var alpha = int.Parse(textBoxAlpha.Text);
            try
            {
                ErrorLabel.Text = string.Empty;

                x2 = double.Parse(textBoxX2.Text);
                y2 = double.Parse(textBoxY2.Text);
                x4 = double.Parse(textBoxX4.Text);
                y4 = double.Parse(textBoxY4.Text);
                x1 = x2;
                y1 = y4;
                x3 = x4;
                y3 = y2;
               
                    var rect = new Models.Rectangle(new Models.Point(x1, y1)
                        , new Models.Point(x2, y2)
                        , new Models.Point(x3, y3)
                        , new Models.Point(x4, y4)
                        , Color.Black);
                    Rectangles.Add(Transform(rect, alpha));

                FileReaderWriter.Write(Rectangles, rectanglepath);
                textBoxX2.Text = string.Empty;
                textBoxY2.Text = string.Empty;
                textBoxX4.Text = string.Empty;
                textBoxY4.Text = string.Empty;
                AddFigure();
            }
            catch(Exception exep) 
            {
                MessageBox.Show($"Error {exep}");
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Error in data types";
            }
        }
       
            public static Models.Rectangle Transform(Models.Rectangle rectangle, int angle)
            {
                double radians = angle * Math.PI / 180;
                int centerX = (int)(rectangle._A.X + rectangle._B.Y + rectangle._C.X + rectangle._D.X) / 4;
                int centerY = (int)(rectangle._A.Y + rectangle._B.Y + rectangle._C.Y + rectangle._D.Y) / 4;
                var newRectangle = new Models.Rectangle(
                    RotatePoint(rectangle._A)
                    , RotatePoint(rectangle._B)
                    , RotatePoint(rectangle._C)
                    , RotatePoint(rectangle._D)
                    , Models.Rectangle.DefaultColor);
                Models.Point RotatePoint(Models.Point point)
                {
                    double x = point.X - centerX;
                    double y = point.Y - centerY;
                    int rotatedX = (int)(x * Math.Cos(radians) - y * Math.Sin(radians));
                    int rotatedY = (int)(x * Math.Sin(radians) + y * Math.Cos(radians));
                    return new Models.Point(rotatedX + centerX, rotatedY + centerY);
                }
                return newRectangle;
            }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
