namespace TestRostelecom
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseDateFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Masters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfDepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRequestToolStripMenuItem,
            this.chooseDateFrameToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addRequestToolStripMenuItem
            // 
            this.addRequestToolStripMenuItem.Name = "addRequestToolStripMenuItem";
            this.addRequestToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addRequestToolStripMenuItem.Text = "Add Request";
            this.addRequestToolStripMenuItem.Click += new System.EventHandler(this.addRequestToolStripMenuItem_Click);
            // 
            // chooseDateFrameToolStripMenuItem
            // 
            this.chooseDateFrameToolStripMenuItem.Name = "chooseDateFrameToolStripMenuItem";
            this.chooseDateFrameToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.chooseDateFrameToolStripMenuItem.Text = "Choose Date Frame";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientsDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn,
            this.closeDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.servicesDataGridViewTextBoxColumn,
            this.operatorsDataGridViewTextBoxColumn,
            this.Masters,
            this.dateOfDepartureDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(984, 526);
            this.dataGridView1.TabIndex = 1;
            // 
            // Masters
            // 
            this.Masters.DataPropertyName = "Masters";
            this.Masters.HeaderText = "Masters";
            this.Masters.Name = "Masters";
            this.Masters.ReadOnly = true;
            // 
            // clientsDataGridViewTextBoxColumn
            // 
            this.clientsDataGridViewTextBoxColumn.DataPropertyName = "Clients";
            this.clientsDataGridViewTextBoxColumn.HeaderText = "Clients";
            this.clientsDataGridViewTextBoxColumn.Name = "clientsDataGridViewTextBoxColumn";
            this.clientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // closeDateDataGridViewTextBoxColumn
            // 
            this.closeDateDataGridViewTextBoxColumn.DataPropertyName = "CloseDate";
            this.closeDateDataGridViewTextBoxColumn.HeaderText = "CloseDate";
            this.closeDateDataGridViewTextBoxColumn.Name = "closeDateDataGridViewTextBoxColumn";
            this.closeDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicesDataGridViewTextBoxColumn
            // 
            this.servicesDataGridViewTextBoxColumn.DataPropertyName = "Services";
            this.servicesDataGridViewTextBoxColumn.HeaderText = "Services";
            this.servicesDataGridViewTextBoxColumn.Name = "servicesDataGridViewTextBoxColumn";
            this.servicesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operatorsDataGridViewTextBoxColumn
            // 
            this.operatorsDataGridViewTextBoxColumn.DataPropertyName = "Operators";
            this.operatorsDataGridViewTextBoxColumn.HeaderText = "Operators";
            this.operatorsDataGridViewTextBoxColumn.Name = "operatorsDataGridViewTextBoxColumn";
            this.operatorsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfDepartureDataGridViewTextBoxColumn
            // 
            this.dateOfDepartureDataGridViewTextBoxColumn.DataPropertyName = "DateOfDeparture";
            this.dateOfDepartureDataGridViewTextBoxColumn.HeaderText = "DateOfDeparture";
            this.dateOfDepartureDataGridViewTextBoxColumn.Name = "dateOfDepartureDataGridViewTextBoxColumn";
            this.dateOfDepartureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataSource = typeof(TestRostelecom.DAO.Requests);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Учет заявок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseDateFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfDepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masters;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsDataGridViewTextBoxColumn;
    }
}

