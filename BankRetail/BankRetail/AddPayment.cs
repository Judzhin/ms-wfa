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
    public partial class AddPayment : Form
    {
        DAL dal = new DAL();
        ArrayList allDebitors;
        ArrayList allCredits;

        public AddPayment()
        {
            InitializeComponent();
            TtBxPaymentID.Text = Guid.NewGuid().ToString();

            allDebitors = dal.GetAllDebitors();
            if (allDebitors == null || allDebitors.Count == 0)
            {
                BnAddNewPayment.Enabled = TtBxPayment.Enabled = false;
            }
            else
            {
                BnAddNewPayment.Enabled = TtBxPayment.Enabled = true;
            }

            LtBxDebitorsID.DataSource = allDebitors;
            LtBxDebitorsName.DataSource = allDebitors;
        }

        private void LtBxDebitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            allCredits = dal.GetAllCreditsForDebitor(LtBxDebitorsID.SelectedValue.ToString());
            
            LtBxCreditID.DataSource = LtBxAmount.DataSource = LtBxBalance.DataSource = allCredits;

            if (allCredits == null || allCredits.Count == 0)
            {
                BnAddNewPayment.Enabled = TtBxPayment.Enabled = false;
            }
            else
            {
                BnAddNewPayment.Enabled = TtBxPayment.Enabled = true;
            }

            //LtBxCreditID.DisplayMember = "ID";
            LtBxCreditID.DisplayMember = LtBxCreditID.ValueMember = LtBxAmount.ValueMember = "ID";

            LtBxAmount.DisplayMember = "Amount";
            //LtBxAmount.ValueMember = "ID";

            LtBxBalance.DisplayMember = "Balance";
            //LtBxBalance.ValueMember = "Balance";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TtBxPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') 
            {
                if (TtBxPayment.Text.Trim().Contains(',') || TtBxPayment.Text == String.Empty)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }

            short res;
            if (Int16.TryParse(e.KeyChar.ToString(), out res))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TtBxPayment_Leave(object sender, EventArgs e)
        {
            if (TtBxPayment.Text.Trim() == String.Empty)
            {
                LlMessageAmountPayment.Text = "Сумма платежа не введена";
                LlMessageAmountPayment.ForeColor = Color.Red;
                BnAddNewPayment.Enabled = false;
                return;
            }

            decimal payValue = decimal.Parse(TtBxPayment.Text.Trim());

            if (payValue < 100 || payValue > decimal.Parse(LtBxBalance.SelectedValue.ToString()))
            {
                LlMessageAmountPayment.Text = "Сумма платежа не валидна";
                LlMessageAmountPayment.ForeColor = Color.Red;
                BnAddNewPayment.Enabled = false;
            }
            else
            {
                LlMessageAmountPayment.Text = "";
                LlMessageAmountPayment.ForeColor = Color.Green;
                BnAddNewPayment.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BnClearPayment_Click(object sender, EventArgs e)
        {
            TtBxPayment.Text = "";
        }

        private void BnAddNewPayment_Click(object sender, EventArgs e)
        {
            decimal paymentAmount;
            
            if (!decimal.TryParse(TtBxPayment.Text.Trim(), out paymentAmount))
            {
                MessageBox.Show("Не верно указана сумма платежа");
                return;
            }

            if (dal.SaveNewPayment(
                new Guid(TtBxPaymentID.Text.Trim()),
                new Guid(LtBxCreditID.SelectedValue.ToString()),
                paymentAmount, DtTmPrOpenDate.Value
                ))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
