using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tanks
{
    class Model
    {
        private int sizeField;
        private int amountTanks;
        private int amountApples;
        public int speedGame;

        public GameStatus gameStatus;

        public Tank tank;

        public Model(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            // TODO: Complete member initialization
            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            gameStatus = GameStatus.stoping;

            tank = new Tanks.Tank();
        }

        public void Play()
        {
            while (gameStatus == GameStatus.playing)
            {
                Thread.Sleep(speedGame);
                tank.Run();
            }
        }
    }
}
