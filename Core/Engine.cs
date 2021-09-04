using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeJeuDeLaVie.Classes
{
    class Engine
    {
        private int _gridColumn;
        private int _gridRow;
        private bool[,] _gameGrid;
        public Engine()
        {
            _gridColumn = 15;
            _gridRow = 10;
            initEngineGameGrid();
        }

        public void initEngineGameGrid()
        {
            int i = 0, y= 0;
            _gameGrid = new bool[_gridColumn, _gridRow];
            while(i++ < _gridColumn) 
            { 
                while(y++ < _gridRow)
                {
                    _gameGrid[i, y] = false;
                }
                y = 0;
            }
        }


        public string engineTest()
        {
            return ("hello world");
        }
    }
}
