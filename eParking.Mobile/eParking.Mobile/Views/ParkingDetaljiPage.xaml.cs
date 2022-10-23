using eParking.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eParking.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParkingDetaljiPage : ContentPage
    {
        private int _parkingid;
        private ParkingDetaljiVM model = null;
        public ParkingDetaljiPage(int parkingid)
        {
            _parkingid = parkingid;
            InitializeComponent();
            BindingContext = model = new ParkingDetaljiVM();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init(_parkingid);
        }

       
    }
}