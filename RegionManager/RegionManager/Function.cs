using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    public partial class Function : UserControl
    {
        public event EventHandler<int> OnOkClick;

        public DataTable Regions { get; set; }
        public int SelectedId;

        public Function()
        {
            InitializeComponent();
        }

        public void SetSource()
        {
            ShapesList.DataSource = Regions;
        }

        private void ShapesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object Id = ShapesList.Rows[e.RowIndex].Cells[1].Value;
            SelectedId = int.Parse(Id.ToString());
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OnOkClick.Invoke(this, SelectedId);
        }
    }
}
