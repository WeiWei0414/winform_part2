namespace MyDrawing
{
    partial class MyDrawing
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDrawing));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Shape_group = new System.Windows.Forms.GroupBox();
            this.shapeDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textboxContent = new System.Windows.Forms.TextBox();
            this.ShapeCombobox = new System.Windows.Forms.ComboBox();
            this.AddShape_Btn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_Start = new System.Windows.Forms.ToolStripButton();
            this.tool_Terminator = new System.Windows.Forms.ToolStripButton();
            this.tool_Process = new System.Windows.Forms.ToolStripButton();
            this.tool_Decision = new System.Windows.Forms.ToolStripButton();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Shape_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1394, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於ToolStripMenuItem});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.關於ToolStripMenuItem.Text = "關於";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 691);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 129);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 99);
            this.button3.TabIndex = 1;
            this.button3.Text = "pagw2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 99);
            this.button2.TabIndex = 0;
            this.button2.Text = "page1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Shape_group
            // 
            this.Shape_group.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Shape_group.Controls.Add(this.shapeDataGridView);
            this.Shape_group.Controls.Add(this.label5);
            this.Shape_group.Controls.Add(this.label4);
            this.Shape_group.Controls.Add(this.label3);
            this.Shape_group.Controls.Add(this.label2);
            this.Shape_group.Controls.Add(this.label1);
            this.Shape_group.Controls.Add(this.textBoxW);
            this.Shape_group.Controls.Add(this.textBoxH);
            this.Shape_group.Controls.Add(this.textBoxY);
            this.Shape_group.Controls.Add(this.textBoxX);
            this.Shape_group.Controls.Add(this.textboxContent);
            this.Shape_group.Controls.Add(this.ShapeCombobox);
            this.Shape_group.Controls.Add(this.AddShape_Btn);
            this.Shape_group.Location = new System.Drawing.Point(938, 42);
            this.Shape_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shape_group.Name = "Shape_group";
            this.Shape_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shape_group.Size = new System.Drawing.Size(444, 691);
            this.Shape_group.TabIndex = 2;
            this.Shape_group.TabStop = false;
            this.Shape_group.Text = "資料顯示";
            // 
            // shapeDataGridView
            // 
            this.shapeDataGridView.AllowUserToAddRows = false;
            this.shapeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shapeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.id,
            this.shapeType,
            this.content,
            this.X,
            this.Y,
            this.height,
            this.width});
            this.shapeDataGridView.Location = new System.Drawing.Point(12, 78);
            this.shapeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.shapeDataGridView.Name = "shapeDataGridView";
            this.shapeDataGridView.RowHeadersVisible = false;
            this.shapeDataGridView.RowHeadersWidth = 51;
            this.shapeDataGridView.RowTemplate.Height = 24;
            this.shapeDataGridView.Size = new System.Drawing.Size(409, 572);
            this.shapeDataGridView.TabIndex = 14;
            this.shapeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shapeDataGridView_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "W";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "文字";
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(388, 39);
            this.textBoxW.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(39, 25);
            this.textBoxW.TabIndex = 6;
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(340, 39);
            this.textBoxH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(39, 25);
            this.textBoxH.TabIndex = 5;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(292, 39);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(39, 25);
            this.textBoxY.TabIndex = 4;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(244, 39);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(39, 25);
            this.textBoxX.TabIndex = 3;
            // 
            // textboxContent
            // 
            this.textboxContent.Location = new System.Drawing.Point(169, 39);
            this.textboxContent.Margin = new System.Windows.Forms.Padding(4);
            this.textboxContent.Name = "textboxContent";
            this.textboxContent.Size = new System.Drawing.Size(65, 25);
            this.textboxContent.TabIndex = 2;
            // 
            // ShapeCombobox
            // 
            this.ShapeCombobox.FormattingEnabled = true;
            this.ShapeCombobox.Items.AddRange(new object[] {
            "Start",
            "Terminator",
            "Process",
            "Decision"});
            this.ShapeCombobox.Location = new System.Drawing.Point(65, 41);
            this.ShapeCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.ShapeCombobox.Name = "ShapeCombobox";
            this.ShapeCombobox.Size = new System.Drawing.Size(95, 23);
            this.ShapeCombobox.TabIndex = 1;
            this.ShapeCombobox.Text = "形狀";
            // 
            // AddShape_Btn
            // 
            this.AddShape_Btn.Location = new System.Drawing.Point(12, 24);
            this.AddShape_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.AddShape_Btn.Name = "AddShape_Btn";
            this.AddShape_Btn.Size = new System.Drawing.Size(46, 46);
            this.AddShape_Btn.TabIndex = 0;
            this.AddShape_Btn.Text = "新增";
            this.AddShape_Btn.UseVisualStyleBackColor = true;
            this.AddShape_Btn.Click += new System.EventHandler(this.AddShape_Btn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_Start,
            this.tool_Terminator,
            this.tool_Process,
            this.tool_Decision});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1394, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_Start
            // 
            this.tool_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_Start.Image = ((System.Drawing.Image)(resources.GetObject("tool_Start.Image")));
            this.tool_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Start.Name = "tool_Start";
            this.tool_Start.Size = new System.Drawing.Size(29, 24);
            this.tool_Start.Text = "toolStripButton1";
            
            // 
            // tool_Terminator
            // 
            this.tool_Terminator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_Terminator.Image = ((System.Drawing.Image)(resources.GetObject("tool_Terminator.Image")));
            this.tool_Terminator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Terminator.Name = "tool_Terminator";
            this.tool_Terminator.Size = new System.Drawing.Size(29, 24);
            this.tool_Terminator.Text = "toolStripButton2";
            
            // 
            // tool_Process
            // 
            this.tool_Process.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_Process.Image = ((System.Drawing.Image)(resources.GetObject("tool_Process.Image")));
            this.tool_Process.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Process.Name = "tool_Process";
            this.tool_Process.Size = new System.Drawing.Size(29, 24);
            this.tool_Process.Text = "toolStripButton3";
            
            // 
            // tool_Decision
            // 
            this.tool_Decision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_Decision.Image = ((System.Drawing.Image)(resources.GetObject("tool_Decision.Image")));
            this.tool_Decision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Decision.Name = "tool_Decision";
            this.tool_Decision.Size = new System.Drawing.Size(29, 24);
            this.tool_Decision.Text = "toolStripButton4";
            
            // 
            // delete
            // 
            this.delete.HeaderText = "刪除";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 45;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 45;
            // 
            // shapeType
            // 
            this.shapeType.HeaderText = "形狀";
            this.shapeType.MinimumWidth = 6;
            this.shapeType.Name = "shapeType";
            this.shapeType.Width = 50;
            // 
            // content
            // 
            this.content.HeaderText = "文字";
            this.content.MinimumWidth = 6;
            this.content.Name = "content";
            this.content.Width = 45;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 40;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 40;
            // 
            // height
            // 
            this.height.HeaderText = "H";
            this.height.MinimumWidth = 6;
            this.height.Name = "height";
            this.height.Width = 40;
            // 
            // width
            // 
            this.width.HeaderText = "W";
            this.width.MinimumWidth = 6;
            this.width.Name = "width";
            this.width.Width = 40;
            // 
            // MyDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 748);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Shape_group);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyDrawing";
            this.Text = "MyDrawing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Shape_group.ResumeLayout(false);
            this.Shape_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Shape_group;
        private System.Windows.Forms.ComboBox ShapeCombobox;
        private System.Windows.Forms.Button AddShape_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textboxContent;
        private System.Windows.Forms.DataGridView shapeDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_Start;
        private System.Windows.Forms.ToolStripButton tool_Terminator;
        private System.Windows.Forms.ToolStripButton tool_Process;
        private System.Windows.Forms.ToolStripButton tool_Decision;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn shapeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
    }
}

