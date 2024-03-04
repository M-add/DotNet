using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace DragAndDrop
{
    public partial class TransitionLib : Form
    {
        public TransitionLib()
        {
            InitializeComponent();
        }

        private void TransitionLibClick(object sender, EventArgs e)
        {
            var transition = new Transition(new TransitionType_EaseInEaseOut(1000));
            transition.add(Paimon, "Left", Gi.Left);
            transition.add(Paimon, "Top", Gi.Top);
            transition.add(Gi, "Left", Paimon.Left);
            transition.add(Gi, "Top", Paimon.Top);
            transition.run();
        }
    }
}
