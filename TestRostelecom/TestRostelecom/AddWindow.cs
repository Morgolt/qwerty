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

        private SecondaryRepository secondaryRepo;
        private RequestDatabaseDataContext requestDBContext;
        private RequestRepository requestRepo;
        private bool isEditMode;
        private Requests requestToEdit;

        private void InitializeMembers(RequestDatabaseDataContext requestDbContext, RequestRepository requestRepo, SecondaryRepository secondaryRepo)
        {
            this.isEditMode = false;
            this.requestToEdit = null;
            this.requestDBContext = requestDbContext;
            this.requestRepo = requestRepo;
            this.secondaryRepo = secondaryRepo;
        }

        private void InitializeComboBoxes()
        {
            IList listServies = this.secondaryRepo.GetServicesList();
            this.comboBoxServices.DataSource = listServies;
            this.comboBoxServices.DisplayMember = "Name";
            this.comboBoxServices.ValueMember = "Id";

            IList listOperations = this.secondaryRepo.GetOperatorsList();
            this.comboBoxOperators.DataSource = listOperations;
            this.comboBoxOperators.DisplayMember = "FullName";
            this.comboBoxOperators.ValueMember = "Id";

            IList listMasters = this.secondaryRepo.GetMastersList();
            this.comboBoxMasters.DataSource = listMasters;
            this.comboBoxMasters.DisplayMember = "FullName";
            this.comboBoxMasters.ValueMember = "Id";
        }

        public AddWindow(RequestDatabaseDataContext requestDbContext, RequestRepository requestRepo, SecondaryRepository secondaryRepo)
        {
            this.InitializeComponent();
            this.InitializeMembers(requestDbContext, requestRepo, secondaryRepo);
            this.InitializeComboBoxes();
        }

        public AddWindow(Requests request, RequestDatabaseDataContext requestDbContext, RequestRepository requestRepo, SecondaryRepository secondaryRepo)
        {
            this.InitializeComponent();
            this.InitializeMembers(requestDbContext, requestRepo, secondaryRepo);
            this.InitializeComboBoxes();
            
            // Fill TextBoxes
            this.textBoxClient.Text = request.Clients.FullName;
            this.textBoxAdress.Text = request.Address;
            this.textBoxComment.Text = request.Comment;

            // Fill ComboBoxes
            this.comboBoxServices.SelectedIndex     = this.comboBoxServices.FindStringExact(request.Services.Name);
            this.comboBoxOperators.SelectedIndex    = this.comboBoxOperators.FindStringExact(request.Operators.FullName);
            this.comboBoxMasters.SelectedIndex      = this.comboBoxMasters.FindStringExact(request.Masters.FullName);

            // Fill DateTimePickers
            this.dateTimePickerRequest.Value = request.RequestDate;
            this.dateTimePickerCloseRequest.Value = request.CloseDate ?? DateTime.Now;
            this.dateTimePickerDepature.Value = request.DateOfDeparture ?? DateTime.Now;

            this.buttonAdd.Text = "Изменить";
            this.isEditMode = true;
            this.requestToEdit = request;
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if ((this.textBoxClient.Text == "") || (this.textBoxAdress.Text == ""))
            {
                MessageBox.Show(this, "Заполните обязательные поля \"ФИО Клиента\" и \"Адрес\"", "Ошибка");
            }
            else
            {
                Clients client = new Clients();
                client.FullName = this.textBoxClient.Text;

                if (this.secondaryRepo.GetClientByFullName(this.textBoxClient.Text) == null)
                {
                    this.secondaryRepo.CreateClient(client);
                }

                if (this.isEditMode)
                {
                    this.requestToEdit.Clients      = this.requestDBContext.Clients.Single(x => x.Id == this.secondaryRepo.GetClientByFullName(this.textBoxClient.Text).Id);
                    this.requestToEdit.Masters      = this.requestDBContext.Masters.Single(x => x.Id == ((Masters)this.comboBoxMasters.SelectedItem).Id);
                    this.requestToEdit.Operators    = this.requestDBContext.Operators.Single(x => x.Id == ((Operators)this.comboBoxOperators.SelectedItem).Id);
                    this.requestToEdit.Services     = this.requestDBContext.Services.Single(x => x.Id == ((Services)this.comboBoxServices.SelectedItem).Id);

                    this.requestToEdit.Comment      = this.textBoxComment.Text;
                    this.requestToEdit.Address      = this.textBoxAdress.Text;
                    this.requestToEdit.RequestDate  = this.dateTimePickerRequest.Value;
                    this.requestToEdit.CloseDate    = this.dateTimePickerCloseRequest.Value;
                    this.requestToEdit.DateOfDeparture = this.dateTimePickerDepature.Value;

                    requestDBContext.SubmitChanges();
                    //requestRepo.UpdateRequest(requestToEdit);
                }
                else
                {
                    Requests request = new Requests();

                    request.ClientId = this.secondaryRepo.GetClientByFullName(this.textBoxClient.Text).Id;
                    request.MasterId = ((Masters)this.comboBoxMasters.SelectedItem).Id;
                    request.OperatorId = ((Operators)this.comboBoxOperators.SelectedItem).Id;
                    request.ServiceId = ((Services)this.comboBoxServices.SelectedItem).Id;
                    request.Comment = this.textBoxComment.Text;
                    request.Address = this.textBoxAdress.Text;
                    request.RequestDate = this.dateTimePickerRequest.Value;
                    request.CloseDate = this.dateTimePickerCloseRequest.Value;
                    request.DateOfDeparture = this.dateTimePickerDepature.Value;

                    requestRepo.CreateRequest(request);
                }

                this.Close();
            }
        }
    }
}
