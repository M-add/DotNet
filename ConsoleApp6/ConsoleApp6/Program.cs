using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
 
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("peace was never an option");
            list.Add("i will have order");
            list.Add("when sun sets darkness rises");
            list.Add("i have no enemies");
            list.Add("BANKAI - Senbonsakura Kageyoshin");
            list.Add("BANKAI - KANON BIRAKI BENIHIME ARATAME");
            list.Add("BANKAI - Katen kyokotsu Karamatsu shinji");
            list.Add("i'm stronger i'm smarter.......i'm BETTER!!");

            //var result = from i in list where i.ToLower().Contains("Bankai".ToLower()) select i;

            var result = list.Where(a => a.ToLower().Contains("....".ToLower()));

            Dictionary<int, string> myDictionary = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Banana" },
    { 3, "Apple" },
    { 4, "Cherry" }
};

            var groupedByValue = myDictionary.GroupBy(pair => pair.Value);
            foreach (var i in groupedByValue)
            {
                Console.WriteLine(i.Key);
            }

            Console.ReadKey();
            
        }
    }
}
