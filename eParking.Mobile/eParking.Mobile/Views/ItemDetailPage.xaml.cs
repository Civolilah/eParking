using eParking.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eParking.Mobile.Views
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