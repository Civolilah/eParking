using eParking.Data;
using eParking.Mobile.Views;
using MobileApps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eParking.Mobile.ViewModels
{
    public class PretragaVM:BaseViewModel
    {
        private readonly APIService _parkingService = new APIService("ParkingMobile");
        public PretragaVM()
        {
        }

        public ObservableCollection<Grad> ListaGradova { get; set; } = new ObservableCollection<Grad>();
        public ICommand CommandPretrazi { get; set; }
        private int GradID { get; set; }

        public async Task Init()
        {
            List<Grad> lista = await _parkingService.GetGradove<List<Grad>>();
            ListaGradova.Clear();
            foreach (var item in lista)
            {
                ListaGradova.Add(item);
            }
        }
        public void UpdateID(int id)
        {
            GradID = id;
        }
        public int GetGradID()
        {
            return GradID;
        }
    }
}
