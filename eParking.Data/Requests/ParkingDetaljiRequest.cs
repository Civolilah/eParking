using eParking.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms.Maps;

namespace eParking.Data.Requests
{
    public class ParkingDetaljiRequest
    {
        public int ParkingID { get; set; }
        public string NazivParkinga { get; set; }
        public string RadnoVrijeme { get; set; }
        public int BrojRezervisanihMijesta { get; set; }
        public int BrojSpecijalnihMijesta { get; set; }
        public int BrojObicnihMijesta { get; set; }
        public int UkupanBrojMijesta { get; set; }
        public double XTacka { get; set; }
        public double YTacka { get; set; }
        public double TrenutnaUdaljenostOdParkinga { get; set; }
        public ObservableCollection<Location> Locations { get; set; }
    }
}
