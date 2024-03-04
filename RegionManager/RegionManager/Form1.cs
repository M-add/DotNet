using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    public partial class Form1 : Form
    {
        private string Shape;
        List<IRegion> Shapes = new List<IRegion>();

        private string ShapeName;
        private int Id;
        private int Edges;
        private int X;
        private int Y;
        private string parameters;

        private string ButtonClicked;

        public Form1()
        {
            InitializeComponent();

            GetWidthButton.Click += FunctionButtonClick;
            MoveButton.Click += FunctionButtonClick;
            ResizeButton.Click += FunctionButtonClick;
        }

        private void FunctionButtonClick(object sender, EventArgs e)
        {
            ShapePanel.Hide();
            FunctionPanel.Hide();

            if (sender is Button clicked)
            {
                ButtonClicked = clicked.Text;
            }
            Function FunctionControl = new Function
            {
                Dock = DockStyle.Top
            };

            FunctionControl.Regions = new DataTable();

            FunctionControl.Regions.Columns.Add("Name", typeof(string));
            FunctionControl.Regions.Columns.Add("Id", typeof(int));
            FunctionControl.Regions.Columns.Add("Shape", typeof(string));

            foreach (var shape in Shapes)
            {
                string CurrentShape = "Circle";
                if (shape.Edges == 3)
                {
                    CurrentShape = "Triangle";
                }
                else if (shape.Edges == 4)
                {
                    CurrentShape = "Rectangle";
                }
                FunctionControl.Regions.Rows.Add(shape.Name, shape.Id, CurrentShape);
            }
            FunctionControl.SetSource();
            FunctionControl.OnOkClick += DoOperation;

            InputPanel.Controls.Add(FunctionControl);
        }

        private void DoOperation(object sender, int id)
        {
            int searchId = id;
            IRegion WorkRegion = null;
            foreach (var shape in Shapes)
            {
                if (shape.Id == searchId)
                {
                    WorkRegion = shape;
                    break;
                }
            }
            if (ButtonClicked == "Get Width")
            {
                MessageBox.Show(WorkRegion.GetArea().ToString());
            }
            else if (ButtonClicked == "Move Region")
            {
                InputDialogForm input = new InputDialogForm();

                int x = 0, y = 0;
                if (input.ShowDialog() == DialogResult.OK)
                {
                    x = int.Parse(input.Input1);
                    y = int.Parse(input.Input2);
                }
                WorkRegion.MoveRegion(x, y);

                Drawpanel.Invalidate();
            }
            else if (ButtonClicked == "Resize")
            {
                InputDialogForm input = new InputDialogForm();
                if (WorkRegion.Edges == 0)
                {
                    input.Input2 = "0";
                }
                int x = 0, y = 0;
                if (input.ShowDialog() == DialogResult.OK)
                {
                    x = int.Parse(input.Input1);
                    y = int.Parse(input.Input2);
                }
                WorkRegion.Resize(x, y);
                Drawpanel.Invalidate();
            }

            UserControl userControlToDelete = InputPanel.Controls.OfType<UserControl>().FirstOrDefault();

            if (userControlToDelete != null)
            {
                userControlToDelete.Dispose();
            }
            ShapePanel.Show();
            FunctionPanel.Show();
        }

        private void InputButtonClick(object sender, EventArgs e)
        {
            if (ShapeComboBox.Text != "")
            {
                ShapePanel.Hide();
                FunctionPanel.Hide();
                Shape = ShapeComboBox.Text;
                InputPanelShow();
            }

        }
        private void InputPanelShow()
        {
            if (Shape == "Circle")
            {
                CircleInput circle = new CircleInput
                {
                    Dock = DockStyle.Top
                };
                InputPanel.Controls.Add(circle);

                circle.OnSetButtonClick += SetValues;
            }
            else if (Shape == "Triangle")
            {
                TriangelInput triangle = new TriangelInput
                {
                    Dock = DockStyle.Top
                };
                InputPanel.Controls.Add(triangle);
                triangle.OnSetButtonClick += SetValues;
            }
            else if (Shape == "Rectangle")
            {
                RectangleInput rectangle = new RectangleInput();
                rectangle.Dock = DockStyle.Top;
                InputPanel.Controls.Add(rectangle);
                rectangle.OnSetButtonClick += SetValues;
            }
        }

        private void SetValues(object sender, List<string> values)
        {
            ShapeName = values[0];
            Id = int.Parse(values[1]);
            Edges = int.Parse(values[2]);
            X = int.Parse(values[3]);
            Y = int.Parse(values[4]);
            parameters = values[5];

            IRegion shape = null;

            if (Shape == "Circle")
            {
                int radius = int.Parse(parameters);
                shape = new Circle(radius, ShapeName, Id, Edges, X, Y);
            }
            else if (Shape == "Triangle")
            {
                string[] input = parameters.Split(' ');
                int height = int.Parse(input[0]);
                int breadth = int.Parse(input[1]);

                shape = new Triangle(breadth, height, ShapeName, Id, Edges, X, Y);
            }
            else if (Shape == "Rectangle")
            {
                string[] input = parameters.Split(' ');
                int length = int.Parse(input[0]);
                int breadth = int.Parse(input[1]);

                shape = new Rectangle(length, breadth, ShapeName, Id, Edges, X, Y);
            }

            CheckId:
            if (Shapes.Any(id => id.Id == shape.Id))
            {
                IdManager idManager = new IdManager();
                if (idManager.ShowDialog() == DialogResult.OK)
                {
                    shape.Id = idManager.IdValue;
                }
                goto CheckId;
            }
            else
            {
                Shapes.Add(shape);
            }
        }
        private void DrawButton_Click(object sender, EventArgs e)
        {
            foreach (var shape in Shapes)
            {
                shape.Draw(Drawpanel.CreateGraphics());
            }
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            UserControl userControlToDelete = InputPanel.Controls.OfType<UserControl>().FirstOrDefault();

            if (userControlToDelete != null)
            {
                userControlToDelete.Dispose();
            }

            ShapePanel.Show();
            FunctionPanel.Show();
        }

        private void Drawpanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in Shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
    }
}
