using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tanks
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Controller_Tanks cpm;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            switch (args.Length)
            {
                // Default && 0
                default:
                case (int)InputParameter.Zero:
                    cpm = new Controller_Tanks();
                    break;

                // 1
                case (int)InputParameter.One:
                    cpm = new Controller_Tanks(Convert.ToInt32(args[0]));
                    break;

                // 2
                case (int)InputParameter.Two:
                    cpm = new Controller_Tanks(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                    break;

                // 3
                case (int)InputParameter.Three:
                    cpm = new Controller_Tanks(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
                    break;

                // 4
                case (int)InputParameter.Four:
                    cpm = new Controller_Tanks(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2], Convert.ToInt32(args[3])));
                    break;

            }

            Application.Run(cpm);
        }

        /// <summary>
        /// 
        /// </summary>
        enum InputParameter
        {
            Zero, One, Two, Three, Four
        }
    }
}
