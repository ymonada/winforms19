using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms19.Models
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X= x; Y=y;
        }
        public Point()
        {
            
        }
        public System.Drawing.Point ToPoint() => new System.Drawing.Point((int)X, (int)Y);


    }
}
