namespace BankRetail
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MuSp = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDebitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GpBxPayments = new Telerik.WinControls.UI.RadGroupBox();
            this.DtGdVwPayments = new System.Windows.Forms.DataGridView();
            this.GpBxCredits = new Telerik.WinControls.UI.RadGroupBox();
            this.DtGdVwCredits = new System.Windows.Forms.DataGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.DtGdVwDebitors = new System.Windows.Forms.DataGridView();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TtBxPhoneNumber = new Telerik.WinControls.UI.RadTextBox();
            this.TtBxNumberPayment = new Telerik.WinControls.UI.RadTextBox();
            this.TtBxDebitorName = new Telerik.WinControls.UI.RadTextBox();
            this.TtBxDebitorID = new Telerik.WinControls.UI.RadTextBox();
            this.GpBxSearch = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.BnSearch = new Telerik.WinControls.UI.RadButton();
            this.TtBxSearchDebitorPhoneNumber = new Telerik.WinControls.UI.RadTextBox();
            this.TtBxSearchDebitorPostNumber = new Telerik.WinControls.UI.RadTextBox();
            this.TtBxSearchDepName = new Telerik.WinControls.UI.RadTextBox();
            this.MuSp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GpBxPayments)).BeginInit();
            this.GpBxPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGdVwPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GpBxCredits)).BeginInit();
            this.GpBxCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGdVwCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGdVwDebitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxNumberPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxDebitorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxDebitorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GpBxSearch)).BeginInit();
            this.GpBxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxSearchDebitorPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxSearchDebitorPostNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxSearchDepName)).BeginInit();
            this.SuspendLayout();
            // 
            // MuSp
            // 
            this.MuSp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debitorToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.MuSp.Location = new System.Drawing.Point(0, 0);
            this.MuSp.Name = "MuSp";
            this.MuSp.Size = new System.Drawing.Size(684, 24);
            this.MuSp.TabIndex = 5;
            this.MuSp.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToCSVToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveDataToCSVToolStripMenuItem
            // 
            this.saveDataToCSVToolStripMenuItem.Name = "saveDataToCSVToolStripMenuItem";
            this.saveDataToCSVToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.saveDataToCSVToolStripMenuItem.Text = "Сохранить данные в CSV";
            this.saveDataToCSVToolStripMenuItem.Click += new System.EventHandler(this.saveDataToCSVToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // debitorToolStripMenuItem
            // 
            this.debitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDebitorToolStripMenuItem});
            this.debitorToolStripMenuItem.Name = "debitorToolStripMenuItem";
            this.debitorToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.debitorToolStripMenuItem.Text = "Дебитор";
            // 
            // addNewDebitorToolStripMenuItem
            // 
            this.addNewDebitorToolStripMenuItem.Name = "addNewDebitorToolStripMenuItem";
            this.addNewDebitorToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.addNewDebitorToolStripMenuItem.Text = "Добавить нового Дебитора";
            this.addNewDebitorToolStripMenuItem.Click += new System.EventHandler(this.AddNewDebitorToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewCreditToolStripMenuItem});
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.creditToolStripMenuItem.Text = "Кредит";
            // 
            // openNewCreditToolStripMenuItem
            // 
            this.openNewCreditToolStripMenuItem.Name = "openNewCreditToolStripMenuItem";
            this.openNewCreditToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.openNewCreditToolStripMenuItem.Text = "Открыть новый кредит";
            this.openNewCreditToolStripMenuItem.Click += new System.EventHandler(this.OpenNewCreditToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passNewPaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.paymentToolStripMenuItem.Text = "Оплаты";
            // 
            // passNewPaymentToolStripMenuItem
            // 
            this.passNewPaymentToolStripMenuItem.Name = "passNewPaymentToolStripMenuItem";
            this.passNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.passNewPaymentToolStripMenuItem.Text = "Обработать новую оплату";
            this.passNewPaymentToolStripMenuItem.Click += new System.EventHandler(this.passNewPaymentToolStripMenuItem_Click);
            // 
            // GpBxPayments
            // 
            this.GpBxPayments.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GpBxPayments.Controls.Add(this.DtGdVwPayments);
            this.GpBxPayments.FooterImageIndex = -1;
            this.GpBxPayments.FooterImageKey = "";
            this.GpBxPayments.HeaderImageIndex = -1;
            this.GpBxPayments.HeaderImageKey = "";
            this.GpBxPayments.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.GpBxPayments.HeaderText = "Платежи";
            this.GpBxPayments.Location = new System.Drawing.Point(12, 333);
            this.GpBxPayments.Name = "GpBxPayments";
            this.GpBxPayments.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.GpBxPayments.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.GpBxPayments.Size = new System.Drawing.Size(660, 100);
            this.GpBxPayments.TabIndex = 6;
            this.GpBxPayments.Text = "Платежи";
            // 
            // DtGdVwPayments
            // 
            this.DtGdVwPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGdVwPayments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtGdVwPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGdVwPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGdVwPayments.Location = new System.Drawing.Point(2, 18);
            this.DtGdVwPayments.Name = "DtGdVwPayments";
            this.DtGdVwPayments.Size = new System.Drawing.Size(656, 80);
            this.DtGdVwPayments.TabIndex = 0;
            this.DtGdVwPayments.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DtGdVw_RowPrePaint);
            // 
            // GpBxCredits
            // 
            this.GpBxCredits.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GpBxCredits.Controls.Add(this.DtGdVwCredits);
            this.GpBxCredits.FooterImageIndex = -1;
            this.GpBxCredits.FooterImageKey = "";
            this.GpBxCredits.HeaderImageIndex = -1;
            this.GpBxCredits.HeaderImageKey = "";
            this.GpBxCredits.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.GpBxCredits.HeaderText = "Кредиты";
            this.GpBxCredits.Location = new System.Drawing.Point(12, 227);
            this.GpBxCredits.Name = "GpBxCredits";
            this.GpBxCredits.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.GpBxCredits.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.GpBxCredits.Size = new System.Drawing.Size(660, 100);
            this.GpBxCredits.TabIndex = 7;
            this.GpBxCredits.Text = "Кредиты";
            // 
            // DtGdVwCredits
            // 
            this.DtGdVwCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGdVwCredits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtGdVwCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGdVwCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGdVwCredits.Location = new System.Drawing.Point(2, 18);
            this.DtGdVwCredits.Name = "DtGdVwCredits";
            this.DtGdVwCredits.Size = new System.Drawing.Size(656, 80);
            this.DtGdVwCredits.TabIndex = 0;
            this.DtGdVwCredits.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DtGdVw_RowPrePaint);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.DtGdVwDebitors);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Дебиторы";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 101);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(325, 120);
            this.radGroupBox1.TabIndex = 8;
            this.radGroupBox1.Text = "Дебиторы";
            // 
            // DtGdVwDebitors
            // 
            this.DtGdVwDebitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGdVwDebitors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtGdVwDebitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGdVwDebitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGdVwDebitors.Location = new System.Drawing.Point(2, 18);
            this.DtGdVwDebitors.Name = "DtGdVwDebitors";
            this.DtGdVwDebitors.Size = new System.Drawing.Size(321, 100);
            this.DtGdVwDebitors.TabIndex = 0;
            this.DtGdVwDebitors.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DtGdVw_RowPrePaint);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.Controls.Add(this.TtBxPhoneNumber);
            this.radGroupBox2.Controls.Add(this.TtBxNumberPayment);
            this.radGroupBox2.Controls.Add(this.TtBxDebitorName);
            this.radGroupBox2.Controls.Add(this.TtBxDebitorID);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Информация о Дебиторе";
            this.radGroupBox2.Location = new System.Drawing.Point(347, 101);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(325, 120);
            this.radGroupBox2.TabIndex = 9;
            this.radGroupBox2.Text = "Информация о Дебиторе";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(5, 96);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(94, 18);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "Номер телефона";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(5, 70);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(72, 18);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Номер счёта";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(5, 44);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(82, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Имя Дебитора";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(5, 18);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(95, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Номер Дебитора";
            // 
            // TtBxPhoneNumber
            // 
            this.TtBxPhoneNumber.Location = new System.Drawing.Point(106, 96);
            this.TtBxPhoneNumber.Name = "TtBxPhoneNumber";
            this.TtBxPhoneNumber.ReadOnly = true;
            this.TtBxPhoneNumber.Size = new System.Drawing.Size(214, 20);
            this.TtBxPhoneNumber.TabIndex = 3;
            this.TtBxPhoneNumber.TabStop = false;
            // 
            // TtBxNumberPayment
            // 
            this.TtBxNumberPayment.Location = new System.Drawing.Point(106, 70);
            this.TtBxNumberPayment.Name = "TtBxNumberPayment";
            this.TtBxNumberPayment.ReadOnly = true;
            this.TtBxNumberPayment.Size = new System.Drawing.Size(214, 20);
            this.TtBxNumberPayment.TabIndex = 2;
            this.TtBxNumberPayment.TabStop = false;
            // 
            // TtBxDebitorName
            // 
            this.TtBxDebitorName.Location = new System.Drawing.Point(106, 44);
            this.TtBxDebitorName.Name = "TtBxDebitorName";
            this.TtBxDebitorName.ReadOnly = true;
            this.TtBxDebitorName.Size = new System.Drawing.Size(214, 20);
            this.TtBxDebitorName.TabIndex = 1;
            this.TtBxDebitorName.TabStop = false;
            // 
            // TtBxDebitorID
            // 
            this.TtBxDebitorID.Location = new System.Drawing.Point(106, 18);
            this.TtBxDebitorID.Name = "TtBxDebitorID";
            this.TtBxDebitorID.ReadOnly = true;
            this.TtBxDebitorID.Size = new System.Drawing.Size(214, 20);
            this.TtBxDebitorID.TabIndex = 0;
            this.TtBxDebitorID.TabStop = false;
            // 
            // GpBxSearch
            // 
            this.GpBxSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GpBxSearch.Controls.Add(this.radLabel7);
            this.GpBxSearch.Controls.Add(this.radLabel6);
            this.GpBxSearch.Controls.Add(this.radLabel5);
            this.GpBxSearch.Controls.Add(this.BnSearch);
            this.GpBxSearch.Controls.Add(this.TtBxSearchDebitorPhoneNumber);
            this.GpBxSearch.Controls.Add(this.TtBxSearchDebitorPostNumber);
            this.GpBxSearch.Controls.Add(this.TtBxSearchDepName);
            this.GpBxSearch.FooterImageIndex = -1;
            this.GpBxSearch.FooterImageKey = "";
            this.GpBxSearch.HeaderImageIndex = -1;
            this.GpBxSearch.HeaderImageKey = "";
            this.GpBxSearch.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.GpBxSearch.HeaderText = "Поиск";
            this.GpBxSearch.Location = new System.Drawing.Point(14, 28);
            this.GpBxSearch.Name = "GpBxSearch";
            this.GpBxSearch.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.GpBxSearch.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.GpBxSearch.Size = new System.Drawing.Size(660, 67);
            this.GpBxSearch.TabIndex = 10;
            this.GpBxSearch.Text = "Поиск";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(357, 18);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(103, 18);
            this.radLabel7.TabIndex = 7;
            this.radLabel7.Text = "Телефон дебитора";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(181, 18);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(93, 18);
            this.radLabel6.TabIndex = 6;
            this.radLabel6.Text = "Номер дебитора";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(5, 18);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(82, 18);
            this.radLabel5.TabIndex = 5;
            this.radLabel5.Text = "Имя Дебитора";
            // 
            // BnSearch
            // 
            this.BnSearch.Location = new System.Drawing.Point(534, 42);
            this.BnSearch.Name = "BnSearch";
            this.BnSearch.Size = new System.Drawing.Size(121, 20);
            this.BnSearch.TabIndex = 4;
            this.BnSearch.Text = "Искать";
            this.BnSearch.Click += new System.EventHandler(this.BnSearch_Click);
            // 
            // TtBxSearchDebitorPhoneNumber
            // 
            this.TtBxSearchDebitorPhoneNumber.Location = new System.Drawing.Point(357, 42);
            this.TtBxSearchDebitorPhoneNumber.Name = "TtBxSearchDebitorPhoneNumber";
            this.TtBxSearchDebitorPhoneNumber.Size = new System.Drawing.Size(170, 20);
            this.TtBxSearchDebitorPhoneNumber.TabIndex = 3;
            this.TtBxSearchDebitorPhoneNumber.TabStop = false;
            // 
            // TtBxSearchDebitorPostNumber
            // 
            this.TtBxSearchDebitorPostNumber.Location = new System.Drawing.Point(181, 42);
            this.TtBxSearchDebitorPostNumber.Name = "TtBxSearchDebitorPostNumber";
            this.TtBxSearchDebitorPostNumber.Size = new System.Drawing.Size(170, 20);
            this.TtBxSearchDebitorPostNumber.TabIndex = 2;
            this.TtBxSearchDebitorPostNumber.TabStop = false;
            // 
            // TtBxSearchDepName
            // 
            this.TtBxSearchDepName.Location = new System.Drawing.Point(5, 42);
            this.TtBxSearchDepName.Name = "TtBxSearchDepName";
            this.TtBxSearchDepName.Size = new System.Drawing.Size(170, 20);
            this.TtBxSearchDepName.TabIndex = 1;
            this.TtBxSearchDepName.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 444);
            this.Controls.Add(this.GpBxSearch);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.GpBxCredits);
            this.Controls.Add(this.GpBxPayments);
            this.Controls.Add(this.MuSp);
            this.MainMenuStrip = this.MuSp;
            this.Name = "MainForm";
            this.Text = "Банк Менеджер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MuSp.ResumeLayout(false);
            this.MuSp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GpBxPayments)).EndInit();
            this.GpBxPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGdVwPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GpBxCredits)).EndInit();
            this.GpBxCredits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGdVwCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGdVwDebitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxNumberPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxDebitorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxDebitorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GpBxSearch)).EndInit();
            this.GpBxSearch.ResumeLayout(false);
            this.GpBxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxSearchDebitorPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxSearchDebitorPostNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TtBxSearchDepName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MuSp;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDebitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passNewPaymentToolStripMenuItem;
        private Telerik.WinControls.UI.RadGroupBox GpBxPayments;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox GpBxCredits;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TtBxPhoneNumber;
        private Telerik.WinControls.UI.RadTextBox TtBxNumberPayment;
        private Telerik.WinControls.UI.RadTextBox TtBxDebitorName;
        private Telerik.WinControls.UI.RadTextBox TtBxDebitorID;
        private Telerik.WinControls.UI.RadGroupBox GpBxSearch;
        private System.Windows.Forms.DataGridView DtGdVwPayments;
        private System.Windows.Forms.DataGridView DtGdVwCredits;
        private System.Windows.Forms.DataGridView DtGdVwDebitors;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadButton BnSearch;
        private Telerik.WinControls.UI.RadTextBox TtBxSearchDebitorPhoneNumber;
        private Telerik.WinControls.UI.RadTextBox TtBxSearchDebitorPostNumber;
        private Telerik.WinControls.UI.RadTextBox TtBxSearchDepName;
    }
}

