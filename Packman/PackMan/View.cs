using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
    partial class View : UserControl
    {
        Model model;

        public View(Model m)
        {
            InitializeComponent();
            this.model = m;
        }

        void Draw(PaintEventArgs e)
        {
            Tank t = this.model.tank;
            e.Graphics.DrawImage(t.img, new Point(t.x, t.y));

            if (model.gameStatus != GameStatus.playing)
            {
                return;
            }

            Thread.Sleep(model.speedGame);
            
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
        }

    }
}
