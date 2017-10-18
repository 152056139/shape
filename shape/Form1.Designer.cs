namespace shape
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Draw = new System.Windows.Forms.Button();
            this.Shape = new System.Windows.Forms.ComboBox();
            this.Shape_Label = new System.Windows.Forms.Label();
            this.Area_Label = new System.Windows.Forms.Label();
            this.Perimeter_label = new System.Windows.Forms.Label();
            this.Area_title = new System.Windows.Forms.Label();
            this.Perimeter_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(618, 17);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(183, 40);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "点击绘制图形";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Shape
            // 
            this.Shape.FormattingEnabled = true;
            this.Shape.Location = new System.Drawing.Point(89, 3);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(94, 26);
            this.Shape.TabIndex = 1;
            // 
            // Shape_Label
            // 
            this.Shape_Label.AutoSize = true;
            this.Shape_Label.Location = new System.Drawing.Point(3, 0);
            this.Shape_Label.Name = "Shape_Label";
            this.Shape_Label.Size = new System.Drawing.Size(44, 18);
            this.Shape_Label.TabIndex = 2;
            this.Shape_Label.Text = "图形";
            // 
            // Area_Label
            // 
            this.Area_Label.AutoSize = true;
            this.Area_Label.Location = new System.Drawing.Point(692, 99);
            this.Area_Label.Name = "Area_Label";
            this.Area_Label.Size = new System.Drawing.Size(0, 18);
            this.Area_Label.TabIndex = 1;
            // 
            // Perimeter_label
            // 
            this.Perimeter_label.AutoSize = true;
            this.Perimeter_label.Location = new System.Drawing.Point(692, 150);
            this.Perimeter_label.Name = "Perimeter_label";
            this.Perimeter_label.Size = new System.Drawing.Size(0, 18);
            this.Perimeter_label.TabIndex = 2;
            // 
            // Area_title
            // 
            this.Area_title.AutoSize = true;
            this.Area_title.Location = new System.Drawing.Point(627, 98);
            this.Area_title.Name = "Area_title";
            this.Area_title.Size = new System.Drawing.Size(62, 18);
            this.Area_title.TabIndex = 3;
            this.Area_title.Text = "面积：";
            // 
            // Perimeter_title
            // 
            this.Perimeter_title.AutoSize = true;
            this.Perimeter_title.Location = new System.Drawing.Point(627, 150);
            this.Perimeter_title.Name = "Perimeter_title";
            this.Perimeter_title.Size = new System.Drawing.Size(62, 18);
            this.Perimeter_title.TabIndex = 4;
            this.Perimeter_title.Text = "周长：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 397);
            this.Controls.Add(this.Perimeter_title);
            this.Controls.Add(this.Area_title);
            this.Controls.Add(this.Perimeter_label);
            this.Controls.Add(this.Area_Label);
            this.Controls.Add(this.Draw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.ComboBox Shape;
        private System.Windows.Forms.Label Shape_Label;
        private System.Windows.Forms.Label Area_Label;
        private System.Windows.Forms.Label Perimeter_label;
        private System.Windows.Forms.Label Area_title;
        private System.Windows.Forms.Label Perimeter_title;
    }
}

