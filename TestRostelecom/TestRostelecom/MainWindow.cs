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

            dataGridView1.CellDoubleClick += DataGridView1_CellContentDoubleClick;
            dataGridView1.RowHeaderMouseDoubleClick += DataGridView1_RowHeaderMouseDoubleClick;
        }

        private void CreateEditDialog(int rowIndex)
        {
            AddWindow addWindow = new AddWindow((Requests)dataGridView1.Rows[rowIndex].DataBoundItem, requestDBContext, requestRepo, secondaryRepo);
            addWindow.Text = "Редактирование существующей заявки";
            addWindow.ShowDialog();

            // HACK: According to https://msdn.microsoft.com/en-us/library/bb384428.aspx
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.CreateEditDialog(e.RowIndex);
        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CreateEditDialog(e.RowIndex);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            requestsBindingSource.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        private void addRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());

            AddWindow addWindow = new AddWindow(requestDBContext, requestRepo, secondaryRepo);
            addWindow.ShowDialog();

            // HACK: According to https://msdn.microsoft.com/en-us/library/bb384428.aspx
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 files (*.xls)|*.xls|Excel 2007/2010/2013/2016 files|*.xlsx";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                string path = sfd.FileName;
                ExportToExcel export = new ExportToExcel();
                export.ExportToXLS(this.dataGridView1, path);
                MessageBox.Show(this, "OK", "Экспорт в Excel");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
