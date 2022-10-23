using eParking.Data.Requests;
using eParking.Data.ViewModels;
using MobileApps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eParking.Mobile.ViewModels
{
    public class MapaVM:BaseViewModel
    {
        private readonly APIService _parkingService = new APIService("ParkingMobile");
        public MapaVM()
        {

        }
        public ObservableCollection<Location> Locations { get; set; } = new ObservableCollection<Location>();

        public async Task Init()
        {
            var location = await Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();

            GetSveLokacijeParkingaRequest lista = await _parkingService.GetSveLokacijeParkinga<GetSveLokacijeParkingaRequest>();

            foreach (var item in lista.Locations)
            {
                Locations.Add(item);
            }
        }
    }
}
