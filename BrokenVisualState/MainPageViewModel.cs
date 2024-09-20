using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BrokenVisualState;
public partial class MainPageViewModel : ObservableObject
{
    public MainPageViewModel()
    {
    }

    [ObservableProperty] private string username=string.Empty;
    [ObservableProperty] private string password = string.Empty;
    [ObservableProperty] private bool canLogin;
    partial void OnUsernameChanged(string value)
    {
        CanLogin = !string.IsNullOrWhiteSpace(value) && !string.IsNullOrWhiteSpace(Password);
    }
    partial void OnPasswordChanged(string value)
    {
        CanLogin = !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(value);
    }

    [RelayCommand]
    public void Login()
    {
        
    }

}