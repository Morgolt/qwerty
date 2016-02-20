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
        private RequestDatabaseDataContext requestDBContext = new RequestDatabaseDataContext();
        private RequestRepository requestRepo = new RequestRepository();

        public MainForm()
        {
            InitializeComponent();   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            requestsBindingSource.DataSource = requestDBContext.Requests;
            //requestsBindingSource.DataSource = requestRepo.GetAllRequest();
        }

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

            //requestsBindingSource.Add(req);


            requestDBContext.Requests.InsertOnSubmit(req);
            requestDBContext.SubmitChanges();

            requestsBindingSource.DataSource = requestDBContext.Requests;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = requestsBindingSource;


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }
    }
}
