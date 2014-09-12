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
    public partial class MainForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        DAL dal = new DAL();
        
        /// <summary>
        /// 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //ArrayList allDebitors = dal.GetAllDebitors();
            DtGdVwDebitors.DataSource = dal.GetAllDebitors();
            Settings_DtGdVwDebitors();
        }

        /// <summary>
        /// 
        /// </summary>
        void Settings_DtGdVwDebitors()
        {
            try
            {
                DtGdVwDebitors.Columns["ID"].Visible = false;
                DtGdVwDebitors.Columns["PostNumber"].Visible = false;
                DtGdVwDebitors.Columns["PhoneNumber"].Visible = false;

                DtGdVwDebitors.TopLeftHeaderCell.Value = "#";
            }
            catch
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DtGdVwDebitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TtBxDebitorID.Text = DtGdVwDebitors.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            TtBxDebitorName.Text = DtGdVwDebitors.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            TtBxNumberPayment.Text = DtGdVwDebitors.Rows[e.RowIndex].Cells["PostNumber"].Value.ToString();

            string phone = DtGdVwDebitors.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();

            TtBxPhoneNumber.Text = (phone == String.Empty) ? "Нет данных" : phone;

            DtGdVwCredits.DataSource = dal.GetAllCreditsForDebitor(DtGdVwDebitors.CurrentRow.Cells["ID"].Value.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainForm_Load(object sender, EventArgs e)
        {
            DtGdVwDebitors.CellEnter += new DataGridViewCellEventHandler(DtGdVwDebitors_CellEnter);
            DtGdVwCredits.CellEnter += new DataGridViewCellEventHandler(DtGdVwCredits_CellEnter);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DtGdVwCredits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string creditID = DtGdVwCredits.CurrentRow.Cells["ID"].Value.ToString();
            DtGdVwPayments.DataSource = dal.GetAllPaymentsForCredit(creditID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы дествительно желаете закрыть приложение?", "Банк менеджер", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDebitor AddDebitor = new AddDebitor();
            if (AddDebitor.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новый дебитор успешно создан", "Банк менеджер", MessageBoxButtons.OK);
                DtGdVwDebitors.DataSource = dal.GetAllDebitors();
            }
            else
                MessageBox.Show("Дебитор не создан", "Банк менеджер", MessageBoxButtons.OK);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCredit AddCredit = new AddCredit();
            if (AddCredit.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новый кредит успешно выдан", "Банк менеджер", MessageBoxButtons.OK);
                DtGdVwCredits.DataSource = dal.GetAllCreditsForDebitor(DtGdVwDebitors.CurrentRow.Cells["ID"].Value.ToString());
            }
            else
                MessageBox.Show("Кредит не выдан", "Банк менеджер", MessageBoxButtons.OK);
        }

        private void passNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment AddPayment = new AddPayment();
            if (AddPayment.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Новый плаьеж успешно принят", "Банк менеджер", MessageBoxButtons.OK);
                DtGdVwCredits.DataSource = dal.GetAllCreditsForDebitor(DtGdVwDebitors.CurrentRow.Cells["ID"].Value.ToString());
            }
            else
                MessageBox.Show("Платеж не принят", "Банк менеджер", MessageBoxButtons.OK);
        }

        private void saveDataToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dal.SaveDBToLocalFile())
            {
                MessageBox.Show("Данные БД были успешно сохранены в локальных файлах", "BankManager", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Данные БД небыли успешно сохранены в локальных файлах", "BankManager", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void DtGdVw_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object headValue = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if (headValue == null || !headValue.Equals((e.RowIndex + 1).ToString()))
            {
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
            }
        }

        List<DataGridViewRow> searchRows;
        int currentRow;

        private void BnSearch_Click(object sender, EventArgs e)
        {
            searchRows = new List<DataGridViewRow>();
            string depName = TtBxSearchDepName.Text.Trim();
            string depPostNumber = TtBxSearchDebitorPostNumber.Text.Trim();
            string depPhoneNumber = TtBxSearchDebitorPhoneNumber.Text.Trim();

            foreach(DataGridViewRow row in DtGdVwDebitors.Rows)
            {
                if
                    (
                        row.Cells["Name"].FormattedValue.ToString().Contains(depName) &&
                        row.Cells["PostNumber"].FormattedValue.ToString().Contains(depPostNumber) &&
                        row.Cells["PhoneNumber"].FormattedValue.ToString().Contains(depName)
                    )
                {
                    searchRows.Add(row);
                }

            }

            if (searchRows.Count == 0)
            {
                MessageBox.Show("По данному запросу не найдено записей");
                return;
            }

            MessageBox.Show("Найдено " + searchRows.Count + " записей");

        }
    }
}
