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
        private RequestDatabaseDataContext requestDBContext;
        private RequestRepository requestRepo;

        public MainForm()
        {
            InitializeComponent();
            requestDBContext = new RequestDatabaseDataContext();
            requestRepo = new RequestRepository(requestDBContext);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindingList<Requests> bl = new BindingList<Requests>(requestDBContext.Requests.ToList());
            bl.AllowNew = true;
            requestsBindingSource.DataSource = bl;
            
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
            //according to https://msdn.microsoft.com/en-us/library/bb384428.aspx
            requestRepo.CreateRequest(req);            
            dataGridView1.DataSource = new BindingList<Requests>(requestDBContext.Requests.ToList());
            

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }
    }
}
