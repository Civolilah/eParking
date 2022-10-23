using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace eParking.Mobile.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Xamarin.FormsMaps.Init("xsI6msJe0ctPDfnqg0S6~mbzIw9_9e5tb6VToEpgw0Q~AuhRvvW3Kthe1dKrb0tS7MmDZfpLgrq1GkZIWVtZbtAQk6QmX2AMhRukXgOe6udE");
            Windows.Services.Maps.MapService.ServiceToken = "xsI6msJe0ctPDfnqg0S6~mbzIw9_9e5tb6VToEpgw0Q~AuhRvvW3Kthe1dKrb0tS7MmDZfpLgrq1GkZIWVtZbtAQk6QmX2AMhRukXgOe6udE";
            LoadApplication(new eParking.Mobile.App());
        }
    }
}
