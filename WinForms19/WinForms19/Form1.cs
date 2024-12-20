using System.Drawing;
using WinForms19.Interfaces;
using WinForms19.Models;

namespace WinForms19
{
    public partial class Form1 : Form
    {
        TriangleForm TriangleForm;
        RectangleForm RectangleForm;
        FilesForm FilesForm;

        List<Triangle> FinalTriangles = new List<Triangle>();
        public static string finalpath = "Files\\finalTriangles.txt";

        public Form1()
        {
            InitializeComponent();
            TriangleForm = new TriangleForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            RectangleForm = new RectangleForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            FilesForm = new FilesForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            MainPanel.Paint += PanelDraw;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HeaderLabel.Text = "������ �19";
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {           
            HeaderLabel.Text = "�������������";
            RectangleForm.AddFigure();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(RectangleForm);
            RectangleForm.Show();
        }
        private void TriangleButtom_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = "����������";
            TriangleForm.AddFigure();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(TriangleForm);
            TriangleForm.Show();
        }
        private void FilesButton_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = "�����";
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(FilesForm);
            FilesForm.Show();
        }
        private void DrawingButtom_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = "���������";
            if (TriangleForm.Triangles.Count>0)
            {
                foreach (var i in TriangleForm.Triangles)
                    i._Color = Models.Triangle.DefaultColor;
            }
            if (RectangleForm.Rectangles.Count > 0)
            {                
                foreach (var i in RectangleForm.Rectangles)
                    i._Color = Models.Rectangle.DefaultColor;
            }
            MainPanel.Controls.Clear();
            MainPanel.Refresh();
        }
        private void PanelDraw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (TriangleForm.Triangles.Count > 0)
                Drawing(TriangleForm.Triangles, g);
            if (RectangleForm.Rectangles.Count > 0)
                Drawing(RectangleForm.Rectangles, g);
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
            HeaderLabel.Text = "�������";
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
                            var a1 = DoSegmentsIntersect(A, B, AA, BB);
                            var a2 = DoSegmentsIntersect(A, B, AA, CC);
                            var a3 = DoSegmentsIntersect(A, B, CC, BB);
                            var a4 = DoSegmentsIntersect(A, C, AA, BB);
                            var a5 = DoSegmentsIntersect(A, C, AA, CC);
                            var a6 = DoSegmentsIntersect(A, C, CC, BB);
                            var a7 = DoSegmentsIntersect(C, B, AA, BB);
                            var a8 = DoSegmentsIntersect(C, B, AA, CC);
                            var a9 = DoSegmentsIntersect(C, B, CC, BB);
                            if ((a1||a2||a3||a4||a5||a6||a7||a8||a9) &&
                                TriangleForm.Triangles[i].IsNested&&
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

            // ���������, ��� ����� A ��������� ������ ��������������
            return (isLeft1 == isLeft2) && (isLeft2 == isLeft3) && (isLeft3 == isLeft4);
        }
        public static bool DoSegmentsIntersect(System.Drawing.Point A, System.Drawing.Point B, System.Drawing.Point C, System.Drawing.Point D)
        {
            // ��������������� ������� ��� ����������� ���������� ��� �����
            int Orientation(System.Drawing.Point p, System.Drawing.Point q, System.Drawing.Point r)
            {
                int val = (q.Y - p.Y) * (r.X - q.X) - (q.X - p.X) * (r.Y - q.Y);

                if (val == 0) return 0; // ������������
                return (val > 0) ? 1 : 2; // ������� ��� ������ ������� �������
            }

            // �������� ����������� ���� ��������
            bool OnSegment(System.Drawing.Point p, System.Drawing.Point q, System.Drawing.Point r)
            {
                if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                    q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
                    return true;
                return false;
            }

            // ����������� ���������� ��� ������� ����������
            int o1 = Orientation(A, B, C);
            int o2 = Orientation(A, B, D);
            int o3 = Orientation(C, D, A);
            int o4 = Orientation(C, D, B);

            // �������� ������
            if (o1 != o2 && o3 != o4)
                return true;

            // ����������� ������
            // A, B � C ����������� � C ����� �� ������� AB
            if (o1 == 0 && OnSegment(A, C, B)) return true;

            // A, B � D ����������� � D ����� �� ������� AB
            if (o2 == 0 && OnSegment(A, D, B)) return true;

            // C, D � A ����������� � A ����� �� ������� CD
            if (o3 == 0 && OnSegment(C, A, D)) return true;

            // C, D � B ����������� � B ����� �� ������� CD
            if (o4 == 0 && OnSegment(C, B, D)) return true;

            // ������� �� ������������
            return false;
        }
        private void NestingButtom_Click(object sender, EventArgs e)
        {
            HeaderLabel.Text = "�����������";
            for (int i = 0; i < TriangleForm.Triangles.Count ; i++)
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
            
            MainPanel.Refresh();
        }

       
    }
}
