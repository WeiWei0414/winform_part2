using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawing.Models
{
    public class Shapes //建立shape的串列，並且跟串列有關的操作 直接在這裡執行
    {
        public int newId = 1;
        public List<Shape> shapes = new List<Shape>();
        public Shapes() { }
        public void AddShape(string shapeType, string text, int x, int y, int width, int height)
        {
            ShapeFactory factory = new ShapeFactory();
            Shape shape = factory.CreateShape(shapeType); //使用工廠模式新增shape
            shape.Id = newId++; // 設定id
            shape.Text = text;
            shape.X = x;
            shape.Y = y;
            shape.Width = width;
            shape.Height = height;

            shapes.Add(shape); //新增到存放shape的list
        }
        public void RemoveShape(int id)
        {
            var shape = shapes.FirstOrDefault(s => s.Id == id);
            if (shape != null)
            {
                shapes.Remove(shape);
            }
        }
        public List<Shape> GetAllshapes()
        {
            return shapes;
        }
    }
 }

