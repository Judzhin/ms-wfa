using RunningButtons;
namespace CarRace
{
    partial class CarRace
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
            this.BttnCarOne = new ButtonCompare();
            this.BttnCarTwo = new ButtonCompare();
            this.BttnCarThree = new ButtonCompare();
            this.BttnCarFour = new ButtonCompare();
            this.BttnStart = new System.Windows.Forms.Button();
            this.GroupBoxMenu = new System.Windows.Forms.GroupBox();
            this.BttnPause = new System.Windows.Forms.Button();
            this.BttnStop = new System.Windows.Forms.Button();
            this.panelFinish = new System.Windows.Forms.Panel();
            this.GroupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BttnCarOne
            // 
            this.BttnCarOne.Location = new System.Drawing.Point(13, 13);
            this.BttnCarOne.Name = "BttnCarOne";
            this.BttnCarOne.Size = new System.Drawing.Size(100, 23);
            this.BttnCarOne.TabIndex = 0;
            this.BttnCarOne.Text = "button1(0)";
            this.BttnCarOne.UseVisualStyleBackColor = true;
            // 
            // BttnCarTwo
            // 
            this.BttnCarTwo.Location = new System.Drawing.Point(13, 43);
            this.BttnCarTwo.Name = "BttnCarTwo";
            this.BttnCarTwo.Size = new System.Drawing.Size(100, 23);
            this.BttnCarTwo.TabIndex = 1;
            this.BttnCarTwo.Text = "button2(0)";
            this.BttnCarTwo.UseVisualStyleBackColor = true;
            // 
            // BttnCarThree
            // 
            this.BttnCarThree.Location = new System.Drawing.Point(13, 73);
            this.BttnCarThree.Name = "BttnCarThree";
            this.BttnCarThree.Size = new System.Drawing.Size(100, 23);
            this.BttnCarThree.TabIndex = 2;
            this.BttnCarThree.Text = "button3(0)";
            this.BttnCarThree.UseVisualStyleBackColor = true;
            // 
            // BttnCarFour
            // 
            this.BttnCarFour.Location = new System.Drawing.Point(13, 103);
            this.BttnCarFour.Name = "BttnCarFour";
            this.BttnCarFour.Size = new System.Drawing.Size(100, 23);
            this.BttnCarFour.TabIndex = 3;
            this.BttnCarFour.Text = "button4(0)";
            this.BttnCarFour.UseVisualStyleBackColor = true;
            // 
            // BttnStart
            // 
            this.BttnStart.Location = new System.Drawing.Point(6, 19);
            this.BttnStart.Name = "BttnStart";
            this.BttnStart.Size = new System.Drawing.Size(75, 23);
            this.BttnStart.TabIndex = 4;
            this.BttnStart.Text = "Start";
            this.BttnStart.UseVisualStyleBackColor = true;
            this.BttnStart.Click += new System.EventHandler(this.Bttn_Start_Click);
            // 
            // GroupBoxMenu
            // 
            this.GroupBoxMenu.Controls.Add(this.BttnPause);
            this.GroupBoxMenu.Controls.Add(this.BttnStop);
            this.GroupBoxMenu.Controls.Add(this.BttnStart);
            this.GroupBoxMenu.Location = new System.Drawing.Point(13, 133);
            this.GroupBoxMenu.Name = "GroupBoxMenu";
            this.GroupBoxMenu.Size = new System.Drawing.Size(302, 55);
            this.GroupBoxMenu.TabIndex = 5;
            this.GroupBoxMenu.TabStop = false;
            // 
            // BttnPause
            // 
            this.BttnPause.Enabled = false;
            this.BttnPause.Location = new System.Drawing.Point(87, 19);
            this.BttnPause.Name = "BttnPause";
            this.BttnPause.Size = new System.Drawing.Size(75, 23);
            this.BttnPause.TabIndex = 6;
            this.BttnPause.Text = "Pause";
            this.BttnPause.UseVisualStyleBackColor = true;
            this.BttnPause.Click += new System.EventHandler(this.Bttn_Pause_Click);
            // 
            // BttnStop
            // 
            this.BttnStop.Enabled = false;
            this.BttnStop.Location = new System.Drawing.Point(168, 19);
            this.BttnStop.Name = "BttnStop";
            this.BttnStop.Size = new System.Drawing.Size(75, 23);
            this.BttnStop.TabIndex = 5;
            this.BttnStop.Text = "Stop";
            this.BttnStop.UseVisualStyleBackColor = true;
            this.BttnStop.Click += new System.EventHandler(this.Bttn_Stop_Click);
            // 
            // panelFinish
            // 
            this.panelFinish.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelFinish.Location = new System.Drawing.Point(567, 13);
            this.panelFinish.Name = "panelFinish";
            this.panelFinish.Size = new System.Drawing.Size(5, 113);
            this.panelFinish.TabIndex = 6;
            // 
            // CarRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 200);
            this.Controls.Add(this.panelFinish);
            this.Controls.Add(this.GroupBoxMenu);
            this.Controls.Add(this.BttnCarFour);
            this.Controls.Add(this.BttnCarThree);
            this.Controls.Add(this.BttnCarTwo);
            this.Controls.Add(this.BttnCarOne);
            this.Name = "CarRace";
            this.Text = "Гонки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarRace_Form_Closing);
            this.GroupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonCompare BttnCarOne;
        private ButtonCompare BttnCarTwo;
        private ButtonCompare BttnCarThree;
        private ButtonCompare BttnCarFour;
        private System.Windows.Forms.Button BttnStart;
        private System.Windows.Forms.GroupBox GroupBoxMenu;
        private System.Windows.Forms.Button BttnPause;
        private System.Windows.Forms.Button BttnStop;
        private System.Windows.Forms.Panel panelFinish;
    }
}

