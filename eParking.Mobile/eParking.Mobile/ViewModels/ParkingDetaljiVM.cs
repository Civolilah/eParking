using eParking.Data.Requests;
using MobileApps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace eParking.Mobile.ViewModels
{
    public class ParkingDetaljiVM : BaseViewModel
    {
        private readonly APIService _parkingService = new APIService("ParkingMobile");
        private int _parkingid;
        public ParkingDetaljiVM()
        {
            
        }
        public ObservableCollection<ParkingDetaljiRequest> ListaParkinga { get; set; } = new ObservableCollection<ParkingDetaljiRequest>();
        public async Task Init(int parkingid)
        {
            _parkingid = parkingid;
            var location = await Geolocation.GetLastKnownLocationAsync();
            Data.Requests.ParkingDetaljiVM model = new Data.Requests.ParkingDetaljiVM
            {
                ParkingID=_parkingid,
                Long=location.Longitude,
                Lat=location.Latitude
            };
            List<ParkingDetaljiRequest> lista = await _parkingService.GetDetaljeParkinga<List<ParkingDetaljiRequest>>(model);
            ListaParkinga.Clear();
            foreach (var item in lista)
            {
                ListaParkinga.Add(item);
            }
        }
    }
}
