using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFA
{
    public partial class WFA : Form
    {
        // Constructor
        public WFA()
        {
            InitializeComponent();
            Control.ControlCollection cc = this.Controls;

            string text = "";
            foreach (Control c in this.Controls)
            {
                text += string.Format("Контроллер: {0}", c.Name);
            }

            //MessageBox.Show(text);
        }

        private void WFA_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Text += "!";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(0, this.Text.Length - 1);
        }

        private void BtnLocked_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Кнопки {0}", (BtnAdd.Enabled && BtnRemove.Enabled) ? "залочены" : "разлочены"));
            BtnAdd.Enabled = !BtnAdd.Enabled;
            BtnRemove.Enabled = !BtnRemove.Enabled;
        }

        private void WFA_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите покинуть приложение?", "Закрытие приложение", MessageBoxButtons.YesNoCancel);
            e.Cancel = (dr == DialogResult.Yes) ? false : true ;
        }

    }
}
