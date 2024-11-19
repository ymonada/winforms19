using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms19.Interfaces;

namespace WinForms19.Models
{
    public class Rectangle : IFigure
    {
        public static Color DefaultColor = Color.Black;
        public Point _A { get; set; }
        public Point _B { get; set; }
        public Point _C { get; set; }
        public Point _D { get; set; }
        public Color _Color { get; set; }
        public Rectangle(Point A, Point B, Point C, Point D, Color Color)
        {
            _A = A;
            _B = B;
            _C = C;
            _D = D;
            _Color = Color;
        }
        public void Drawing(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen,(float)_A.X, (float)_A.Y,(float)_B.X, (float)_B.Y);
            graphics.DrawLine(pen,(float)_B.X, (float)_B.Y,(float)_C.X, (float)_C.Y);
            graphics.DrawLine(pen, (float)_C.X, (float)_C.Y, (float)_D.X, (float)_D.Y);
            graphics.DrawLine(pen, (float)_D.X, (float)_D.Y, (float)_A.X, (float)_A.Y);          
        }
        public override string ToString() => $"Rectangle : \r\n\tA = {_A.X}; {_A.Y}\r\n" +
          $"\tB = {_B.X}; {_B.Y}\r\n" +
           $"\tC = {_C.X}; {_C.Y}\r\n" +
             $"\tD = {_D.X}; {_D.Y}\r\n";

        public string ToStringLine() => $"Rectangle :    A = {_A.X}; {_A.Y}" +
          $"    B = {_B.X}; {_B.Y}" +
          $"    C = {_C.X}; {_C.Y}" +
          $"    D = {_D.X}; {_D.Y}\r\n";

    }
}
