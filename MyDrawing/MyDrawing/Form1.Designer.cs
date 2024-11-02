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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Shape_group = new System.Windows.Forms.GroupBox();
            this.Shape_dataGridView = new System.Windows.Forms.DataGridView();
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
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Shape_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shape_dataGridView)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1172, 27);
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
            this.Shape_group.Controls.Add(this.Shape_dataGridView);
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
            this.Shape_group.Location = new System.Drawing.Point(709, 42);
            this.Shape_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shape_group.Name = "Shape_group";
            this.Shape_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shape_group.Size = new System.Drawing.Size(444, 691);
            this.Shape_group.TabIndex = 2;
            this.Shape_group.TabStop = false;
            this.Shape_group.Text = "資料顯示";
            // 
            // Shape_dataGridView
            // 
            this.Shape_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shape_dataGridView.Location = new System.Drawing.Point(12, 78);
            this.Shape_dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Shape_dataGridView.Name = "Shape_dataGridView";
            this.Shape_dataGridView.RowHeadersWidth = 51;
            this.Shape_dataGridView.RowTemplate.Height = 24;
            this.Shape_dataGridView.Size = new System.Drawing.Size(416, 382);
            this.Shape_dataGridView.TabIndex = 12;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.textBoxW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(39, 25);
            this.textBoxW.TabIndex = 6;
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(340, 39);
            this.textBoxH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(39, 25);
            this.textBoxH.TabIndex = 5;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(292, 39);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(39, 25);
            this.textBoxY.TabIndex = 4;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(244, 39);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(39, 25);
            this.textBoxX.TabIndex = 3;
            // 
            // textboxContent
            // 
            this.textboxContent.Location = new System.Drawing.Point(169, 39);
            this.textboxContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ShapeCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShapeCombobox.Name = "ShapeCombobox";
            this.ShapeCombobox.Size = new System.Drawing.Size(95, 23);
            this.ShapeCombobox.TabIndex = 1;
            this.ShapeCombobox.Text = "形狀";
            this.ShapeCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddShape_Btn
            // 
            this.AddShape_Btn.Location = new System.Drawing.Point(7, 41);
            this.AddShape_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddShape_Btn.Name = "AddShape_Btn";
            this.AddShape_Btn.Size = new System.Drawing.Size(51, 29);
            this.AddShape_Btn.TabIndex = 0;
            this.AddShape_Btn.Text = "新增";
            this.AddShape_Btn.UseVisualStyleBackColor = true;
            this.AddShape_Btn.Click += new System.EventHandler(this.AddShape_Btn_Click);
            // 
            // MyDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 748);
            this.Controls.Add(this.Shape_group);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyDrawing";
            this.Text = "MyDrawing";
            this.Load += new System.EventHandler(this.MyDrawing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Shape_group.ResumeLayout(false);
            this.Shape_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shape_dataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView Shape_dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

