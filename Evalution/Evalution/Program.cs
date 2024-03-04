using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evalution1;

namespace Evalution
{
    class Program
    {
      
        static void Main(string[] args)
        {           
            while (true)
            {
                Console.WriteLine("What operation You want to do:");
                Console.WriteLine("1 . Add Region \n2 . Remove Region \n3 . Get All Regions \n4 . Get Region \n5.Region Operations");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        RegionManager.AddRegion();
                        break;
                    case 2:
                        RegionManager.RemoveRegion();
                        break;
                    case 3:
                        RegionManager.GetAllRegions();
                        break;
                    case 4:
                        RegionManager.GetRegion();
                        break;
                    case 5:
                        RegionManager.RegionOperations();
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
            

            

            Console.ReadKey();
        }
    }
}
