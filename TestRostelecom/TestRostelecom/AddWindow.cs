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
        public AddWindow()
        {
            InitializeComponent();
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
    }
}
