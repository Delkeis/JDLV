using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LeJeuDeLaVie.Core
{
    class DataController
    {
        private int _gridRow = 10;
        private int _gridCollumn = 10;

        private Grid _gameGrid;
        public DataController()
        {
            InitGameGrid();
        }

        private void InitGameGrid()
        {
            int i = 0;
            _gameGrid = new Grid();
            while (i++ < _gridCollumn)
            {
                ColumnDefinition myNewColumn = new ColumnDefinition();
                _gameGrid.ColumnDefinitions.Add(myNewColumn);
            }
            i = 0;
            while (i++ < _gridRow)
            {
                RowDefinition myNewRow = new RowDefinition();
                _gameGrid.RowDefinitions.Add(myNewRow);
            }
            _gameGrid.ShowGridLines = true;

            ///<summary>
            ///débug / test
            /// </summary>

            TextBlock testText = new TextBlock();
            testText.Text = "text de test !";
            Grid.SetRow(testText, 1);
            Grid.SetColumn(testText, 1);
            _gameGrid.Children.Add(testText);
        }
        public Grid GetGameGrid()
        {
            return (_gameGrid);
        }
    }
}
