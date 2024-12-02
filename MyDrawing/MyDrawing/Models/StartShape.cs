using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawing.Models
{
    public class StartShape:Shape
    {
        public StartShape()
        {
            ShapeType = "Start";
        }
        public override void Display(IGraphics graphics)
        {
            graphics.DrawEllipse(X, Y, Width, Height);
            graphics.DrawString(Text, X + Width / 2.5, Y + Height / 2.5);
        }
    }
}

