using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateWinForms
{
    public delegate bool DownloadNotification(string Name, int Size, string Location);

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 obj = new Class1();
            obj.StartTimer();
            obj.Notify += Notification;          
        }

        private bool Notification(string Name, int Size, string Location)
        {
            MessageBox.Show(Name + "\n" + Size + "\n" + Location);
            return true;
        }
    }


}
