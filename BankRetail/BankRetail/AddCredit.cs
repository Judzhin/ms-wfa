using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BankRetail
{
    public partial class AddCredit : Form
    {
        ArrayList allDebitors;
        DAL dal = new DAL();

        public AddCredit()
        {
            InitializeComponent();
            TtBxCreditID.Text = Guid.NewGuid().ToString();

            allDebitors = dal.GetAllDebitors();

            if (allDebitors == null || allDebitors.Count == 0)
            {
                TtBxBalance.Enabled = BnOpenNewCredit.Enabled = false;
            }
            else
            {
                TtBxBalance.Enabled = BnOpenNewCredit.Enabled = true;
            }

            LtBxDebitorsID.DataSource = allDebitors;
            LtBxDebitorsName.DataSource = allDebitors;
        }

        private void TtBxAmount_TextChanged(object sender, EventArgs e)
        {
            //TtBxAmount.Text = TtBxAmount.Text.Trim().Replace(" ", "");
            TtBxBalance.Text = TtBxAmount.Text;
        }

        private void BnOpenNewCredit_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewCredit(
                new Guid(TtBxCreditID.Text),
                new Guid(LtBxDebitorsID.SelectedValue.ToString()),
                Int32.Parse(TtBxAmount.Text),
                Int32.Parse(TtBxBalance.Text),
                DeTePrOpenDate.Value
                ))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void TtBxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TtBxAmount_Leave(object sender, EventArgs e)
        {
            if (TtBxAmount.Text == String.Empty || Int64.Parse(TtBxAmount.Text.Trim()) < 100 || Int64.Parse(TtBxAmount.Text.Trim()) > 100000000)
            {
                LlMessageAmountCredit.Text = "Недопустимое значение";
                LlMessageAmountCredit.ForeColor = Color.Red;
                BnOpenNewCredit.Enabled = false;
            }
            else
            {
                LlMessageAmountCredit.Text = "";
                BnOpenNewCredit.Enabled = true;
            }
        }
    }
}
