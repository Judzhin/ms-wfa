using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankRetail
{
    public partial class AddDebitor : Form
    {
        DAL dal = new DAL();

        public AddDebitor()
        {
            InitializeComponent();
            TtBxDebitorID.Text = Guid.NewGuid().ToString();
        }

        private void BnNewDebitor_Click(object sender, EventArgs e)
        {

            if (dal.SaveNewDebitor(TtBxDebitorID.Text.Trim(), TtBxDebitorName.Text.Trim(), TtBxNumberPayment.Text.Trim(), TtBxPhoneNumber.Text.Trim()))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;

        }
    }
}
