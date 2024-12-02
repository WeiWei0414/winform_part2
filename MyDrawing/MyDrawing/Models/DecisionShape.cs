using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawing.Models
{
    public class DecisionShape:Shape
    {
        public DecisionShape()
        {
            ShapeType = "Decision";
        }
        public override void Display(IGraphics graphics)
        {
            Point[] points = new Point[4];
            points[0] = new Point(X + Width / 2, Y);
            points[1] = new Point(X + Width, Y + Height / 2);
            points[2] = new Point(X + Width / 2, Y + Height);
            points[3] = new Point(X, Y + (Height / 2));
            graphics.DrawPolygon(points);
            graphics.DrawString(Text, X + Width / 2.5, Y + Height / 2.5);

        }
    }
}
