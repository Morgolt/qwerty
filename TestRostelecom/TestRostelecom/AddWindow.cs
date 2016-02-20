using System;
using System.Collections;
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
    public partial class AddWindow : Form
    {

        private SecondaryRepository secondRep = new SecondaryRepository();
        private RequestDatabaseDataContext requestDBContext;
        private RequestRepository requestRepo;

        public AddWindow()
        {
            InitializeComponent();
            requestDBContext = new RequestDatabaseDataContext();
            requestRepo = new RequestRepository(requestDBContext);

            IList listServies = secondRep.GetServicesList();
            comboBoxServies.DataSource = listServies;
            comboBoxServies.DisplayMember = "Name";
            comboBoxServies.ValueMember = "Id";

            IList listOperations = secondRep.GetOperatorsList();
            comboBoxOperators.DataSource = listOperations;
            comboBoxOperators.DisplayMember = "FullName";
            comboBoxOperators.ValueMember = "Id";

            IList listMasters = secondRep.GetMastersList();
            comboBoxMasters.DataSource = listMasters;
            comboBoxMasters.DisplayMember = "FullName";
            comboBoxMasters.ValueMember = "Id";
        }

        public AddWindow(Requests request)
        {
            InitializeComponent();

            textBoxClient.Text = request.Clients.FullName;
            textBoxAdress.Text = request.Address;
            textBoxComment.Text = request.Comment;
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            //IList<Masters> masters = secondRep.GetMastersList();

            if ((textBoxClient.Text == null) || (textBoxAdress.Text == null))
            {
                MessageBox.Show("Блять напиши что нибудь в пустые текст боксы");
            }
            else
            {
                Clients client = new Clients();
                client.FullName = textBoxClient.Text;
                Requests request = new Requests();
                if (secondRep.GetClientByFullName(textBoxClient.Text) == null)
                {
                    secondRep.CreateClient(client);
                }

                request.ClientId = secondRep.GetClientByFullName(textBoxClient.Text).Id;
                request.MasterId = ((Masters)comboBoxMasters.SelectedItem).Id;
                request.OperatorId = ((Operators)comboBoxOperators.SelectedItem).Id;
                request.ServiceId = ((Services)comboBoxServies.SelectedItem).Id;
                request.Comment = textBoxComment.Text;
                request.Address = textBoxAdress.Text;
                requestRepo.CreateRequest(request);
            }
        }
    }
}
