using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using LeJeuDeLaVie.MVVM.ViewModel;

namespace LeJeuDeLaVie.Mvvm.View
{
    public partial class GameView
    {
        public GameView()
        {
            InitializeComponent();

            var rowDefinitions = GameViewModel.GetRowDefinitions();
            var columnDefinitions = GameViewModel.GetColumnDefinitions();
            foreach (var current in columnDefinitions)
            {
                GameGrid.ColumnDefinitions.Add(current);
            }
            foreach (var current in rowDefinitions)
            {
                GameGrid.RowDefinitions.Add(current);
            }
            GameGrid = GameViewModel.FillGrid(GameGrid);
        }

        public void NextOnClick(object sender, RoutedEventArgs e)
        {
            GameGrid = GameViewModel.UpdateNextTurn(GameGrid);
        }

        public void StartOnClick(object sender, RoutedEventArgs e)
        {
            GameGrid = GameViewModel.RandomFistState(GameGrid);
        }

    }
}
