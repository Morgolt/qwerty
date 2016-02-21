using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRostelecom.Filter
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime from = this.firstDateTimePicker.Value;
            DateTime to = this.secondDateTimePicker.Value;
            (this.Owner as MainForm).FilterDataInDataGrid(from, to);
            this.Close();
        }        
    }
}
