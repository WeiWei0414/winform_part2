using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawing.Models
{
    public class ProcessShape : Shape
    {
        public ProcessShape()
        {
            ShapeType = "Process";
        }
        public override void Display(IGraphics graphics)
        {
            graphics.DrawRectangle(X, Y, Width, Height);
            graphics.DrawString(Text, X + Width / 2.5, Y + Height / 2.5);
        }
    }
}
