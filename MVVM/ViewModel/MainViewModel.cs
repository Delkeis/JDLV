using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeJeuDeLaVie.Core;
using System.Windows.Controls;



namespace LeJeuDeLaVie.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        private object _currentView;

        public GameViewModel MyGameViewModel { get; set; }
        public RulesViewModel MyRulesViewModel { get; set; }
        public CreditViewModel MyCreditViewModel { get; set; }

        public RelayCommand GameViewCommand { get; set; }
        public RelayCommand RulesViewCommand { get; set; }
        public RelayCommand CreditViewCommand { get; set; }


        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            MyGameViewModel = new GameViewModel();
            MyRulesViewModel = new RulesViewModel();
            MyCreditViewModel = new CreditViewModel();
            CurrentView = MyGameViewModel;

            GameViewCommand = new RelayCommand(o => { CurrentView = MyGameViewModel; });
            RulesViewCommand = new RelayCommand(o => { CurrentView = MyRulesViewModel; });
            CreditViewCommand = new RelayCommand(o => { CurrentView = MyCreditViewModel; });
        }

        public void AddGameBoard(Grid gameBoard)
        {
            
        }
    }
}
