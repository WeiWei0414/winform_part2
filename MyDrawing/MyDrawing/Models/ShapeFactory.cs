using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawing.Models
{
    public static  class ShapeFactory
    {
        public static Shape CreateShape(string ShapeType)
        {
            switch (ShapeType)
            {
                case "Start":
                    return new StartShape();
                case "Terminator":
                    return new TerminatorShape();
                case "Process":
                    return new ProcessShape();
                case "Decision":
                    return new DecisionShape();
                default:
                    throw new ArgumentException("Unknown shape type");
            }
        }
    }
}
