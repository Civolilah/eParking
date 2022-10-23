using eParking.Data;
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
    public partial class PretragaPage : ContentPage
    {
        private PretragaVM model = null;
        public PretragaPage()
        {
            InitializeComponent();
            BindingContext = model = new PretragaVM();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker objeec = sender as Picker;

            if (((Picker)sender).BindingContext != null)
            {
                var objname = (PretragaVM)((Picker)sender).BindingContext;
                var objgrad = (Grad)objeec.SelectedItem;
                if (objeec.SelectedItem != null)
                {
                    model.UpdateID(objgrad.GradID);
                }
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int gradid = model.GetGradID();
            await Navigation.PushAsync(new ParkinziPage(gradid));
        }
    }
}