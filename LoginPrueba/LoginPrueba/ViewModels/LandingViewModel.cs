using LoginPrueba.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginPrueba.ViewModels
{
    public class LandingViewModel : BaseViewModel
    {
        public ICommand SignUpCommand => new Command(async () => await Shell.Current.GoToAsync($"{nameof(RegisterPage)}", false));
        public ICommand SignInCommand => new Command(async () => await Shell.Current.GoToAsync($"{nameof(LoginPage)}", false));
    }
}
