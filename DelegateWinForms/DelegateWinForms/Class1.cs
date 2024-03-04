using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace DelegateWinForms
{
    class Class1
    {
        public Timer time;

        public event DownloadNotification Notify;

        public Class1()
        {
            time = new Timer();          
            time.Interval = 5000;
            time.Tick += NotifyClass;
            
        }
        public void StartTimer()
        {
            time.Start();
        }

        private void NotifyClass(object sender, EventArgs e)
        {
            Notify?.Invoke("File.png" , 25 , "c://Downloads//File.png");
        }

        
    }
}
