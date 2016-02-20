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
        //private RequestDatabaseDataContext requestDBContext = new RequestDatabaseDataContext();
        private RequestRepository requestRepo = new RequestRepository();

        public MainForm()
        {
            InitializeComponent();   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //requestsBindingSource.DataSource = requestDBContext.Requests;
            requestsBindingSource.DataSource = requestRepo.GetAllRequest();
        }
    }
}
