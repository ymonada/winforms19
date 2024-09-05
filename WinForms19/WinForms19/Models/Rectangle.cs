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
        public Point _A { get; set; }
        public Point _B { get; set; }
        public Point _C { get; set; }
        public Point _D { get; set; }
        public Color _Color { get; set; }
        public Rectangle()
        {
            
        }
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
            graphics.DrawLine(pen, _A, _B);
            graphics.DrawLine(pen, _B, _C);
            graphics.DrawLine(pen, _C, _D);
            graphics.DrawLine(pen, _D, _A);
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
