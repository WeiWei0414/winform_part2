using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawing
{
    public interface IGraphics
    {
        void ClearAll(); //清空
        void DrawLine(double x, double y, double a, double b); //直線
        void DrawRectangle(double x, double y, double w, double h);//長方形
        void DrawEllipse(double x, double y, double w, double h); //橢圓
        void DrawArc(double x, double y, double w, double h, double firstD, double secondD);  //弧形
        void DrawString(string text, double x, double y);  //寫字
        void DrawPolygon(Point[] points); //多邊形
    }
}
