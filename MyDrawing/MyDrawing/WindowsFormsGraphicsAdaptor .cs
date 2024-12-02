using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace MyDrawing.presentationModel

{
    internal class WindowsFormsGraphicsAdaptor : IGraphics
    {
        Graphics graphics;
        Pen Pen = new Pen(Color.Black, 2);
        public WindowsFormsGraphicsAdaptor(Graphics graphics)
        {
            this.graphics = graphics;
        }
        public void ClearAll() //會自動清除，所以不用實作。
        {
        }
        public void DrawLine(double x, double y, double a, double b) //畫線。
        {
            graphics.DrawLine(Pen, (float)x, (float)y, (float)a, (float)b);
        }
        public void DrawRectangle(double x, double y, double w, double h)//線
        {
            graphics.DrawRectangle(Pen, (float)x, (float)y, (float)w, (float)h);
        }
        public void DrawEllipse(double x, double y, double w, double h)//畫圓形、橢圓形。
        {
            graphics.DrawEllipse(Pen, (float)x, (float)y, (float)w, (float)h);
        }
        public void DrawArc(double x, double y, double w, double h, double firstD, double secondD)//畫半圓形。
        {
            graphics.DrawArc(Pen, (float)x, (float)y, (float)w, (float)h, (float)firstD, (float)secondD);
        }
        public void DrawString(string text, double x, double y)//上文字。
        {
            graphics.DrawString(text, new Font("Arial", 7), Brushes.Black, (float)x, (float)y);
        }
        public void DrawPolygon(Point[] points)//畫多邊形。
        {
            graphics.DrawPolygon(Pen, points);
        }
    }
}
