namespace OOP_6
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TreeangleButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.DeleteShapeButton = new System.Windows.Forms.Button();
            this.ListBoxShapes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TreeangleButton
            // 
            this.TreeangleButton.Location = new System.Drawing.Point(580, 131);
            this.TreeangleButton.Name = "TreeangleButton";
            this.TreeangleButton.Size = new System.Drawing.Size(120, 30);
            this.TreeangleButton.TabIndex = 0;
            this.TreeangleButton.Text = "Treeangle";
            this.TreeangleButton.UseVisualStyleBackColor = true;
            this.TreeangleButton.Click += new System.EventHandler(this.TreeangleButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(580, 167);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(120, 30);
            this.CircleButton.TabIndex = 1;
            this.CircleButton.Text = "Circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(580, 203);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(120, 30);
            this.RectangleButton.TabIndex = 2;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(580, 239);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(120, 30);
            this.SquareButton.TabIndex = 3;
            this.SquareButton.Text = "Square";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Location = new System.Drawing.Point(499, 35);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(120, 30);
            this.MoveUpButton.TabIndex = 4;
            this.MoveUpButton.Text = "Move UP";
            this.MoveUpButton.UseVisualStyleBackColor = true;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Location = new System.Drawing.Point(656, 35);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(120, 30);
            this.MoveDownButton.TabIndex = 5;
            this.MoveDownButton.Text = "Move DOWN";
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // DeleteShapeButton
            // 
            this.DeleteShapeButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteShapeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteShapeButton.Location = new System.Drawing.Point(580, 71);
            this.DeleteShapeButton.Name = "DeleteShapeButton";
            this.DeleteShapeButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteShapeButton.TabIndex = 6;
            this.DeleteShapeButton.Text = "Delete shape";
            this.DeleteShapeButton.UseVisualStyleBackColor = false;
            this.DeleteShapeButton.Click += new System.EventHandler(this.DeleteShapeButton_Click);
            // 
            // ListBoxShapes
            // 
            this.ListBoxShapes.BackColor = System.Drawing.SystemColors.Info;
            this.ListBoxShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxShapes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ListBoxShapes.FormattingEnabled = true;
            this.ListBoxShapes.ItemHeight = 20;
            this.ListBoxShapes.Location = new System.Drawing.Point(169, 49);
            this.ListBoxShapes.Name = "ListBoxShapes";
            this.ListBoxShapes.Size = new System.Drawing.Size(280, 304);
            this.ListBoxShapes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Shapes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Create";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxShapes);
            this.Controls.Add(this.DeleteShapeButton);
            this.Controls.Add(this.MoveDownButton);
            this.Controls.Add(this.MoveUpButton);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.TreeangleButton);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.Text = "Shapes creater";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TreeangleButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button DeleteShapeButton;
        private System.Windows.Forms.ListBox ListBoxShapes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

