using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;

namespace Drawing_MAnager
{
    public partial class Form1 : Form
    {
        #region Private Variables
        private int x = 0, y = 28;
        private PictureBox CurrentObject;

        private bool isDragging = false;
        private Point offset;
        private Color HighLightColor;

        private PictureBox CurrentlySelected;

        private bool isResizing = false;
        private Point resizePoint;

        private bool BrushClicked = false;
        private bool BrushDown = false;

        private Color BrushButtonColor;
        private Point BrushPoints;
        private Color BrushColor = Color.Black;

        List<PictureBox> SvgObjects = new List<PictureBox>();
        List<PointsF> DrawingPoints = new List<PointsF>();
        private Pen pen;

        Stack<List<PointsF>> UndoStack = new Stack<List<PointsF>>();
        Stack<List<PointsF>> RedoStack = new Stack<List<PointsF>>();

        Stack<ImageState> ImageUndo = new Stack<ImageState>();
        Stack<ImageState> ImageRedo = new Stack<ImageState>();

        #endregion

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance |
                BindingFlags.NonPublic, null, DrawingPanel, new object[] { true });
            pen = new Pen(BrushColor, 5);
            scaleControl.SubmitClick += ScaleButtonClick;

            BrushButtonColor = BrushButton.BackColor;
        }

        private void ScaleButtonClick(object sender, EventArgs e)
        {
            if (CurrentlySelected != null)
            {
                CurrentlySelected.Width = scaleControl.WidthChange;
                CurrentlySelected.Height = scaleControl.HeightChange;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG(*.png)|*.png|JPEG(*.jpeg)|*.jpeg";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(DrawingPanel.Width, DrawingPanel.Height - 28);

                DrawingPanel.DrawToBitmap(bitmap,
                    new Rectangle(0, 28, DrawingPanel.Width, DrawingPanel.Height - 28));

                bitmap.Save(save.FileName);
            }
        }

        private void AddSvg(string path)
        {
            SvgDocument svg = SvgDocument.Open(path);

            if (svg != null)
            {
                Bitmap bitmap = svg.Draw();
                PictureBox pic = new PictureBox
                {
                    Image = bitmap,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(100, 80)
                };

                pic.MouseClick += ObjectMouseClick;
                AddImages(pic);
            }
            else
            {
                MessageBox.Show("Failed to load SVG file.");
            }
        }

        private void ObjectMouseClick(object sender, MouseEventArgs e)
        {
            PictureBox currentPic = sender as PictureBox;
            PictureBox current = new PictureBox
            {
                Image = currentPic.Image,
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            CurrentObject = current;
        }

        private void AddImages(PictureBox image)
        {
            if (x + image.Width > ObjectPanel.Width)
            {
                x = 0;
                y += image.Height;
                image.Location = new Point(x, y);
            }
            else
            {
                image.Location = new Point(x, y);
                x += image.Width;
            }


            ObjectPanel.Controls.Add(image);
        }

        //Drag Control && Resize Control
        private void CurrentMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            HighLightColor = pic.BackColor;
            pic.BackColor = SystemColors.Highlight;

            ImageState img = new ImageState();
            img.size = pic.Size;
            img.Location = e.Location;

            if (e.Button == MouseButtons.Left && !BrushClicked)
            {
                isDragging = true;
                offset = new Point(e.X, e.Y);
            }

            if (e.Button == MouseButtons.Right && !BrushClicked)
            {
                isResizing = true;
                resizePoint = new Point(e.X, e.Y);
            }
            DrawingPanel.Refresh();
        }
        private void CurrentMouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BackColor = HighLightColor;
            DrawingPanel.Refresh();
            isDragging = false;
            isResizing = false;
        }
        private void CurrentMouseMove(object sender, MouseEventArgs e)
        {
            Control Object = sender as Control;

            if (isDragging)
            {
                Point newLocation = Object.Location;

                newLocation.X += e.X - offset.X;
                newLocation.Y += e.Y - offset.Y;

                newLocation.X = Math.Max(0, Math.Min(newLocation.X, 
                    DrawingPanel.ClientSize.Width - Object.Width));
                newLocation.Y = Math.Max(0, Math.Min(newLocation.Y, 
                    DrawingPanel.ClientSize.Height - Object.Height));

                Object.Location = newLocation;
            }

            if (isResizing)
            {
                int deltaX = MousePosition.X - resizePoint.X;
                int deltaY = MousePosition.Y - resizePoint.Y;

                Object.Size = new Size(Object.Width + deltaX, Object.Height + deltaY);

                resizePoint = MousePosition;
            }
        }

        private void CurrentMouseClick(object sender, MouseEventArgs e)
        {
            CurrentlySelected = sender as PictureBox;
            //CurrentlySelected.Paint += CurrentPaint;
        }

        private void TopButtonClick(object sender, EventArgs e)
        {
            if (CurrentlySelected != null && CurrentlySelected.Location.Y - 5 > 28)
            {
                CurrentlySelected.Location = new Point(CurrentlySelected.Location.X, CurrentlySelected.Location.Y - 5);
            }
        }

        private void LeftButtonClick(object sender, EventArgs e)
        {
            if (CurrentlySelected != null && CurrentlySelected.Location.X - 5 > 0)
            {
                CurrentlySelected.Location = new Point(CurrentlySelected.Location.X - 5, CurrentlySelected.Location.Y);
            }
        }

        private void DownButtonClick(object sender, EventArgs e)
        {
            if (CurrentlySelected != null && CurrentlySelected.Location.Y + CurrentlySelected.Height + 5 < DrawingPanel.Height)
            {
                CurrentlySelected.Location = new Point(CurrentlySelected.Location.X, CurrentlySelected.Location.Y + 5);
            }
        }

        private void RightButtonClick(object sender, EventArgs e)
        {
            if (CurrentlySelected != null && CurrentlySelected.Location.X + CurrentlySelected.Width + 5 < DrawingPanel.Width)
            {
                CurrentlySelected.Location = new Point(CurrentlySelected.Location.X + 5, CurrentlySelected.Location.Y);
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            BrushClicked = false;
            BrushButton.BackColor = BrushButtonColor;

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "SVG(*.svg)|*.svg|All Files(*.*)|*.*";
            open.Title = "Add Objects";

            if (open.ShowDialog() == DialogResult.OK)
            {
                AddSvg(open.FileName);
            }
        }

        //Rotate Controls
        private void RotateRightClick(object sender, EventArgs e)
        {
            if (CurrentlySelected != null)
            {
                CurrentlySelected.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                CurrentlySelected.Invalidate();
            }
        }
        private void RotateLeftClick(object sender, EventArgs e)
        {
            if (CurrentlySelected != null)
            {
                CurrentlySelected.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                CurrentlySelected.Invalidate();
            }
        }

        //Flip Control
        private void FlipXButtonClick(object sender, EventArgs e)
        {
            if (CurrentlySelected != null)
            {
                CurrentlySelected.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                CurrentlySelected.Invalidate();
            }
        }

        private void EraseButtonClick(object sender, EventArgs e)
        {
            if (CurrentlySelected != null)
            {
                DrawingPanel.Controls.Remove(CurrentlySelected);
            }
        }

        private void DrawingPanelMouseClick(object sender, MouseEventArgs e)
        {
            if (CurrentObject != null)
            {
                PictureBox current = new PictureBox()
                {
                    Image = CurrentObject.Image,
                    Location = e.Location,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(100, 100)
                };
                //current.Location = e.Location;

                current.MouseClick += CurrentMouseClick;
                current.MouseDown += CurrentMouseDown;
                current.MouseUp += CurrentMouseUp;
                current.MouseMove += CurrentMouseMove;
                current.SizeChanged += CurrentPictureSizeChanged;

                //var method = typeof(Control).GetMethod("SetStyle", BindingFlags.Instance |BindingFlags.NonPublic);
                //method?.Invoke(current, new object[] { ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true });
                //current.Update();
                typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty |
                    BindingFlags.Instance |BindingFlags.NonPublic, null, current, new object[] { true });

                DrawingPanel.Controls.Add(current);

                ImageState img = new ImageState();
                img.size = current.Size;
                img.Location = e.Location;
                ImageUndo.Push(img);

                SvgObjects.Add(current);
            }
        }

        private void CurrentPictureSizeChanged(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (!isResizing)
            {
            }
        }

        private void BrushButtonClick(object sender, EventArgs e)
        {
            BrushClicked = !BrushClicked;

            if (BrushClicked)
            {
                BrushButtonColor = BrushButton.BackColor;
                BrushButton.BackColor = SystemColors.Highlight;
            }
            else
            {
                BrushButton.BackColor = BrushButtonColor;
            }
        }
        private void DrawingPanelMouseDown(object sender, MouseEventArgs e)
        {
            BrushDown = true;
            BrushPoints = e.Location;
            PointsF obj = new PointsF();
            obj.points.Add(e.Location);
            obj.PaintColor = BrushColor;

            if (BrushClicked)
            {
                DrawingPoints.Add(obj);
                UndoStack.Push(new List<PointsF>(DrawingPoints));
            }
        }

        private void DrawingPanelMouseUp(object sender, MouseEventArgs e)
        {
            BrushDown = false;
            //DrawingPoints.Clear();
        }

        private void DrawingPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (BrushClicked && BrushDown)
            {
                using (Graphics g = DrawingPanel.CreateGraphics())
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawLine(pen, BrushPoints, e.Location);
                    DrawingPoints[DrawingPoints.Count - 1].points.Add(e.Location);
                    BrushPoints = e.Location;
                }
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.ShowDialog();
            BrushColor = colorDialog.Color;
            ColorButton.BackColor = colorDialog.Color;
            pen = new Pen(BrushColor, 5);
        }

        private void FlipYButtonClick(object sender, EventArgs e)
        {
            if (CurrentlySelected != null)
            {
                CurrentlySelected.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                CurrentlySelected.Invalidate();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            panel1.Width = (ToolPanel.Width / 2);
            DrawingPanel.Invalidate();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (UndoStack.Count > 0)
            {
                List<PointsF> temp = UndoStack.Pop();
                using (Graphics g = DrawingPanel.CreateGraphics())
                {
                    //g.DrawLines(new Pen(DrawingPanel.BackColor, 6), temp[0].points.ToArray());
                    DrawingPanel.Invalidate();
                }
                RedoStack.Push(temp);
            }
            if (ImageUndo.Count > 0)
            {
                ImageState temp = ImageUndo.Pop();
                if (temp.Location != null)
                {
                    CurrentlySelected.Location = temp.Location;
                }
                if (temp.size != null)
                {
                    CurrentlySelected.Size = temp.size;
                }
                DrawingPanel.Invalidate();
                ImageRedo.Push(temp);
            }
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (RedoStack.Count > 0)
            {
                List<PointsF> temp = RedoStack.Pop();
                using (Graphics g = DrawingPanel.CreateGraphics())
                {
                    DrawingPanel.Invalidate();
                }

                UndoStack.Push(temp);
            }

            if (ImageRedo.Count > 0)
            {
                ImageState temp = ImageRedo.Pop();
                if (temp.Location != null)
                {
                    CurrentlySelected.Location = temp.Location;
                }
                if (temp.size != null)
                {
                    CurrentlySelected.Size = temp.size;
                }
                DrawingPanel.Invalidate();
                ImageUndo.Push(temp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToolPanel.Visible = !ToolPanel.Visible;
            ObjectPanel.Visible = !ObjectPanel.Visible;
            AddButton.Visible = !AddButton.Visible;
            DrawingPanel.Dock = DockStyle.Fill;
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (UndoStack.Count > 0)
            {
                foreach (var obj in UndoStack)
                {
                    if (obj[obj.Count - 1].points.Count > 1)
                    {
                        e.Graphics.DrawLines(new Pen(obj[obj.Count - 1].PaintColor, 5), obj[obj.Count - 1].points.ToArray());
                    }
                }
            }
        }
    }
    class PointsF
    {
        public List<PointF> points = new List<PointF>();
        public Color PaintColor { get; set; } = Color.Black;
    }

    class ImageState
    {
        public Point Location { get; set; }
        public Size size { get; set; }
        public float RotationAngle { get; set; }
        public bool FlippedX { get; set; }
        public bool FlippedY { get; set; }
    }
}
