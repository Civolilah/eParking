using eParking.Data.Requests;
using MobileApps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
namespace eParking.Mobile.ViewModels
{
    public class ParkinziVM : BaseViewModel
    {
        private int _gradID;
        private readonly APIService _parkingService = new APIService("ParkingMobile");
        public ParkinziVM()
        {

        }
        
        public ObservableCollection<IspisParkingaRequest> ListaParkinga { get; set; } = new ObservableCollection<IspisParkingaRequest>();
        public ObservableCollection<IspisParkingaRequest> Preporuka { get; set; } = new ObservableCollection<IspisParkingaRequest>();
        public ICommand CommandPretrazi { get; set; }
       
        public async Task Init(int id)
        {
            _gradID = id;
            var location = await Geolocation.GetLastKnownLocationAsync();
            ListaParkingaRequest model = new ListaParkingaRequest
            {
                GradID=_gradID,
                Lang=location.Longitude,
                Lat=location.Latitude
            };


            List<IspisParkingaRequest> listapre = new List<IspisParkingaRequest>();
            listapre=await _parkingService.GetPreporuku<List<IspisParkingaRequest>>(model);
            Preporuka.Clear();
            foreach (var item in listapre)
            {
                if (item != null)
                {
                    Preporuka.Add(item);
                }
            }

            List<IspisParkingaRequest> lista = await _parkingService.GetParkingeByGrad<List<IspisParkingaRequest>>(model);
            ListaParkinga.Clear();
            foreach (var item in lista)
            {
                if (Preporuka.Count > 0)
                {
                    if (item.ParkingID != Preporuka[0].ParkingID)
                    {
                        ListaParkinga.Add(item);
                    }
                }
                else
                {
                    ListaParkinga.Add(item);
                }
            }
        }
    }
}
