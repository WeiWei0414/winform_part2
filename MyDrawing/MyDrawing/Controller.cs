using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDrawing.Models;

namespace MyDrawing
{
    public class Controller
    {
        private Model model;
        private MyDrawing view;
        public Controller(MyDrawing form,Model model) 
        {
            this.model = model;
            this.view= form;
            this.view.OnAddShape += addShapeHandler; //訂閱view的新增圖案事件
            this.view.OnDeleteShape += RemoveShape;
        }

        public void RemoveShape(object sender,int id)
        {
            model.RemoveShape(id);
            view.UpdateDataGridView(model.GetAllshapes());
        }
        //新增圖案 
        public void addShapeHandler(object sender,ShapeEventArgs e) //ShapeEventArgs在view已經設定好值
        {
            
            //新增到model
            model.AddShape(e.ShapeType, e.Text, e.X, e.Y, e.Width, e.Height);

            //更新view的值
            view.UpdateDataGridView(model.GetAllshapes());
            
        }
    }
}
