using LoginPrueba.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LoginPrueba.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}