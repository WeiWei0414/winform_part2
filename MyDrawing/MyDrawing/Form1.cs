
using MyDrawing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyDrawing
{
    public partial class MyDrawing : Form
    {
        public event EventHandler<ShapeEventArgs> OnAddShape; //新增圖案事件
        public event EventHandler<int> OnDeleteShape;         //刪除圖案事件
        
        public MyDrawing()
        {
            InitializeComponent();
            SetupDataGridView();
            Shape_dataGridView.CellClick += Shape_dataGridView_CellClick;
           
        }
        private void SetupDataGridView()
        {
            Shape_dataGridView.ReadOnly = true;
            Shape_dataGridView.AutoGenerateColumns = false;
            //新增刪除按鈕作為第一行
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true; //顯示按鈕文字
            Shape_dataGridView.Columns.Add(deleteButton);
            
            //新增header

            Shape_dataGridView.Columns.Add("Id", "ID");
            Shape_dataGridView.Columns.Add("ShapeType", "Shape Type");
            Shape_dataGridView.Columns.Add("Text", "Text");
            Shape_dataGridView.Columns.Add("X", "X");
            Shape_dataGridView.Columns.Add("Y", "Y");
            Shape_dataGridView.Columns.Add("Height", "Height");
            Shape_dataGridView.Columns.Add("Width", "Width");
            Shape_dataGridView.Columns["ID"].DisplayIndex = 1;


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MyDrawing_Load(object sender, EventArgs e)
        {

        }

        private void AddShape_Btn_Click(object sender, EventArgs e)
        {
            //從ui取得資料
            string shapeType = ShapeCombobox.SelectedItem.ToString();
            string content = textboxContent.Text;
            int X = int.Parse(textBoxX.Text);
            int Y = int.Parse(textBoxY.Text);
            int H = int.Parse(textBoxH.Text);
            int W = int.Parse(textBoxW.Text);

            //通知controller 觸發新增事件
            OnAddShape?.Invoke(this, new ShapeEventArgs
            {
                ShapeType = shapeType,
                Text = content,
                X = X,
                Y = Y,
                Height = H,
                Width = W
                
            });
            
       
        }
        public void UpdateDataGridView(List<Shape> shapes)
        {
            Shape_dataGridView.Rows.Clear();
            foreach(var shape in shapes)
            {   
                Shape_dataGridView.Rows.Add(
                    null,     //第一行為按鈕，所以資料給null
                    shape.Id, 
                    shape.ShapeType, 
                    shape.Text, 
                    shape.X, 
                    shape.Y, 
                    shape.Height, 
                    shape.Width);
            }
        }
        private void Shape_dataGridView_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Shape_dataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // 取得要刪除的行 ID
                int id = (int)Shape_dataGridView.Rows[e.RowIndex].Cells["Id"].Value;

                // 通知 Controller 執行刪除操作
                OnDeleteShape?.Invoke(this, id);
            }

        }

    }
}
