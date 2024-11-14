using System.Drawing;
using WinForms19.Interfaces;
using WinForms19.Models;

namespace WinForms19
{
    public partial class Form1 : Form
    {
        TriangleForm TriangleForm = new TriangleForm()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true
        };
        RectangleForm RectangleForm = new RectangleForm()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true
        };
        FilesForm FilesForm = new FilesForm()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true
        };
        List<Triangle> FinalTriangles = new List<Triangle>();
        public static string finalpath = "C:\\dotnet\\winforms19\\WinForms19\\WinForms19\\Files\\finalTriangles.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HeaderLabel.Text = "Variant 19";
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {

            HeaderLabel.Text = "Rectangle";
            RectangleForm.Refresh();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(RectangleForm);
            RectangleForm.Show();
        }

        private void TriangleButtom_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = "Triangle";
            TriangleForm.Refresh();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(TriangleForm);
            TriangleForm.Show();
        }
        private void FilesButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = "Files";
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(FilesForm);
            FilesForm.Show();
        }


        private void DrawingButtom_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = "Draw";
            if (TriangleForm.Triangles != null && RectangleForm.Rectangles != null)
            {
                foreach (var i in TriangleForm.Triangles)
                    i._Color = Color.Black;
                foreach (var i in RectangleForm.Rectangles)
                    i._Color = Color.Black;
            }
            MainPanel.Controls.Clear();
            MainPanel.Paint += new PaintEventHandler(PanelDraw);
            MainPanel.Refresh();

        }

        private bool IsNested(Models.Rectangle rect, Triangle tri)
        {
            if (tri._A.X >= rect._A.X && tri._A.X <= rect._C.X
                && tri._A.Y >= rect._A.Y && tri._A.Y <= rect._C.Y)
            {
                if (tri._B.X >= rect._A.X && tri._B.X <= rect._C.X
                   && tri._B.Y >= rect._A.Y && tri._B.Y <= rect._C.Y)
                {
                    if (tri._C.X >= rect._A.X && tri._C.X <= rect._C.X
                       && tri._C.Y >= rect._A.Y && tri._C.Y <= rect._C.Y)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }


        private void PanelDraw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Drawing(TriangleForm.Triangles, g);
            Drawing(RectangleForm.Rectangles, g);
        }
        private void Drawing(IEnumerable<IFigure> collection, Graphics g)
        {
            if (collection != null)
            {
                foreach (var i in collection)
                {
                    i.Drawing(g, new Pen(i._Color, 3));
                }
            }
        }

        private void CrossButtom_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = "Cross";
            if (TriangleForm.Triangles != null && RectangleForm.Rectangles != null)
            {
                for (int i = 0; i < TriangleForm.Triangles.Count; i++)
                {
                    for (int j = i; j < TriangleForm.Triangles.Count; j++)
                    {
                        if (i != j)
                        {
                            var A = TriangleForm.Triangles[j]._A.ToPoint();
                            var B = TriangleForm.Triangles[j]._B.ToPoint();
                            var C = TriangleForm.Triangles[j]._C.ToPoint();
                            var AA = TriangleForm.Triangles[i]._A.ToPoint();
                            var BB = TriangleForm.Triangles[i]._B.ToPoint();
                            var CC = TriangleForm.Triangles[i]._C.ToPoint();
                            if ((DoSegmentsIntersect(A, B, AA, BB) ||
                                DoSegmentsIntersect(A, B, AA, CC) ||
                                DoSegmentsIntersect(A, B, CC, BB) ||

                                DoSegmentsIntersect(A, C, AA, BB) ||
                                DoSegmentsIntersect(A, C, AA, CC) ||
                                DoSegmentsIntersect(A, C, CC, BB) ||

                                DoSegmentsIntersect(C, B, AA, BB) ||
                                DoSegmentsIntersect(C, B, AA, CC) ||
                                DoSegmentsIntersect(C, B, CC, BB)) &&
                                TriangleForm.Triangles[i].IsNested &&
                                TriangleForm.Triangles[j].IsNested)
                            {
                                TriangleForm.Triangles[j]._Color = Color.FromArgb(131, 165, 152);
                                TriangleForm.Triangles[i]._Color = Color.FromArgb(131, 165, 152);

                            }
                        }
                    }
                }

                FinalTriangles = TriangleForm.Triangles.Where(c => c._Color == Color.FromArgb(131, 165, 152)).ToList();
                FileReaderWriter.Write(FinalTriangles, finalpath);
            }
            MainPanel.Controls.Clear();
            MainPanel.Paint += new PaintEventHandler(PanelDraw);
            MainPanel.Refresh();
        }

        private static bool PositionRelativeToLine(Models.Point A, Models.Point B, Models.Point tC)
        {
            double crossProduct = (B.X - A.X) * (tC.Y - A.Y) - (B.Y - A.Y) * (tC.X - A.X);
            return (crossProduct > 0);

        }
        private static bool IsPointInsideRectangle(Models.Rectangle rec, Models.Point A)
        {
            bool isLeft1 = PositionRelativeToLine(rec._A, rec._B, A);
            bool isLeft2 = PositionRelativeToLine(rec._B, rec._C, A);
            bool isLeft3 = PositionRelativeToLine(rec._C, rec._D, A);
            bool isLeft4 = PositionRelativeToLine(rec._D, rec._A, A);

            // Проверяем, что точка A находится внутри прямоугольника
            return (isLeft1 == isLeft2) && (isLeft2 == isLeft3) && (isLeft3 == isLeft4);
        }
        public static bool DoSegmentsIntersect(System.Drawing.Point A, System.Drawing.Point B, System.Drawing.Point C, System.Drawing.Point D)
        {
            // Вспомогательная функция для определения ориентации трёх точек
            int Orientation(System.Drawing.Point p, System.Drawing.Point q, System.Drawing.Point r)
            {
                int val = (q.Y - p.Y) * (r.X - q.X) - (q.X - p.X) * (r.Y - q.Y);

                if (val == 0) return 0; // коллинеарные
                return (val > 0) ? 1 : 2; // часовая или против часовой стрелки
            }

            // Проверка пересечения двух отрезков
            bool OnSegment(System.Drawing.Point p, System.Drawing.Point q, System.Drawing.Point r)
            {
                if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                    q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
                    return true;
                return false;
            }

            // Определение ориентации для четырех комбинаций
            int o1 = Orientation(A, B, C);
            int o2 = Orientation(A, B, D);
            int o3 = Orientation(C, D, A);
            int o4 = Orientation(C, D, B);

            // Основной случай
            if (o1 != o2 && o3 != o4)
                return true;

            // Специальные случаи
            // A, B и C коллинеарны и C лежит на отрезке AB
            if (o1 == 0 && OnSegment(A, C, B)) return true;

            // A, B и D коллинеарны и D лежит на отрезке AB
            if (o2 == 0 && OnSegment(A, D, B)) return true;

            // C, D и A коллинеарны и A лежит на отрезке CD
            if (o3 == 0 && OnSegment(C, A, D)) return true;

            // C, D и B коллинеарны и B лежит на отрезке CD
            if (o4 == 0 && OnSegment(C, B, D)) return true;

            // Отрезки не пересекаются
            return false;
        }
        private void NestingButtom_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = "Include";
            for (int i = 0; i < TriangleForm.Triangles.Count; i++)
            {
                for (int j = 0; j < RectangleForm.Rectangles.Count; j++)
                {

                    bool result = IsPointInsideRectangle(RectangleForm.Rectangles[j], TriangleForm.Triangles[i]._A) &&
                        IsPointInsideRectangle(RectangleForm.Rectangles[j], TriangleForm.Triangles[i]._B) &&
                        IsPointInsideRectangle(RectangleForm.Rectangles[j], TriangleForm.Triangles[i]._C);


                    if (result)
                    //TriangleForm.Triangles[j]._Color != Color.Black)
                    {
                        TriangleForm.Triangles[i]._Color = Color.FromArgb(251, 73, 52);
                        TriangleForm.Triangles[i].IsNested = true;
                    }
                }
            }

            MainPanel.Controls.Clear();
            MainPanel.Paint += new PaintEventHandler(PanelDraw);
            MainPanel.Refresh();
        }

        private void ButtonsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
