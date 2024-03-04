using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionManager
{
    public interface IRegion
    {
        int Id { get; set; }
        string Name { get; set; }
        int Edges { get; set; }
        int X { get; set; }
        int Y { get; set; }

        double GetArea();
        void MoveRegion(int x, int y);
        bool Resize(int x, int y);
        void Intersect(IRegion one);
        void Draw(Graphics e);
    }

    public class Circle : IRegion
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Edges { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        private int Radius;


        public Circle(int radius, string name, int id, int edges, int x, int y)
        {
            Radius = radius;
            Name = name;
            Id = id;
            Edges = edges;
            X = x;
            Y = y;
        }

        public void Draw(Graphics e)
        {
            e.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black);
            e.DrawEllipse(pen, new RectangleF(X, Y, Radius * 2, Radius * 2));
        }

        public double GetArea()
        {
            double area = Math.PI * (Radius * Radius);
            return area;
        }

        public void MoveRegion(int x, int y)
        {
            X += x;
            Y += y;
        }

        public bool Resize(int x, int y)
        {
            Radius = Radius + x;
            return true;
        }

        public void Intersect(IRegion one)
        {
            if (one.X == this.X || one.Y == this.Y)
            {
                Console.WriteLine("The regions are Intersecting");
            }
            else
            {
                Console.WriteLine("The regions do not Intersect");
            }

        }
    }

    public class Rectangle : IRegion
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Edges { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        private int Length;
        private int Breadth;


        public Rectangle(int length, int breadth, string name, int id, int edges, int x, int y)
        {
            Length = length;
            Breadth = breadth;
            Name = name;
            Id = id;
            Edges = edges;
            X = x;
            Y = y;
        }

        public void Draw(Graphics e)
        {
            e.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black);

            e.DrawRectangle(pen, new System.Drawing.Rectangle(X, Y, Breadth, Length));
        }
        public double GetArea()
        {
            double area = Length * Breadth;
            return area;
        }

        public void MoveRegion(int x, int y)
        {
            X += x;
            Y += y;
        }

        public bool Resize(int x, int y)
        {
            Length += y;
            Breadth += x;
            return true;
        }

        public void Intersect(IRegion one)
        {
            if (one.X == this.X || one.Y == this.Y)
            {
                Console.WriteLine("The regions are Intersecting");
            }
            else
            {
                Console.WriteLine("The regions do not Intersect");
            }
        }
    }

    public class Triangle : IRegion
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Edges { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        private int Breadth;
        private int Height;


        public Triangle(int breadth, int height, string name, int id, int edges, int x, int y)
        {
            Breadth = breadth;
            Height = height;
            Name = name;
            Id = id;
            Edges = edges;
            X = x;
            Y = y;
        }

        public void Draw(Graphics e)
        {
            e.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black);

            PointF[] points = new PointF[3]
            {
                new PointF(X, Y + Height),
                new PointF(X + Breadth, Y + Height),
                new PointF(X + (Breadth / 2), Y)
            };


            e.DrawPolygon(pen, points);
        }

        public double GetArea()
        {
            double area = (Height * Breadth) / 2.0;
            return area;
        }

        public void MoveRegion(int offsetX, int offsetY)
        {
            X += offsetX;
            Y += offsetY;
        }

        public bool Resize(int x, int y)
        {
            Breadth += y;
            Height -= x;
            return true;
        }

        public void Intersect(IRegion one)
        {
            if (one.X == this.X || one.Y == this.Y)
            {
                Console.WriteLine("The regions are Intersecting");
            }
            else
            {
                Console.WriteLine("The regions do not Intersect");
            }
        }
    }
}
