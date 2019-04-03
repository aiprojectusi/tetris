using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class Game
    {

        DataGridView blocksGrid;
        Blocks blocks = new Blocks();

        public  Game(DataGridView bgrid)
        {
            this.blocksGrid = bgrid;
        }

        public void start()
        {
            int[,] block = blocks.randomBlock();
        }
    }
}
