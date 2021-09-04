using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using LeJeuDeLaVie.MVVM.View;
using LeJeuDeLaVie.Core;

namespace LeJeuDeLaVie.MVVM.ViewModel
{
    class GameViewModel
    {

        public Grid gameGrid { get; set; }
        public GameViewModel()
        {
            DataController dc = new DataController();
            gameGrid = dc.GetGameGrid();
            
        }
    }
}
