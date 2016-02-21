namespace TestRostelecom
{
    partial class AddWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.dateTimePickerRequest = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCloseRequest = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxOperators = new System.Windows.Forms.ComboBox();
            this.comboBoxMasters = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDepature = new System.Windows.Forms.DateTimePicker();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(12, 26);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(478, 20);
            this.textBoxClient.TabIndex = 0;
            // 
            // dateTimePickerRequest
            // 
            this.dateTimePickerRequest.CustomFormat = "";
            this.dateTimePickerRequest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRequest.Location = new System.Drawing.Point(12, 80);
            this.dateTimePickerRequest.Name = "dateTimePickerRequest";
            this.dateTimePickerRequest.Size = new System.Drawing.Size(143, 20);
            this.dateTimePickerRequest.TabIndex = 2;
            this.dateTimePickerRequest.Value = new System.DateTime(2016, 2, 21, 0, 0, 0, 0);
            // 
            // dateTimePickerCloseRequest
            // 
            this.dateTimePickerCloseRequest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCloseRequest.Location = new System.Drawing.Point(179, 80);
            this.dateTimePickerCloseRequest.Name = "dateTimePickerCloseRequest";
            this.dateTimePickerCloseRequest.Size = new System.Drawing.Size(143, 20);
            this.dateTimePickerCloseRequest.TabIndex = 3;
            this.dateTimePickerCloseRequest.Value = new System.DateTime(2016, 2, 21, 0, 0, 0, 0);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(12, 124);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(478, 20);
            this.textBoxAdress.TabIndex = 4;
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requestsBindingSource, "Services", true));
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(12, 171);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(478, 21);
            this.comboBoxServices.TabIndex = 5;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataSource = typeof(TestRostelecom.DAO.Requests);
            // 
            // comboBoxOperators
            // 
            this.comboBoxOperators.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requestsBindingSource, "Services", true));
            this.comboBoxOperators.FormattingEnabled = true;
            this.comboBoxOperators.Location = new System.Drawing.Point(12, 216);
            this.comboBoxOperators.Name = "comboBoxOperators";
            this.comboBoxOperators.Size = new System.Drawing.Size(478, 21);
            this.comboBoxOperators.TabIndex = 6;
            // 
            // comboBoxMasters
            // 
            this.comboBoxMasters.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requestsBindingSource, "Services", true));
            this.comboBoxMasters.FormattingEnabled = true;
            this.comboBoxMasters.Location = new System.Drawing.Point(12, 265);
            this.comboBoxMasters.Name = "comboBoxMasters";
            this.comboBoxMasters.Size = new System.Drawing.Size(478, 21);
            this.comboBoxMasters.TabIndex = 7;
            // 
            // dateTimePickerDepature
            // 
            this.dateTimePickerDepature.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDepature.Location = new System.Drawing.Point(347, 80);
            this.dateTimePickerDepature.Name = "dateTimePickerDepature";
            this.dateTimePickerDepature.Size = new System.Drawing.Size(143, 20);
            this.dateTimePickerDepature.TabIndex = 8;
            this.dateTimePickerDepature.Value = new System.DateTime(2016, 2, 21, 0, 0, 0, 0);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(514, 25);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(222, 261);
            this.textBoxComment.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ФИО Клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата подачи заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата закрытия заявки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата выезда мастера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Услуга";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Оператор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Комментарий";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Мастер";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 332);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(142, 37);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 381);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.dateTimePickerDepature);
            this.Controls.Add(this.comboBoxMasters);
            this.Controls.Add(this.comboBoxOperators);
            this.Controls.Add(this.comboBoxServices);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.dateTimePickerCloseRequest);
            this.Controls.Add(this.dateTimePickerRequest);
            this.Controls.Add(this.textBoxClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить заявку";
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequest;
        private System.Windows.Forms.DateTimePicker dateTimePickerCloseRequest;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private System.Windows.Forms.ComboBox comboBoxOperators;
        private System.Windows.Forms.ComboBox comboBoxMasters;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepature;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAdd;
    }
}