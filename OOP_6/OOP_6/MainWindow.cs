using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_6
{
    public partial class MainWindow : Form
    {
        public List<Shape> ListShapes;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxUpdate(object sender, EventArgs e)
        {
            ListBoxShapes.Items.Clear();
            for (int i = 0; i < ListShapes.Count; i++)
                ListBoxShapes.Items.Add(ListShapes[i].ToString());
            ShapeBinSerialazier.Serialize(ListShapes, "Save.bin");
        }

        private void DeleteShapeButton_Click(object sender, EventArgs e)
        {
            if (ListBoxShapes.SelectedIndex != -1)
            {
                ListShapes.RemoveAt(ListBoxShapes.SelectedIndex);
                ListBoxUpdate(sender, e);
            }
        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            if (ListBoxShapes.SelectedIndex != -1)
            {
                if(ListBoxShapes.SelectedIndex!=0)
                {
                    Shape upper = ListShapes[ListBoxShapes.SelectedIndex - 1];
                    ListShapes[ListBoxShapes.SelectedIndex - 1] = ListShapes[ListBoxShapes.SelectedIndex];
                    ListShapes[ListBoxShapes.SelectedIndex] = upper;
                    ListBoxUpdate(sender, e);
                }
            }
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            if (ListBoxShapes.SelectedIndex != -1)
            {
                if (ListBoxShapes.SelectedIndex != ListShapes.Count - 1)
                {
                    Shape lower = ListShapes[ListBoxShapes.SelectedIndex + 1];
                    ListShapes[ListBoxShapes.SelectedIndex + 1] = ListShapes[ListBoxShapes.SelectedIndex];
                    ListShapes[ListBoxShapes.SelectedIndex] = lower;
                    ListBoxUpdate(sender, e);
                }
            }
        }

        private void TreeangleButton_Click(object sender, EventArgs e)
        {
            Form form_treeangle = new Form();
            form_treeangle.MaximumSize = form_treeangle.Size;
            form_treeangle.MinimumSize = form_treeangle.Size;
            form_treeangle.Show();
            form_treeangle.Text = "Create treeangle";
            Button AddButton = new Button();
            AddButton.Text = "Add";
            AddButton.Location = new Point(100, 200);
            Label side1Label = new Label();
            Label side2Label = new Label();
            Label side3Label = new Label();
            TextBox side1Box = new TextBox();
            TextBox side2Box = new TextBox();
            TextBox side3Box = new TextBox();
            side1Label.Text = "Side 1";
            side2Label.Text = "Side 2";
            side3Label.Text = "Side 3";
            side1Label.Location = new Point(50, 50);
            side2Label.Location = new Point(50, 100);
            side3Label.Location = new Point(50, 150);
            side1Box.Size = new Size(100, 30);
            side1Box.Location = new Point(100, 50);
            side2Box.Size = new Size(100, 30);
            side2Box.Location = new Point(100, 100);
            side3Box.Size = new Size(100, 30);
            side3Box.Location = new Point(100, 150);
            form_treeangle.Controls.Add(side1Box);
            form_treeangle.Controls.Add(side2Box);
            form_treeangle.Controls.Add(side3Box);
            form_treeangle.Controls.Add(side1Label);
            form_treeangle.Controls.Add(side2Label);
            form_treeangle.Controls.Add(side3Label);
            form_treeangle.Controls.Add(AddButton);
            AddButton.Click += (Sender, args) =>
            {
                try
                {
                    ListShapes.Add(new Treeangle(Convert.ToDouble(side1Box.Text),
                    Convert.ToDouble(side2Box.Text), Convert.ToDouble(side3Box.Text)));
                    form_treeangle.Close();
                    ListBoxUpdate(sender, e);
                }
                catch
                {
                    MessageBox.Show(
                        "Incorrect data, try again",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
                
            };
            //form_treeangle.Show();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Form form_circle = new Form();
            form_circle.MaximumSize = form_circle.Size;
            form_circle.MinimumSize = form_circle.Size;
            form_circle.Show();
            form_circle.Text = "Create circle";
            Button AddButton = new Button();
            AddButton.Text = "Add";
            AddButton.Location = new Point(100, 200);
            Label radiusLabel = new Label();
            TextBox radiusBox = new TextBox();
            radiusLabel.Text = "Radius";
            radiusLabel.Location = new Point(50, 50);
            radiusBox.Size = new Size(100, 30);
            radiusBox.Location = new Point(100, 50);
            form_circle.Controls.Add(radiusBox);
            form_circle.Controls.Add(radiusLabel);
            form_circle.Controls.Add(AddButton);
            AddButton.Click += (Sender, args) =>
            {
                try
                {
                    ListShapes.Add(new Circle(Convert.ToDouble(radiusBox.Text)));
                    form_circle.Close();
                    ListBoxUpdate(sender, e);
                }
                catch
                {
                    MessageBox.Show(
                        "Incorrect data, try again",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            };
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Form form_rectangle = new Form();
            form_rectangle.MaximumSize = form_rectangle.Size;
            form_rectangle.MinimumSize = form_rectangle.Size;
            form_rectangle.Show();
            form_rectangle.Text = "Create rectangle";
            Button AddButton = new Button();
            AddButton.Text = "Add";
            AddButton.Location = new Point(100, 200);
            Label lengthLabel = new Label();
            Label widthLabel = new Label();
            TextBox lengthBox = new TextBox();
            TextBox widthBox = new TextBox();
            lengthLabel.Text = "Lenght";
            widthLabel.Text = "Width";
            lengthLabel.Location = new Point(50, 50);
            widthLabel.Location = new Point(50, 100);
            lengthBox.Size = new Size(100, 30);
            lengthBox.Location = new Point(100, 50);
            widthBox.Size = new Size(100, 30);
            widthBox.Location = new Point(100, 100);
            form_rectangle.Controls.Add(lengthBox);
            form_rectangle.Controls.Add(widthBox);
            form_rectangle.Controls.Add(widthLabel);
            form_rectangle.Controls.Add(lengthLabel);
            form_rectangle.Controls.Add(AddButton);
            AddButton.Click += (Sender, args) =>
            {
                try
                {
                    ListShapes.Add(new Rectangle(Convert.ToDouble(lengthBox.Text), Convert.ToDouble(widthBox.Text)));
                    form_rectangle.Close();
                    ListBoxUpdate(sender, e);
                }
                catch
                {
                    MessageBox.Show(
                        "Incorrect data, try again",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            };
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Form form_square = new Form();
            form_square.MaximumSize = form_square.Size;
            form_square.MinimumSize = form_square.Size;
            form_square.Show();
            form_square.Text = "Create square";
            Button AddButton = new Button();
            AddButton.Text = "Add";
            AddButton.Location = new Point(100, 200);
            Label squareLabel = new Label();
            TextBox squareBox = new TextBox();
            squareLabel.Text = "Length";
            squareLabel.Location = new Point(50, 50);
            squareBox.Size = new Size(100, 30);
            squareBox.Location = new Point(100, 50);
            form_square.Controls.Add(squareBox);
            form_square.Controls.Add(squareLabel);
            form_square.Controls.Add(AddButton);
            AddButton.Click += (Sender, args) =>
            {
                try
                {
                    ListShapes.Add(new Square(Convert.ToDouble(squareBox.Text)));
                    form_square.Close();
                    ListBoxUpdate(sender, e);
                }
                catch
                {
                    MessageBox.Show(
                        "Incorrect data, try again",
                        "Error",MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            };
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShapeBinSerialazier.Serialize(ListShapes, "Save.bin");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ListShapes = new List<Shape>();
            ListShapes = ShapeBinSerialazier.Deserialize("Save.bin");
            ListBoxUpdate(sender, e);
            double s = Convert.ToDouble("1,1");
            
        }

        
    }
}
