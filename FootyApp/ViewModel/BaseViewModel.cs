using CommunityToolkit.Mvvm.ComponentModel;

namespace FootyApp.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title;  // nagłówek

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;   // czy VM aktualnie jest zajęty

        public bool IsNotBusy => !IsBusy;
    }
}
