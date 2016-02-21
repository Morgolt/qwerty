using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using TestRostelecom.DAO;

namespace TestRostelecom
{
    public partial class AddWindow : Form
    {
        private bool isEditMode;
        private Requests requestToEdit;
        private Service.Service service;

        private void InitializeMembers(Service.Service service)
        {
            this.isEditMode = false;
            this.requestToEdit = null;
            this.service = service;
        }

        private void InitializeComboBoxes()
        {
            IList listServies = service.getListServices();
            this.comboBoxServices.DataSource = listServies;
            this.comboBoxServices.DisplayMember = "Name";
            this.comboBoxServices.ValueMember = "Id";

            IList listOperations = service.getListOperators();
            this.comboBoxOperators.DataSource = listOperations;
            this.comboBoxOperators.DisplayMember = "FullName";
            this.comboBoxOperators.ValueMember = "Id";

            IList listMasters = service.getListMasters();
            this.comboBoxMasters.DataSource = listMasters;
            this.comboBoxMasters.DisplayMember = "FullName";
            this.comboBoxMasters.ValueMember = "Id";
        }

        public AddWindow(Service.Service service)
        {
            this.InitializeComponent();
            this.InitializeMembers(service);
            this.InitializeComboBoxes();
        }

        public AddWindow(Requests request, Service.Service service)
        {
            this.InitializeComponent();
            this.InitializeMembers(service);
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
                string message;

                if (this.isEditMode)
                {
                    message = service.UpdateRequest(requestToEdit, textBoxClient.Text,
                        ((Masters)comboBoxMasters.SelectedItem).Id,
                        ((Operators)this.comboBoxOperators.SelectedItem).Id,
                        ((Services)this.comboBoxServices.SelectedItem).Id,
                        textBoxComment.Text, textBoxAdress.Text,
                        dateTimePickerRequest.Value, dateTimePickerCloseRequest.Value, dateTimePickerDepature.Value);
                }
                else
                {
                    message = service.CreateRequest(textBoxClient.Text,
                        ((Masters)comboBoxMasters.SelectedItem).Id,
                        ((Operators)this.comboBoxOperators.SelectedItem).Id,
                        ((Services)this.comboBoxServices.SelectedItem).Id,
                        textBoxComment.Text, textBoxAdress.Text,
                        dateTimePickerRequest.Value, dateTimePickerCloseRequest.Value, dateTimePickerDepature.Value);
                }

                MessageBox.Show(this, message, "Уведомление");
                this.Close();
            }
        }
    }
}
