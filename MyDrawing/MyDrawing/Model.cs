using MyDrawing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace MyDrawing
{
    
    public class Model
    {
        Shape newShape;  //新圖案
        ShapeFactory factory;
        Shapes shapes = new Shapes();  //存放shape的陣列
        public event ModelChangedEventHandler ModelChanged;
        public delegate void ModelChangedEventHandler();
        double firstX = 0;
        double firstY = 0;
        bool isPressed = false;
        double secondX = 0;
        double secondY = 0;
        
        
        public Model()
        {
            factory = new ShapeFactory(); //新增工廠
        }
        void NotifyModelChanged()
        {
            if (ModelChanged != null)
                ModelChanged();
        }

        //取得新增的圖案
        public Shape GetNewShape()
        {
            return newShape;
        }
        public void AddShape(string shapeType,string content,int x,int y,int width,int height)
        {
            shapes.AddShape(shapeType,content,x,y,width,height);
            NotifyModelChanged();
        }
        public void DeleteShape(int id)
        {
            shapes.RemoveShape(id);
            NotifyModelChanged();

        }
        public List<Shape> GetShapes()
        {
            return shapes.GetAllshapes();
        }
        public void PointerPressed(string type, double x, double y)
        {
            if (x > 0 && y > 0)
            {
                this.newShape = factory.CreateShape(type);
                
                firstX = x;
                firstY = y;
                isPressed = true;
                newShape.X = (int)x;
                newShape.Y = (int)y;
                newShape.Text = RandomText();
            }
        }
        public void PointerMoved(double x, double y)
        {
            if (isPressed)
            {
                secondX = x;
                secondY = y;
                NotifyModelChanged();
            }
        }
        public void PointerReleased(double x, double y, Shape newShape)
        {
            if (isPressed)
            {
                isPressed = false;
                shapes.AddShape(newShape.ShapeType,newShape.Text,newShape.X,newShape.Y,newShape.Height,newShape.Width);
                NotifyModelChanged();
            }
        }
        public void Draw(IGraphics graphics)
        {
            graphics.ClearAll();

            foreach (Shape item in shapes.GetAllshapes())  //shapes裡面存放shape 
            {
                item.Display(graphics);
            }
            if (isPressed)
            {
                double MinX = firstX < secondX ? firstX : secondX; //成立右 不成立則左
                double MaxX = firstX < secondX ? secondX : firstX;
                double MinY = firstY < secondY ? firstY : secondY;
                double MaxY = firstY < secondY ? secondY : firstY;
                this.newShape.X = (int)MinX;
                this.newShape.Y = (int)MinY;
                this.newShape.Height = (int)(MaxY - MinY);
                this.newShape.Width = (int)(MaxX - MinX);
                this.newShape.Display(graphics);
            }
        }
        private string RandomText()
        {
            Random random = new Random();
            int length = random.Next(3, 11);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
                result.Append(chars[random.Next(chars.Length)]);

            return result.ToString();
        }





    }
}
