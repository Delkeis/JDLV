using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using LeJeuDeLaVie.Core;
using System.Windows.Shapes;
using System.Windows.Media;

namespace LeJeuDeLaVie.MVVM.ViewModel
{
    internal class GameViewModel
    {
        private static int _rowDefinition;
        private static int _columnDefinition;
        private static int _gridSize;
        private static bool[,] _gameGrid;
        public GameViewModel()
        {
            _rowDefinition = 10;
            _columnDefinition = 15;
            _gridSize = 35;
            FillInGrid();
        }

        private static void FillInGrid()
        {
            var colPos = 0;
            var rowPos = 0;

            _gameGrid = new bool[_rowDefinition,_columnDefinition];

            while(colPos < _columnDefinition) 
            {
                while (rowPos < _rowDefinition)
                {
                    _gameGrid[rowPos++, colPos] = false;
                }
                colPos++;
                rowPos = 0;
            }
        }

        public static Grid ApplyGridUpdate(Grid gameGrid)
        {
            var colPos = 0;
            var rowPos = 0;

            while (colPos < _columnDefinition)
            {
                while (rowPos < _rowDefinition)
                {
                    Rectangle rect;
                    if (_gameGrid[rowPos, colPos])
                    {
                        rect = new Rectangle() { Fill = Brushes.Black };
                    }
                    else
                    {
                        rect = new Rectangle() { Fill = Brushes.WhiteSmoke };
                    }
                    gameGrid.Children.Add(rect);
                    Grid.SetRow(rect, rowPos++);
                    Grid.SetColumn(rect, colPos);
                }
                rowPos = 0;
                colPos++;
            }
            return (gameGrid);
        }

        public static Grid UpdateNextTurn(Grid gameGrid)
        {
            var colPos = 0;
            var rowPos = 0;

            while (colPos < _columnDefinition)
            {
                while (rowPos < _rowDefinition)
                {
                    _gameGrid[rowPos,colPos] = Engine.CheckCellValue(_gameGrid, colPos, rowPos++);
                }
                colPos++;
                rowPos = 0;
            }
            return ApplyGridUpdate(gameGrid);
        }

        public static Grid RandomFistState(Grid gameGrid)
        {
            var numberToRand = 25;
            var rand = new Random();

            gameGrid = FillGrid(gameGrid);
            while (numberToRand > 0)
            {
                var colPos = rand.Next(_columnDefinition);
                var rowPos = rand.Next(_rowDefinition);
                var rect = new Rectangle() { Fill = Brushes.Black };
                Grid.SetColumn(rect, colPos);
                Grid.SetRow(rect, rowPos);
                gameGrid.Children.Add(rect);
                _gameGrid[rowPos,colPos] = true;
                numberToRand--;
            }
            return (gameGrid);
        }

        public static Grid FillGrid(Grid myGrid)
        {
            var colPos = 0;
            var rowPos = 0;

            while(colPos < _columnDefinition)
            {
                while(rowPos < _rowDefinition)
                {
                    var rect = new Rectangle() { Fill = Brushes.WhiteSmoke };
                    myGrid.Children.Add(rect);
                    Grid.SetRow(rect, rowPos++);
                    Grid.SetColumn(rect, colPos);
                }
                rowPos = 0;
                colPos++;
            }
            return (myGrid);
        }

        public static List<RowDefinition> GetRowDefinitions()
        {
            var i = 0;
            var rowDefinitions = new List<RowDefinition>();

            while (i++ < _rowDefinition)
            {
                var row = new RowDefinition
                {
                    Height = new GridLength(_gridSize, GridUnitType.Pixel)
                };
                rowDefinitions.Add(row);
            }
            return (rowDefinitions);
        }

        public static List<ColumnDefinition> GetColumnDefinitions()
        {
            var i = 0;
            var columnDefinitions = new List<ColumnDefinition>();

            while (i++ < _columnDefinition)
            {
                var col = new ColumnDefinition
                {
                    Width = new GridLength(_gridSize, GridUnitType.Pixel)
                };
                columnDefinitions.Add(col);
            }
            return (columnDefinitions);
        }
    }
}
