using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms19.Interfaces;
using WinForms19.Models;

namespace WinForms19
{
    public partial class TriangleForm : Form
    {
        public List<Triangle> Triangles = [];
        
        public static string trianglepath = "Files\\triangles.txt";
        public TriangleForm()
        {
            InitializeComponent();
            Paint += (s, e) =>
            {
                var g = e.Graphics;
                var pen = new Pen(Color.DodgerBlue, 3);
                g.DrawLine(pen, 800, 150, 950 ,370);
                g.DrawLine(pen, 950, 370, 650, 370);
                g.DrawLine(pen, 650, 370, 800, 150);
            };
        }
        private void TriangleForm_Load(object sender, EventArgs e)
        {
            if (Triangles.Count < 1)
            {
                AddFigure();
            }
        }
        private void TriangleList()
        {
            var res = string.Empty;
            foreach (var figure in Triangles)
            {
                res += figure.ToStringLine();
            }
            TriangleListLabel.Text = res;
        }
        public void AddFigure()
        {
            Triangles = FileReaderWriter.TriangleRead(trianglepath);
            TriangleList();
        }
        private void AddTriangle_Click(object sender, EventArgs e)
        {
            int x1, x2, x3, y1, y2, y3;
            var textX1 = textBoxX1.Text;
            var textX2 = textBoxX2.Text;
            var textX3 = textBoxX3.Text;
            var textY1 = textBoxY1.Text;
            var textY2 = textBoxY2.Text;
            var textY3 = textBoxY3.Text;
            try
            {
                ErrorLabel.Text = string.Empty;
                x1 = int.Parse(textX1);
                x2 = int.Parse(textX2);
                x3 = int.Parse(textX3);
                y1 = int.Parse(textY1);
                y2 = int.Parse(textY2);
                y3 = int.Parse(textY3);
                Triangles.Add(new Triangle(
                new Models.Point(x1, y1)
                , new Models.Point(x2, y2)
                , new Models.Point(x3, y3)
                , Color.Black));
                FileReaderWriter.Write(Triangles, trianglepath);
                TriangleList();
            }
            catch(Exception ex)
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = $"Error in data types {ex}";
            }

            textBoxX1.Text = string.Empty;
            textBoxX2.Text = string.Empty;
            textBoxX3.Text = string.Empty;
            textBoxY1.Text = string.Empty;
            textBoxY2.Text = string.Empty;
            textBoxY3.Text = string.Empty;
        }
        
    }
}
