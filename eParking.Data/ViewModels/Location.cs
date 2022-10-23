using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.ViewModels
{
    public class Location
    {
        public string Address { get; set; }
        public string Description { get; set; }
        public Xamarin.Forms.Maps.Position Position { get; set; }
    }
}
