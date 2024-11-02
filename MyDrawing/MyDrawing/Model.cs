using MyDrawing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyDrawing
{
    
    public class Model
    {
        private List<Shape> shapes;
     
        private  int newId = 1;

        public Model()
        {
            shapes = new List<Shape>();
            
        }
        public void AddShape(string shapeType, string text, int x, int y, int width, int height)
        {
            Shape shape=ShapeFactory.CreateShape(shapeType); //使用工廠模式新增shape
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
            var shape=shapes.FirstOrDefault(s => s.Id == id);
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
