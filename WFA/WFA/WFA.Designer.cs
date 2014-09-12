namespace WFA
{
    partial class WFA
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnLocked = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 125);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 25);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(93, 125);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 25);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "Стереть";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnLocked
            // 
            this.BtnLocked.Location = new System.Drawing.Point(175, 125);
            this.BtnLocked.Name = "BtnLocked";
            this.BtnLocked.Size = new System.Drawing.Size(100, 25);
            this.BtnLocked.TabIndex = 3;
            this.BtnLocked.Text = "Заблокировать";
            this.BtnLocked.UseVisualStyleBackColor = true;
            this.BtnLocked.Click += new System.EventHandler(this.BtnLocked_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.AutoSize = true;
            this.PanelMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelMain.Location = new System.Drawing.Point(0, 12);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(284, 100);
            this.PanelMain.TabIndex = 4;
            // 
            // WFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.BtnLocked);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Name = "WFA";
            this.Text = "Testing Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WFA_FormClosing);
            this.Load += new System.EventHandler(this.WFA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnLocked;
        private System.Windows.Forms.Panel PanelMain;

    }
}

