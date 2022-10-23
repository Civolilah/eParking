using eParking.Data.Requests;
using eParking.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eParking.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParkinziPage : ContentPage
    {
        private int _gradID;
        private ParkinziVM model = null;
        public ParkinziPage(int id)
        {
            InitializeComponent();
            _gradID = id;
            BindingContext = model = new ParkinziVM();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init(_gradID);
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var objname = (IspisParkingaRequest)e.SelectedItem;
            await Navigation.PushAsync(new ParkingDetaljiPage(objname.ParkingID));
        }
    }
}