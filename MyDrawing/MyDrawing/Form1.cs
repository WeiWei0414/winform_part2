
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
        Model model = new Model();
        PresentationModel pModel;
        Panel canva = new DoubleBufferedPanel();  //繪圖的地方

        public Shape currentShape { get; private set; } //設定新增的shape
        public MyDrawing(PresentationModel presentationModel)
        {
            this.pModel= presentationModel;
            InitializeComponent();
            SetupToolStrip();
            pModel.ButtonStateChanged += pModel_ButtonStateChanged;
            pModel.ButtonStateCancled += pModel_ButtonStateCancled;
            //以下為panel的事件
            canva.Parent = this;
            canva.Dock = DockStyle.Fill;
            canva.MouseDown += HandleCanvaPointerPressed;
            canva.MouseUp += HandleCanvaPointerRealeased;
            canva.MouseMove += HandleCanvaPointerMoved;
            canva.Paint += HandleCanvaPaint;
            model.ModelChanged += HandleModelChanged;

        }
        private void SetupToolStrip()
        {
            //設定toolstrip的四個按鈕的基本屬性
            tool_Start.CheckOnClick = true;
            tool_Terminator.CheckOnClick = true;
            tool_Process.CheckOnClick = true;
            tool_Decision.CheckOnClick = true;
            tool_Start.Click += (sender, e) => pModel.SetButtonChecked("Start");
            tool_Terminator.Click += (sender, e) => pModel.SetButtonChecked("Terminator");
            tool_Process.Click += (sender, e) => pModel.SetButtonChecked("Process");
            tool_Decision.Click += (sender, e) => pModel.SetButtonChecked("Decision");

        }


        private void AddShape_Btn_Click(object sender, EventArgs e)
        {
            string shapeType = "";
          
            string content = textboxContent.Text;
            string X = textBoxX.Text;
            string Y = textBoxY.Text;
            string H = textBoxH.Text;
            string W = textBoxW.Text;
            
            
            if (ShapeCombobox.SelectedItem == null)
            {
                MessageBox.Show("請先選擇圖案");
            }
            else if (content == "")
            {
                MessageBox.Show("Please enter text");
            }
            else if (X == null || !int.TryParse(X, out _))
            {
                MessageBox.Show("Please enter correct X");
            }
            else if (Y == null || !int.TryParse(Y, out _))
            {
                MessageBox.Show("Please enter correct Y");
            }
            else if (H == null || !int.TryParse(H, out _))
            {
                MessageBox.Show("Please enter correct H");
            }
            else if (W == null || !int.TryParse(W, out _))
            {
                MessageBox.Show("Please enter correct W");
            }
            else
            {
                shapeType = ShapeCombobox.SelectedItem.ToString();
                model.AddShape(shapeType, content, int.Parse(X), int.Parse(Y), int.Parse(H), int.Parse(W));
                UpdateDataGridView();
            }
        }
        public void UpdateDataGridView()
        {
            List<Shape> shapes = model.GetShapes();
            shapeDataGridView.Rows.Clear();
            foreach(var shape in shapes)
            {   
                shapeDataGridView.Rows.Add(
                    "刪除",     //第一行為按鈕，所以資料給null
                    shape.Id, 
                    shape.ShapeType, 
                    shape.Text, 
                    shape.X, 
                    shape.Y, 
                    shape.Height, 
                    shape.Width);
            }
        }

        public void UpdateShape(Shape shape)
        {
            currentShape = shape;
        }

        private void shapeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == shapeDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int id = 0;
                if (shapeDataGridView.Rows[e.RowIndex].Cells["Id"].Value == null)
                {
                    MessageBox.Show("erroe");
                }
                else
                {
                    id = (int)shapeDataGridView.Rows[e.RowIndex].Cells["Id"].Value;
                }
                model.DeleteShape(id);
                UpdateDataGridView();

            }
        }
        public void RefreashToolstrip()
        {
            tool_Start.Checked = pModel.isStartChecked;
            tool_Process.Checked = pModel.isProcessChecked;
            tool_Decision.Checked = pModel.isDecisionChecked;
            tool_Terminator.Checked = pModel.isTerminatorChecked;
            //canva.Cursor = Cursors.Default;
        }
        private void pModel_ButtonStateChanged(object sender, EventArgs e)
        {
            //從pmodel拿值過來更新ui
            RefreashToolstrip();
            canva.Cursor = Cursors.Cross;

        }
        private void pModel_ButtonStateCancled(object sender,EventArgs e)
        {
            canva.Cursor = Cursors.Default;
        }
        public void HandleCanvaPointerPressed(object sender,MouseEventArgs e)
        {
            if (pModel.CurrentType() != "null")
            {
                model.PointerPressed(pModel.CurrentType(), e.X, e.Y);
            }
        }
        public void HandleCanvaPointerRealeased(object sender,MouseEventArgs e)
        {
            if(pModel.CurrentType() != "null")
            {
                model.PointerReleased(e.X, e.Y,model.GetNewShape());
                RefreashToolstrip();
                UpdateDataGridView();
                canva.Cursor=Cursors.Default;
            }
        }
        public void HandleCanvaPointerMoved(object sender,MouseEventArgs e)
        {
            model.PointerMoved(e.X, e.Y);
        }
        public void HandleCanvaPaint(object sender,PaintEventArgs e)
        {
            model.Draw(new presentationModel.WindowsFormsGraphicsAdaptor(e.Graphics));
        }
        public void HandleModelChanged()
        {
            Invalidate(true);
        }
    }
}
