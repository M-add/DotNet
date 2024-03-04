using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evaluation2;

namespace Evalution1
{
    public static class RegionManager
    {
        public static List<IRegion> regions = new List<IRegion>();

        public static bool CheckId(int id)
        {
            foreach (var a in regions)
            {
                if (id == a.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddRegion()
        {

            label:
            Console.WriteLine("What region you want to add");
            Console.WriteLine("1-circle \n2-Triangle \n3-Rectangle\n");

            int s = int.Parse(Console.ReadLine());

            if (s == 1)
            {
                Console.WriteLine("Enter Radius");
                int r = int.Parse(Console.ReadLine());

                labelId:
                Console.WriteLine("Enter Id:");
                int id = int.Parse(Console.ReadLine());

                if(CheckId(id))
                {
                    Console.WriteLine("Id already exist");
                    goto labelId;
                }

                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter X axis:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y axis:");
                int y = int.Parse(Console.ReadLine());

                Circle obj = new Circle(r, name, id, 0, x, y);

                regions.Add(obj);
            }
            else if (s == 2)
            {
                Console.WriteLine("Enter Length & Breadth");
                int l = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                labelId:
                Console.WriteLine("Enter Id:");
                int id = int.Parse(Console.ReadLine());

                if (CheckId(id))
                {
                    Console.WriteLine("Id already exist");
                    goto labelId;
                }

                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter X axis:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y axis:");
                int y = int.Parse(Console.ReadLine());

                Rectangle obj = new Rectangle(l, b, name, id, 4, x, y);

                regions.Add(obj);
            }
            else if (s == 3)
            {
                Console.WriteLine("Enter Length & Height");

                int l = int.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                labelId:
                Console.WriteLine("Enter Id:");
                int id = int.Parse(Console.ReadLine());

                if (CheckId(id))
                {
                    Console.WriteLine("Id already exist");
                    goto labelId;
                }

                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter X axis:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y axis:");
                int y = int.Parse(Console.ReadLine());

                Triangle obj = new Triangle(l, h, name, id, 3, x, y);
                regions.Add(obj);
            }
            else
            {
                Console.WriteLine("Enter a valid option\n");
                goto label;
            }

        }
        public static void RemoveRegion()
        {
            Console.WriteLine("All the Id's:");
            foreach (var item in regions)
            {
                Console.Write(item.Id + " - " + item.Name + "\n");
            }

            Console.WriteLine("Enter the region Id you want remove:");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in regions.ToList())
            {
                if (item.Id == id)
                {
                    regions.Remove(item);
                }
            }
        }
        public static void GetAllRegions()
        {
            IReadOnlyList<IRegion> Copy = regions;

            if (regions.Count == 0)
            {
                Console.WriteLine("Empty:");
                return;
            }

            foreach (var i in Copy)
            {
                Console.Write(i.Id + " -> " + i.Name + " at X-axis " + i.X + " & at Y-axis-" + i.Y + "\n");
            }
        }
        public static void GetRegion()
        {
            Console.WriteLine("Enter the region Id you want:");
            int id = int.Parse(Console.ReadLine());

            foreach (var i in regions)
            {
                if (i.Id == id)
                {
                    Console.WriteLine(i.Name);
                    break;
                }
            }
        }
        public static void RegionOperations()
        {
            Console.WriteLine("All the Id's:");
            foreach (var item in regions)
            {
                Console.Write(item.Id + "-" + item.Name + "\n");
            }
            Console.WriteLine("Enter the region Id you want to perform operations on:");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in regions)
            {
                if (item.Id == id)
                {
                    Console.WriteLine("Enter the operation You want to perform");

                    while (true)
                    {
                        Console.WriteLine("1 . GetArea \n2 . Move \n3 . Resize \n4 . Intersect");
                        int n = int.Parse(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                Console.WriteLine(value: $"Area of {item.Name} is:{item.GetArea()}");
                                break;
                            case 2:
                                Console.WriteLine("Enter the offsets of X and Y axis you want to move:");
                                int x = int.Parse(Console.ReadLine());
                                int y = int.Parse(Console.ReadLine());
                                item.MoveRegion(x, y);
                                break;
                            case 3:
                                Console.WriteLine("Enter resize values:");
                                if (item.Edges == 0)
                                {
                                    Console.WriteLine("Its a circle:");
                                    int a = int.Parse(Console.ReadLine());
                                    item.Resize(a, a);
                                }
                                else
                                {
                                    int a = int.Parse(Console.ReadLine());
                                    int b = int.Parse(Console.ReadLine());
                                    item.Resize(a, b);
                                }

                                break;
                            case 4:
                                Console.WriteLine("All the other Id's:");
                                foreach (var iregion in regions)
                                {
                                    if (iregion.Id != item.Id)
                                    {
                                        Console.Write(iregion.Id + "-" + iregion.Name + "\n");
                                    }
                                }
                                Console.WriteLine($"Enter Id of the regions you want to check Intersection with the current region{item.Name}:");
                                int Id1 = int.Parse(Console.ReadLine());

                                IRegion one = null;

                                foreach (var iregion in regions)
                                {
                                    if (iregion.Id == Id1)
                                    {
                                        one = iregion;
                                    }
                                }
                                item.Intersect(one);

                                break;

                        }
                        Console.WriteLine("Press Q to quit and Y to continue");

                        string s = Console.ReadLine();

                        if (s[0] == 'q')
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                }
            }
        }
    }
}
