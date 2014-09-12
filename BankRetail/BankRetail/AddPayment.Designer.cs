namespace BankRetail
{
    partial class AddPayment
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
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.LtBxCreditID = new System.Windows.Forms.ListBox();
            this.LtBxAmount = new System.Windows.Forms.ListBox();
            this.LtBxBalance = new System.Windows.Forms.ListBox();
            this.LlMessageAmountPayment = new Telerik.WinControls.UI.RadLabel();
            this.LtBxDebitorsName = new System.Windows.Forms.ListBox();
            this.LtBxDebitorsID = new System.Windows.Forms.ListBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.DtTmPrOpenDate = new System.Windows.Forms.DateTimePicker();
            this.BnAddNewPayment = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TtBxPayment = new Telerik.WinControls.UI.RadTextBox();
            this.TtBxPaymentID = new Telerik.WinControls.UI.RadTextBox();
            this.BnClearPayment = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LlMessageAmountPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnAddNewPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxPaymentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnClearPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.BnClearPayment);
            this.radGroupBox2.Controls.Add(this.radLabel6);
            this.radGroupBox2.Controls.Add(this.LtBxCreditID);
            this.radGroupBox2.Controls.Add(this.LtBxAmount);
            this.radGroupBox2.Controls.Add(this.LtBxBalance);
            this.radGroupBox2.Controls.Add(this.LlMessageAmountPayment);
            this.radGroupBox2.Controls.Add(this.LtBxDebitorsName);
            this.radGroupBox2.Controls.Add(this.LtBxDebitorsID);
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.Controls.Add(this.DtTmPrOpenDate);
            this.radGroupBox2.Controls.Add(this.BnAddNewPayment);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.Controls.Add(this.TtBxPayment);
            this.radGroupBox2.Controls.Add(this.TtBxPaymentID);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Информация о платиже";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(560, 300);
            this.radGroupBox2.TabIndex = 12;
            this.radGroupBox2.Text = "Информация о платиже";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(5, 132);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(43, 18);
            this.radLabel6.TabIndex = 6;
            this.radLabel6.Text = "Кредит";
            // 
            // LtBxCreditID
            // 
            this.LtBxCreditID.DisplayMember = "ID";
            this.LtBxCreditID.FormattingEnabled = true;
            this.LtBxCreditID.Location = new System.Drawing.Point(106, 132);
            this.LtBxCreditID.Name = "LtBxCreditID";
            this.LtBxCreditID.Size = new System.Drawing.Size(140, 82);
            this.LtBxCreditID.TabIndex = 18;
            this.LtBxCreditID.ValueMember = "ID";
            // 
            // LtBxAmount
            // 
            this.LtBxAmount.DisplayMember = "Amount";
            this.LtBxAmount.FormattingEnabled = true;
            this.LtBxAmount.Location = new System.Drawing.Point(252, 132);
            this.LtBxAmount.Name = "LtBxAmount";
            this.LtBxAmount.Size = new System.Drawing.Size(150, 82);
            this.LtBxAmount.TabIndex = 17;
            this.LtBxAmount.ValueMember = "ID";
            // 
            // LtBxBalance
            // 
            this.LtBxBalance.DisplayMember = "Balance";
            this.LtBxBalance.FormattingEnabled = true;
            this.LtBxBalance.Location = new System.Drawing.Point(405, 132);
            this.LtBxBalance.Name = "LtBxBalance";
            this.LtBxBalance.Size = new System.Drawing.Size(150, 82);
            this.LtBxBalance.TabIndex = 16;
            this.LtBxBalance.ValueMember = "Balance";
            // 
            // LlMessageAmountPayment
            // 
            this.LlMessageAmountPayment.ForeColor = System.Drawing.Color.DimGray;
            this.LlMessageAmountPayment.Location = new System.Drawing.Point(335, 220);
            this.LlMessageAmountPayment.Name = "LlMessageAmountPayment";
            this.LlMessageAmountPayment.Size = new System.Drawing.Size(158, 18);
            this.LlMessageAmountPayment.TabIndex = 15;
            this.LlMessageAmountPayment.Text = "Введите начальное значение";
            // 
            // LtBxDebitorsName
            // 
            this.LtBxDebitorsName.DisplayMember = "Name";
            this.LtBxDebitorsName.FormattingEnabled = true;
            this.LtBxDebitorsName.Location = new System.Drawing.Point(335, 44);
            this.LtBxDebitorsName.Name = "LtBxDebitorsName";
            this.LtBxDebitorsName.Size = new System.Drawing.Size(220, 82);
            this.LtBxDebitorsName.TabIndex = 14;
            this.LtBxDebitorsName.ValueMember = "ID";
            this.LtBxDebitorsName.SelectedIndexChanged += new System.EventHandler(this.LtBxDebitors_SelectedIndexChanged);
            // 
            // LtBxDebitorsID
            // 
            this.LtBxDebitorsID.DisplayMember = "ID";
            this.LtBxDebitorsID.FormattingEnabled = true;
            this.LtBxDebitorsID.Location = new System.Drawing.Point(106, 44);
            this.LtBxDebitorsID.Name = "LtBxDebitorsID";
            this.LtBxDebitorsID.Size = new System.Drawing.Size(220, 82);
            this.LtBxDebitorsID.TabIndex = 13;
            this.LtBxDebitorsID.ValueMember = "ID";
            this.LtBxDebitorsID.SelectedIndexChanged += new System.EventHandler(this.LtBxDebitors_SelectedIndexChanged);
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(5, 244);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(76, 18);
            this.radLabel5.TabIndex = 8;
            this.radLabel5.Text = "Дата Кредита";
            // 
            // DtTmPrOpenDate
            // 
            this.DtTmPrOpenDate.Location = new System.Drawing.Point(106, 244);
            this.DtTmPrOpenDate.Name = "DtTmPrOpenDate";
            this.DtTmPrOpenDate.Size = new System.Drawing.Size(449, 20);
            this.DtTmPrOpenDate.TabIndex = 12;
            // 
            // BnAddNewPayment
            // 
            this.BnAddNewPayment.Location = new System.Drawing.Point(425, 270);
            this.BnAddNewPayment.Name = "BnAddNewPayment";
            this.BnAddNewPayment.Size = new System.Drawing.Size(130, 24);
            this.BnAddNewPayment.TabIndex = 11;
            this.BnAddNewPayment.Text = "Добавить";
            this.BnAddNewPayment.Click += new System.EventHandler(this.BnAddNewPayment_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(5, 220);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(88, 18);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Сумма Платежа";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(5, 44);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(51, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Дебитор";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(5, 18);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(89, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Номер Платежа";
            // 
            // TtBxPayment
            // 
            this.TtBxPayment.Location = new System.Drawing.Point(106, 220);
            this.TtBxPayment.MaxLength = 8;
            this.TtBxPayment.Name = "TtBxPayment";
            this.TtBxPayment.Size = new System.Drawing.Size(125, 20);
            this.TtBxPayment.TabIndex = 2;
            this.TtBxPayment.TabStop = false;
            this.TtBxPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TtBxPayment_KeyPress);
            this.TtBxPayment.Leave += new System.EventHandler(this.TtBxPayment_Leave);
            // 
            // TtBxPaymentID
            // 
            this.TtBxPaymentID.Location = new System.Drawing.Point(106, 18);
            this.TtBxPaymentID.Name = "TtBxPaymentID";
            this.TtBxPaymentID.ReadOnly = true;
            this.TtBxPaymentID.Size = new System.Drawing.Size(449, 20);
            this.TtBxPaymentID.TabIndex = 0;
            this.TtBxPaymentID.TabStop = false;
            // 
            // BnClearPayment
            // 
            this.BnClearPayment.Location = new System.Drawing.Point(238, 221);
            this.BnClearPayment.Name = "BnClearPayment";
            this.BnClearPayment.Size = new System.Drawing.Size(88, 19);
            this.BnClearPayment.TabIndex = 19;
            this.BnClearPayment.Text = "Очистить";
            this.BnClearPayment.Click += new System.EventHandler(this.BnClearPayment_Click);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 322);
            this.Controls.Add(this.radGroupBox2);
            this.Name = "AddPayment";
            this.Text = "AddPayment";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LlMessageAmountPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnAddNewPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxPaymentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnClearPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private System.Windows.Forms.ListBox LtBxCreditID;
        private System.Windows.Forms.ListBox LtBxAmount;
        private System.Windows.Forms.ListBox LtBxBalance;
        private Telerik.WinControls.UI.RadLabel LlMessageAmountPayment;
        private System.Windows.Forms.ListBox LtBxDebitorsName;
        private System.Windows.Forms.ListBox LtBxDebitorsID;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.DateTimePicker DtTmPrOpenDate;
        private Telerik.WinControls.UI.RadButton BnAddNewPayment;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TtBxPayment;
        private Telerik.WinControls.UI.RadTextBox TtBxPaymentID;
        private Telerik.WinControls.UI.RadButton BnClearPayment;
    }
}