using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
    public partial class Controller_Tanks : Form
    {
        /// <summary>
        /// 
        /// </summary>
        View view;
        
        /// <summary>
        /// 
        /// </summary>
        Model model;

        /// <summary>
        /// 
        /// </summary>
        Thread mPlay;

        #region Конструктор
        /// <summary>
        /// 
        /// </summary>
        public Controller_Tanks() : this(260) { }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sizeField"></param>
        public Controller_Tanks(int sizeField) : this(sizeField, 5) { }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sizeField"></param>
        /// <param name="amountTanks"></param>
        public Controller_Tanks(int sizeField, int amountTanks) : this(sizeField, amountTanks, 5) { }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sizeField"></param>
        /// <param name="amountTanks"></param>
        /// <param name="amountApples"></param>
        public Controller_Tanks(int sizeField, int amountTanks, int amountApples) : this(sizeField, amountTanks, amountApples, 40) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sizeField"></param>
        /// <param name="amountTanks"></param>
        /// <param name="amountApples"></param>
        /// <param name="speedGame"></param>
        public Controller_Tanks(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            // Init Component
            InitializeComponent();

            // Init Model
            model = new Model(sizeField, amountTanks, amountApples, speedGame);

            // Init View
            view = new View(model);

            // Add View in form
            this.Controls.Add(view);
        }
        #endregion;

        private void StartrStoping_bttn_Click(object sender, EventArgs e)
        {
            if (model.gameStatus == GameStatus.playing)
            {
                mPlay.Abort();
                model.gameStatus = GameStatus.stoping;
            }
            else
            {
                model.gameStatus = GameStatus.playing;
                mPlay = new Thread(model.Play);
                mPlay.Start();

                view.Invalidate();
            }
        }

        private void Controller_Tanks_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mPlay != null)
            {
                model.gameStatus = GameStatus.stoping;
                mPlay.Abort();
            }

            DialogResult dr = MessageBox.Show("Вы уверены что хотите выйти?", "Application closed", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
