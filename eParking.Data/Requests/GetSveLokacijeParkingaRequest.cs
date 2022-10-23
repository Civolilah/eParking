using eParking.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eParking.Data.Requests
{
    public class GetSveLokacijeParkingaRequest
    {
        public ObservableCollection<Location> Locations { get; set; }
    }
}
