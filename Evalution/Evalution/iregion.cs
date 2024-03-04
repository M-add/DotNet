using System;

namespace Evaluation2
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
    }

    class Circle : IRegion
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Edges { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        private int radius;


        public Circle(int radius, string name, int id, int edges, int x, int y)
        {
            this.radius = radius;
            Name = name;
            Id = id;
            Edges = edges;
            X = x;
            Y = y;
        }

        public double GetArea()
        {
            double area = Math.PI * (radius * radius);
            return area;
        }

        public void MoveRegion(int x, int y)
        {
            X += x;
            Y += y;
            Console.WriteLine($"New region axis is at: {X}, {Y}");
        }

        public bool Resize(int x, int y)
        {
            radius = radius + x;
            return true;
        }

        public void Intersect(IRegion one)
        {
            if(one.X == this.X || one.Y == this.Y)
            {
                Console.WriteLine("The regions are Intersecting");
            }
            else
            {
                Console.WriteLine("The regions do not Intersect");
            }
            
        }
    }

    class Rectangle : IRegion
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Edges { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        private int length;
        private int breadth;


        public Rectangle(int length, int breadth, string name, int id, int edges, int x, int y)
        {
            this.length = length;
            this.breadth = breadth;
            Name = name;
            Id = id;
            Edges = edges;
            X = x;
            Y = y;
        }

        public double GetArea()
        {
            double area = length * breadth;
            return area;
        }

        public void MoveRegion(int x, int y)
        {
            X += x;
            Y += y;
            Console.WriteLine($"New region axis is at: {X}, {Y}");
        }

        public bool Resize(int x, int y)
        {
            length += y;
            breadth -= x;
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

    class Triangle : IRegion
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Edges { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        private int breadth;
        private int height;


        public Triangle(int breadth, int height, string name, int id, int edges, int x, int y)
        {
            this.breadth = breadth;
            this.height = height;
            Name = name;
            Id = id;
            Edges = edges;
            X = x;
            Y = y;
        }

        public double GetArea()
        {
            double area = (height * breadth) / 2.0;
            return area;
        }

        public void MoveRegion(int offsetX, int offsetY)
        {
            X += offsetX;
            Y += offsetY;
            Console.WriteLine($"New region axis is at: {X}, {Y}");
        }

        public bool Resize(int x, int y)
        {
            breadth += y;
            height -= x;
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
