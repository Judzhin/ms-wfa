using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using RunningButtons;
using System.Media;

namespace CarRace
{
    #region Delegate
    /// <summary>
    /// Помошник для манипулирования обработки из разных потоков
    /// </summary>
    /// <param name="bttn"></param>
    delegate void HelperToCall(ButtonCompare bttn);
    #endregion;

    #region Project
    /// <summary>
    /// 
    /// </summary>
    public partial class CarRace : Form
    {
        #region Поля

        Thread tOne, tTwo, tThree, tFour; // Потоки для движения кнопок

        static Random r; // Random();

        HelperToCall htc; // Delegate for Invoke();

        ButtonCompare[] buttons; // Array Buttons;

        SoundPlayer running; // Мелодия двищущегося автомобиля

        #endregion;

        #region Конструктор;
        public CarRace()
        {
            InitializeComponent();
            htc = new HelperToCall(Motion);
            r = new Random();
            buttons = new ButtonCompare[] { BttnCarOne, BttnCarTwo, BttnCarThree, BttnCarFour };
            running = new SoundPlayer(Properties.Resources._94_Truck_snd_run03);
        }
        #endregion;

        #region Bttn_Start_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bttn_Start_Click(object sender, EventArgs e)
        {
            running.Load();
            running.PlayLooping();

            BttnPause.Enabled = BttnStop.Enabled = true;

            ((Button)sender).Enabled = false;

            if (tOne != null)
            {
                tOne.Resume();
                tTwo.Resume();
                tThree.Resume();
                tFour.Resume();
                return;
            }

            tOne = new Thread(new ParameterizedThreadStart(Movement));
            tTwo = new Thread(new ParameterizedThreadStart(Movement));
            tThree = new Thread(new ParameterizedThreadStart(Movement));
            tFour = new Thread(new ParameterizedThreadStart(Movement));

            tOne.IsBackground = true;
            tTwo.IsBackground = true;
            tThree.IsBackground = true;
            tFour.IsBackground = true;

            tOne.Start(BttnCarOne);
            tTwo.Start(BttnCarTwo);
            tThree.Start(BttnCarThree);
            tFour.Start(BttnCarFour);
        }
        #endregion;

        #region Bttn_Pause_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bttn_Pause_Click(object sender, EventArgs e)
        {
            running.Stop();

            BttnPause.Enabled = false;

            BttnStart.Enabled = true;

            if (tOne != null)
            {
                tOne.Suspend();
                tTwo.Suspend();
                tThree.Suspend();
                tFour.Suspend();
            }

        }
        #endregion;

        #region Bttn_Stop_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bttn_Stop_Click(object sender, EventArgs e)
        {
            Bttn_Pause_Click(sender, e);
            BttnPause.Enabled = BttnStop.Enabled = false;
            
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = SystemColors.ControlLight;
            }

            BttnCarOne.Location = new Point(13, BttnCarOne.Location.Y);
            BttnCarTwo.Location = new Point(13, BttnCarTwo.Location.Y);
            BttnCarThree.Location = new Point(13, BttnCarThree.Location.Y);
            BttnCarFour.Location = new Point(13, BttnCarFour.Location.Y);
        }
        #endregion;

        #region Motion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bttn"></param>
        void Motion(ButtonCompare bttn)
        {
            bttn.Location = new Point(bttn.Location.X + r.Next(3), bttn.Location.Y);
            Array.Sort(buttons);

            for (int i = 0; i < buttons.Length; i++ )
            {
                buttons[i].BackColor = (i != 0) ? SystemColors.ControlLight : Color.Yellow;
                buttons[i].Text = buttons[i].Text.Substring(0, 8) + buttons[i].Location.X + ")";
            }

            if ((bttn.Location.X + bttn.Width) > panelFinish.Location.X)
            {
                Bttn_Pause_Click(new object(), new EventArgs());
                BttnStart.Enabled = false;

                string text = string.Format("Выиграла кнопка {0}", bttn.Text.Substring(0, 7));
                MessageBox.Show(text);
            }
        }
        #endregion;

        #region Movement
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bttn"></param>
        void Movement(object bttn)
        {
            // Распаковка
            ButtonCompare b = bttn as ButtonCompare;
            
            do {
                // Задержка потока
                Thread.Sleep(r.Next(5,40));
                // Метод внедрения в другой поток
                // htc делегат
                // b объект
                Invoke(htc, b);

            } while (true);
        }
        #endregion;

        #region CarRace_Form_Closing
        /// <summary>
        /// Событие срабатывающееся при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarRace_Form_Closing(object sender, FormClosingEventArgs e)
        {
            Bttn_Stop_Click(sender, e);
        }
        #endregion;
    }
    #endregion;
}
