using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExampleClientServer
{
    //public delegate void HttpwebClientTimeoutDelegate(string clientName);

    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    class Program
    {
        static void Main(string[] args)
        {
            //deleg1();

            WorkPerformedHandler del1 = new WorkPerformedHandler(Manager_WorkPerformed);
            del1(10, WorkType.Golf);

            Console.ReadLine();
        }

        public static void Manager_WorkPerformed(int workHours, WorkType wType)
        {
            Console.WriteLine("Work Performed by Event Handler");
            Console.WriteLine($"Work Hours: {workHours}, Work Type: {wType}");
        }

        //public static void deleg1()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        var client = new HttpwebClient($"clinet {i}", i * 1000);
        //        client.TimedOut += TimedOutHandler;
        //    }
        //}

        //public static void TimedOutHandler(string name)
        //{
        //    Console.WriteLine($"TimedOut {name}");
        //}
    }

    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }

    //public class HttpwebClient
    //{
    //    public HttpwebClientTimeoutDelegate TimedOut;

    //    public HttpwebClient(string name, int timeout)
    //    {
    //        new System.Threading.Thread(() =>
    //        {

    //            System.Threading.Thread.Sleep(timeout);
    //            TimedOut.Invoke(name);

    //        }).Start();
    //    }
    //}

}

