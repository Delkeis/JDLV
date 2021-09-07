using LeJeuDeLaVie.Core;


namespace LeJeuDeLaVie.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
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
            get => _currentView;
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

            GameViewCommand = new RelayCommand(_ => { CurrentView = MyGameViewModel; });
            RulesViewCommand = new RelayCommand(_ => { CurrentView = MyRulesViewModel; });
            CreditViewCommand = new RelayCommand(_ => { CurrentView = MyCreditViewModel; });
        }

    }
}
