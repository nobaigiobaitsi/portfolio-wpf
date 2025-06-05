using System;

namespace WpfPortfolio.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentViewModel; // Holds the current ViewModel to be displayed in the UI

        public ViewModelBase CurrentViewModel //Binds the UI to decide which View to show
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value); //Triggers UI updates when the ViewModel changes
        }

        public MainViewModel() //	Acts as the controller of the application
        {
            // The default?
        }
    }
}