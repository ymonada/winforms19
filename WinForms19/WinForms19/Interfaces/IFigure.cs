using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms19.Interfaces
{
    public interface IFigure
    {
        public Color _Color { get; set; }
        void Drawing(Graphics graphics, Pen pen);
        string ToStringLine();
    }
}
