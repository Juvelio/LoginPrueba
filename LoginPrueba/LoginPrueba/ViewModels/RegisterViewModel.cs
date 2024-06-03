using LoginPrueba.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginPrueba.ViewModels
{
    public class RegisterViewModel:BaseViewModel
    {
        public ICommand SignInCommand => new Command(async () => await Shell.Current.GoToAsync($"{nameof(LoginPage)}"));

    }
}
