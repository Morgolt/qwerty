using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestRostelecom.DAO;

namespace TestRostelecom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Export.ExportToExcel exp = new Export.ExportToExcel();
            exp.ExportToXLS(new List<Requests>());
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());

            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());
        }
    }
}
