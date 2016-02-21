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
using TestRostelecom.Export;

namespace TestRostelecom
{
    public partial class MainForm : Form
    {
        private RequestDatabaseDataContext requestDBContext;
        private RequestRepository requestRepo;
        private SecondaryRepository secondaryRepo;

        public MainForm()
        {
            InitializeComponent();

            requestDBContext = new RequestDatabaseDataContext();
            requestRepo = new RequestRepository(requestDBContext);
            secondaryRepo = new SecondaryRepository(requestDBContext);

            dataGridView1.CellContentDoubleClick += DataGridView1_CellContentDoubleClick;
            dataGridView1.RowHeaderMouseDoubleClick += DataGridView1_RowHeaderMouseDoubleClick;
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddWindow addWindow = new AddWindow((Requests)dataGridView1.Rows[e.RowIndex].DataBoundItem, requestDBContext, requestRepo, secondaryRepo);
            addWindow.Text = "Редакирование существующей заявки";
            addWindow.ShowDialog();
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddWindow addWindow = new AddWindow((Requests)dataGridView1.Rows[e.RowIndex].DataBoundItem, requestDBContext, requestRepo, secondaryRepo);
            addWindow.Text = "Редакирование существующей заявки";
            addWindow.ShowDialog();
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            requestsBindingSource.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());
        }

        // TODO: DELETE IT
        private void testButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Requests req = new Requests();
            req.ClientId = 2;
            req.MasterId = 2;
            req.OperatorId = 2;
            req.ServiceId = 3;
            req.Address = "test address";
            req.RequestDate = DateTime.Parse("2/2/1999");

            //requestRepo.CreateRequest(req);
            //according to https://msdn.microsoft.com/en-us/library/bb384428.aspx
            requestRepo.CreateRequest(req);            
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());
            

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void addRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());

            AddWindow addWindow = new AddWindow(requestDBContext, requestRepo, secondaryRepo);
            addWindow.ShowDialog();
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 2003 files (*.xls)|*.xls|Excel 2007/10/13/16 files|*.xlsx";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                string path = sfd.FileName;
                ExportToExcel export = new ExportToExcel();
                export.ExportToXLS(this.dataGridView1, path);
                MessageBox.Show("OK");
            }
        }
    }
}
