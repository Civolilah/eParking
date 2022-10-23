using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eParking.Data.Requests;
using eParking.Data.ViewModels;
using Flurl;
using Flurl.Http;

namespace eParking.Desktop
{
    public class APIService
    {
        private string _route;
        public static string Username { get; set; }
        public static string Password { get; set; }

        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> GetUloge<T>()
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}"+ "/GetUloge";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetParkinge<T>()
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/GetParkinge";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetUrediParkingMjesto<T>(object id)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/GetUrediParkingMjesto"+"/"+id.ToString();

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetUrediKorisnika<T>(object id)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/GetUrediKorisnika" + "/" + id.ToString();

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetSveParkinge<T>()
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/GetParkinge";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetSveKorisnike<T>()
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/GetSveKorisnike";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> IsUnique<T>(string UserName)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/IsUnique";
            url += "/" + UserName;

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetKorisnika<T>(string UserName)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/GetKorisnika";
            url += "/" + UserName;

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetParking<T>(string UserName)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/GetParking";
            url += "/" + UserName;

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> UrediParking<T>(int ID)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/UrediParking";
            url += "/" + ID.ToString();

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetGradove<T>()
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/GetGradove";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetDrzave<T>()
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/GetDrzave";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> GetSveTipoveParkingMjesta<T>()
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/GetTipoveParkingMjesta";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }
        public async Task<T> InsertKorisnika<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/InsertNoviKorisnik";
            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> InsertDrzava<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/InsertDrzava";
            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();
            
            return result;
        }
        public async Task<T> SlobodnoMjesto<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/PromjenaSlobodnoMjesto";
            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> ZauzetoMjesto<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/PromjenaZauzetoMjesto";
            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> InsertNovaUloga<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/InsertNovaUloga";
            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> InsertTipParkingMjesta<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/InsertTipParkingMjesta"+ "/"+input.ToString();

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> InsertGrad<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/InsertGrad";

            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> InsertParkingMjesto<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/InsertParkingMjesto";

            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> UrediParkingMjesto<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/UrediParkingMjesto";

            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> UrediKorisnika<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/UrediKorisnika";

            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> InsertParking<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/InsertParking";

            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> IzmijeniParking<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/IzmijeniParking";

            if (input != null)
            {
                var keyValueContent = input.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }

            var result = await url.WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> IzbrisiParking<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}"+ "/IzbrisiParking" + "?id=" + input.ToString();

            var result = await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> IzbrisiKorisnika<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}" + "/IzbrisiKorisnika" + "?id=" + input.ToString();

            var result = await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();

            return result;
        }
        public async Task<T> IzbrisiParkingMjesto<T>(object input)
        {
            var url = $"{ Properties.Settings.Default.APIUrl}/{_route}"+ "/IzbrisiParkingMjesto" + "?id=" + input.ToString();

            var result = await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();

            return result;
        }
    }
}
