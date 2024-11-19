using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms19.Interfaces;

namespace WinForms19.Models
{
    public class Triangle : IFigure
    {
        public static Color DefaultColor = Color.Black;
        public Point _A { get; set; }
        public Point _B { get; set; }
        public Point _C { get; set; }
        public Color _Color { get; set; }
        public bool IsNested { get; set; }
        public Triangle() { }
        public Triangle(Point A, Point B, Point C, Color Color)
        {
            _A = A;
            _B = B;
            _C = C;
            _Color = Color;
        }
        public void Drawing(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, (float)_A.X,(float)_A.Y, (float)_B.X, (float)_B.Y);
            graphics.DrawLine(pen, (float)_B.X, (float)_B.Y, (float)_C.X, (float)_C.Y);
            graphics.DrawLine(pen, (float)_C.X, (float)_C.Y, (float)_A.X, (float)_A.Y);           
        }
        public override string ToString() => $"Triangle : \r\n\tA = {_A.X}; {_A.Y}\r\n" +
            $"\tB = {_B.X}; {_B.Y}\r\n" +
             $"\tC = {_C.X}; {_C.Y}\r\n";
        public string ToStringLine() => $"Triangle :    A = {_A.X}; {_A.Y}" +
            $"    B = {_B.X}; {_B.Y}" +
            $"    C = {_C.X}; {_C.Y}\r\n";
    }
}
