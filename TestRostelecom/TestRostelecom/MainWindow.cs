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
using TestRostelecom.Filter;

namespace TestRostelecom
{
    public partial class MainForm : Form
    {
        private Service.Service service;

        public MainForm()
        {
            InitializeComponent();

            service = new Service.Service();

            dataGridView1.CellDoubleClick += DataGridView1_CellContentDoubleClick;
            dataGridView1.RowHeaderMouseDoubleClick += DataGridView1_RowHeaderMouseDoubleClick;
            chooseDateFrameToolStripMenuItem.CheckedChanged += ChooseDateFrameToolStripMenuItem_CheckedChanged;
            chooseDateFrameToolStripMenuItem.CheckOnClick = true;                   
        }

        private void ChooseDateFrameToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(chooseDateFrameToolStripMenuItem.Checked)
            {
                chooseDateFrameToolStripMenuItem_Click(sender, e);
            }
            else
            {
                dataGridView1.DataSource = service.getDataSource();
            }
        }

        private void CreateEditDialog(int rowIndex)
        {
            AddWindow addWindow = new AddWindow((Requests)dataGridView1.Rows[rowIndex].DataBoundItem, service);
            addWindow.Text = "Редактирование существующей заявки";
            addWindow.ShowDialog();

            // HACK: According to https://msdn.microsoft.com/en-us/library/bb384428.aspx
            dataGridView1.DataSource = service.getDataSource();
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
            requestsBindingSource.DataSource = service.getDataSource();
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        private void addRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.getDataSource();

            AddWindow addWindow = new AddWindow(service);
            addWindow.ShowDialog();

            // HACK: According to https://msdn.microsoft.com/en-us/library/bb384428.aspx
            dataGridView1.DataSource = service.getDataSource();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 2007/2010/2013/2016 files(.xlsx)|*.xlsx|Все файлы|*.*";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                string path = sfd.FileName;
                
                ExportToExcel export = new ExportToExcel();
                export.ExportToXLS(this.dataGridView1, path);
                MessageBox.Show(this, "Файл успешно сохранен", "Экспорт в Excel");
            }
        }


        private void chooseDateFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm();
            filterForm.Owner = this;
            filterForm.ShowDialog();            
        }

        public void FilterDataInDataGrid(DateTime begin, DateTime end)
        {
            dataGridView1.DataSource = service.GetRequestsByDateTimeFrame(begin, end);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
